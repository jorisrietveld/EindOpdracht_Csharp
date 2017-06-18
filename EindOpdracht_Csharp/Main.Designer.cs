namespace EindOpdracht_Csharp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabCurrent = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConditionText = new System.Windows.Forms.Label();
            this.labelConditionLocation = new System.Windows.Forms.Label();
            this.labelConditionTemperature = new System.Windows.Forms.Label();
            this.labelConditionHumididy = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxConditionImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTrend = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonCelcius = new System.Windows.Forms.RadioButton();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.intervalSettingTextBox = new System.Windows.Forms.TextBox();
            this.locationSettingTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuRefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuOptionsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabCurrent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConditionImage)).BeginInit();
            this.tabTrend.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxRadioButtons.SuspendLayout();
            this.trayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabCurrent);
            this.tabMenu.Controls.Add(this.tabTrend);
            this.tabMenu.Controls.Add(this.tabOptions);
            this.tabMenu.Location = new System.Drawing.Point(0, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(435, 333);
            this.tabMenu.TabIndex = 0;
            // 
            // tabCurrent
            // 
            this.tabCurrent.Controls.Add(this.groupBox1);
            this.tabCurrent.Controls.Add(this.label1);
            this.tabCurrent.Location = new System.Drawing.Point(4, 22);
            this.tabCurrent.Name = "tabCurrent";
            this.tabCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrent.Size = new System.Drawing.Size(427, 307);
            this.tabCurrent.TabIndex = 0;
            this.tabCurrent.Text = "Actueel";
            this.tabCurrent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConditionText);
            this.groupBox1.Controls.Add(this.labelConditionLocation);
            this.groupBox1.Controls.Add(this.labelConditionTemperature);
            this.groupBox1.Controls.Add(this.labelConditionHumididy);
            this.groupBox1.Controls.Add(this.labelWind);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBoxConditionImage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelConditionText
            // 
            this.labelConditionText.AutoSize = true;
            this.labelConditionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionText.Location = new System.Drawing.Point(79, 42);
            this.labelConditionText.Name = "labelConditionText";
            this.labelConditionText.Size = new System.Drawing.Size(58, 20);
            this.labelConditionText.TabIndex = 9;
            this.labelConditionText.Text = "Zonnig";
            // 
            // labelConditionLocation
            // 
            this.labelConditionLocation.AutoSize = true;
            this.labelConditionLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionLocation.Location = new System.Drawing.Point(79, 16);
            this.labelConditionLocation.Name = "labelConditionLocation";
            this.labelConditionLocation.Size = new System.Drawing.Size(156, 24);
            this.labelConditionLocation.TabIndex = 8;
            this.labelConditionLocation.Text = "Emmen, Drente";
            // 
            // labelConditionTemperature
            // 
            this.labelConditionTemperature.AutoSize = true;
            this.labelConditionTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionTemperature.Location = new System.Drawing.Point(113, 81);
            this.labelConditionTemperature.Name = "labelConditionTemperature";
            this.labelConditionTemperature.Size = new System.Drawing.Size(42, 20);
            this.labelConditionTemperature.TabIndex = 7;
            this.labelConditionTemperature.Text = "25 C";
            // 
            // labelConditionHumididy
            // 
            this.labelConditionHumididy.AutoSize = true;
            this.labelConditionHumididy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionHumididy.Location = new System.Drawing.Point(142, 115);
            this.labelConditionHumididy.Name = "labelConditionHumididy";
            this.labelConditionHumididy.Size = new System.Drawing.Size(41, 20);
            this.labelConditionHumididy.TabIndex = 6;
            this.labelConditionHumididy.Text = "60%";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWind.Location = new System.Drawing.Point(58, 150);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(123, 20);
            this.labelWind.TabIndex = 5;
            this.labelWind.Text = "NO met 18 km/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Wind:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Luchtvochtigheid:";
            // 
            // pictureBoxConditionImage
            // 
            this.pictureBoxConditionImage.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxConditionImage.Name = "pictureBoxConditionImage";
            this.pictureBoxConditionImage.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxConditionImage.TabIndex = 1;
            this.pictureBoxConditionImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Temperatuur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stenden Weerstation";
            // 
            // tabTrend
            // 
            this.tabTrend.Controls.Add(this.chart1);
            this.tabTrend.Controls.Add(this.label2);
            this.tabTrend.Location = new System.Drawing.Point(4, 22);
            this.tabTrend.Name = "tabTrend";
            this.tabTrend.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrend.Size = new System.Drawing.Size(427, 307);
            this.tabTrend.TabIndex = 1;
            this.tabTrend.Text = "Trend";
            this.tabTrend.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stenden Weerstation";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupBox2);
            this.tabOptions.Controls.Add(this.label3);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(427, 307);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Opties";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBoxRadioButtons);
            this.groupBox2.Controls.Add(this.buttonSaveSettings);
            this.groupBox2.Controls.Add(this.intervalSettingTextBox);
            this.groupBox2.Controls.Add(this.locationSettingTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(6, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonFahrenheit);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonCelcius);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(104, 85);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(155, 25);
            this.groupBoxRadioButtons.TabIndex = 9;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Checked = global::EindOpdracht_Csharp.Properties.Settings.Default.TemperatureF;
            this.radioButtonFahrenheit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EindOpdracht_Csharp.Properties.Settings.Default, "TemperatureF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(6, 8);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFahrenheit.TabIndex = 6;
            this.radioButtonFahrenheit.Text = "Fahrenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelcius
            // 
            this.radioButtonCelcius.AutoSize = true;
            this.radioButtonCelcius.Checked = global::EindOpdracht_Csharp.Properties.Settings.Default.TemperatureC;
            this.radioButtonCelcius.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EindOpdracht_Csharp.Properties.Settings.Default, "TemperatureC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButtonCelcius.Location = new System.Drawing.Point(87, 8);
            this.radioButtonCelcius.Name = "radioButtonCelcius";
            this.radioButtonCelcius.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCelcius.TabIndex = 7;
            this.radioButtonCelcius.TabStop = true;
            this.radioButtonCelcius.Text = "Celcius";
            this.radioButtonCelcius.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(283, 216);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(119, 35);
            this.buttonSaveSettings.TabIndex = 8;
            this.buttonSaveSettings.Text = "Oke";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // intervalSettingTextBox
            // 
            this.intervalSettingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EindOpdracht_Csharp.Properties.Settings.Default, "RefreshInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.intervalSettingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalSettingTextBox.Location = new System.Drawing.Point(104, 53);
            this.intervalSettingTextBox.Name = "intervalSettingTextBox";
            this.intervalSettingTextBox.Size = new System.Drawing.Size(130, 26);
            this.intervalSettingTextBox.TabIndex = 5;
            this.intervalSettingTextBox.Text = global::EindOpdracht_Csharp.Properties.Settings.Default.RefreshInterval;
            // 
            // locationSettingTextBox
            // 
            this.locationSettingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EindOpdracht_Csharp.Properties.Settings.Default, "UserLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locationSettingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationSettingTextBox.Location = new System.Drawing.Point(104, 16);
            this.locationSettingTextBox.Name = "locationSettingTextBox";
            this.locationSettingTextBox.Size = new System.Drawing.Size(208, 26);
            this.locationSettingTextBox.TabIndex = 4;
            this.locationSettingTextBox.Text = global::EindOpdracht_Csharp.Properties.Settings.Default.UserLocation;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Weergave:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Interval:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Plaats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stenden Weerstation";
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.ContextMenuStrip = this.trayMenu;
            this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
            this.systemTrayIcon.Text = "Stenden Weerstation";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayMenu_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuTitle,
            this.trayMenuAboutButton,
            this.toolStripSeparator2,
            this.trayMenuRefreshButton,
            this.toolStripSeparator3,
            this.trayMenuOptionsButton,
            this.toolStripSeparator1,
            this.trayMenuOpenButton,
            this.trayMenuCloseButton});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(206, 154);
            // 
            // trayMenuTitle
            // 
            this.trayMenuTitle.BackColor = System.Drawing.Color.Navy;
            this.trayMenuTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.trayMenuTitle.Name = "trayMenuTitle";
            this.trayMenuTitle.Size = new System.Drawing.Size(205, 22);
            this.trayMenuTitle.Text = "Huidige temperatuur: 7C";
            this.trayMenuTitle.Click += new System.EventHandler(this.TrayMenuTitle_Click);
            // 
            // trayMenuAboutButton
            // 
            this.trayMenuAboutButton.Name = "trayMenuAboutButton";
            this.trayMenuAboutButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuAboutButton.Text = "Over...";
            this.trayMenuAboutButton.Click += new System.EventHandler(this.TrayMenuAboutButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // trayMenuRefreshButton
            // 
            this.trayMenuRefreshButton.Name = "trayMenuRefreshButton";
            this.trayMenuRefreshButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuRefreshButton.Text = "Verversen...";
            this.trayMenuRefreshButton.Click += new System.EventHandler(this.TrayMenuRefreshButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // trayMenuOptionsButton
            // 
            this.trayMenuOptionsButton.Name = "trayMenuOptionsButton";
            this.trayMenuOptionsButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuOptionsButton.Text = "Opties...";
            this.trayMenuOptionsButton.Click += new System.EventHandler(this.TrayMenuOptionsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // trayMenuOpenButton
            // 
            this.trayMenuOpenButton.Name = "trayMenuOpenButton";
            this.trayMenuOpenButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuOpenButton.Text = "Open...";
            // 
            // trayMenuCloseButton
            // 
            this.trayMenuCloseButton.Name = "trayMenuCloseButton";
            this.trayMenuCloseButton.Size = new System.Drawing.Size(205, 22);
            this.trayMenuCloseButton.Text = "Sluiten";
            this.trayMenuCloseButton.Click += new System.EventHandler(this.TrayMenuCloseButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(8, 43);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(410, 264);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Seconds";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tabMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stenden Weather";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabCurrent.ResumeLayout(false);
            this.tabCurrent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConditionImage)).EndInit();
            this.tabTrend.ResumeLayout(false);
            this.tabTrend.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabCurrent;
        private System.Windows.Forms.TabPage tabTrend;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.NotifyIcon systemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuTitle;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayMenuRefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem trayMenuOptionsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayMenuOpenButton;
        private System.Windows.Forms.ToolStripMenuItem trayMenuCloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxConditionImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConditionText;
        private System.Windows.Forms.Label labelConditionLocation;
        private System.Windows.Forms.Label labelConditionTemperature;
        private System.Windows.Forms.Label labelConditionHumididy;
        private System.Windows.Forms.TextBox intervalSettingTextBox;
        private System.Windows.Forms.TextBox locationSettingTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.RadioButton radioButtonCelcius;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
    }
}