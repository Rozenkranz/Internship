using System.Text.Json;
using System;
using System.Diagnostics;

namespace Backuper
{
    public partial class MainForm : Form
    {
        Config cfg = new Config();

        public MainForm()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText("cfg.json");
                cfg = JsonSerializer.Deserialize<Config>(json);
                UpdateConfig(cfg);
                textBoxLog.Text = "Файл конфигурации успешно загружен, можете приступать к работе!";

            }
            catch
            {
                textBoxLog.Text = "Файл конфигурации не найден или поверждён. Импортируйте файл конфигурации или создайте новый!";
            }
        }

        private void UpdateConfig(Config cfg)
        {
            textBoxHome.Text = cfg.HomePath;
            textBoxTarget.Text = cfg.TargetPath;
            if (cfg.CompressionType == "gzip")
                radioButtonGZip.Checked = true;
            else
                radioButtonZip.Checked = true;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            cfg.HomePath = fd.SelectedPath;
            textBoxHome.Text = cfg.HomePath;

            fd.SelectedPath = null;
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.Cancel)
                return;

            cfg.TargetPath = fd.SelectedPath;
            textBoxTarget.Text = cfg.TargetPath;

            fd.SelectedPath = null;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int status = 0; 
            if (cfg.TargetPath == null || cfg.HomePath == null || cfg.CompressionType==null)
            {
                MessageBox.Show("Не выбраны соответствующие пути к папкам!", "Ошибка");
            }
            else
            {
                if (cfg.CompressionType == "gzip")
                {
                    status = Compressor.CompressGZ(cfg);
                    if (status == 0)
                    {
                        textBoxHome.Text = "Архивирование успешно завершено! Ошибок: " + status.ToString();
                    }
                    else
                    {
                        textBoxHome.Text = "В процессе архивирования возникли проблемы. Ошибок: " + status.ToString();
                    }
                }
                else
                {
                    status = Compressor.CompressZip(cfg);
                    if (status == 0)
                        textBoxHome.Text = "Архивирование успешно завершено!";
                    else
                        textBoxHome.Text = "В процессе архивирования возникли проблемы.";
                }
                    
            }
            
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.Cancel)
                return;
            string path = fd.SelectedPath;
            string json = JsonSerializer.Serialize(cfg);
            path = Path.Combine(path, "cfg.json");
            File.WriteAllText(path, json);
            fd.SelectedPath = null;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                string json = File.ReadAllText(ofd.FileName);
                cfg = JsonSerializer.Deserialize<Config>(json);
                UpdateConfig(cfg);
                textBoxLog.Text = "Файл конфигурации успешно загружен, можете приступать к работе!";
            }
            catch
            {
                textBoxLog.Text = "Файл конфигурации не найден или поверждён. Импортируйте корректный файл конфигурации или создайте новый!";
            }
        }

        private void radioButtonZip_CheckedChanged(object sender, EventArgs e)
        {
            cfg.CompressionType = "zip";
        }

        private void radioButtonGZip_CheckedChanged(object sender, EventArgs e)
        {
            cfg.CompressionType = "gzip";
        }
    }
}