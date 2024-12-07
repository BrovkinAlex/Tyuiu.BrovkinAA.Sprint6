using Tyuiu.BrovkinAA.Sprint6.Task4.V18.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.BrovkinAA.Sprint6.Task4.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.chartFunction.Titles.Add("График функции F(x)");
            this.chartFunction.Titles[0].Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            this.chartFunction.Titles[0].ForeColor = Color.Red;
            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
            textBoxFuncValues.Font = new Font(FontFamily.GenericMonospace, 10);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                if (startStep > stopStep)
                {
                    int temp = startStep;
                    startStep = stopStep;
                    stopStep = temp;
                }

                double[] values = ds.GetMassFunction(startStep, stopStep);

                textBoxFuncValues.Text = "";
                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i < values.Length; i++)
                {
                    chartFunction.Series[0].Points.AddXY(startStep++, values[i]);
                    textBoxFuncValues.AppendText(String.Format("{0,7}", values[i]) + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.IndianRed;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.LightCoral;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.White;
        }

        private void buttonDone_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.IndianRed;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V18.txt");
                File.WriteAllText(path, textBoxFuncValues.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\nОткрыть его в Проводнике?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process exp = new System.Diagnostics.Process();
                    exp.StartInfo.FileName = "explorer.exe";
                    exp.StartInfo.Arguments = Directory.GetCurrentDirectory();
                    exp.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.LimeGreen;
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Lime;
        }

        private void buttonSave_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSave.BackColor = Color.White;
        }

        private void buttonSave_MouseUp(object sender, MouseEventArgs e)
        {
            buttonSave.BackColor = Color.LimeGreen;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-24-1\nБровкин Алексей Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonInfo_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.MediumTurquoise;
        }

        private void buttonInfo_MouseLeave(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.Cyan;
        }

        private void buttonInfo_MouseDown(object sender, MouseEventArgs e)
        {
            buttonInfo.BackColor = Color.White;
        }

        private void buttonInfo_MouseUp(object sender, MouseEventArgs e)
        {
            buttonInfo.BackColor = Color.MediumTurquoise;
        }
    }
}
