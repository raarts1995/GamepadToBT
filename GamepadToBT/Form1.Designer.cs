namespace GamepadToBT
{
    partial class gamepadToBluetooth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamepadCB = new System.Windows.Forms.ComboBox();
            this.gamepadGb = new System.Windows.Forms.GroupBox();
            this.bluetoothGb = new System.Windows.Forms.GroupBox();
            this.bluetoothCb = new System.Windows.Forms.ComboBox();
            this.openBTBtn = new System.Windows.Forms.Button();
            this.leftPB = new System.Windows.Forms.PictureBox();
            this.gpBtnsGb = new System.Windows.Forms.GroupBox();
            this.btn12rb = new System.Windows.Forms.RadioButton();
            this.btn11rb = new System.Windows.Forms.RadioButton();
            this.btn10rb = new System.Windows.Forms.RadioButton();
            this.btn9rb = new System.Windows.Forms.RadioButton();
            this.btn8rb = new System.Windows.Forms.RadioButton();
            this.btn4rb = new System.Windows.Forms.RadioButton();
            this.btn7rb = new System.Windows.Forms.RadioButton();
            this.btn6rb = new System.Windows.Forms.RadioButton();
            this.btn5rb = new System.Windows.Forms.RadioButton();
            this.btn3rb = new System.Windows.Forms.RadioButton();
            this.btn2rb = new System.Windows.Forms.RadioButton();
            this.btn1rb = new System.Windows.Forms.RadioButton();
            this.rightPB = new System.Windows.Forms.PictureBox();
            this.triggerPb = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTriggerLbl = new System.Windows.Forms.Label();
            this.lTriggerLbl = new System.Windows.Forms.Label();
            this.sticksGb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lStickLbl = new System.Windows.Forms.Label();
            this.dpadGb = new System.Windows.Forms.GroupBox();
            this.dpadPb = new System.Windows.Forms.PictureBox();
            this.gamepadGb.SuspendLayout();
            this.bluetoothGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPB)).BeginInit();
            this.gpBtnsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerPb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.sticksGb.SuspendLayout();
            this.dpadGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpadPb)).BeginInit();
            this.SuspendLayout();
            // 
            // gamepadCB
            // 
            this.gamepadCB.FormattingEnabled = true;
            this.gamepadCB.Location = new System.Drawing.Point(6, 19);
            this.gamepadCB.Name = "gamepadCB";
            this.gamepadCB.Size = new System.Drawing.Size(190, 21);
            this.gamepadCB.TabIndex = 1;
            this.gamepadCB.DropDown += new System.EventHandler(this.gamepadCB_DropDown);
            this.gamepadCB.SelectedIndexChanged += new System.EventHandler(this.gamepadCB_SelectedIndexChanged);
            // 
            // gamepadGb
            // 
            this.gamepadGb.Controls.Add(this.gamepadCB);
            this.gamepadGb.Location = new System.Drawing.Point(12, 12);
            this.gamepadGb.Name = "gamepadGb";
            this.gamepadGb.Size = new System.Drawing.Size(202, 50);
            this.gamepadGb.TabIndex = 2;
            this.gamepadGb.TabStop = false;
            this.gamepadGb.Text = "Gamepads";
            // 
            // bluetoothGb
            // 
            this.bluetoothGb.Controls.Add(this.bluetoothCb);
            this.bluetoothGb.Controls.Add(this.openBTBtn);
            this.bluetoothGb.Location = new System.Drawing.Point(12, 68);
            this.bluetoothGb.Name = "bluetoothGb";
            this.bluetoothGb.Size = new System.Drawing.Size(202, 76);
            this.bluetoothGb.TabIndex = 3;
            this.bluetoothGb.TabStop = false;
            this.bluetoothGb.Text = "Serial ports";
            // 
            // bluetoothCb
            // 
            this.bluetoothCb.FormattingEnabled = true;
            this.bluetoothCb.Location = new System.Drawing.Point(6, 19);
            this.bluetoothCb.Name = "bluetoothCb";
            this.bluetoothCb.Size = new System.Drawing.Size(190, 21);
            this.bluetoothCb.TabIndex = 1;
            this.bluetoothCb.DropDown += new System.EventHandler(this.bluetoothCb_DropDown);
            // 
            // openBTBtn
            // 
            this.openBTBtn.Location = new System.Drawing.Point(6, 44);
            this.openBTBtn.Name = "openBTBtn";
            this.openBTBtn.Size = new System.Drawing.Size(75, 23);
            this.openBTBtn.TabIndex = 0;
            this.openBTBtn.Text = "Open";
            this.openBTBtn.UseVisualStyleBackColor = true;
            this.openBTBtn.Click += new System.EventHandler(this.openBTBtn_Click);
            // 
            // leftPB
            // 
            this.leftPB.Location = new System.Drawing.Point(8, 32);
            this.leftPB.Name = "leftPB";
            this.leftPB.Size = new System.Drawing.Size(91, 91);
            this.leftPB.TabIndex = 4;
            this.leftPB.TabStop = false;
            // 
            // gpBtnsGb
            // 
            this.gpBtnsGb.Controls.Add(this.btn12rb);
            this.gpBtnsGb.Controls.Add(this.btn11rb);
            this.gpBtnsGb.Controls.Add(this.btn10rb);
            this.gpBtnsGb.Controls.Add(this.btn9rb);
            this.gpBtnsGb.Controls.Add(this.btn8rb);
            this.gpBtnsGb.Controls.Add(this.btn4rb);
            this.gpBtnsGb.Controls.Add(this.btn7rb);
            this.gpBtnsGb.Controls.Add(this.btn6rb);
            this.gpBtnsGb.Controls.Add(this.btn5rb);
            this.gpBtnsGb.Controls.Add(this.btn3rb);
            this.gpBtnsGb.Controls.Add(this.btn2rb);
            this.gpBtnsGb.Controls.Add(this.btn1rb);
            this.gpBtnsGb.Location = new System.Drawing.Point(12, 150);
            this.gpBtnsGb.Name = "gpBtnsGb";
            this.gpBtnsGb.Size = new System.Drawing.Size(202, 113);
            this.gpBtnsGb.TabIndex = 5;
            this.gpBtnsGb.TabStop = false;
            this.gpBtnsGb.Text = "Gamepad buttons";
            // 
            // btn12rb
            // 
            this.btn12rb.AutoCheck = false;
            this.btn12rb.AutoSize = true;
            this.btn12rb.Location = new System.Drawing.Point(150, 88);
            this.btn12rb.Name = "btn12rb";
            this.btn12rb.Size = new System.Drawing.Size(37, 17);
            this.btn12rb.TabIndex = 11;
            this.btn12rb.TabStop = true;
            this.btn12rb.Text = "12";
            this.btn12rb.UseVisualStyleBackColor = true;
            // 
            // btn11rb
            // 
            this.btn11rb.AutoCheck = false;
            this.btn11rb.AutoSize = true;
            this.btn11rb.Location = new System.Drawing.Point(150, 65);
            this.btn11rb.Name = "btn11rb";
            this.btn11rb.Size = new System.Drawing.Size(37, 17);
            this.btn11rb.TabIndex = 10;
            this.btn11rb.TabStop = true;
            this.btn11rb.Text = "11";
            this.btn11rb.UseVisualStyleBackColor = true;
            // 
            // btn10rb
            // 
            this.btn10rb.AutoCheck = false;
            this.btn10rb.AutoSize = true;
            this.btn10rb.Location = new System.Drawing.Point(150, 42);
            this.btn10rb.Name = "btn10rb";
            this.btn10rb.Size = new System.Drawing.Size(37, 17);
            this.btn10rb.TabIndex = 9;
            this.btn10rb.TabStop = true;
            this.btn10rb.Text = "10";
            this.btn10rb.UseVisualStyleBackColor = true;
            // 
            // btn9rb
            // 
            this.btn9rb.AutoCheck = false;
            this.btn9rb.AutoSize = true;
            this.btn9rb.Location = new System.Drawing.Point(150, 19);
            this.btn9rb.Name = "btn9rb";
            this.btn9rb.Size = new System.Drawing.Size(31, 17);
            this.btn9rb.TabIndex = 8;
            this.btn9rb.TabStop = true;
            this.btn9rb.Text = "9";
            this.btn9rb.UseVisualStyleBackColor = true;
            // 
            // btn8rb
            // 
            this.btn8rb.AutoCheck = false;
            this.btn8rb.AutoSize = true;
            this.btn8rb.Location = new System.Drawing.Point(83, 88);
            this.btn8rb.Name = "btn8rb";
            this.btn8rb.Size = new System.Drawing.Size(31, 17);
            this.btn8rb.TabIndex = 7;
            this.btn8rb.TabStop = true;
            this.btn8rb.Text = "8";
            this.btn8rb.UseVisualStyleBackColor = true;
            // 
            // btn4rb
            // 
            this.btn4rb.AutoCheck = false;
            this.btn4rb.AutoSize = true;
            this.btn4rb.Location = new System.Drawing.Point(16, 88);
            this.btn4rb.Name = "btn4rb";
            this.btn4rb.Size = new System.Drawing.Size(31, 17);
            this.btn4rb.TabIndex = 6;
            this.btn4rb.TabStop = true;
            this.btn4rb.Text = "4";
            this.btn4rb.UseVisualStyleBackColor = true;
            // 
            // btn7rb
            // 
            this.btn7rb.AutoCheck = false;
            this.btn7rb.AutoSize = true;
            this.btn7rb.Location = new System.Drawing.Point(83, 65);
            this.btn7rb.Name = "btn7rb";
            this.btn7rb.Size = new System.Drawing.Size(31, 17);
            this.btn7rb.TabIndex = 5;
            this.btn7rb.TabStop = true;
            this.btn7rb.Text = "7";
            this.btn7rb.UseVisualStyleBackColor = true;
            // 
            // btn6rb
            // 
            this.btn6rb.AutoCheck = false;
            this.btn6rb.AutoSize = true;
            this.btn6rb.Location = new System.Drawing.Point(83, 42);
            this.btn6rb.Name = "btn6rb";
            this.btn6rb.Size = new System.Drawing.Size(31, 17);
            this.btn6rb.TabIndex = 4;
            this.btn6rb.TabStop = true;
            this.btn6rb.Text = "6";
            this.btn6rb.UseVisualStyleBackColor = true;
            // 
            // btn5rb
            // 
            this.btn5rb.AutoCheck = false;
            this.btn5rb.AutoSize = true;
            this.btn5rb.Location = new System.Drawing.Point(83, 19);
            this.btn5rb.Name = "btn5rb";
            this.btn5rb.Size = new System.Drawing.Size(31, 17);
            this.btn5rb.TabIndex = 3;
            this.btn5rb.TabStop = true;
            this.btn5rb.Text = "5";
            this.btn5rb.UseVisualStyleBackColor = true;
            // 
            // btn3rb
            // 
            this.btn3rb.AutoCheck = false;
            this.btn3rb.AutoSize = true;
            this.btn3rb.Location = new System.Drawing.Point(16, 65);
            this.btn3rb.Name = "btn3rb";
            this.btn3rb.Size = new System.Drawing.Size(31, 17);
            this.btn3rb.TabIndex = 2;
            this.btn3rb.TabStop = true;
            this.btn3rb.Text = "3";
            this.btn3rb.UseVisualStyleBackColor = true;
            // 
            // btn2rb
            // 
            this.btn2rb.AutoCheck = false;
            this.btn2rb.AutoSize = true;
            this.btn2rb.Location = new System.Drawing.Point(16, 42);
            this.btn2rb.Name = "btn2rb";
            this.btn2rb.Size = new System.Drawing.Size(31, 17);
            this.btn2rb.TabIndex = 1;
            this.btn2rb.TabStop = true;
            this.btn2rb.Text = "2";
            this.btn2rb.UseVisualStyleBackColor = true;
            // 
            // btn1rb
            // 
            this.btn1rb.AutoCheck = false;
            this.btn1rb.AutoSize = true;
            this.btn1rb.Location = new System.Drawing.Point(16, 19);
            this.btn1rb.Name = "btn1rb";
            this.btn1rb.Size = new System.Drawing.Size(31, 17);
            this.btn1rb.TabIndex = 0;
            this.btn1rb.TabStop = true;
            this.btn1rb.Text = "1";
            this.btn1rb.UseVisualStyleBackColor = true;
            // 
            // rightPB
            // 
            this.rightPB.Location = new System.Drawing.Point(6, 154);
            this.rightPB.Name = "rightPB";
            this.rightPB.Size = new System.Drawing.Size(91, 91);
            this.rightPB.TabIndex = 6;
            this.rightPB.TabStop = false;
            // 
            // triggerPb
            // 
            this.triggerPb.Location = new System.Drawing.Point(6, 32);
            this.triggerPb.Name = "triggerPb";
            this.triggerPb.Size = new System.Drawing.Size(190, 23);
            this.triggerPb.TabIndex = 7;
            this.triggerPb.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rTriggerLbl);
            this.groupBox1.Controls.Add(this.lTriggerLbl);
            this.groupBox1.Controls.Add(this.triggerPb);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analog triggers";
            // 
            // rTriggerLbl
            // 
            this.rTriggerLbl.AutoSize = true;
            this.rTriggerLbl.Location = new System.Drawing.Point(164, 16);
            this.rTriggerLbl.Name = "rTriggerLbl";
            this.rTriggerLbl.Size = new System.Drawing.Size(32, 13);
            this.rTriggerLbl.TabIndex = 9;
            this.rTriggerLbl.Text = "Right";
            // 
            // lTriggerLbl
            // 
            this.lTriggerLbl.AutoSize = true;
            this.lTriggerLbl.Location = new System.Drawing.Point(6, 16);
            this.lTriggerLbl.Name = "lTriggerLbl";
            this.lTriggerLbl.Size = new System.Drawing.Size(25, 13);
            this.lTriggerLbl.TabIndex = 8;
            this.lTriggerLbl.Text = "Left";
            // 
            // sticksGb
            // 
            this.sticksGb.Controls.Add(this.label1);
            this.sticksGb.Controls.Add(this.lStickLbl);
            this.sticksGb.Controls.Add(this.leftPB);
            this.sticksGb.Controls.Add(this.rightPB);
            this.sticksGb.Location = new System.Drawing.Point(220, 12);
            this.sticksGb.Name = "sticksGb";
            this.sticksGb.Size = new System.Drawing.Size(105, 251);
            this.sticksGb.TabIndex = 9;
            this.sticksGb.TabStop = false;
            this.sticksGb.Text = "Analog sticks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 138);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Right stick";
            // 
            // lStickLbl
            // 
            this.lStickLbl.AutoSize = true;
            this.lStickLbl.Location = new System.Drawing.Point(6, 16);
            this.lStickLbl.Name = "lStickLbl";
            this.lStickLbl.Size = new System.Drawing.Size(50, 13);
            this.lStickLbl.TabIndex = 7;
            this.lStickLbl.Text = "Left stick";
            // 
            // dpadGb
            // 
            this.dpadGb.Controls.Add(this.dpadPb);
            this.dpadGb.Location = new System.Drawing.Point(220, 269);
            this.dpadGb.Name = "dpadGb";
            this.dpadGb.Size = new System.Drawing.Size(105, 64);
            this.dpadGb.TabIndex = 10;
            this.dpadGb.TabStop = false;
            this.dpadGb.Text = "Dpad";
            // 
            // dpadPb
            // 
            this.dpadPb.Location = new System.Drawing.Point(6, 16);
            this.dpadPb.Name = "dpadPb";
            this.dpadPb.Size = new System.Drawing.Size(93, 42);
            this.dpadPb.TabIndex = 0;
            this.dpadPb.TabStop = false;
            // 
            // gamepadToBluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 343);
            this.Controls.Add(this.dpadGb);
            this.Controls.Add(this.sticksGb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBtnsGb);
            this.Controls.Add(this.bluetoothGb);
            this.Controls.Add(this.gamepadGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "gamepadToBluetooth";
            this.Text = "Gamepad to bluetooth";
            this.gamepadGb.ResumeLayout(false);
            this.bluetoothGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftPB)).EndInit();
            this.gpBtnsGb.ResumeLayout(false);
            this.gpBtnsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerPb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sticksGb.ResumeLayout(false);
            this.sticksGb.PerformLayout();
            this.dpadGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpadPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox gamepadCB;
        private System.Windows.Forms.GroupBox gamepadGb;
        private System.Windows.Forms.GroupBox bluetoothGb;
        private System.Windows.Forms.ComboBox bluetoothCb;
        private System.Windows.Forms.Button openBTBtn;
        private System.Windows.Forms.PictureBox leftPB;
        private System.Windows.Forms.GroupBox gpBtnsGb;
        private System.Windows.Forms.RadioButton btn7rb;
        private System.Windows.Forms.RadioButton btn6rb;
        private System.Windows.Forms.RadioButton btn5rb;
        private System.Windows.Forms.RadioButton btn3rb;
        private System.Windows.Forms.RadioButton btn2rb;
        private System.Windows.Forms.RadioButton btn1rb;
        private System.Windows.Forms.RadioButton btn12rb;
        private System.Windows.Forms.RadioButton btn11rb;
        private System.Windows.Forms.RadioButton btn10rb;
        private System.Windows.Forms.RadioButton btn9rb;
        private System.Windows.Forms.RadioButton btn8rb;
        private System.Windows.Forms.RadioButton btn4rb;
        private System.Windows.Forms.PictureBox rightPB;
        private System.Windows.Forms.PictureBox triggerPb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label rTriggerLbl;
        private System.Windows.Forms.Label lTriggerLbl;
        private System.Windows.Forms.GroupBox sticksGb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lStickLbl;
        private System.Windows.Forms.GroupBox dpadGb;
        private System.Windows.Forms.PictureBox dpadPb;
    }
}

