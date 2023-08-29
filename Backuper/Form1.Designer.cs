namespace Backuper
{
    partial class Form1
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
            labelHome = new Label();
            labelTarget = new Label();
            buttonConfig = new Button();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Consolas", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.DarkSlateBlue;
            labelHeader.Location = new Point(12, 9);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(459, 70);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Backuper v1.0";
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(12, 121);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(294, 37);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Задать исходную папку";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // textBoxHome
            // 
            textBoxHome.Location = new Point(312, 126);
            textBoxHome.Name = "textBoxHome";
            textBoxHome.ReadOnly = true;
            textBoxHome.ScrollBars = ScrollBars.Horizontal;
            textBoxHome.Size = new Size(476, 27);
            textBoxHome.TabIndex = 2;
            // 
            // buttonTarget
            // 
            buttonTarget.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTarget.Location = new Point(12, 177);
            buttonTarget.Name = "buttonTarget";
            buttonTarget.Size = new Size(294, 37);
            buttonTarget.TabIndex = 3;
            buttonTarget.Text = "Задать целевую папку";
            buttonTarget.UseVisualStyleBackColor = true;
            buttonTarget.Click += buttonTarget_Click;
            // 
            // textBoxTarget
            // 
            textBoxTarget.Location = new Point(312, 182);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.ReadOnly = true;
            textBoxTarget.Size = new Size(476, 27);
            textBoxTarget.TabIndex = 4;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 232);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(294, 37);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Копировать и сжать";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // fd
            // 
            fd.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelHome.Location = new Point(312, 105);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(464, 18);
            labelHome.TabIndex = 6;
            labelHome.Text = "Выберите папку из которой будет производиться копирование";
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTarget.Location = new Point(312, 161);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(456, 18);
            labelTarget.TabIndex = 7;
            labelTarget.Text = "Выберите папку в которую будет производиться копирование\r\n";
            // 
            // buttonConfig
            // 
            buttonConfig.Location = new Point(12, 285);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(294, 34);
            buttonConfig.TabIndex = 8;
            buttonConfig.Text = "Открыть файл конфигурации";
            buttonConfig.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfig);
            Controls.Add(labelTarget);
            Controls.Add(labelHome);
            Controls.Add(buttonStart);
            Controls.Add(textBoxTarget);
            Controls.Add(buttonTarget);
            Controls.Add(textBoxHome);
            Controls.Add(buttonHome);
            Controls.Add(labelHeader);
            Name = "Form1";
            Text = "Form1";
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
        private Label labelHome;
        private Label labelTarget;
        private Button buttonConfig;
    }
}