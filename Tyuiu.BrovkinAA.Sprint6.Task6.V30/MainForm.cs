namespace Tyuiu.BrovkinAA.Sprint6.Task6.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string openFilePath;

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBox1.Text = File.ReadAllText(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
