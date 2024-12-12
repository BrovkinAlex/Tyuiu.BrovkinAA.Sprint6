namespace Tyuiu.BrovkinAA.Sprint6.Task5.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelInfo_BAA = new Panel();
            buttonInfo_BAA = new Button();
            buttonLoadDataFile_BAA = new Button();
            buttonDone_BAA = new Button();
            groupBoxInfo_BAA = new GroupBox();
            textBoxInfo_BAA = new TextBox();
            panelData_BAA = new Panel();
            groupBoxInPut_BAA = new GroupBox();
            dataGridViewInPut_BAA = new DataGridView();
            panelChart_BAA = new Panel();
            chartFunction_BAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterBetweenDataAndChart_BAA = new Splitter();
            button1 = new Button();
            panelInfo_BAA.SuspendLayout();
            groupBoxInfo_BAA.SuspendLayout();
            panelData_BAA.SuspendLayout();
            groupBoxInPut_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_BAA).BeginInit();
            panelChart_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BAA).BeginInit();
            SuspendLayout();
            // 
            // panelInfo_BAA
            // 
            panelInfo_BAA.Controls.Add(button1);
            panelInfo_BAA.Controls.Add(buttonInfo_BAA);
            panelInfo_BAA.Controls.Add(buttonLoadDataFile_BAA);
            panelInfo_BAA.Controls.Add(buttonDone_BAA);
            panelInfo_BAA.Controls.Add(groupBoxInfo_BAA);
            panelInfo_BAA.Dock = DockStyle.Top;
            panelInfo_BAA.Location = new Point(5, 5);
            panelInfo_BAA.Name = "panelInfo_BAA";
            panelInfo_BAA.Size = new Size(1174, 102);
            panelInfo_BAA.TabIndex = 0;
            // 
            // buttonInfo_BAA
            // 
            buttonInfo_BAA.Location = new Point(1049, 15);
            buttonInfo_BAA.Name = "buttonInfo_BAA";
            buttonInfo_BAA.Size = new Size(122, 81);
            buttonInfo_BAA.TabIndex = 2;
            buttonInfo_BAA.TabStop = false;
            buttonInfo_BAA.Text = "Справка";
            buttonInfo_BAA.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDataFile_BAA
            // 
            buttonLoadDataFile_BAA.Location = new Point(619, 15);
            buttonLoadDataFile_BAA.Name = "buttonLoadDataFile_BAA";
            buttonLoadDataFile_BAA.Size = new Size(122, 81);
            buttonLoadDataFile_BAA.TabIndex = 2;
            buttonLoadDataFile_BAA.TabStop = false;
            buttonLoadDataFile_BAA.Text = "Загрузить\r\nфайл";
            buttonLoadDataFile_BAA.UseVisualStyleBackColor = true;
            buttonLoadDataFile_BAA.Click += buttonLoadDataFile_BAA_Click;
            // 
            // buttonDone_BAA
            // 
            buttonDone_BAA.Location = new Point(491, 15);
            buttonDone_BAA.Name = "buttonDone_BAA";
            buttonDone_BAA.Size = new Size(122, 81);
            buttonDone_BAA.TabIndex = 1;
            buttonDone_BAA.TabStop = false;
            buttonDone_BAA.Text = "Выполнить";
            buttonDone_BAA.UseVisualStyleBackColor = true;
            buttonDone_BAA.Click += buttonDone_BAA_Click;
            // 
            // groupBoxInfo_BAA
            // 
            groupBoxInfo_BAA.Controls.Add(textBoxInfo_BAA);
            groupBoxInfo_BAA.Location = new Point(3, 3);
            groupBoxInfo_BAA.Name = "groupBoxInfo_BAA";
            groupBoxInfo_BAA.Size = new Size(485, 93);
            groupBoxInfo_BAA.TabIndex = 0;
            groupBoxInfo_BAA.TabStop = false;
            groupBoxInfo_BAA.Text = "Условие";
            // 
            // textBoxInfo_BAA
            // 
            textBoxInfo_BAA.BackColor = SystemColors.Control;
            textBoxInfo_BAA.BorderStyle = BorderStyle.None;
            textBoxInfo_BAA.Dock = DockStyle.Fill;
            textBoxInfo_BAA.Font = new Font("Segoe UI", 10F);
            textBoxInfo_BAA.Location = new Point(3, 19);
            textBoxInfo_BAA.Multiline = true;
            textBoxInfo_BAA.Name = "textBoxInfo_BAA";
            textBoxInfo_BAA.ReadOnly = true;
            textBoxInfo_BAA.Size = new Size(479, 71);
            textBoxInfo_BAA.TabIndex = 0;
            textBoxInfo_BAA.TabStop = false;
            textBoxInfo_BAA.Text = "Прочитать данные из файла InPutFileTask5V10.txt. Вывести в dataGridView. \r\nДан список из чисел. Вывести все числа, не равные 0. Построить диаграмму по этим значениям.";
            // 
            // panelData_BAA
            // 
            panelData_BAA.Controls.Add(groupBoxInPut_BAA);
            panelData_BAA.Dock = DockStyle.Left;
            panelData_BAA.Location = new Point(5, 107);
            panelData_BAA.Name = "panelData_BAA";
            panelData_BAA.Size = new Size(273, 549);
            panelData_BAA.TabIndex = 1;
            // 
            // groupBoxInPut_BAA
            // 
            groupBoxInPut_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInPut_BAA.AutoSize = true;
            groupBoxInPut_BAA.Controls.Add(dataGridViewInPut_BAA);
            groupBoxInPut_BAA.Location = new Point(6, 6);
            groupBoxInPut_BAA.Name = "groupBoxInPut_BAA";
            groupBoxInPut_BAA.Size = new Size(261, 540);
            groupBoxInPut_BAA.TabIndex = 0;
            groupBoxInPut_BAA.TabStop = false;
            groupBoxInPut_BAA.Text = "Входные данные:";
            // 
            // dataGridViewInPut_BAA
            // 
            dataGridViewInPut_BAA.AllowUserToAddRows = false;
            dataGridViewInPut_BAA.AllowUserToDeleteRows = false;
            dataGridViewInPut_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_BAA.Dock = DockStyle.Fill;
            dataGridViewInPut_BAA.Location = new Point(3, 19);
            dataGridViewInPut_BAA.Name = "dataGridViewInPut_BAA";
            dataGridViewInPut_BAA.ReadOnly = true;
            dataGridViewInPut_BAA.Size = new Size(255, 518);
            dataGridViewInPut_BAA.TabIndex = 0;
            dataGridViewInPut_BAA.TabStop = false;
            // 
            // panelChart_BAA
            // 
            panelChart_BAA.Controls.Add(chartFunction_BAA);
            panelChart_BAA.Dock = DockStyle.Fill;
            panelChart_BAA.Location = new Point(278, 107);
            panelChart_BAA.Name = "panelChart_BAA";
            panelChart_BAA.Size = new Size(901, 549);
            panelChart_BAA.TabIndex = 2;
            // 
            // chartFunction_BAA
            // 
            chartFunction_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartFunction_BAA.BackColor = SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            chartFunction_BAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BAA.Legends.Add(legend1);
            chartFunction_BAA.Location = new Point(9, 6);
            chartFunction_BAA.Name = "chartFunction_BAA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BAA.Series.Add(series1);
            chartFunction_BAA.Size = new Size(889, 537);
            chartFunction_BAA.TabIndex = 3;
            chartFunction_BAA.TabStop = false;
            chartFunction_BAA.Text = "График";
            // 
            // splitterBetweenDataAndChart_BAA
            // 
            splitterBetweenDataAndChart_BAA.Location = new Point(278, 107);
            splitterBetweenDataAndChart_BAA.Name = "splitterBetweenDataAndChart_BAA";
            splitterBetweenDataAndChart_BAA.Size = new Size(3, 549);
            splitterBetweenDataAndChart_BAA.TabIndex = 3;
            splitterBetweenDataAndChart_BAA.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(747, 15);
            button1.Name = "button1";
            button1.Size = new Size(122, 81);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(splitterBetweenDataAndChart_BAA);
            Controls.Add(panelChart_BAA);
            Controls.Add(panelData_BAA);
            Controls.Add(panelInfo_BAA);
            MinimumSize = new Size(1200, 700);
            Name = "FormMain";
            Padding = new Padding(5);
            Text = "Спринт 6 | Таск 5 | Бровкин А.А.";
            Load += FormMain_Load;
            panelInfo_BAA.ResumeLayout(false);
            groupBoxInfo_BAA.ResumeLayout(false);
            groupBoxInfo_BAA.PerformLayout();
            panelData_BAA.ResumeLayout(false);
            panelData_BAA.PerformLayout();
            groupBoxInPut_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_BAA).EndInit();
            panelChart_BAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo_BAA;
        private Panel panelData_BAA;
        private Panel panelChart_BAA;
        private Splitter splitterBetweenDataAndChart_BAA;
        private GroupBox groupBoxInfo_BAA;
        private TextBox textBoxInfo_BAA;
        private GroupBox groupBoxInPut_BAA;
        private DataGridView dataGridViewInPut_BAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BAA;
        private Button buttonDone_BAA;
        private Button buttonInfo_BAA;
        private Button buttonLoadDataFile_BAA;
        private Button button1;
    }
}
