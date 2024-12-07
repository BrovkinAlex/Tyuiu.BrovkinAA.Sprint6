using Tyuiu.BrovkinAA.Sprint6.Task3.V27.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        DataService ds = new DataService();
        int[,] matrix =
        {
            { 9, 13, -14, 23, 1 },
            { 15, -17, 21, 25, 23 },
            { -4, 29, -20, -10, 14},
            { 27, 33, 12, 33, -12 },
            { 18, -9, -5, 6, 3 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {            
            textBoxMatrix.Font = new Font(FontFamily.GenericMonospace, 10);
            dataGridViewIO.RowHeadersVisible = false;
            dataGridViewIO.ColumnHeadersVisible = false;
            dataGridViewIO.Font = new Font("Segoe UI", 10);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                textBoxMatrix.Text += String.Format("{0,5}  |{1,5}  |{2,5}  |{3,5}  |{4,5}", matrix[i, 0], matrix[i, 1], matrix[i, 2], matrix[i, 3], matrix[i, 4]);
                textBoxMatrix.Text += Environment.NewLine;
            }

            dataGridViewIO.ColumnCount = cols;
            dataGridViewIO.RowCount = rows;

            for (int i = 0; i < cols; i++)
                dataGridViewIO.Columns[i].Width = 50;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dataGridViewIO.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                int[,] newMtrx = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        newMtrx[i, j] = Convert.ToInt32(dataGridViewIO.Rows[i].Cells[j].Value);

                newMtrx = ds.Calculate(newMtrx);

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        dataGridViewIO.Rows[i].Cells[j].Value = Convert.ToString(newMtrx[i, j]);
            }
            catch
            {
                MessageBox.Show("Неверно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-24-1 Бровкин Алексей Александрович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
