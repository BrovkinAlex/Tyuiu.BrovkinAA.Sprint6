using Tyuiu.BrovkinAA.Sprint6.Task7.V12.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённыу запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённыу запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

            dataGridViewInPut.ColumnHeadersVisible = false;
            dataGridViewInPut.RowHeadersVisible = false;
            dataGridViewOutPut.ColumnHeadersVisible = false;
            dataGridViewOutPut.RowHeadersVisible = false;
        }

        static int rows, cols;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFile(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split('\r', StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_row = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_row[c]);
                }
            }

            return arrayValues;
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, cols];

            arrayValues = LoadFromFile(openFilePath);

            dataGridViewInPut.ColumnCount = cols;
            dataGridViewInPut.RowCount = rows;
            dataGridViewOutPut.ColumnCount = cols;
            dataGridViewOutPut.RowCount = cols;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewInPut.Columns[i].Width = 25;
                dataGridViewOutPut.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewInPut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            //arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOutPut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveInFile.Enabled = true;
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv ";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            if (File.Exists(path))
                File.Delete(path);

            int rows = dataGridViewOutPut.RowCount;
            int cols = dataGridViewOutPut.ColumnCount;

            string str = "";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (c != cols - 1)
                        str += dataGridViewOutPut.Rows[r].Cells[c].Value + ";";
                    else
                        str += dataGridViewOutPut.Rows[r].Cells[c].Value;
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
