using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GamepadToBT
{
    public partial class gamepadToBluetooth : Form
    {
        Gamepad gp;
        Bluetooth bt;
        List<DeviceInstance> gpInstances;
        Timer pollTimer;
        Timer transmitTimer;

        public gamepadToBluetooth()
        {
            InitializeComponent();

            openBTBtn.Tag = 0; //use tag to indicate open state

            gp = new Gamepad();
            bt = new Bluetooth();
            pollTimer = new Timer();
            pollTimer.Interval = 20; //ms
            pollTimer.Tick += pollTimer_Tick;

            transmitTimer = new Timer();
            transmitTimer.Interval = 150; //ms
            transmitTimer.Tick += TransmitTimer_Tick;

            ShowAnalogPosition(UInt16.MaxValue / 2, UInt16.MaxValue / 2, true);
            ShowAnalogPosition(UInt16.MaxValue / 2, UInt16.MaxValue / 2, false);
            ShowTriggerPosition(UInt16.MaxValue / 2);
            ShowDpadState(GamepadState.DpadDir.center);
        }

        private void bluetoothCb_DropDown(object sender, EventArgs e)
        {
            bluetoothCb.Items.Clear();
            List<string> list = bt.GetCOMlist();
            if (list.Count == 0)
            {
                MessageBox.Show("No Serial ports available");
                return;
            }

            foreach (string com in list)
            {
                bluetoothCb.Items.Add(com);
            }
        }

        private void openBTBtn_Click(object sender, EventArgs e)
        {
            openBTBtn.Enabled = false;
            if ((int)openBTBtn.Tag == 0)
            {
                if (bt.OpenSerial((string)bluetoothCb.SelectedItem))
                {
                    transmitTimer.Start();
                    openBTBtn.Text = "Close";
                    openBTBtn.Tag = 1;
                }
                else
                {
                    MessageBox.Show("Failed to open bluetooth connection");
                }
            }
            else
            {
                CloseBTConnection();
            }
            openBTBtn.Enabled = true;
        }

        private void gamepadCB_DropDown(object sender, EventArgs e)
        {
            gamepadCB.Items.Clear();
            gpInstances = gp.ListDevices();
            foreach (DeviceInstance gpInstance in gpInstances)
            {
                gamepadCB.Items.Add(gpInstance.ProductName);
            }
        }

        private void CloseBTConnection()
        {
            bt.CloseSerial();
            transmitTimer.Stop();
            openBTBtn.Text = "Open";
            openBTBtn.Tag = 0;
        }

        private void gamepadCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            pollTimer.Stop();
            gp.DisconnectGamepad();
            gp.ConnectGamepad(gpInstances[gamepadCB.SelectedIndex].ProductGuid);

            pollTimer.Start();
        }

        private void pollTimer_Tick(object sender, EventArgs e)
        {
            if (!gp.PollGamepad())
            {
                pollTimer.Stop();
                MessageBox.Show("Failed to read gamepad");
            }
            if (gp.gamepadState.button[4]) lIndicatorButtonPressed = true;
            if (gp.gamepadState.button[5]) rIndicatorButtonPressed = true;
            if (gp.gamepadState.button[0]) hazardButtonPressed = true;
            if (gp.gamepadState.button[1]) lightButtonPressed = true;

            ShowAnalogPosition(gp.gamepadState.lx, gp.gamepadState.ly, true);
            ShowAnalogPosition(gp.gamepadState.rx, gp.gamepadState.ry, false);
            ShowButtonStates(gp.gamepadState.button);
            ShowTriggerPosition(gp.gamepadState.trigger);
            ShowDpadState(gp.gamepadState.dpad);
        }

        bool lIndicatorButtonPressed;
        bool rIndicatorButtonPressed;
        bool hazardButtonPressed;
        bool lightButtonPressed;
        bool prevLIndicator;
        bool prevRIndicator;
        bool prevHazard;
        bool prevLight;
        private void TransmitTimer_Tick(object sender, EventArgs e)
        {
            if (!bt.Opened())
                return;
            int lStickY = UInt16.MaxValue - gp.gamepadState.ly;
            lStickY -= UInt16.MaxValue / 2 - 1;
            lStickY = lStickY * 255 / Int16.MaxValue;

            bool motorReverse = !(gp.gamepadState.ly < UInt16.MaxValue / 2);
            int motorSpeed = 0;
            if (motorReverse)
                motorSpeed = -lStickY;
            else
                motorSpeed = lStickY;

            int rStickX = gp.gamepadState.rx;
            char steerDir = '0';
            if (rStickX > UInt16.MaxValue * 3 / 4)
                steerDir = 'r';
            else if (rStickX < UInt16.MaxValue / 4)
                steerDir = 'l';
            
            bool lIndicator = gp.gamepadState.button[4] | lIndicatorButtonPressed;
            bool rIndicator = gp.gamepadState.button[5] | rIndicatorButtonPressed;
            bool hazard = gp.gamepadState.button[0] | hazardButtonPressed;
            bool light = gp.gamepadState.button[1] | lightButtonPressed;

            string data = "M" + motorSpeed + ",R" + (motorReverse ? "1" : "0") + ",S" + steerDir;
            if (hazard & !prevHazard) data += ",Ih";
            else if (lIndicator & !prevLIndicator) data += ",Il";
            else if (rIndicator & !prevRIndicator) data += ",Ir";

            if (light & !prevLight) data += ",L1";

            //Console.WriteLine(data);
            if (!bt.WriteLine(data))
            {
                CloseBTConnection();
                MessageBox.Show("Lost bluetooth connection");
            }

            prevLIndicator = lIndicator;
            prevRIndicator = rIndicator;
            prevHazard = hazard;
            prevLight = light;
            lIndicatorButtonPressed = false;
            rIndicatorButtonPressed = false;
            hazardButtonPressed = false;
            lightButtonPressed = false;
        }


        private void ShowAnalogPosition(UInt16 x, UInt16 y, bool left)
        {
            int radius = 5;
            int width = (left ? leftPB.Size.Width : rightPB.Size.Width);
            int height = (left ? leftPB.Size.Height : rightPB.Size.Height);

            int mx = (int)(x * ((float)width / (float)UInt16.MaxValue));
            int my = (int)(y * ((float)height / (float)UInt16.MaxValue));

            Bitmap bm = new Bitmap(width, height);
            Pen black = new Pen(Color.Black, 1);
            Brush red = new SolidBrush(Color.Red);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
                g.DrawLine(black, new Point(width / 2 + 1, 0), new Point(width / 2 + 1, height - 1));
                g.DrawLine(black, new Point(0, height / 2 + 1), new Point(width - 1, height / 2 + 1));

                g.FillEllipse(red, mx - radius, my - radius, radius * 2 + 1, radius * 2 + 1);
            }

            if (left)
                leftPB.Image = bm;
            else
                rightPB.Image = bm;
        }

        public void ShowButtonStates(bool[] buttons)
        {
            btn1rb.Checked =  buttons[0];
            btn2rb.Checked =  buttons[1];
            btn3rb.Checked =  buttons[2];
            btn4rb.Checked =  buttons[3];
            btn5rb.Checked =  buttons[4];
            btn6rb.Checked =  buttons[5];
            btn7rb.Checked =  buttons[6];
            btn8rb.Checked =  buttons[7];
            btn9rb.Checked =  buttons[8];
            btn10rb.Checked = buttons[9];
            btn11rb.Checked = buttons[10];
            btn12rb.Checked = buttons[11];
        }

        public void ShowTriggerPosition(UInt16 trigger)
        {
            int width = triggerPb.Width;
            int height = triggerPb.Height;
            int mTrigger = (int)(trigger * ((float)width / (float)UInt16.MaxValue));

            int rectX = (mTrigger < width / 2) ? mTrigger : width / 2;
            int rectWidth = (mTrigger < width / 2) ? (width / 2) - mTrigger : mTrigger - (width / 2);

            Bitmap bm = new Bitmap(width, height);
            Brush green = new SolidBrush(Color.Green);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
                g.FillRectangle(green, rectX, 0, rectWidth, height);
            }
            triggerPb.Image = bm;
        }

        public void ShowDpadState(GamepadState.DpadDir dir)
        {
            int width = dpadPb.Width;
            int height = dpadPb.Height;
            int al = (width < height ? width / 2 : height / 2);

            Bitmap bm = new Bitmap(width, height);
            Brush red = new SolidBrush(Color.Red);
            Point[] center = { new Point(width / 2 - al / 2, height / 2), new Point(width / 2, height / 2 - al / 2), new Point(width / 2 + al / 2, height / 2), new Point(width / 2, height / 2 + al / 2), };
            Point[] up = { new Point(width / 2 - al/2, height / 2), new Point(width/2, height/2-al), new Point(width / 2 + al / 2, height / 2) };
            Point[] down = { new Point(width / 2 - al / 2, height / 2), new Point(width / 2, height / 2 + al), new Point(width / 2 + al / 2, height / 2) };
            Point[] right = { new Point(width / 2, height / 2 - al / 2), new Point(width / 2 + al, height / 2), new Point(width / 2, height / 2 + al / 2) };
            Point[] left = { new Point(width / 2, height / 2 - al / 2), new Point(width / 2 - al, height / 2), new Point(width / 2, height / 2 + al / 2) };
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
                        g.FillPolygon(red, center);
                switch (dir)
                {
                    case GamepadState.DpadDir.up:
                        g.FillPolygon(red, up);
                        break;
                    case GamepadState.DpadDir.down:
                        g.FillPolygon(red, down);
                        break;
                    case GamepadState.DpadDir.right:
                        g.FillPolygon(red, right);
                        break;
                    case GamepadState.DpadDir.left:
                        g.FillPolygon(red, left);
                        break;
                    default:
                        break;
                }
            }
            dpadPb.Image = bm;
        }
    }
}
