namespace Panel_Control_Frequency
{
    partial class Panel_4ControlFrequency
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_FREQUENCYCONTROL = new System.Windows.Forms.GroupBox();
            this.groupBox_Single_Frequency = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SINGLEFREQUENCY = new System.Windows.Forms.Button();
            this.textBox_SingleFrequency = new System.Windows.Forms.TextBox();
            this.label_SingleFreq = new System.Windows.Forms.Label();
            this.groupBox_Sweep_Frequency = new System.Windows.Forms.GroupBox();
            this.button_SWEEPFREQUENCY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_STOPFREQUENCY = new System.Windows.Forms.TextBox();
            this.label_Stop_Frequency = new System.Windows.Forms.Label();
            this.textBox_STEPFREQUENCY = new System.Windows.Forms.TextBox();
            this.label_Step_Frequency = new System.Windows.Forms.Label();
            this.textBox_START_FREQUENCY = new System.Windows.Forms.TextBox();
            this.label_Start_Frequency = new System.Windows.Forms.Label();
            this.groupBox_SELECT_MODE = new System.Windows.Forms.GroupBox();
            this.checkBox_Sweep_Frequency = new System.Windows.Forms.CheckBox();
            this.checkBox_Single_Frequency = new System.Windows.Forms.CheckBox();
            this.groupBox_Select_Current = new System.Windows.Forms.GroupBox();
            this.button_SetCurrent = new System.Windows.Forms.Button();
            this.comboBox_SELECTCURRENT = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_COMPORTONOFFSTATUS = new System.Windows.Forms.Label();
            this.label_COMPORTSTATUS = new System.Windows.Forms.Label();
            this.label_SELECTcOMPORT = new System.Windows.Forms.Label();
            this.comboBox_COMPORT = new System.Windows.Forms.ComboBox();
            this.button_DISCONNECT = new System.Windows.Forms.Button();
            this.button_CONNECT = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox_FREQUENCYCONTROL.SuspendLayout();
            this.groupBox_Single_Frequency.SuspendLayout();
            this.groupBox_Sweep_Frequency.SuspendLayout();
            this.groupBox_SELECT_MODE.SuspendLayout();
            this.groupBox_Select_Current.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_FREQUENCYCONTROL);
            this.panel2.Controls.Add(this.groupBox_Select_Current);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(186, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 576);
            this.panel2.TabIndex = 3;
            // 
            // groupBox_FREQUENCYCONTROL
            // 
            this.groupBox_FREQUENCYCONTROL.AutoSize = true;
            this.groupBox_FREQUENCYCONTROL.Controls.Add(this.groupBox_Single_Frequency);
            this.groupBox_FREQUENCYCONTROL.Controls.Add(this.groupBox_Sweep_Frequency);
            this.groupBox_FREQUENCYCONTROL.Controls.Add(this.groupBox_SELECT_MODE);
            this.groupBox_FREQUENCYCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FREQUENCYCONTROL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_FREQUENCYCONTROL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_FREQUENCYCONTROL.ForeColor = System.Drawing.Color.White;
            this.groupBox_FREQUENCYCONTROL.Location = new System.Drawing.Point(0, 0);
            this.groupBox_FREQUENCYCONTROL.Name = "groupBox_FREQUENCYCONTROL";
            this.groupBox_FREQUENCYCONTROL.Size = new System.Drawing.Size(388, 576);
            this.groupBox_FREQUENCYCONTROL.TabIndex = 1;
            this.groupBox_FREQUENCYCONTROL.TabStop = false;
            this.groupBox_FREQUENCYCONTROL.Text = " Control Frequency";
            // 
            // groupBox_Single_Frequency
            // 
            this.groupBox_Single_Frequency.Controls.Add(this.label1);
            this.groupBox_Single_Frequency.Controls.Add(this.button_SINGLEFREQUENCY);
            this.groupBox_Single_Frequency.Controls.Add(this.textBox_SingleFrequency);
            this.groupBox_Single_Frequency.Controls.Add(this.label_SingleFreq);
            this.groupBox_Single_Frequency.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Single_Frequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Single_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Single_Frequency.ForeColor = System.Drawing.Color.White;
            this.groupBox_Single_Frequency.Location = new System.Drawing.Point(3, 82);
            this.groupBox_Single_Frequency.Name = "groupBox_Single_Frequency";
            this.groupBox_Single_Frequency.Size = new System.Drawing.Size(382, 110);
            this.groupBox_Single_Frequency.TabIndex = 1;
            this.groupBox_Single_Frequency.TabStop = false;
            this.groupBox_Single_Frequency.Text = "Single Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hz";
            // 
            // button_SINGLEFREQUENCY
            // 
            this.button_SINGLEFREQUENCY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SINGLEFREQUENCY.FlatAppearance.BorderSize = 0;
            this.button_SINGLEFREQUENCY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SINGLEFREQUENCY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SINGLEFREQUENCY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SINGLEFREQUENCY.Location = new System.Drawing.Point(195, 71);
            this.button_SINGLEFREQUENCY.Name = "button_SINGLEFREQUENCY";
            this.button_SINGLEFREQUENCY.Size = new System.Drawing.Size(119, 33);
            this.button_SINGLEFREQUENCY.TabIndex = 2;
            this.button_SINGLEFREQUENCY.Text = "SEND DATA";
            this.button_SINGLEFREQUENCY.UseVisualStyleBackColor = false;
            // 
            // textBox_SingleFrequency
            // 
            this.textBox_SingleFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_SingleFrequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SingleFrequency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SingleFrequency.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_SingleFrequency.Location = new System.Drawing.Point(177, 32);
            this.textBox_SingleFrequency.Name = "textBox_SingleFrequency";
            this.textBox_SingleFrequency.Size = new System.Drawing.Size(137, 19);
            this.textBox_SingleFrequency.TabIndex = 1;
            this.textBox_SingleFrequency.Text = "e.g.: 10000000";
            // 
            // label_SingleFreq
            // 
            this.label_SingleFreq.AutoSize = true;
            this.label_SingleFreq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SingleFreq.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_SingleFreq.Location = new System.Drawing.Point(45, 34);
            this.label_SingleFreq.Name = "label_SingleFreq";
            this.label_SingleFreq.Size = new System.Drawing.Size(91, 20);
            this.label_SingleFreq.TabIndex = 0;
            this.label_SingleFreq.Text = "Frequency:";
            // 
            // groupBox_Sweep_Frequency
            // 
            this.groupBox_Sweep_Frequency.Controls.Add(this.button_SWEEPFREQUENCY);
            this.groupBox_Sweep_Frequency.Controls.Add(this.label4);
            this.groupBox_Sweep_Frequency.Controls.Add(this.label3);
            this.groupBox_Sweep_Frequency.Controls.Add(this.label2);
            this.groupBox_Sweep_Frequency.Controls.Add(this.textBox_STOPFREQUENCY);
            this.groupBox_Sweep_Frequency.Controls.Add(this.label_Stop_Frequency);
            this.groupBox_Sweep_Frequency.Controls.Add(this.textBox_STEPFREQUENCY);
            this.groupBox_Sweep_Frequency.Controls.Add(this.label_Step_Frequency);
            this.groupBox_Sweep_Frequency.Controls.Add(this.textBox_START_FREQUENCY);
            this.groupBox_Sweep_Frequency.Controls.Add(this.label_Start_Frequency);
            this.groupBox_Sweep_Frequency.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Sweep_Frequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Sweep_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Sweep_Frequency.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Sweep_Frequency.Location = new System.Drawing.Point(3, 381);
            this.groupBox_Sweep_Frequency.Name = "groupBox_Sweep_Frequency";
            this.groupBox_Sweep_Frequency.Size = new System.Drawing.Size(382, 192);
            this.groupBox_Sweep_Frequency.TabIndex = 2;
            this.groupBox_Sweep_Frequency.TabStop = false;
            this.groupBox_Sweep_Frequency.Text = "Sweep Frequency";
            // 
            // button_SWEEPFREQUENCY
            // 
            this.button_SWEEPFREQUENCY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SWEEPFREQUENCY.FlatAppearance.BorderSize = 0;
            this.button_SWEEPFREQUENCY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SWEEPFREQUENCY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SWEEPFREQUENCY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SWEEPFREQUENCY.Location = new System.Drawing.Point(195, 153);
            this.button_SWEEPFREQUENCY.Name = "button_SWEEPFREQUENCY";
            this.button_SWEEPFREQUENCY.Size = new System.Drawing.Size(119, 33);
            this.button_SWEEPFREQUENCY.TabIndex = 11;
            this.button_SWEEPFREQUENCY.Text = "SEND DATA";
            this.button_SWEEPFREQUENCY.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(291, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(291, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(291, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hz";
            // 
            // textBox_STOPFREQUENCY
            // 
            this.textBox_STOPFREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_STOPFREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_STOPFREQUENCY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_STOPFREQUENCY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_STOPFREQUENCY.Location = new System.Drawing.Point(177, 120);
            this.textBox_STOPFREQUENCY.Name = "textBox_STOPFREQUENCY";
            this.textBox_STOPFREQUENCY.Size = new System.Drawing.Size(124, 19);
            this.textBox_STOPFREQUENCY.TabIndex = 8;
            this.textBox_STOPFREQUENCY.Text = "e.g.: 10000000";
            // 
            // label_Stop_Frequency
            // 
            this.label_Stop_Frequency.AutoSize = true;
            this.label_Stop_Frequency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stop_Frequency.Location = new System.Drawing.Point(29, 123);
            this.label_Stop_Frequency.Name = "label_Stop_Frequency";
            this.label_Stop_Frequency.Size = new System.Drawing.Size(127, 20);
            this.label_Stop_Frequency.TabIndex = 7;
            this.label_Stop_Frequency.Text = "Stop Frequency:";
            // 
            // textBox_STEPFREQUENCY
            // 
            this.textBox_STEPFREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_STEPFREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_STEPFREQUENCY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_STEPFREQUENCY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_STEPFREQUENCY.Location = new System.Drawing.Point(177, 77);
            this.textBox_STEPFREQUENCY.Name = "textBox_STEPFREQUENCY";
            this.textBox_STEPFREQUENCY.Size = new System.Drawing.Size(124, 19);
            this.textBox_STEPFREQUENCY.TabIndex = 6;
            this.textBox_STEPFREQUENCY.Text = "e.g.: 10000000";
            // 
            // label_Step_Frequency
            // 
            this.label_Step_Frequency.AutoSize = true;
            this.label_Step_Frequency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Step_Frequency.Location = new System.Drawing.Point(26, 76);
            this.label_Step_Frequency.Name = "label_Step_Frequency";
            this.label_Step_Frequency.Size = new System.Drawing.Size(127, 20);
            this.label_Step_Frequency.TabIndex = 5;
            this.label_Step_Frequency.Text = "Step Frequency:";
            // 
            // textBox_START_FREQUENCY
            // 
            this.textBox_START_FREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_START_FREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_START_FREQUENCY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_START_FREQUENCY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_START_FREQUENCY.Location = new System.Drawing.Point(177, 27);
            this.textBox_START_FREQUENCY.Name = "textBox_START_FREQUENCY";
            this.textBox_START_FREQUENCY.Size = new System.Drawing.Size(124, 19);
            this.textBox_START_FREQUENCY.TabIndex = 3;
            this.textBox_START_FREQUENCY.Text = "e.g.: 10000000";
            // 
            // label_Start_Frequency
            // 
            this.label_Start_Frequency.AutoSize = true;
            this.label_Start_Frequency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Start_Frequency.Location = new System.Drawing.Point(29, 27);
            this.label_Start_Frequency.Name = "label_Start_Frequency";
            this.label_Start_Frequency.Size = new System.Drawing.Size(127, 20);
            this.label_Start_Frequency.TabIndex = 2;
            this.label_Start_Frequency.Text = "Start Frequency:";
            // 
            // groupBox_SELECT_MODE
            // 
            this.groupBox_SELECT_MODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox_SELECT_MODE.Controls.Add(this.checkBox_Sweep_Frequency);
            this.groupBox_SELECT_MODE.Controls.Add(this.checkBox_Single_Frequency);
            this.groupBox_SELECT_MODE.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_SELECT_MODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_SELECT_MODE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SELECT_MODE.ForeColor = System.Drawing.Color.White;
            this.groupBox_SELECT_MODE.Location = new System.Drawing.Point(3, 18);
            this.groupBox_SELECT_MODE.Name = "groupBox_SELECT_MODE";
            this.groupBox_SELECT_MODE.Size = new System.Drawing.Size(382, 64);
            this.groupBox_SELECT_MODE.TabIndex = 0;
            this.groupBox_SELECT_MODE.TabStop = false;
            this.groupBox_SELECT_MODE.Text = "SELECT MODE";
            // 
            // checkBox_Sweep_Frequency
            // 
            this.checkBox_Sweep_Frequency.AutoSize = true;
            this.checkBox_Sweep_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Sweep_Frequency.Location = new System.Drawing.Point(162, 18);
            this.checkBox_Sweep_Frequency.Name = "checkBox_Sweep_Frequency";
            this.checkBox_Sweep_Frequency.Size = new System.Drawing.Size(139, 21);
            this.checkBox_Sweep_Frequency.TabIndex = 1;
            this.checkBox_Sweep_Frequency.Text = "Sweep Frequency";
            this.checkBox_Sweep_Frequency.UseVisualStyleBackColor = true;
            // 
            // checkBox_Single_Frequency
            // 
            this.checkBox_Single_Frequency.AutoSize = true;
            this.checkBox_Single_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Single_Frequency.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox_Single_Frequency.Location = new System.Drawing.Point(3, 18);
            this.checkBox_Single_Frequency.Name = "checkBox_Single_Frequency";
            this.checkBox_Single_Frequency.Size = new System.Drawing.Size(133, 21);
            this.checkBox_Single_Frequency.TabIndex = 0;
            this.checkBox_Single_Frequency.Text = "Single Frequency";
            this.checkBox_Single_Frequency.UseVisualStyleBackColor = true;
            // 
            // groupBox_Select_Current
            // 
            this.groupBox_Select_Current.Controls.Add(this.button_SetCurrent);
            this.groupBox_Select_Current.Controls.Add(this.comboBox_SELECTCURRENT);
            this.groupBox_Select_Current.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_Select_Current.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Select_Current.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_Select_Current.Location = new System.Drawing.Point(388, 0);
            this.groupBox_Select_Current.Name = "groupBox_Select_Current";
            this.groupBox_Select_Current.Size = new System.Drawing.Size(196, 576);
            this.groupBox_Select_Current.TabIndex = 0;
            this.groupBox_Select_Current.TabStop = false;
            this.groupBox_Select_Current.Text = "SELECT CURRENT";
            // 
            // button_SetCurrent
            // 
            this.button_SetCurrent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SetCurrent.FlatAppearance.BorderSize = 0;
            this.button_SetCurrent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SetCurrent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SetCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SetCurrent.Location = new System.Drawing.Point(59, 116);
            this.button_SetCurrent.Name = "button_SetCurrent";
            this.button_SetCurrent.Size = new System.Drawing.Size(119, 33);
            this.button_SetCurrent.TabIndex = 3;
            this.button_SetCurrent.Text = "SEND DATA";
            this.button_SetCurrent.UseVisualStyleBackColor = false;
            // 
            // comboBox_SELECTCURRENT
            // 
            this.comboBox_SELECTCURRENT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_SELECTCURRENT.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_SELECTCURRENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SELECTCURRENT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SELECTCURRENT.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_SELECTCURRENT.FormattingEnabled = true;
            this.comboBox_SELECTCURRENT.Items.AddRange(new object[] {
            "1 mA",
            "100 μA",
            "10 μA",
            "1 μA",
            "0,1 μA"});
            this.comboBox_SELECTCURRENT.Location = new System.Drawing.Point(13, 36);
            this.comboBox_SELECTCURRENT.Name = "comboBox_SELECTCURRENT";
            this.comboBox_SELECTCURRENT.Size = new System.Drawing.Size(165, 25);
            this.comboBox_SELECTCURRENT.TabIndex = 1;
            this.comboBox_SELECTCURRENT.Text = "1 mA";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label_COMPORTONOFFSTATUS);
            this.panel1.Controls.Add(this.label_COMPORTSTATUS);
            this.panel1.Controls.Add(this.label_SELECTcOMPORT);
            this.panel1.Controls.Add(this.comboBox_COMPORT);
            this.panel1.Controls.Add(this.button_DISCONNECT);
            this.panel1.Controls.Add(this.button_CONNECT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 576);
            this.panel1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 293);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label_COMPORTONOFFSTATUS
            // 
            this.label_COMPORTONOFFSTATUS.AutoSize = true;
            this.label_COMPORTONOFFSTATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label_COMPORTONOFFSTATUS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COMPORTONOFFSTATUS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_COMPORTONOFFSTATUS.Location = new System.Drawing.Point(60, 375);
            this.label_COMPORTONOFFSTATUS.Name = "label_COMPORTONOFFSTATUS";
            this.label_COMPORTONOFFSTATUS.Size = new System.Drawing.Size(64, 33);
            this.label_COMPORTONOFFSTATUS.TabIndex = 3;
            this.label_COMPORTONOFFSTATUS.Text = "OFF";
            // 
            // label_COMPORTSTATUS
            // 
            this.label_COMPORTSTATUS.AutoSize = true;
            this.label_COMPORTSTATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label_COMPORTSTATUS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COMPORTSTATUS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_COMPORTSTATUS.Location = new System.Drawing.Point(34, 341);
            this.label_COMPORTSTATUS.Name = "label_COMPORTSTATUS";
            this.label_COMPORTSTATUS.Size = new System.Drawing.Size(116, 17);
            this.label_COMPORTSTATUS.TabIndex = 2;
            this.label_COMPORTSTATUS.Text = "COMPORT STATUS";
            // 
            // label_SELECTcOMPORT
            // 
            this.label_SELECTcOMPORT.AutoSize = true;
            this.label_SELECTcOMPORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label_SELECTcOMPORT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SELECTcOMPORT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_SELECTcOMPORT.Location = new System.Drawing.Point(3, 91);
            this.label_SELECTcOMPORT.Name = "label_SELECTcOMPORT";
            this.label_SELECTcOMPORT.Size = new System.Drawing.Size(127, 17);
            this.label_SELECTcOMPORT.TabIndex = 0;
            this.label_SELECTcOMPORT.Text = "SELECT COM PORT:";
            // 
            // comboBox_COMPORT
            // 
            this.comboBox_COMPORT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_COMPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_COMPORT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_COMPORT.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_COMPORT.FormattingEnabled = true;
            this.comboBox_COMPORT.Location = new System.Drawing.Point(3, 111);
            this.comboBox_COMPORT.Name = "comboBox_COMPORT";
            this.comboBox_COMPORT.Size = new System.Drawing.Size(180, 25);
            this.comboBox_COMPORT.TabIndex = 0;
            // 
            // button_DISCONNECT
            // 
            this.button_DISCONNECT.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_DISCONNECT.FlatAppearance.BorderSize = 0;
            this.button_DISCONNECT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_DISCONNECT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_DISCONNECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DISCONNECT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DISCONNECT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DISCONNECT.Location = new System.Drawing.Point(0, 236);
            this.button_DISCONNECT.Name = "button_DISCONNECT";
            this.button_DISCONNECT.Size = new System.Drawing.Size(183, 40);
            this.button_DISCONNECT.TabIndex = 1;
            this.button_DISCONNECT.Text = "DISCONNECT";
            this.button_DISCONNECT.UseVisualStyleBackColor = false;
            // 
            // button_CONNECT
            // 
            this.button_CONNECT.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_CONNECT.FlatAppearance.BorderSize = 0;
            this.button_CONNECT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_CONNECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CONNECT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CONNECT.ForeColor = System.Drawing.Color.White;
            this.button_CONNECT.Location = new System.Drawing.Point(0, 172);
            this.button_CONNECT.Name = "button_CONNECT";
            this.button_CONNECT.Size = new System.Drawing.Size(183, 40);
            this.button_CONNECT.TabIndex = 0;
            this.button_CONNECT.Text = "CONNECT ";
            this.button_CONNECT.UseVisualStyleBackColor = false;
            // 
            // Panel_4ControlFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(770, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_4ControlFrequency";
            this.Opacity = 0.9D;
            this.RightToLeftLayout = true;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Panel_4ControlFrequency_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_FREQUENCYCONTROL.ResumeLayout(false);
            this.groupBox_Single_Frequency.ResumeLayout(false);
            this.groupBox_Single_Frequency.PerformLayout();
            this.groupBox_Sweep_Frequency.ResumeLayout(false);
            this.groupBox_Sweep_Frequency.PerformLayout();
            this.groupBox_SELECT_MODE.ResumeLayout(false);
            this.groupBox_SELECT_MODE.PerformLayout();
            this.groupBox_Select_Current.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_FREQUENCYCONTROL;
        private System.Windows.Forms.GroupBox groupBox_Single_Frequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SINGLEFREQUENCY;
        private System.Windows.Forms.TextBox textBox_SingleFrequency;
        private System.Windows.Forms.Label label_SingleFreq;
        private System.Windows.Forms.GroupBox groupBox_Sweep_Frequency;
        private System.Windows.Forms.Button button_SWEEPFREQUENCY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_STOPFREQUENCY;
        private System.Windows.Forms.Label label_Stop_Frequency;
        private System.Windows.Forms.TextBox textBox_STEPFREQUENCY;
        private System.Windows.Forms.Label label_Step_Frequency;
        private System.Windows.Forms.TextBox textBox_START_FREQUENCY;
        private System.Windows.Forms.Label label_Start_Frequency;
        private System.Windows.Forms.GroupBox groupBox_SELECT_MODE;
        private System.Windows.Forms.CheckBox checkBox_Sweep_Frequency;
        private System.Windows.Forms.CheckBox checkBox_Single_Frequency;
        private System.Windows.Forms.GroupBox groupBox_Select_Current;
        private System.Windows.Forms.Button button_SetCurrent;
        private System.Windows.Forms.ComboBox comboBox_SELECTCURRENT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_COMPORTONOFFSTATUS;
        private System.Windows.Forms.Label label_COMPORTSTATUS;
        private System.Windows.Forms.Label label_SELECTcOMPORT;
        private System.Windows.Forms.ComboBox comboBox_COMPORT;
        private System.Windows.Forms.Button button_DISCONNECT;
        private System.Windows.Forms.Button button_CONNECT;
    }
}

