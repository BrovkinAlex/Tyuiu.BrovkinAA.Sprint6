using Tyuiu.BrovkinAA.Sprint6.Task5.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task5.V10
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
            this.chartFunction_BAA.Titles.Add("График функции F(x)");
            this.chartFunction_BAA.Titles[0].Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            this.chartFunction_BAA.Titles[0].ForeColor = Color.Red;
            this.chartFunction_BAA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_BAA.ChartAreas[0].AxisY.Title = "Ось Y";

            dataGridViewInPut_BAA.RowHeadersVisible = false;
            dataGridViewInPut_BAA.ColumnHeadersVisible = false;
            dataGridViewInPut_BAA.Font = new Font("Segoe UI", 10);
        }

        private void buttonLoadDataFile_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                double[] data = ds.LoadFromDataFile(Path.Combine(Directory.GetCurrentDirectory(), "InPutFileTask5V10.txt"));

                dataGridViewInPut_BAA.DataSource = null;
                dataGridViewInPut_BAA.Rows.Clear();

                dataGridViewInPut_BAA.ColumnCount = 2;
                dataGridViewInPut_BAA.RowCount = data.Length;
                dataGridViewInPut_BAA.Columns[0].Width = 35;
                dataGridViewInPut_BAA.Columns[1].Width = 75;

                for (int i = 0; i < data.Length; i++)
                {
                    dataGridViewInPut_BAA.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
                    dataGridViewInPut_BAA.Rows[i].Cells[1].Value = Convert.ToString(data[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartFunction_BAA.Series[0].Points.Clear();


                for (int i = 0; i < dataGridViewInPut_BAA.Rows.Count; i++)
                {
                    this.chartFunction_BAA.Series[0].Points.AddXY(Convert.ToInt32(dataGridViewInPut_BAA.Rows[i].Cells[0].Value), Convert.ToDouble(dataGridViewInPut_BAA.Rows[i].Cells[1].Value));
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения данных из dataGridView", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
