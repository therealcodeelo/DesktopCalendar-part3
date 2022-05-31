
namespace DesktopCalendar
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloGradientPanel3 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloGradientPanel2 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.YearNavigationPanel = new System.Windows.Forms.Panel();
            this.MonthNavigationPanel = new System.Windows.Forms.Panel();
            this.AppointmentInfoPanel = new System.Windows.Forms.Panel();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.YearButton = new System.Windows.Forms.Button();
            this.JanuaryButton = new System.Windows.Forms.Button();
            this.FebruaryButton = new System.Windows.Forms.Button();
            this.MarchButton = new System.Windows.Forms.Button();
            this.AprilButton = new System.Windows.Forms.Button();
            this.MayButton = new System.Windows.Forms.Button();
            this.JuneButton = new System.Windows.Forms.Button();
            this.JuleButton = new System.Windows.Forms.Button();
            this.AugustButton = new System.Windows.Forms.Button();
            this.SeptemberButton = new System.Windows.Forms.Button();
            this.OctoberButton = new System.Windows.Forms.Button();
            this.NovemberButton = new System.Windows.Forms.Button();
            this.DecemberButton = new System.Windows.Forms.Button();
            this.codeeloGradientPanel3.SuspendLayout();
            this.YearNavigationPanel.SuspendLayout();
            this.MonthNavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(1445, 29);
            this.codeeloGradientPanel1.TabIndex = 0;
            // 
            // codeeloGradientPanel3
            // 
            this.codeeloGradientPanel3.AccessibleRole = null;
            this.codeeloGradientPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel3.CausesValidation = false;
            this.codeeloGradientPanel3.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.codeeloGradientPanel3.ColorFillSecond = System.Drawing.Color.Gray;
            this.codeeloGradientPanel3.Controls.Add(this.AppointmentInfoPanel);
            this.codeeloGradientPanel3.Controls.Add(this.MonthNavigationPanel);
            this.codeeloGradientPanel3.Controls.Add(this.YearNavigationPanel);
            this.codeeloGradientPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeeloGradientPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel3.Location = new System.Drawing.Point(1085, 29);
            this.codeeloGradientPanel3.Name = "codeeloGradientPanel3";
            this.codeeloGradientPanel3.Size = new System.Drawing.Size(360, 590);
            this.codeeloGradientPanel3.TabIndex = 2;
            // 
            // codeeloGradientPanel2
            // 
            this.codeeloGradientPanel2.AccessibleRole = null;
            this.codeeloGradientPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel2.CausesValidation = false;
            this.codeeloGradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.codeeloGradientPanel2.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.codeeloGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel2.Location = new System.Drawing.Point(0, 29);
            this.codeeloGradientPanel2.Name = "codeeloGradientPanel2";
            this.codeeloGradientPanel2.Size = new System.Drawing.Size(1085, 590);
            this.codeeloGradientPanel2.TabIndex = 3;
            // 
            // YearNavigationPanel
            // 
            this.YearNavigationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.YearNavigationPanel.Controls.Add(this.YearButton);
            this.YearNavigationPanel.Controls.Add(this.PreviousYearButton);
            this.YearNavigationPanel.Controls.Add(this.NextYearButton);
            this.YearNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.YearNavigationPanel.Name = "YearNavigationPanel";
            this.YearNavigationPanel.Size = new System.Drawing.Size(360, 72);
            this.YearNavigationPanel.TabIndex = 0;
            // 
            // MonthNavigationPanel
            // 
            this.MonthNavigationPanel.Controls.Add(this.DecemberButton);
            this.MonthNavigationPanel.Controls.Add(this.NovemberButton);
            this.MonthNavigationPanel.Controls.Add(this.OctoberButton);
            this.MonthNavigationPanel.Controls.Add(this.SeptemberButton);
            this.MonthNavigationPanel.Controls.Add(this.AugustButton);
            this.MonthNavigationPanel.Controls.Add(this.JuleButton);
            this.MonthNavigationPanel.Controls.Add(this.JuneButton);
            this.MonthNavigationPanel.Controls.Add(this.MayButton);
            this.MonthNavigationPanel.Controls.Add(this.AprilButton);
            this.MonthNavigationPanel.Controls.Add(this.MarchButton);
            this.MonthNavigationPanel.Controls.Add(this.FebruaryButton);
            this.MonthNavigationPanel.Controls.Add(this.JanuaryButton);
            this.MonthNavigationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonthNavigationPanel.Location = new System.Drawing.Point(146, 72);
            this.MonthNavigationPanel.Name = "MonthNavigationPanel";
            this.MonthNavigationPanel.Size = new System.Drawing.Size(214, 518);
            this.MonthNavigationPanel.TabIndex = 1;
            // 
            // AppointmentInfoPanel
            // 
            this.AppointmentInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentInfoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppointmentInfoPanel.BackgroundImage")));
            this.AppointmentInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppointmentInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentInfoPanel.Location = new System.Drawing.Point(0, 72);
            this.AppointmentInfoPanel.Name = "AppointmentInfoPanel";
            this.AppointmentInfoPanel.Size = new System.Drawing.Size(146, 518);
            this.AppointmentInfoPanel.TabIndex = 2;
            // 
            // NextYearButton
            // 
            this.NextYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.NextYearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextYearButton.FlatAppearance.BorderSize = 0;
            this.NextYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextYearButton.Location = new System.Drawing.Point(285, 0);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(75, 72);
            this.NextYearButton.TabIndex = 0;
            this.NextYearButton.Text = ">>";
            this.NextYearButton.UseVisualStyleBackColor = false;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // PreviousYearButton
            // 
            this.PreviousYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.PreviousYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousYearButton.FlatAppearance.BorderSize = 0;
            this.PreviousYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousYearButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousYearButton.Name = "PreviousYearButton";
            this.PreviousYearButton.Size = new System.Drawing.Size(75, 72);
            this.PreviousYearButton.TabIndex = 1;
            this.PreviousYearButton.Text = "<<";
            this.PreviousYearButton.UseVisualStyleBackColor = false;
            this.PreviousYearButton.Click += new System.EventHandler(this.PreviousYearButton_Click);
            // 
            // YearButton
            // 
            this.YearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.YearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearButton.FlatAppearance.BorderSize = 0;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearButton.Location = new System.Drawing.Point(75, 0);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(210, 72);
            this.YearButton.TabIndex = 2;
            this.YearButton.Text = "ГОД";
            this.YearButton.UseVisualStyleBackColor = false;
            // 
            // JanuaryButton
            // 
            this.JanuaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.JanuaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JanuaryButton.FlatAppearance.BorderSize = 0;
            this.JanuaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JanuaryButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JanuaryButton.Location = new System.Drawing.Point(0, 0);
            this.JanuaryButton.Name = "JanuaryButton";
            this.JanuaryButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.JanuaryButton.Size = new System.Drawing.Size(214, 43);
            this.JanuaryButton.TabIndex = 1;
            this.JanuaryButton.Text = "Январь";
            this.JanuaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JanuaryButton.UseVisualStyleBackColor = false;
            // 
            // FebruaryButton
            // 
            this.FebruaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.FebruaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FebruaryButton.FlatAppearance.BorderSize = 0;
            this.FebruaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FebruaryButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FebruaryButton.Location = new System.Drawing.Point(0, 43);
            this.FebruaryButton.Name = "FebruaryButton";
            this.FebruaryButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.FebruaryButton.Size = new System.Drawing.Size(214, 43);
            this.FebruaryButton.TabIndex = 2;
            this.FebruaryButton.Text = "Февраль";
            this.FebruaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FebruaryButton.UseVisualStyleBackColor = false;
            // 
            // MarchButton
            // 
            this.MarchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MarchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarchButton.FlatAppearance.BorderSize = 0;
            this.MarchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarchButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarchButton.Location = new System.Drawing.Point(0, 86);
            this.MarchButton.Name = "MarchButton";
            this.MarchButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.MarchButton.Size = new System.Drawing.Size(214, 43);
            this.MarchButton.TabIndex = 3;
            this.MarchButton.Text = "Март";
            this.MarchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarchButton.UseVisualStyleBackColor = false;
            // 
            // AprilButton
            // 
            this.AprilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AprilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AprilButton.FlatAppearance.BorderSize = 0;
            this.AprilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AprilButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AprilButton.Location = new System.Drawing.Point(0, 129);
            this.AprilButton.Name = "AprilButton";
            this.AprilButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.AprilButton.Size = new System.Drawing.Size(214, 43);
            this.AprilButton.TabIndex = 4;
            this.AprilButton.Text = "Апрель";
            this.AprilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AprilButton.UseVisualStyleBackColor = false;
            // 
            // MayButton
            // 
            this.MayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MayButton.FlatAppearance.BorderSize = 0;
            this.MayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MayButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MayButton.Location = new System.Drawing.Point(0, 172);
            this.MayButton.Name = "MayButton";
            this.MayButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.MayButton.Size = new System.Drawing.Size(214, 43);
            this.MayButton.TabIndex = 5;
            this.MayButton.Text = "Май";
            this.MayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MayButton.UseVisualStyleBackColor = false;
            // 
            // JuneButton
            // 
            this.JuneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.JuneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JuneButton.FlatAppearance.BorderSize = 0;
            this.JuneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JuneButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JuneButton.Location = new System.Drawing.Point(0, 215);
            this.JuneButton.Name = "JuneButton";
            this.JuneButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.JuneButton.Size = new System.Drawing.Size(214, 43);
            this.JuneButton.TabIndex = 6;
            this.JuneButton.Text = "Июнь";
            this.JuneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuneButton.UseVisualStyleBackColor = false;
            // 
            // JuleButton
            // 
            this.JuleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.JuleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JuleButton.FlatAppearance.BorderSize = 0;
            this.JuleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JuleButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JuleButton.Location = new System.Drawing.Point(0, 258);
            this.JuleButton.Name = "JuleButton";
            this.JuleButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.JuleButton.Size = new System.Drawing.Size(214, 43);
            this.JuleButton.TabIndex = 7;
            this.JuleButton.Text = "Июль";
            this.JuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuleButton.UseVisualStyleBackColor = false;
            // 
            // AugustButton
            // 
            this.AugustButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AugustButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AugustButton.FlatAppearance.BorderSize = 0;
            this.AugustButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AugustButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AugustButton.Location = new System.Drawing.Point(0, 301);
            this.AugustButton.Name = "AugustButton";
            this.AugustButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.AugustButton.Size = new System.Drawing.Size(214, 43);
            this.AugustButton.TabIndex = 8;
            this.AugustButton.Text = "Август";
            this.AugustButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AugustButton.UseVisualStyleBackColor = false;
            // 
            // SeptemberButton
            // 
            this.SeptemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.SeptemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeptemberButton.FlatAppearance.BorderSize = 0;
            this.SeptemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeptemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeptemberButton.Location = new System.Drawing.Point(0, 344);
            this.SeptemberButton.Name = "SeptemberButton";
            this.SeptemberButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.SeptemberButton.Size = new System.Drawing.Size(214, 43);
            this.SeptemberButton.TabIndex = 9;
            this.SeptemberButton.Text = "Сентябрь";
            this.SeptemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeptemberButton.UseVisualStyleBackColor = false;
            // 
            // OctoberButton
            // 
            this.OctoberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.OctoberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OctoberButton.FlatAppearance.BorderSize = 0;
            this.OctoberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OctoberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OctoberButton.Location = new System.Drawing.Point(0, 387);
            this.OctoberButton.Name = "OctoberButton";
            this.OctoberButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.OctoberButton.Size = new System.Drawing.Size(214, 43);
            this.OctoberButton.TabIndex = 10;
            this.OctoberButton.Text = "Октябрь";
            this.OctoberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OctoberButton.UseVisualStyleBackColor = false;
            // 
            // NovemberButton
            // 
            this.NovemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.NovemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NovemberButton.FlatAppearance.BorderSize = 0;
            this.NovemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NovemberButton.Location = new System.Drawing.Point(0, 430);
            this.NovemberButton.Name = "NovemberButton";
            this.NovemberButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.NovemberButton.Size = new System.Drawing.Size(214, 43);
            this.NovemberButton.TabIndex = 11;
            this.NovemberButton.Text = "Ноябрь";
            this.NovemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NovemberButton.UseVisualStyleBackColor = false;
            // 
            // DecemberButton
            // 
            this.DecemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DecemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecemberButton.FlatAppearance.BorderSize = 0;
            this.DecemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecemberButton.Location = new System.Drawing.Point(0, 473);
            this.DecemberButton.Name = "DecemberButton";
            this.DecemberButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.DecemberButton.Size = new System.Drawing.Size(214, 45);
            this.DecemberButton.TabIndex = 12;
            this.DecemberButton.Text = "Декабрь";
            this.DecemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecemberButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1445, 619);
            this.Controls.Add(this.codeeloGradientPanel2);
            this.Controls.Add(this.codeeloGradientPanel3);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.codeeloGradientPanel3.ResumeLayout(false);
            this.YearNavigationPanel.ResumeLayout(false);
            this.MonthNavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel3;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel2;
        private System.Windows.Forms.Panel AppointmentInfoPanel;
        private System.Windows.Forms.Panel MonthNavigationPanel;
        private System.Windows.Forms.Button DecemberButton;
        private System.Windows.Forms.Button NovemberButton;
        private System.Windows.Forms.Button OctoberButton;
        private System.Windows.Forms.Button SeptemberButton;
        private System.Windows.Forms.Button AugustButton;
        private System.Windows.Forms.Button JuleButton;
        private System.Windows.Forms.Button JuneButton;
        private System.Windows.Forms.Button MayButton;
        private System.Windows.Forms.Button AprilButton;
        private System.Windows.Forms.Button MarchButton;
        private System.Windows.Forms.Button FebruaryButton;
        private System.Windows.Forms.Button JanuaryButton;
        private System.Windows.Forms.Panel YearNavigationPanel;
        private System.Windows.Forms.Button YearButton;
        private System.Windows.Forms.Button PreviousYearButton;
        private System.Windows.Forms.Button NextYearButton;
    }
}

