namespace Backuper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            Config.HomePath = fd.SelectedPath;
            textBoxHome.Text = Config.HomePath;
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            Config.TargetPath = fd.SelectedPath;
            textBoxTarget.Text = Config.TargetPath;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (Config.TargetPath == null || Config.HomePath == null)
            {
                MessageBox.Show("Не выбраны соответствующие пути к папкам!", "Ошибка");
            }
            else
            {
                Copier.CopyAndCompress();

            }
        }


    }
}