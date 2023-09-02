namespace Backuper
{
    partial class MainForm
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
            labelHeader = new Label();
            buttonHome = new Button();
            textBoxHome = new TextBox();
            buttonTarget = new Button();
            textBoxTarget = new TextBox();
            buttonStart = new Button();
            fd = new FolderBrowserDialog();
            textBoxLog = new TextBox();
            groupBoxType = new GroupBox();
            radioButtonZip = new RadioButton();
            radioButtonGZip = new RadioButton();
            buttonExport = new Button();
            buttonImport = new Button();
            ofd = new OpenFileDialog();
            groupBoxType.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Consolas", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.DarkSlateBlue;
            labelHeader.Location = new Point(122, 6);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(362, 56);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Backuper v1.0";
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(10, 64);
            buttonHome.Margin = new Padding(3, 2, 3, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(257, 28);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Задать исходную папку";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // textBoxHome
            // 
            textBoxHome.BackColor = SystemColors.Control;
            textBoxHome.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxHome.ForeColor = SystemColors.GrayText;
            textBoxHome.Location = new Point(273, 69);
            textBoxHome.Margin = new Padding(3, 2, 3, 2);
            textBoxHome.Name = "textBoxHome";
            textBoxHome.ReadOnly = true;
            textBoxHome.ScrollBars = ScrollBars.Horizontal;
            textBoxHome.Size = new Size(324, 23);
            textBoxHome.TabIndex = 2;
            textBoxHome.Text = "Путь исходной папки...";
            // 
            // buttonTarget
            // 
            buttonTarget.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTarget.Location = new Point(10, 98);
            buttonTarget.Margin = new Padding(3, 2, 3, 2);
            buttonTarget.Name = "buttonTarget";
            buttonTarget.Size = new Size(257, 28);
            buttonTarget.TabIndex = 3;
            buttonTarget.Text = "Задать целевую папку";
            buttonTarget.UseVisualStyleBackColor = true;
            buttonTarget.Click += buttonTarget_Click;
            // 
            // textBoxTarget
            // 
            textBoxTarget.BackColor = SystemColors.Control;
            textBoxTarget.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxTarget.ForeColor = SystemColors.GrayText;
            textBoxTarget.Location = new Point(273, 102);
            textBoxTarget.Margin = new Padding(3, 2, 3, 2);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.ReadOnly = true;
            textBoxTarget.Size = new Size(324, 23);
            textBoxTarget.TabIndex = 4;
            textBoxTarget.Text = "Путь целевой папки...";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(10, 254);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(586, 26);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Начать архивацию";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // fd
            // 
            fd.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLog.Location = new Point(10, 284);
            textBoxLog.Margin = new Padding(3, 2, 3, 2);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(587, 186);
            textBoxLog.TabIndex = 9;
            // 
            // groupBoxType
            // 
            groupBoxType.Controls.Add(radioButtonZip);
            groupBoxType.Controls.Add(radioButtonGZip);
            groupBoxType.Location = new Point(10, 130);
            groupBoxType.Margin = new Padding(3, 2, 3, 2);
            groupBoxType.Name = "groupBoxType";
            groupBoxType.Padding = new Padding(3, 2, 3, 2);
            groupBoxType.Size = new Size(134, 94);
            groupBoxType.TabIndex = 10;
            groupBoxType.TabStop = false;
            groupBoxType.Text = "Тип архивации";
            // 
            // radioButtonZip
            // 
            radioButtonZip.AutoSize = true;
            radioButtonZip.Location = new Point(5, 43);
            radioButtonZip.Margin = new Padding(3, 2, 3, 2);
            radioButtonZip.Name = "radioButtonZip";
            radioButtonZip.Size = new Size(103, 19);
            radioButtonZip.TabIndex = 13;
            radioButtonZip.TabStop = true;
            radioButtonZip.Text = "Zip архивация";
            radioButtonZip.UseVisualStyleBackColor = true;
            radioButtonZip.CheckedChanged += radioButtonZip_CheckedChanged;
            // 
            // radioButtonGZip
            // 
            radioButtonGZip.AutoSize = true;
            radioButtonGZip.Checked = true;
            radioButtonGZip.Location = new Point(5, 20);
            radioButtonGZip.Margin = new Padding(3, 2, 3, 2);
            radioButtonGZip.Name = "radioButtonGZip";
            radioButtonGZip.Size = new Size(92, 19);
            radioButtonGZip.TabIndex = 12;
            radioButtonGZip.TabStop = true;
            radioButtonGZip.Text = "GZip сжатие";
            radioButtonGZip.UseVisualStyleBackColor = true;
            radioButtonGZip.CheckedChanged += radioButtonGZip_CheckedChanged;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(340, 141);
            buttonExport.Margin = new Padding(3, 2, 3, 2);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(257, 28);
            buttonExport.TabIndex = 12;
            buttonExport.Text = "Экспорт конфигурации";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(341, 186);
            buttonImport.Margin = new Padding(3, 2, 3, 2);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(257, 28);
            buttonImport.TabIndex = 13;
            buttonImport.Text = "Импорт конфигурации";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // ofd
            // 
            ofd.Filter = "Json file|*.json";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 478);
            Controls.Add(buttonImport);
            Controls.Add(buttonExport);
            Controls.Add(groupBoxType);
            Controls.Add(buttonStart);
            Controls.Add(textBoxTarget);
            Controls.Add(buttonTarget);
            Controls.Add(textBoxHome);
            Controls.Add(buttonHome);
            Controls.Add(labelHeader);
            Controls.Add(textBoxLog);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Backuper v1.0";
            groupBoxType.ResumeLayout(false);
            groupBoxType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Button buttonHome;
        private TextBox textBoxHome;
        private Button buttonTarget;
        private TextBox textBoxTarget;
        private Button buttonStart;
        private FolderBrowserDialog fd;
        private TextBox textBoxLog;
        private GroupBox groupBoxType;
        private RadioButton radioButtonZip;
        private RadioButton radioButtonGZip;
        private GroupBox groupBoxLog;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button buttonExport;
        private Button buttonImport;
        private OpenFileDialog ofd;
    }
}