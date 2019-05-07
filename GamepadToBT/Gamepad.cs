using SharpDX.DirectInput;
using System;
using System.Collections.Generic;

namespace GamepadToBT
{
    class Gamepad
    {
        private DirectInput directInput;
        private Joystick joystick;

        public GamepadState gamepadState;

        public Gamepad()
        {
            directInput = new DirectInput();
            joystick = null;
            gamepadState = new GamepadState();
        }

        public List<DeviceInstance> ListDevices()
        {
            List<DeviceInstance> joystickInstances = new List<DeviceInstance>();
            Guid joystickGuid = Guid.Empty;

            foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                string name = deviceInstance.ProductName;
                Console.WriteLine("Found Gamepad with name: " + name);
                joystickInstances.Add(deviceInstance);
            }

            foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                string name = deviceInstance.ProductName;
                Console.WriteLine("Found Joystick with name: " + name);
                joystickInstances.Add(deviceInstance);
            }
            if (joystickInstances.Count == 0)
                Console.WriteLine("No joysticks/gamepads found");
            return joystickInstances;
        }

        public void ConnectGamepad(Guid joystickGuid)
        {
            // Instantiate the joystick
            joystick = new Joystick(directInput, joystickGuid);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available " + effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();
            Console.WriteLine("Gamepad connected");

        }

        public void DisconnectGamepad()
        {
            if (joystick == null)
                return;

            joystick.Unacquire();
            joystick = null;
        }

        public bool PollGamepad()
        {
            if (joystick == null)
                return false;

            // Poll events from joystick
            try
            {
                joystick.Poll();
                ParseGamepad(joystick.GetBufferedData());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not read gamepad data: " + ex.Message);
                return false;
            }
        }

        private void ParseGamepad(JoystickUpdate[] data)
        {
            foreach (JoystickUpdate state in data)
            {
                //Console.WriteLine(state);
                if (joystick.Information.Type == DeviceType.Joystick || joystick.Information.Type == DeviceType.Gamepad)
                {
                    if (joystick.Information.Type == DeviceType.Joystick)
                    {
                        if (state.Offset == JoystickOffset.RotationZ)
                            gamepadState.rx = (UInt16)state.Value;
                        else if (state.Offset == JoystickOffset.Z)
                            gamepadState.ry = (UInt16)state.Value;
                    }
                    else
                    {
                        if (state.Offset == JoystickOffset.RotationX)
                            gamepadState.rx = (UInt16)state.Value;
                        else if (state.Offset == JoystickOffset.RotationY)
                            gamepadState.ry = (UInt16)state.Value;
                        else if (state.Offset == JoystickOffset.Z)
                            gamepadState.trigger = (UInt16)state.Value;
                    }

                    if (state.Offset == JoystickOffset.X)
                        gamepadState.lx = (UInt16)state.Value;
                    else if (state.Offset == JoystickOffset.Y)
                        gamepadState.ly = (UInt16)state.Value;
                    else if (state.Offset == JoystickOffset.PointOfViewControllers0)
                    {
                        switch (state.Value)
                        {
                            case 0: gamepadState.dpad = GamepadState.DpadDir.up; break;
                            case 9000: gamepadState.dpad = GamepadState.DpadDir.right; break;
                            case 18000: gamepadState.dpad = GamepadState.DpadDir.down; break;
                            case 27000: gamepadState.dpad = GamepadState.DpadDir.left; break;
                            default: gamepadState.dpad = GamepadState.DpadDir.center; break;
                        }
                    }
                    if (state.Offset >= JoystickOffset.Buttons0 && state.Offset <= JoystickOffset.Buttons11)
                    {
                        int btnNr = (state.Offset - JoystickOffset.Buttons0);
                        gamepadState.button[btnNr] = (state.Value != 0);
                    }
                }
                else
                {
                    Console.WriteLine("Undefined device type");
                }
            }
        }
    }

    public class GamepadState
    {
        public readonly int numButtons = 12;
        public enum DpadDir { center, up, down, right, left };

        public UInt16 lx; //left joystick x
        public UInt16 ly; //left joystick y
        public UInt16 rx; //right joystick x
        public UInt16 ry; //right joystick y
        public UInt16 trigger; //left trigger
        public DpadDir dpad; //dpad
        public bool[] button; //buttons

        public GamepadState()
        {
            lx = ly = rx = ry = UInt16.MaxValue / 2;
            trigger = UInt16.MaxValue / 2;
            dpad = DpadDir.center;
            button = new bool[numButtons];
        }
    }
}
