namespace Tyuiu.BrovkinAA.Sprint6.Task4.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelInfo = new Panel();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBoxInPut = new GroupBox();
            textBoxStopInfo = new TextBox();
            textBoxStartInfo = new TextBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBoxInfo = new GroupBox();
            pictureBoxFunc = new PictureBox();
            textBoxInfo = new TextBox();
            panelFuncValues = new Panel();
            groupBoxFuncValues = new GroupBox();
            textBoxFuncValues = new TextBox();
            panelFunction = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelInfo.SuspendLayout();
            groupBoxInPut.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunc).BeginInit();
            panelFuncValues.SuspendLayout();
            groupBoxFuncValues.SuspendLayout();
            panelFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(buttonInfo);
            panelInfo.Controls.Add(buttonSave);
            panelInfo.Controls.Add(buttonDone);
            panelInfo.Controls.Add(groupBoxInPut);
            panelInfo.Controls.Add(groupBoxInfo);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1184, 109);
            panelInfo.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = Color.Cyan;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.Location = new Point(1058, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(114, 91);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            buttonInfo.MouseDown += buttonInfo_MouseDown;
            buttonInfo.MouseEnter += buttonInfo_MouseEnter;
            buttonInfo.MouseLeave += buttonInfo_MouseLeave;
            buttonInfo.MouseUp += buttonInfo_MouseUp;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Lime;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Location = new Point(938, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(114, 91);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseDown += buttonSave_MouseDown;
            buttonSave.MouseEnter += buttonSave_MouseEnter;
            buttonSave.MouseLeave += buttonSave_MouseLeave;
            buttonSave.MouseUp += buttonSave_MouseUp;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightCoral;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Location = new Point(767, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(165, 91);
            buttonDone.TabIndex = 2;
            buttonDone.TabStop = false;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            buttonDone.MouseUp += buttonDone_MouseUp;
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(textBoxStopInfo);
            groupBoxInPut.Controls.Add(textBoxStartInfo);
            groupBoxInPut.Controls.Add(textBoxStop);
            groupBoxInPut.Controls.Add(textBoxStart);
            groupBoxInPut.Location = new Point(543, 3);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(218, 100);
            groupBoxInPut.TabIndex = 1;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод данных:";
            // 
            // textBoxStopInfo
            // 
            textBoxStopInfo.BackColor = SystemColors.Control;
            textBoxStopInfo.BorderStyle = BorderStyle.None;
            textBoxStopInfo.Location = new Point(112, 47);
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
            textBoxStartInfo.Location = new Point(6, 47);
            textBoxStartInfo.Name = "textBoxStartInfo";
            textBoxStartInfo.ReadOnly = true;
            textBoxStartInfo.Size = new Size(100, 16);
            textBoxStartInfo.TabIndex = 2;
            textBoxStartInfo.TabStop = false;
            textBoxStartInfo.Text = "Начало шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Cursor = Cursors.IBeam;
            textBoxStop.Location = new Point(112, 69);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 1;
            textBoxStop.Text = "5";
            // 
            // textBoxStart
            // 
            textBoxStart.Cursor = Cursors.IBeam;
            textBoxStart.Location = new Point(6, 69);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "-5";
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(pictureBoxFunc);
            groupBoxInfo.Controls.Add(textBoxInfo);
            groupBoxInfo.Location = new Point(12, 3);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(525, 100);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Условие";
            // 
            // pictureBoxFunc
            // 
            pictureBoxFunc.Image = Properties.Resources.FormulaTask4;
            pictureBoxFunc.Location = new Point(304, 57);
            pictureBoxFunc.Name = "pictureBoxFunc";
            pictureBoxFunc.Size = new Size(196, 35);
            pictureBoxFunc.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFunc.TabIndex = 1;
            pictureBoxFunc.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.BorderStyle = BorderStyle.None;
            textBoxInfo.Location = new Point(6, 22);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(522, 53);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // panelFuncValues
            // 
            panelFuncValues.Controls.Add(groupBoxFuncValues);
            panelFuncValues.Dock = DockStyle.Left;
            panelFuncValues.Location = new Point(0, 109);
            panelFuncValues.Name = "panelFuncValues";
            panelFuncValues.Size = new Size(316, 552);
            panelFuncValues.TabIndex = 1;
            // 
            // groupBoxFuncValues
            // 
            groupBoxFuncValues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxFuncValues.AutoSize = true;
            groupBoxFuncValues.Controls.Add(textBoxFuncValues);
            groupBoxFuncValues.Location = new Point(12, 6);
            groupBoxFuncValues.Name = "groupBoxFuncValues";
            groupBoxFuncValues.Size = new Size(298, 534);
            groupBoxFuncValues.TabIndex = 0;
            groupBoxFuncValues.TabStop = false;
            groupBoxFuncValues.Text = "Вывод:";
            // 
            // textBoxFuncValues
            // 
            textBoxFuncValues.BackColor = SystemColors.Window;
            textBoxFuncValues.Dock = DockStyle.Fill;
            textBoxFuncValues.Location = new Point(3, 19);
            textBoxFuncValues.Multiline = true;
            textBoxFuncValues.Name = "textBoxFuncValues";
            textBoxFuncValues.ReadOnly = true;
            textBoxFuncValues.ScrollBars = ScrollBars.Vertical;
            textBoxFuncValues.Size = new Size(292, 512);
            textBoxFuncValues.TabIndex = 0;
            textBoxFuncValues.TabStop = false;
            // 
            // panelFunction
            // 
            panelFunction.Controls.Add(chartFunction);
            panelFunction.Dock = DockStyle.Fill;
            panelFunction.Location = new Point(316, 109);
            panelFunction.Name = "panelFunction";
            panelFunction.Size = new Size(868, 552);
            panelFunction.TabIndex = 2;
            // 
            // chartFunction
            // 
            chartFunction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(6, 9);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(850, 531);
            chartFunction.TabIndex = 2;
            chartFunction.TabStop = false;
            chartFunction.Text = "График";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(316, 109);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(8, 552);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 661);
            Controls.Add(splitter1);
            Controls.Add(panelFunction);
            Controls.Add(panelFuncValues);
            Controls.Add(panelInfo);
            MinimumSize = new Size(1200, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            panelInfo.ResumeLayout(false);
            groupBoxInPut.ResumeLayout(false);
            groupBoxInPut.PerformLayout();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunc).EndInit();
            panelFuncValues.ResumeLayout(false);
            panelFuncValues.PerformLayout();
            groupBoxFuncValues.ResumeLayout(false);
            groupBoxFuncValues.PerformLayout();
            panelFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Panel panelFuncValues;
        private Panel panelFunction;
        private GroupBox groupBoxInfo;
        private TextBox textBoxInfo;
        private PictureBox pictureBoxFunc;
        private GroupBox groupBoxInPut;
        private TextBox textBoxStopInfo;
        private TextBox textBoxStartInfo;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonInfo;
        private Button buttonSave;
        private Button buttonDone;
        private GroupBox groupBoxFuncValues;
        private TextBox textBoxFuncValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Splitter splitter1;
    }
}
