namespace WinFormsApp1
{
    partial class Standart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standart));
            this.redLight = new System.Windows.Forms.PictureBox();
            this.yellowLight = new System.Windows.Forms.PictureBox();
            this.greenLight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timerChange = new System.Windows.Forms.Button();
            this.timerInterval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yellowTimer = new System.Windows.Forms.Timer(this.components);
            this.emptyLight = new System.Windows.Forms.PictureBox();
            this.redBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.rightLight = new System.Windows.Forms.CheckBox();
            this.leftLight = new System.Windows.Forms.CheckBox();
            this.bottomLight = new System.Windows.Forms.CheckBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.bottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // redLight
            // 
            this.redLight.Image = global::WinFormsApp1.Properties.Resources.red;
            this.redLight.Location = new System.Drawing.Point(528, 27);
            this.redLight.Name = "redLight";
            this.redLight.Size = new System.Drawing.Size(100, 188);
            this.redLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redLight.TabIndex = 0;
            this.redLight.TabStop = false;
            // 
            // yellowLight
            // 
            this.yellowLight.Image = global::WinFormsApp1.Properties.Resources.yellow;
            this.yellowLight.Location = new System.Drawing.Point(530, 27);
            this.yellowLight.Name = "yellowLight";
            this.yellowLight.Size = new System.Drawing.Size(100, 188);
            this.yellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowLight.TabIndex = 1;
            this.yellowLight.TabStop = false;
            // 
            // greenLight
            // 
            this.greenLight.Image = global::WinFormsApp1.Properties.Resources.green;
            this.greenLight.Location = new System.Drawing.Point(530, 27);
            this.greenLight.Name = "greenLight";
            this.greenLight.Size = new System.Drawing.Size(100, 188);
            this.greenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenLight.TabIndex = 2;
            this.greenLight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(32, 27);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(145, 27);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timerChange
            // 
            this.timerChange.AutoSize = true;
            this.timerChange.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerChange.Location = new System.Drawing.Point(32, 73);
            this.timerChange.Name = "timerChange";
            this.timerChange.Size = new System.Drawing.Size(110, 27);
            this.timerChange.TabIndex = 5;
            this.timerChange.Text = "Задати таймер";
            this.timerChange.UseVisualStyleBackColor = true;
            this.timerChange.Click += new System.EventHandler(this.timerChange_Click);
            // 
            // timerInterval
            // 
            this.timerInterval.Location = new System.Drawing.Point(161, 76);
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.Size = new System.Drawing.Size(59, 23);
            this.timerInterval.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(31, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Світлофор не працює";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yellowTimer
            // 
            this.yellowTimer.Interval = 1000;
            this.yellowTimer.Tick += new System.EventHandler(this.yellowTimer_Tick);
            // 
            // emptyLight
            // 
            this.emptyLight.Image = ((System.Drawing.Image)(resources.GetObject("emptyLight.Image")));
            this.emptyLight.Location = new System.Drawing.Point(530, 27);
            this.emptyLight.Name = "emptyLight";
            this.emptyLight.Size = new System.Drawing.Size(98, 188);
            this.emptyLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyLight.TabIndex = 8;
            this.emptyLight.TabStop = false;
            this.emptyLight.Visible = false;
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(67, 171);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(75, 23);
            this.redBtn.TabIndex = 9;
            this.redBtn.Text = "Червоний";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // yellowBtn
            // 
            this.yellowBtn.Location = new System.Drawing.Point(67, 211);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(75, 23);
            this.yellowBtn.TabIndex = 10;
            this.yellowBtn.Text = "Жовтий";
            this.yellowBtn.UseVisualStyleBackColor = true;
            this.yellowBtn.Click += new System.EventHandler(this.yellowBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.Location = new System.Drawing.Point(67, 253);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(75, 23);
            this.greenBtn.TabIndex = 11;
            this.greenBtn.Text = "Зелений";
            this.greenBtn.UseVisualStyleBackColor = true;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // rightLight
            // 
            this.rightLight.AutoSize = true;
            this.rightLight.Location = new System.Drawing.Point(67, 322);
            this.rightLight.Name = "rightLight";
            this.rightLight.Size = new System.Drawing.Size(66, 19);
            this.rightLight.TabIndex = 12;
            this.rightLight.Text = "правий";
            this.rightLight.UseVisualStyleBackColor = true;
            this.rightLight.CheckStateChanged += new System.EventHandler(this.rightLight_CheckStateChanged);
            // 
            // leftLight
            // 
            this.leftLight.AutoSize = true;
            this.leftLight.Location = new System.Drawing.Point(67, 347);
            this.leftLight.Name = "leftLight";
            this.leftLight.Size = new System.Drawing.Size(56, 19);
            this.leftLight.TabIndex = 13;
            this.leftLight.Text = "лівий";
            this.leftLight.UseVisualStyleBackColor = true;
            this.leftLight.CheckedChanged += new System.EventHandler(this.leftLight_CheckedChanged);
            // 
            // bottomLight
            // 
            this.bottomLight.AutoSize = true;
            this.bottomLight.Location = new System.Drawing.Point(67, 377);
            this.bottomLight.Name = "bottomLight";
            this.bottomLight.Size = new System.Drawing.Size(62, 19);
            this.bottomLight.TabIndex = 14;
            this.bottomLight.Text = "нижнє";
            this.bottomLight.UseVisualStyleBackColor = true;
            this.bottomLight.CheckedChanged += new System.EventHandler(this.bottomLight_CheckedChanged);
            // 
            // left
            // 
            this.left.Image = global::WinFormsApp1.Properties.Resources.left;
            this.left.Location = new System.Drawing.Point(494, 153);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(54, 62);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left.TabIndex = 15;
            this.left.TabStop = false;
            this.left.Visible = false;
            // 
            // right
            // 
            this.right.Image = global::WinFormsApp1.Properties.Resources.right;
            this.right.Location = new System.Drawing.Point(610, 153);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(52, 62);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right.TabIndex = 16;
            this.right.TabStop = false;
            this.right.Visible = false;
            // 
            // bottom
            // 
            this.bottom.Image = global::WinFormsApp1.Properties.Resources.bottom;
            this.bottom.Location = new System.Drawing.Point(548, 221);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(65, 65);
            this.bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottom.TabIndex = 17;
            this.bottom.TabStop = false;
            this.bottom.Visible = false;
            // 
            // Standart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.bottomLight);
            this.Controls.Add(this.leftLight);
            this.Controls.Add(this.rightLight);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.yellowBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.emptyLight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timerInterval);
            this.Controls.Add(this.timerChange);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.greenLight);
            this.Controls.Add(this.yellowLight);
            this.Controls.Add(this.redLight);
            this.Name = "Standart";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox redLight;
        private PictureBox yellowLight;
        private PictureBox greenLight;
        private System.Windows.Forms.Timer timer1;
        private Button startBtn;
        private Button stopBtn;
        private Button timerChange;
        private TextBox timerInterval;
        private Button button1;
        private System.Windows.Forms.Timer yellowTimer;
        private PictureBox emptyLight;
        private Button redBtn;
        private Button yellowBtn;
        private Button greenBtn;
        private CheckBox rightLight;
        private CheckBox leftLight;
        private CheckBox bottomLight;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox left;
        private PictureBox right;
        private PictureBox bottom;
    }
}