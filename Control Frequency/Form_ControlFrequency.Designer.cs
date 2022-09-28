namespace Control_Frequency
{
    partial class Form_ControlFrequency
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_RESTARTESP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_COMPORTONOFFSTATUS = new System.Windows.Forms.Label();
            this.label_COMPORTSTATUS = new System.Windows.Forms.Label();
            this.label_SELECTcOMPORT = new System.Windows.Forms.Label();
            this.comboBox_COMPORT = new System.Windows.Forms.ComboBox();
            this.button_DISCONNECT = new System.Windows.Forms.Button();
            this.button_CONNECT = new System.Windows.Forms.Button();
            this.groupBox_ControlCurrent = new System.Windows.Forms.GroupBox();
            this.button_SetCurrent = new System.Windows.Forms.Button();
            this.comboBox_SELECTCURRENT = new System.Windows.Forms.ComboBox();
            this.groupBox_SELECT_MODE = new System.Windows.Forms.GroupBox();
            this.groupBox_SweepFrequencyPerDecade = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_StopPerdecade = new System.Windows.Forms.TextBox();
            this.button_SweepPerdecade = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_StartPerdecade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.checkBox_SweepPerDecade = new System.Windows.Forms.CheckBox();
            this.groupBox_Single_Frequency = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SINGLEFREQUENCY = new System.Windows.Forms.Button();
            this.textBox_SingleFrequency = new System.Windows.Forms.TextBox();
            this.label_SingleFreq = new System.Windows.Forms.Label();
            this.checkBox_Sweep_Frequency = new System.Windows.Forms.CheckBox();
            this.checkBox_Single_Frequency = new System.Windows.Forms.CheckBox();
            this.groupBox_ControlFrequency = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel_ControlFrequency = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox_ControlCurrent.SuspendLayout();
            this.groupBox_SELECT_MODE.SuspendLayout();
            this.groupBox_SweepFrequencyPerDecade.SuspendLayout();
            this.groupBox_Sweep_Frequency.SuspendLayout();
            this.groupBox_Single_Frequency.SuspendLayout();
            this.groupBox_ControlFrequency.SuspendLayout();
            this.panel_ControlFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_RESTARTESP);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label_COMPORTONOFFSTATUS);
            this.panel1.Controls.Add(this.label_COMPORTSTATUS);
            this.panel1.Controls.Add(this.label_SELECTcOMPORT);
            this.panel1.Controls.Add(this.comboBox_COMPORT);
            this.panel1.Controls.Add(this.button_DISCONNECT);
            this.panel1.Controls.Add(this.button_CONNECT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 576);
            this.panel1.TabIndex = 0;
            // 
            // button_RESTARTESP
            // 
            this.button_RESTARTESP.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_RESTARTESP.FlatAppearance.BorderSize = 0;
            this.button_RESTARTESP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_RESTARTESP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RESTARTESP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RESTARTESP.ForeColor = System.Drawing.Color.White;
            this.button_RESTARTESP.Location = new System.Drawing.Point(9, 334);
            this.button_RESTARTESP.Name = "button_RESTARTESP";
            this.button_RESTARTESP.Size = new System.Drawing.Size(183, 40);
            this.button_RESTARTESP.TabIndex = 11;
            this.button_RESTARTESP.Text = "RESTART ESP32";
            this.button_RESTARTESP.UseVisualStyleBackColor = false;
            this.button_RESTARTESP.Click += new System.EventHandler(this.button_RESTARTESP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label_COMPORTONOFFSTATUS
            // 
            this.label_COMPORTONOFFSTATUS.AutoSize = true;
            this.label_COMPORTONOFFSTATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label_COMPORTONOFFSTATUS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COMPORTONOFFSTATUS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_COMPORTONOFFSTATUS.Location = new System.Drawing.Point(71, 480);
            this.label_COMPORTONOFFSTATUS.Name = "label_COMPORTONOFFSTATUS";
            this.label_COMPORTONOFFSTATUS.Size = new System.Drawing.Size(64, 33);
            this.label_COMPORTONOFFSTATUS.TabIndex = 10;
            this.label_COMPORTONOFFSTATUS.Text = "OFF";
            // 
            // label_COMPORTSTATUS
            // 
            this.label_COMPORTSTATUS.AutoSize = true;
            this.label_COMPORTSTATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label_COMPORTSTATUS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COMPORTSTATUS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_COMPORTSTATUS.Location = new System.Drawing.Point(43, 451);
            this.label_COMPORTSTATUS.Name = "label_COMPORTSTATUS";
            this.label_COMPORTSTATUS.Size = new System.Drawing.Size(116, 17);
            this.label_COMPORTSTATUS.TabIndex = 9;
            this.label_COMPORTSTATUS.Text = "COMPORT STATUS";
            // 
            // label_SELECTcOMPORT
            // 
            this.label_SELECTcOMPORT.AutoSize = true;
            this.label_SELECTcOMPORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label_SELECTcOMPORT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SELECTcOMPORT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_SELECTcOMPORT.Location = new System.Drawing.Point(12, 152);
            this.label_SELECTcOMPORT.Name = "label_SELECTcOMPORT";
            this.label_SELECTcOMPORT.Size = new System.Drawing.Size(123, 17);
            this.label_SELECTcOMPORT.TabIndex = 4;
            this.label_SELECTcOMPORT.Text = "SELECT COMPORT:";
            // 
            // comboBox_COMPORT
            // 
            this.comboBox_COMPORT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_COMPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_COMPORT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_COMPORT.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_COMPORT.FormattingEnabled = true;
            this.comboBox_COMPORT.Location = new System.Drawing.Point(9, 184);
            this.comboBox_COMPORT.Name = "comboBox_COMPORT";
            this.comboBox_COMPORT.Size = new System.Drawing.Size(180, 25);
            this.comboBox_COMPORT.TabIndex = 5;
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
            this.button_DISCONNECT.Location = new System.Drawing.Point(9, 282);
            this.button_DISCONNECT.Name = "button_DISCONNECT";
            this.button_DISCONNECT.Size = new System.Drawing.Size(183, 40);
            this.button_DISCONNECT.TabIndex = 8;
            this.button_DISCONNECT.Text = "DISCONNECT";
            this.button_DISCONNECT.UseVisualStyleBackColor = false;
            this.button_DISCONNECT.Click += new System.EventHandler(this.button_DISCONNECT_Click);
            // 
            // button_CONNECT
            // 
            this.button_CONNECT.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_CONNECT.FlatAppearance.BorderSize = 0;
            this.button_CONNECT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_CONNECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CONNECT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CONNECT.ForeColor = System.Drawing.Color.White;
            this.button_CONNECT.Location = new System.Drawing.Point(9, 227);
            this.button_CONNECT.Name = "button_CONNECT";
            this.button_CONNECT.Size = new System.Drawing.Size(183, 40);
            this.button_CONNECT.TabIndex = 6;
            this.button_CONNECT.Text = "CONNECT ";
            this.button_CONNECT.UseVisualStyleBackColor = false;
            this.button_CONNECT.Click += new System.EventHandler(this.button_CONNECT_Click);
            // 
            // groupBox_ControlCurrent
            // 
            this.groupBox_ControlCurrent.Controls.Add(this.button_SetCurrent);
            this.groupBox_ControlCurrent.Controls.Add(this.comboBox_SELECTCURRENT);
            this.groupBox_ControlCurrent.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_ControlCurrent.ForeColor = System.Drawing.Color.White;
            this.groupBox_ControlCurrent.Location = new System.Drawing.Point(370, 0);
            this.groupBox_ControlCurrent.Name = "groupBox_ControlCurrent";
            this.groupBox_ControlCurrent.Size = new System.Drawing.Size(200, 576);
            this.groupBox_ControlCurrent.TabIndex = 3;
            this.groupBox_ControlCurrent.TabStop = false;
            this.groupBox_ControlCurrent.Text = "Control Current";
            // 
            // button_SetCurrent
            // 
            this.button_SetCurrent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SetCurrent.FlatAppearance.BorderSize = 0;
            this.button_SetCurrent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SetCurrent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SetCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SetCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SetCurrent.Location = new System.Drawing.Point(6, 74);
            this.button_SetCurrent.Name = "button_SetCurrent";
            this.button_SetCurrent.Size = new System.Drawing.Size(188, 33);
            this.button_SetCurrent.TabIndex = 5;
            this.button_SetCurrent.Text = "SEND DATA";
            this.button_SetCurrent.UseVisualStyleBackColor = false;
            this.button_SetCurrent.Click += new System.EventHandler(this.button_SetCurrent_Click);
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
            this.comboBox_SELECTCURRENT.Location = new System.Drawing.Point(6, 27);
            this.comboBox_SELECTCURRENT.Name = "comboBox_SELECTCURRENT";
            this.comboBox_SELECTCURRENT.Size = new System.Drawing.Size(188, 25);
            this.comboBox_SELECTCURRENT.TabIndex = 4;
            this.comboBox_SELECTCURRENT.Text = "1 mA";
            // 
            // groupBox_SELECT_MODE
            // 
            this.groupBox_SELECT_MODE.AutoSize = true;
            this.groupBox_SELECT_MODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox_SELECT_MODE.Controls.Add(this.groupBox_SweepFrequencyPerDecade);
            this.groupBox_SELECT_MODE.Controls.Add(this.groupBox_Sweep_Frequency);
            this.groupBox_SELECT_MODE.Controls.Add(this.checkBox_SweepPerDecade);
            this.groupBox_SELECT_MODE.Controls.Add(this.groupBox_Single_Frequency);
            this.groupBox_SELECT_MODE.Controls.Add(this.checkBox_Sweep_Frequency);
            this.groupBox_SELECT_MODE.Controls.Add(this.checkBox_Single_Frequency);
            this.groupBox_SELECT_MODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SELECT_MODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_SELECT_MODE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SELECT_MODE.ForeColor = System.Drawing.Color.White;
            this.groupBox_SELECT_MODE.Location = new System.Drawing.Point(3, 16);
            this.groupBox_SELECT_MODE.Name = "groupBox_SELECT_MODE";
            this.groupBox_SELECT_MODE.Size = new System.Drawing.Size(364, 557);
            this.groupBox_SELECT_MODE.TabIndex = 3;
            this.groupBox_SELECT_MODE.TabStop = false;
            this.groupBox_SELECT_MODE.Text = "SELECT MODE";
            // 
            // groupBox_SweepFrequencyPerDecade
            // 
            this.groupBox_SweepFrequencyPerDecade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.label5);
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.textBox_StopPerdecade);
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.button_SweepPerdecade);
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.label7);
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.label8);
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.textBox_StartPerdecade);
            this.groupBox_SweepFrequencyPerDecade.Controls.Add(this.label10);
            this.groupBox_SweepFrequencyPerDecade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_SweepFrequencyPerDecade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SweepFrequencyPerDecade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_SweepFrequencyPerDecade.Location = new System.Drawing.Point(6, 205);
            this.groupBox_SweepFrequencyPerDecade.Name = "groupBox_SweepFrequencyPerDecade";
            this.groupBox_SweepFrequencyPerDecade.Size = new System.Drawing.Size(346, 152);
            this.groupBox_SweepFrequencyPerDecade.TabIndex = 6;
            this.groupBox_SweepFrequencyPerDecade.TabStop = false;
            this.groupBox_SweepFrequencyPerDecade.Text = "Sweep Frequency Log Scale";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(292, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hz";
            // 
            // textBox_StopPerdecade
            // 
            this.textBox_StopPerdecade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_StopPerdecade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_StopPerdecade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_StopPerdecade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StopPerdecade.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_StopPerdecade.Location = new System.Drawing.Point(178, 74);
            this.textBox_StopPerdecade.Name = "textBox_StopPerdecade";
            this.textBox_StopPerdecade.Size = new System.Drawing.Size(124, 19);
            this.textBox_StopPerdecade.TabIndex = 12;
            this.textBox_StopPerdecade.Text = "e.g.: 10000000";
            this.textBox_StopPerdecade.Enter += new System.EventHandler(this.textBox_StopPerdecade_Enter);
            this.textBox_StopPerdecade.Leave += new System.EventHandler(this.textBox_StopPerdecade_Leave);
            // 
            // button_SweepPerdecade
            // 
            this.button_SweepPerdecade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SweepPerdecade.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SweepPerdecade.FlatAppearance.BorderSize = 0;
            this.button_SweepPerdecade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SweepPerdecade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SweepPerdecade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SweepPerdecade.Location = new System.Drawing.Point(196, 113);
            this.button_SweepPerdecade.Name = "button_SweepPerdecade";
            this.button_SweepPerdecade.Size = new System.Drawing.Size(119, 33);
            this.button_SweepPerdecade.TabIndex = 11;
            this.button_SweepPerdecade.Text = "SEND DATA";
            this.button_SweepPerdecade.UseVisualStyleBackColor = false;
            this.button_SweepPerdecade.Click += new System.EventHandler(this.button_SweepPerdecade_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(292, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stop Frequency:";
            // 
            // textBox_StartPerdecade
            // 
            this.textBox_StartPerdecade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_StartPerdecade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_StartPerdecade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_StartPerdecade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StartPerdecade.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_StartPerdecade.Location = new System.Drawing.Point(178, 27);
            this.textBox_StartPerdecade.Name = "textBox_StartPerdecade";
            this.textBox_StartPerdecade.Size = new System.Drawing.Size(124, 19);
            this.textBox_StartPerdecade.TabIndex = 3;
            this.textBox_StartPerdecade.Text = "e.g.: 10000000";
            this.textBox_StartPerdecade.Enter += new System.EventHandler(this.textBox_StartPerdecade_Enter);
            this.textBox_StartPerdecade.Leave += new System.EventHandler(this.textBox_StartPerdecade_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Start Frequency:";
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
            this.groupBox_Sweep_Frequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Sweep_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Sweep_Frequency.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_Sweep_Frequency.Location = new System.Drawing.Point(6, 359);
            this.groupBox_Sweep_Frequency.Name = "groupBox_Sweep_Frequency";
            this.groupBox_Sweep_Frequency.Size = new System.Drawing.Size(346, 192);
            this.groupBox_Sweep_Frequency.TabIndex = 5;
            this.groupBox_Sweep_Frequency.TabStop = false;
            this.groupBox_Sweep_Frequency.Text = "Sweep Frequency";
            // 
            // button_SWEEPFREQUENCY
            // 
            this.button_SWEEPFREQUENCY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SWEEPFREQUENCY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SWEEPFREQUENCY.FlatAppearance.BorderSize = 0;
            this.button_SWEEPFREQUENCY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SWEEPFREQUENCY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SWEEPFREQUENCY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SWEEPFREQUENCY.Location = new System.Drawing.Point(196, 153);
            this.button_SWEEPFREQUENCY.Name = "button_SWEEPFREQUENCY";
            this.button_SWEEPFREQUENCY.Size = new System.Drawing.Size(119, 33);
            this.button_SWEEPFREQUENCY.TabIndex = 11;
            this.button_SWEEPFREQUENCY.Text = "SEND DATA";
            this.button_SWEEPFREQUENCY.UseVisualStyleBackColor = false;
            this.button_SWEEPFREQUENCY.Click += new System.EventHandler(this.button_SWEEPFREQUENCY_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(292, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hz";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(292, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hz";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(292, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hz";
            // 
            // textBox_STOPFREQUENCY
            // 
            this.textBox_STOPFREQUENCY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_STOPFREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_STOPFREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_STOPFREQUENCY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_STOPFREQUENCY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_STOPFREQUENCY.Location = new System.Drawing.Point(178, 120);
            this.textBox_STOPFREQUENCY.Name = "textBox_STOPFREQUENCY";
            this.textBox_STOPFREQUENCY.Size = new System.Drawing.Size(124, 19);
            this.textBox_STOPFREQUENCY.TabIndex = 8;
            this.textBox_STOPFREQUENCY.Text = "e.g.: 10000000";
            this.textBox_STOPFREQUENCY.Enter += new System.EventHandler(this.textBox_STOPFREQUENCY_Enter);
            this.textBox_STOPFREQUENCY.Leave += new System.EventHandler(this.textBox_STOPFREQUENCY_Leave);
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
            this.textBox_STEPFREQUENCY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_STEPFREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_STEPFREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_STEPFREQUENCY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_STEPFREQUENCY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_STEPFREQUENCY.Location = new System.Drawing.Point(178, 77);
            this.textBox_STEPFREQUENCY.Name = "textBox_STEPFREQUENCY";
            this.textBox_STEPFREQUENCY.Size = new System.Drawing.Size(124, 19);
            this.textBox_STEPFREQUENCY.TabIndex = 6;
            this.textBox_STEPFREQUENCY.Text = "e.g.: 10000000";
            this.textBox_STEPFREQUENCY.Enter += new System.EventHandler(this.textBox_STEPFREQUENCY_Enter);
            this.textBox_STEPFREQUENCY.Leave += new System.EventHandler(this.textBox_STEPFREQUENCY_Leave);
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
            this.textBox_START_FREQUENCY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_START_FREQUENCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_START_FREQUENCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_START_FREQUENCY.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_START_FREQUENCY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_START_FREQUENCY.Location = new System.Drawing.Point(178, 27);
            this.textBox_START_FREQUENCY.Name = "textBox_START_FREQUENCY";
            this.textBox_START_FREQUENCY.Size = new System.Drawing.Size(124, 19);
            this.textBox_START_FREQUENCY.TabIndex = 3;
            this.textBox_START_FREQUENCY.Text = "e.g.: 10000000";
            this.textBox_START_FREQUENCY.Enter += new System.EventHandler(this.textBox_START_FREQUENCY_Enter);
            this.textBox_START_FREQUENCY.Leave += new System.EventHandler(this.textBox_START_FREQUENCY_Leave);
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
            // checkBox_SweepPerDecade
            // 
            this.checkBox_SweepPerDecade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_SweepPerDecade.AutoSize = true;
            this.checkBox_SweepPerDecade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SweepPerDecade.Location = new System.Drawing.Point(20, 58);
            this.checkBox_SweepPerDecade.Name = "checkBox_SweepPerDecade";
            this.checkBox_SweepPerDecade.Size = new System.Drawing.Size(205, 21);
            this.checkBox_SweepPerDecade.TabIndex = 2;
            this.checkBox_SweepPerDecade.Text = "Sweep Frequency Log Scale";
            this.checkBox_SweepPerDecade.UseVisualStyleBackColor = true;
            this.checkBox_SweepPerDecade.CheckedChanged += new System.EventHandler(this.checkBox_SweepPerDecade_CheckedChanged);
            // 
            // groupBox_Single_Frequency
            // 
            this.groupBox_Single_Frequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Single_Frequency.Controls.Add(this.label1);
            this.groupBox_Single_Frequency.Controls.Add(this.button_SINGLEFREQUENCY);
            this.groupBox_Single_Frequency.Controls.Add(this.textBox_SingleFrequency);
            this.groupBox_Single_Frequency.Controls.Add(this.label_SingleFreq);
            this.groupBox_Single_Frequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Single_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Single_Frequency.ForeColor = System.Drawing.Color.White;
            this.groupBox_Single_Frequency.Location = new System.Drawing.Point(6, 89);
            this.groupBox_Single_Frequency.Name = "groupBox_Single_Frequency";
            this.groupBox_Single_Frequency.Size = new System.Drawing.Size(346, 110);
            this.groupBox_Single_Frequency.TabIndex = 4;
            this.groupBox_Single_Frequency.TabStop = false;
            this.groupBox_Single_Frequency.Text = "Single Frequency";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hz";
            // 
            // button_SINGLEFREQUENCY
            // 
            this.button_SINGLEFREQUENCY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SINGLEFREQUENCY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SINGLEFREQUENCY.FlatAppearance.BorderSize = 0;
            this.button_SINGLEFREQUENCY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_SINGLEFREQUENCY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button_SINGLEFREQUENCY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SINGLEFREQUENCY.Location = new System.Drawing.Point(196, 71);
            this.button_SINGLEFREQUENCY.Name = "button_SINGLEFREQUENCY";
            this.button_SINGLEFREQUENCY.Size = new System.Drawing.Size(119, 33);
            this.button_SINGLEFREQUENCY.TabIndex = 2;
            this.button_SINGLEFREQUENCY.Text = "SEND DATA";
            this.button_SINGLEFREQUENCY.UseVisualStyleBackColor = false;
            this.button_SINGLEFREQUENCY.Click += new System.EventHandler(this.button_SINGLEFREQUENCY_Click);
            // 
            // textBox_SingleFrequency
            // 
            this.textBox_SingleFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SingleFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_SingleFrequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SingleFrequency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SingleFrequency.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_SingleFrequency.Location = new System.Drawing.Point(178, 32);
            this.textBox_SingleFrequency.Name = "textBox_SingleFrequency";
            this.textBox_SingleFrequency.Size = new System.Drawing.Size(137, 19);
            this.textBox_SingleFrequency.TabIndex = 1;
            this.textBox_SingleFrequency.Text = "e.g.: 10000000";
            this.textBox_SingleFrequency.Enter += new System.EventHandler(this.textBox_SingleFrequency_Enter);
            this.textBox_SingleFrequency.Leave += new System.EventHandler(this.textBox_SingleFrequency_Leave);
            // 
            // label_SingleFreq
            // 
            this.label_SingleFreq.AutoSize = true;
            this.label_SingleFreq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SingleFreq.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_SingleFreq.Location = new System.Drawing.Point(29, 34);
            this.label_SingleFreq.Name = "label_SingleFreq";
            this.label_SingleFreq.Size = new System.Drawing.Size(91, 20);
            this.label_SingleFreq.TabIndex = 0;
            this.label_SingleFreq.Text = "Frequency:";
            // 
            // checkBox_Sweep_Frequency
            // 
            this.checkBox_Sweep_Frequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Sweep_Frequency.AutoSize = true;
            this.checkBox_Sweep_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Sweep_Frequency.Location = new System.Drawing.Point(185, 21);
            this.checkBox_Sweep_Frequency.Name = "checkBox_Sweep_Frequency";
            this.checkBox_Sweep_Frequency.Size = new System.Drawing.Size(139, 21);
            this.checkBox_Sweep_Frequency.TabIndex = 1;
            this.checkBox_Sweep_Frequency.Text = "Sweep Frequency";
            this.checkBox_Sweep_Frequency.UseVisualStyleBackColor = true;
            this.checkBox_Sweep_Frequency.CheckedChanged += new System.EventHandler(this.checkBox_Sweep_Frequency_CheckedChanged);
            // 
            // checkBox_Single_Frequency
            // 
            this.checkBox_Single_Frequency.AutoSize = true;
            this.checkBox_Single_Frequency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Single_Frequency.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox_Single_Frequency.Location = new System.Drawing.Point(20, 21);
            this.checkBox_Single_Frequency.Name = "checkBox_Single_Frequency";
            this.checkBox_Single_Frequency.Size = new System.Drawing.Size(133, 21);
            this.checkBox_Single_Frequency.TabIndex = 0;
            this.checkBox_Single_Frequency.Text = "Single Frequency";
            this.checkBox_Single_Frequency.UseVisualStyleBackColor = true;
            this.checkBox_Single_Frequency.CheckedChanged += new System.EventHandler(this.checkBox_Single_Frequency_CheckedChanged);
            // 
            // groupBox_ControlFrequency
            // 
            this.groupBox_ControlFrequency.Controls.Add(this.groupBox_SELECT_MODE);
            this.groupBox_ControlFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ControlFrequency.ForeColor = System.Drawing.Color.White;
            this.groupBox_ControlFrequency.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ControlFrequency.Name = "groupBox_ControlFrequency";
            this.groupBox_ControlFrequency.Size = new System.Drawing.Size(370, 576);
            this.groupBox_ControlFrequency.TabIndex = 2;
            this.groupBox_ControlFrequency.TabStop = false;
            this.groupBox_ControlFrequency.Text = "Control Frequency";
            // 
            // panel_ControlFrequency
            // 
            this.panel_ControlFrequency.Controls.Add(this.groupBox_ControlFrequency);
            this.panel_ControlFrequency.Controls.Add(this.groupBox_ControlCurrent);
            this.panel_ControlFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ControlFrequency.Location = new System.Drawing.Point(200, 0);
            this.panel_ControlFrequency.Name = "panel_ControlFrequency";
            this.panel_ControlFrequency.Size = new System.Drawing.Size(570, 576);
            this.panel_ControlFrequency.TabIndex = 2;
            // 
            // Form_ControlFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(770, 576);
            this.Controls.Add(this.panel_ControlFrequency);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ControlFrequency";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_ControlFrequency_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_ControlCurrent.ResumeLayout(false);
            this.groupBox_SELECT_MODE.ResumeLayout(false);
            this.groupBox_SELECT_MODE.PerformLayout();
            this.groupBox_SweepFrequencyPerDecade.ResumeLayout(false);
            this.groupBox_SweepFrequencyPerDecade.PerformLayout();
            this.groupBox_Sweep_Frequency.ResumeLayout(false);
            this.groupBox_Sweep_Frequency.PerformLayout();
            this.groupBox_Single_Frequency.ResumeLayout(false);
            this.groupBox_Single_Frequency.PerformLayout();
            this.groupBox_ControlFrequency.ResumeLayout(false);
            this.groupBox_ControlFrequency.PerformLayout();
            this.panel_ControlFrequency.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_ControlCurrent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_COMPORTONOFFSTATUS;
        private System.Windows.Forms.Label label_COMPORTSTATUS;
        private System.Windows.Forms.Label label_SELECTcOMPORT;
        private System.Windows.Forms.ComboBox comboBox_COMPORT;
        private System.Windows.Forms.Button button_DISCONNECT;
        private System.Windows.Forms.Button button_CONNECT;
        private System.Windows.Forms.Button button_SetCurrent;
        private System.Windows.Forms.ComboBox comboBox_SELECTCURRENT;
        private System.Windows.Forms.GroupBox groupBox_SELECT_MODE;
        private System.Windows.Forms.CheckBox checkBox_Sweep_Frequency;
        private System.Windows.Forms.CheckBox checkBox_Single_Frequency;
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
        private System.Windows.Forms.GroupBox groupBox_Single_Frequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SINGLEFREQUENCY;
        private System.Windows.Forms.TextBox textBox_SingleFrequency;
        private System.Windows.Forms.Label label_SingleFreq;
        private System.Windows.Forms.GroupBox groupBox_SweepFrequencyPerDecade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_StopPerdecade;
        private System.Windows.Forms.Button button_SweepPerdecade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_StartPerdecade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_ControlFrequency;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel_ControlFrequency;
        private System.Windows.Forms.CheckBox checkBox_SweepPerDecade;
        private System.Windows.Forms.Button button_RESTARTESP;
    }
}