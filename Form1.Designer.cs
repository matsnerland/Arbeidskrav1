namespace Arbeidskrav1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.BitRate = new System.Windows.Forms.ComboBox();
            this.ComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.WriteConfig = new System.Windows.Forms.Button();
            this.LowLevelText = new System.Windows.Forms.TextBox();
            this.AlarmHighText = new System.Windows.Forms.TextBox();
            this.UpperLevelText = new System.Windows.Forms.TextBox();
            this.AlarmLowText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAlarmHigh = new System.Windows.Forms.Label();
            this.labelLowLevel = new System.Windows.Forms.Label();
            this.labelAlarmLow = new System.Windows.Forms.Label();
            this.labelUpperLevel = new System.Windows.Forms.Label();
            this.SaveConfig = new System.Windows.Forms.Button();
            this.ReadConfig = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ScaledValues = new System.Windows.Forms.Button();
            this.RawValues = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManualRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Commando = new System.Windows.Forms.TextBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Monitoring = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.Disconnect);
            this.tabPage1.Controls.Add(this.Connect);
            this.tabPage1.Controls.Add(this.BitRate);
            this.tabPage1.Controls.Add(this.ComPort);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(325, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 24);
            this.label20.TabIndex = 7;
            this.label20.Text = "SoftSensConf";
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(339, 234);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(119, 23);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(337, 189);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(121, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click_1);
            // 
            // BitRate
            // 
            this.BitRate.FormattingEnabled = true;
            this.BitRate.Location = new System.Drawing.Point(337, 148);
            this.BitRate.Name = "BitRate";
            this.BitRate.Size = new System.Drawing.Size(121, 21);
            this.BitRate.TabIndex = 4;
            // 
            // ComPort
            // 
            this.ComPort.FormattingEnabled = true;
            this.ComPort.Location = new System.Drawing.Point(339, 104);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(121, 21);
            this.ComPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Bit Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose COM Port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.SaveConfig);
            this.tabPage2.Controls.Add(this.ReadConfig);
            this.tabPage2.Controls.Add(this.Load);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NameText);
            this.groupBox2.Controls.Add(this.WriteConfig);
            this.groupBox2.Controls.Add(this.LowLevelText);
            this.groupBox2.Controls.Add(this.AlarmHighText);
            this.groupBox2.Controls.Add(this.UpperLevelText);
            this.groupBox2.Controls.Add(this.AlarmLowText);
            this.groupBox2.Location = new System.Drawing.Point(411, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 288);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Config";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Alarm High:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Alarm Low:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Upper Level:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Low Level:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(83, 37);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 9;
            // 
            // WriteConfig
            // 
            this.WriteConfig.Location = new System.Drawing.Point(51, 239);
            this.WriteConfig.Name = "WriteConfig";
            this.WriteConfig.Size = new System.Drawing.Size(107, 23);
            this.WriteConfig.TabIndex = 7;
            this.WriteConfig.Text = "Write Config";
            this.WriteConfig.UseVisualStyleBackColor = true;
            this.WriteConfig.Click += new System.EventHandler(this.WriteConfig_Click);
            // 
            // LowLevelText
            // 
            this.LowLevelText.Location = new System.Drawing.Point(83, 77);
            this.LowLevelText.Name = "LowLevelText";
            this.LowLevelText.Size = new System.Drawing.Size(100, 20);
            this.LowLevelText.TabIndex = 10;
            // 
            // AlarmHighText
            // 
            this.AlarmHighText.Location = new System.Drawing.Point(83, 190);
            this.AlarmHighText.Name = "AlarmHighText";
            this.AlarmHighText.Size = new System.Drawing.Size(100, 20);
            this.AlarmHighText.TabIndex = 13;
            // 
            // UpperLevelText
            // 
            this.UpperLevelText.Location = new System.Drawing.Point(83, 115);
            this.UpperLevelText.Name = "UpperLevelText";
            this.UpperLevelText.Size = new System.Drawing.Size(100, 20);
            this.UpperLevelText.TabIndex = 11;
            // 
            // AlarmLowText
            // 
            this.AlarmLowText.Location = new System.Drawing.Point(83, 152);
            this.AlarmLowText.Name = "AlarmLowText";
            this.AlarmLowText.Size = new System.Drawing.Size(100, 20);
            this.AlarmLowText.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelAlarmHigh);
            this.groupBox1.Controls.Add(this.labelLowLevel);
            this.groupBox1.Controls.Add(this.labelAlarmLow);
            this.groupBox1.Controls.Add(this.labelUpperLevel);
            this.groupBox1.Location = new System.Drawing.Point(176, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 241);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Config";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Alarm High: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Alarm Low: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Low Level: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Upper Level: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Name: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(110, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 16;
            // 
            // labelAlarmHigh
            // 
            this.labelAlarmHigh.AutoSize = true;
            this.labelAlarmHigh.Location = new System.Drawing.Point(113, 169);
            this.labelAlarmHigh.Name = "labelAlarmHigh";
            this.labelAlarmHigh.Size = new System.Drawing.Size(0, 13);
            this.labelAlarmHigh.TabIndex = 20;
            // 
            // labelLowLevel
            // 
            this.labelLowLevel.AutoSize = true;
            this.labelLowLevel.Location = new System.Drawing.Point(113, 76);
            this.labelLowLevel.Name = "labelLowLevel";
            this.labelLowLevel.Size = new System.Drawing.Size(0, 13);
            this.labelLowLevel.TabIndex = 17;
            // 
            // labelAlarmLow
            // 
            this.labelAlarmLow.AutoSize = true;
            this.labelAlarmLow.Location = new System.Drawing.Point(113, 138);
            this.labelAlarmLow.Name = "labelAlarmLow";
            this.labelAlarmLow.Size = new System.Drawing.Size(0, 13);
            this.labelAlarmLow.TabIndex = 19;
            // 
            // labelUpperLevel
            // 
            this.labelUpperLevel.AutoSize = true;
            this.labelUpperLevel.Location = new System.Drawing.Point(113, 105);
            this.labelUpperLevel.Name = "labelUpperLevel";
            this.labelUpperLevel.Size = new System.Drawing.Size(0, 13);
            this.labelUpperLevel.TabIndex = 18;
            // 
            // SaveConfig
            // 
            this.SaveConfig.Location = new System.Drawing.Point(54, 182);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(107, 23);
            this.SaveConfig.TabIndex = 6;
            this.SaveConfig.Text = "Save Config";
            this.SaveConfig.UseVisualStyleBackColor = true;
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // ReadConfig
            // 
            this.ReadConfig.Location = new System.Drawing.Point(54, 140);
            this.ReadConfig.Name = "ReadConfig";
            this.ReadConfig.Size = new System.Drawing.Size(107, 23);
            this.ReadConfig.TabIndex = 5;
            this.ReadConfig.Text = "Read Config";
            this.ReadConfig.UseVisualStyleBackColor = true;
            this.ReadConfig.Click += new System.EventHandler(this.ReadConfig_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(462, 335);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(107, 23);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load From File";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Monitoring);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.ScaledValues);
            this.tabPage3.Controls.Add(this.RawValues);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ManualRead);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.Send);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.Commando);
            this.tabPage3.Controls.Add(this.Chart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensor Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StatusLabel);
            this.groupBox3.Location = new System.Drawing.Point(29, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 100);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ALARM STATUS";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(10, 48);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(34, 13);
            this.StatusLabel.TabIndex = 26;
            this.StatusLabel.Text = "---------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 25;
            // 
            // ScaledValues
            // 
            this.ScaledValues.Location = new System.Drawing.Point(262, 173);
            this.ScaledValues.Name = "ScaledValues";
            this.ScaledValues.Size = new System.Drawing.Size(75, 23);
            this.ScaledValues.TabIndex = 22;
            this.ScaledValues.Text = "Scaled Values";
            this.ScaledValues.UseVisualStyleBackColor = true;
            this.ScaledValues.Click += new System.EventHandler(this.ScaledValues_Click);
            // 
            // RawValues
            // 
            this.RawValues.Location = new System.Drawing.Point(157, 173);
            this.RawValues.Name = "RawValues";
            this.RawValues.Size = new System.Drawing.Size(75, 23);
            this.RawValues.TabIndex = 21;
            this.RawValues.Text = "Raw Values";
            this.RawValues.UseVisualStyleBackColor = true;
            this.RawValues.Click += new System.EventHandler(this.RawValues_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Light Sensitivity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time";
            // 
            // ManualRead
            // 
            this.ManualRead.Location = new System.Drawing.Point(206, 202);
            this.ManualRead.Name = "ManualRead";
            this.ManualRead.Size = new System.Drawing.Size(84, 23);
            this.ManualRead.TabIndex = 18;
            this.ManualRead.Text = "Stop Reading";
            this.ManualRead.UseVisualStyleBackColor = true;
            this.ManualRead.Click += new System.EventHandler(this.ManualRead_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 10);
            this.textBox1.TabIndex = 16;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(42, 113);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 15;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Write  Commando:";
            // 
            // Commando
            // 
            this.Commando.Location = new System.Drawing.Point(29, 87);
            this.Commando.Name = "Commando";
            this.Commando.Size = new System.Drawing.Size(100, 20);
            this.Commando.TabIndex = 13;
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(381, 43);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Vba";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(403, 300);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "V ab";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Disconnected";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Monitoring
            // 
            this.Monitoring.Location = new System.Drawing.Point(157, 87);
            this.Monitoring.Multiline = true;
            this.Monitoring.Name = "Monitoring";
            this.Monitoring.Size = new System.Drawing.Size(181, 80);
            this.Monitoring.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SoftSensConf";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox BitRate;
        private System.Windows.Forms.ComboBox ComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ManualRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Commando;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ScaledValues;
        private System.Windows.Forms.Button RawValues;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button WriteConfig;
        private System.Windows.Forms.Button SaveConfig;
        private System.Windows.Forms.Button ReadConfig;
        private System.Windows.Forms.TextBox AlarmHighText;
        private System.Windows.Forms.TextBox AlarmLowText;
        private System.Windows.Forms.TextBox UpperLevelText;
        private System.Windows.Forms.TextBox LowLevelText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label labelAlarmHigh;
        private System.Windows.Forms.Label labelAlarmLow;
        private System.Windows.Forms.Label labelUpperLevel;
        private System.Windows.Forms.Label labelLowLevel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.TextBox Monitoring;
    }
}

