using Tyuiu.BrovkinAA.Sprint6.Task1.V24.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxStartValue_Enter(object sender, EventArgs e)
        {
            if (textBoxStartValue.Text == "������� ��������")
            {
                textBoxStartValue.Clear();
                textBoxStartValue.ForeColor = Color.Black;
            }
        }

        private void textBoxStartValue_Leave(object sender, EventArgs e)
        {
            if (textBoxStartValue.Text == "")
            {
                textBoxStartValue.Text = "������� ��������";
                textBoxStartValue.ForeColor = Color.Gray;
            }
        }

        private void textBoxStopValue_Enter(object sender, EventArgs e)
        {
            if (textBoxStopValue.Text == "������� ��������")
            {
                textBoxStopValue.Clear();
                textBoxStopValue.ForeColor = Color.Black;
            }
        }

        private void textBoxStopValue_Leave(object sender, EventArgs e)
        {
            if (textBoxStopValue.Text == "")
            {
                textBoxStopValue.Text = "������� ��������";
                textBoxStopValue.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue.Text);
                double[] masValue = ds.GetMassFunction(startValue, stopValue);

                textBoxOutPut.Font = new Font(FontFamily.GenericMonospace, 9);
                textBoxOutPut.Text = "";
                textBoxOutPut.AppendText("+-----------------+-----------------+" + Environment.NewLine);
                textBoxOutPut.AppendText("|        x        |       f(x)      |" + Environment.NewLine);
                textBoxOutPut.AppendText("+-----------------+-----------------+" + Environment.NewLine);
                //         String.Format("|    {0,5:d}      |    {1,5:f2}       |", startValue, masValue[i]);
                for (int i = 0; i < masValue.Length; i++)
                {
                    string line = String.Format("|    {0,5:d}        |      {1,5:f2}\t    |", startValue++, masValue[i]);
                    textBoxOutPut.AppendText(line + Environment.NewLine);
                }

                textBoxOutPut.AppendText("+-----------------+-----------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� �������� ������� �.�.\n������ ����-24-1", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
