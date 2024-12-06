using Tyuiu.BrovkinAA.Sprint6.Task2.V16.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                double[] funcValues = ds.GetMassFunction(startStep, stopStep);

                this.chartOutPut.Titles.Clear();
                this.chartOutPut.Series[0].Points.Clear();

                this.chartOutPut.Titles.Add("График функции f(x)");

                this.chartOutPut.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartOutPut.ChartAreas[0].AxisY.Title = "Ось Y";

                this.dataGridViewOutPut.DataSource = null;
                this.dataGridViewOutPut.Rows.Clear();

                for (int i = 0; i < funcValues.Length; i++)
                {
                    this.dataGridViewOutPut.Rows.Add(Convert.ToString(startStep), Convert.ToString(funcValues[i]));
                    this.chartOutPut.Series[0].Points.AddXY(startStep, funcValues[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Неверно введены данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_EnterMouse(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.LimeGreen;
        }

        private void buttonDone_LeaveMouse(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Lime;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.White;
        }

        private void buttonDone_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.LimeGreen;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил: Бровкин А.А.\nГруппа: ИБКСб-24-1", "Полезная информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
