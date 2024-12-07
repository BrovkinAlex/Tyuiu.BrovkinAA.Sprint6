namespace Tyuiu.BrovkinAA.Sprint6.Task3.V27
{
    partial class FormMain
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
            groupBoxMain = new GroupBox();
            textBoxMatrix = new TextBox();
            textBoxInfo = new TextBox();
            groupBoxInOutPut = new GroupBox();
            dataGridViewIO = new DataGridView();
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBoxMain.SuspendLayout();
            groupBoxInOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(textBoxMatrix);
            groupBoxMain.Controls.Add(textBoxInfo);
            groupBoxMain.Location = new Point(12, 12);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(410, 357);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Условие";
            // 
            // textBoxMatrix
            // 
            textBoxMatrix.BorderStyle = BorderStyle.None;
            textBoxMatrix.Location = new Point(6, 87);
            textBoxMatrix.Multiline = true;
            textBoxMatrix.Name = "textBoxMatrix";
            textBoxMatrix.ReadOnly = true;
            textBoxMatrix.Size = new Size(398, 132);
            textBoxMatrix.TabIndex = 1;
            textBoxMatrix.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.BackColor = SystemColors.Control;
            textBoxInfo.BorderStyle = BorderStyle.None;
            textBoxInfo.Font = new Font("Segoe UI", 10F);
            textBoxInfo.Location = new Point(6, 22);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(398, 59);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в четвертом столбце.\r\nРезультат вывести в DataGridView.\r\n\r\n";
            // 
            // groupBoxInOutPut
            // 
            groupBoxInOutPut.Controls.Add(dataGridViewIO);
            groupBoxInOutPut.Location = new Point(428, 12);
            groupBoxInOutPut.Name = "groupBoxInOutPut";
            groupBoxInOutPut.Size = new Size(410, 426);
            groupBoxInOutPut.TabIndex = 1;
            groupBoxInOutPut.TabStop = false;
            groupBoxInOutPut.Text = "Ввод и вывод данных:";
            // 
            // dataGridViewIO
            // 
            dataGridViewIO.AllowUserToAddRows = false;
            dataGridViewIO.AllowUserToDeleteRows = false;
            dataGridViewIO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIO.Location = new Point(6, 22);
            dataGridViewIO.Name = "dataGridViewIO";
            dataGridViewIO.Size = new Size(398, 398);
            dataGridViewIO.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(12, 375);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(105, 63);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Что тут происходит?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            buttonDone.Location = new Point(123, 375);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(299, 63);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "ВЫПОЛНИТЬ!";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxInOutPut);
            Controls.Add(groupBoxMain);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            groupBoxInOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain;
        private TextBox textBoxInfo;
        private GroupBox groupBoxInOutPut;
        private DataGridView dataGridViewIO;
        private Button buttonInfo;
        private Button buttonDone;
        private TextBox textBoxMatrix;
    }
}
