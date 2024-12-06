namespace Tyuiu.BrovkinAA.Sprint6.Task2.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            chartOutPut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutPut = new GroupBox();
            dataGridViewOutPut = new DataGridView();
            variable = new DataGridViewTextBoxColumn();
            function = new DataGridViewTextBoxColumn();
            groupBoxInfo = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBoxVariables = new GroupBox();
            textBoxStopInfo = new TextBox();
            textBoxStartInfo = new TextBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)chartOutPut).BeginInit();
            groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxVariables.SuspendLayout();
            SuspendLayout();
            // 
            // chartOutPut
            // 
            chartOutPut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartOutPut.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartOutPut.Legends.Add(legend2);
            chartOutPut.Location = new Point(258, 22);
            chartOutPut.Name = "chartOutPut";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartOutPut.Series.Add(series2);
            chartOutPut.Size = new Size(482, 398);
            chartOutPut.TabIndex = 1;
            chartOutPut.TabStop = false;
            chartOutPut.Text = "График";
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxOutPut.Controls.Add(dataGridViewOutPut);
            groupBoxOutPut.Controls.Add(chartOutPut);
            groupBoxOutPut.Location = new Point(581, 12);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(746, 426);
            groupBoxOutPut.TabIndex = 2;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод данных:";
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.AllowUserToAddRows = false;
            dataGridViewOutPut.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewOutPut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Columns.AddRange(new DataGridViewColumn[] { variable, function });
            dataGridViewOutPut.Location = new Point(6, 22);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.ReadOnly = true;
            dataGridViewOutPut.RowHeadersVisible = false;
            dataGridViewOutPut.Size = new Size(240, 398);
            dataGridViewOutPut.TabIndex = 2;
            dataGridViewOutPut.TabStop = false;
            // 
            // variable
            // 
            variable.HeaderText = "x";
            variable.Name = "variable";
            variable.ReadOnly = true;
            // 
            // function
            // 
            function.HeaderText = "f(x)";
            function.Name = "function";
            function.ReadOnly = true;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(pictureBox1);
            groupBoxInfo.Controls.Add(textBox1);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(563, 342);
            groupBoxInfo.TabIndex = 3;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.FormulaTask2;
            pictureBox1.Location = new Point(6, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(551, 107);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxVariables
            // 
            groupBoxVariables.Controls.Add(textBoxStopInfo);
            groupBoxVariables.Controls.Add(textBoxStartInfo);
            groupBoxVariables.Controls.Add(textBoxStop);
            groupBoxVariables.Controls.Add(textBoxStart);
            groupBoxVariables.Location = new Point(12, 360);
            groupBoxVariables.Name = "groupBoxVariables";
            groupBoxVariables.Size = new Size(312, 78);
            groupBoxVariables.TabIndex = 4;
            groupBoxVariables.TabStop = false;
            groupBoxVariables.Text = "Ввод данных";
            // 
            // textBoxStopInfo
            // 
            textBoxStopInfo.BackColor = SystemColors.Control;
            textBoxStopInfo.BorderStyle = BorderStyle.None;
            textBoxStopInfo.Location = new Point(161, 27);
            textBoxStopInfo.Name = "textBoxStopInfo";
            textBoxStopInfo.ReadOnly = true;
            textBoxStopInfo.Size = new Size(100, 16);
            textBoxStopInfo.TabIndex = 3;
            textBoxStopInfo.TabStop = false;
            textBoxStopInfo.Text = "Конец шага:";
            // 
            // textBoxStartInfo
            // 
            textBoxStartInfo.BackColor = SystemColors.Control;
            textBoxStartInfo.BorderStyle = BorderStyle.None;
            textBoxStartInfo.Location = new Point(6, 27);
            textBoxStartInfo.Name = "textBoxStartInfo";
            textBoxStartInfo.ReadOnly = true;
            textBoxStartInfo.Size = new Size(100, 16);
            textBoxStartInfo.TabIndex = 2;
            textBoxStartInfo.TabStop = false;
            textBoxStartInfo.Text = "Начало шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxStop.Location = new Point(161, 49);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(145, 23);
            textBoxStop.TabIndex = 1;
            textBoxStop.Text = "5";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 49);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(145, 23);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "-5";
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Cyan;
            buttonInfo.Location = new Point(330, 360);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(86, 78);
            buttonInfo.TabIndex = 5;
            buttonInfo.TabStop = false;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Location = new Point(422, 360);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(153, 78);
            buttonDone.TabIndex = 6;
            buttonDone.TabStop = false;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_EnterMouse;
            buttonDone.MouseLeave += buttonDone_LeaveMouse;
            buttonDone.MouseUp += buttonDone_MouseUp;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxVariables);
            Controls.Add(groupBoxInfo);
            Controls.Add(groupBoxOutPut);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сприт 6 | Таск 2 | Бровкин А.А. | ИБКСб-24-1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartOutPut).EndInit();
            groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxVariables.ResumeLayout(false);
            groupBoxVariables.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPut;
        private GroupBox groupBoxOutPut;
        private DataGridView dataGridViewOutPut;
        private GroupBox groupBoxInfo;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private GroupBox groupBoxVariables;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBoxStopInfo;
        private TextBox textBoxStartInfo;
        private Button buttonInfo;
        private Button buttonDone;
        private DataGridViewTextBoxColumn variable;
        private DataGridViewTextBoxColumn function;
    }
}
