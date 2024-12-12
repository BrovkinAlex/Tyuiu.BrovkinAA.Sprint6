namespace Tyuiu.BrovkinAA.Sprint6.Task7.V12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons = new Panel();
            buttonSaveInFile = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            buttonLoadFromFile = new Button();
            panel2 = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            toolTipOptionalInfo = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            panelInPutData = new Panel();
            groupBoxInPutData = new GroupBox();
            dataGridViewInPut = new DataGridView();
            panelOuPutData = new Panel();
            groupBoxOutPutData = new GroupBox();
            dataGridViewOutPut = new DataGridView();
            splitterBetweenTwoPanels = new Splitter();
            saveFileDialogMatrix = new SaveFileDialog();
            panelButtons.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelInPutData.SuspendLayout();
            groupBoxInPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).BeginInit();
            panelOuPutData.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BorderStyle = BorderStyle.Fixed3D;
            panelButtons.Controls.Add(buttonSaveInFile);
            panelButtons.Controls.Add(buttonDone);
            panelButtons.Controls.Add(buttonInfo);
            panelButtons.Controls.Add(buttonLoadFromFile);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1184, 80);
            panelButtons.TabIndex = 0;
            // 
            // buttonSaveInFile
            // 
            buttonSaveInFile.BackgroundImageLayout = ImageLayout.None;
            buttonSaveInFile.Enabled = false;
            buttonSaveInFile.Image = (Image)resources.GetObject("buttonSaveInFile.Image");
            buttonSaveInFile.Location = new Point(202, 10);
            buttonSaveInFile.Name = "buttonSaveInFile";
            buttonSaveInFile.Size = new Size(90, 62);
            buttonSaveInFile.TabIndex = 0;
            buttonSaveInFile.TabStop = false;
            toolTipOptionalInfo.SetToolTip(buttonSaveInFile, "Сохранить\r\nНажмите чтобы сохранить результат в файл");
            buttonSaveInFile.UseVisualStyleBackColor = true;
            buttonSaveInFile.Click += buttonSaveInFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImageLayout = ImageLayout.None;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(106, 10);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(90, 62);
            buttonDone.TabIndex = 0;
            buttonDone.TabStop = false;
            toolTipOptionalInfo.SetToolTip(buttonDone, "Выполнить\r\nНажмите чтобы произвести действия над данными");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackgroundImageLayout = ImageLayout.None;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(1080, 10);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(90, 62);
            buttonInfo.TabIndex = 0;
            buttonInfo.TabStop = false;
            toolTipOptionalInfo.SetToolTip(buttonInfo, "Справка\r\nНажмите чтобы получить информцию о программе");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonLoadFromFile
            // 
            buttonLoadFromFile.BackgroundImageLayout = ImageLayout.None;
            buttonLoadFromFile.Image = (Image)resources.GetObject("buttonLoadFromFile.Image");
            buttonLoadFromFile.Location = new Point(10, 10);
            buttonLoadFromFile.Name = "buttonLoadFromFile";
            buttonLoadFromFile.Size = new Size(90, 62);
            buttonLoadFromFile.TabIndex = 0;
            buttonLoadFromFile.TabStop = false;
            toolTipOptionalInfo.SetToolTip(buttonLoadFromFile, "Загрузить файл\r\nНажмите чтобы загрузить данные из файла");
            buttonLoadFromFile.UseVisualStyleBackColor = true;
            buttonLoadFromFile.Click += buttonLoadFromFile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 80);
            panel2.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask.AutoSize = true;
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 6);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1160, 71);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1154, 49);
            textBoxTask.TabIndex = 0;
            textBoxTask.TabStop = false;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // toolTipOptionalInfo
            // 
            toolTipOptionalInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipOptionalInfo.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // panelInPutData
            // 
            panelInPutData.Controls.Add(groupBoxInPutData);
            panelInPutData.Dock = DockStyle.Left;
            panelInPutData.Location = new Point(0, 160);
            panelInPutData.Name = "panelInPutData";
            panelInPutData.Size = new Size(511, 501);
            panelInPutData.TabIndex = 1;
            // 
            // groupBoxInPutData
            // 
            groupBoxInPutData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInPutData.AutoSize = true;
            groupBoxInPutData.Controls.Add(dataGridViewInPut);
            groupBoxInPutData.Location = new Point(15, 6);
            groupBoxInPutData.Name = "groupBoxInPutData";
            groupBoxInPutData.Size = new Size(490, 483);
            groupBoxInPutData.TabIndex = 1;
            groupBoxInPutData.TabStop = false;
            groupBoxInPutData.Text = "Ввод:";
            // 
            // dataGridViewInPut
            // 
            dataGridViewInPut.AllowUserToAddRows = false;
            dataGridViewInPut.AllowUserToDeleteRows = false;
            dataGridViewInPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut.Dock = DockStyle.Fill;
            dataGridViewInPut.Location = new Point(3, 19);
            dataGridViewInPut.Name = "dataGridViewInPut";
            dataGridViewInPut.ReadOnly = true;
            dataGridViewInPut.Size = new Size(484, 461);
            dataGridViewInPut.TabIndex = 0;
            // 
            // panelOuPutData
            // 
            panelOuPutData.Controls.Add(groupBoxOutPutData);
            panelOuPutData.Dock = DockStyle.Fill;
            panelOuPutData.Location = new Point(511, 160);
            panelOuPutData.Name = "panelOuPutData";
            panelOuPutData.Size = new Size(673, 501);
            panelOuPutData.TabIndex = 2;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutPutData.AutoSize = true;
            groupBoxOutPutData.Controls.Add(dataGridViewOutPut);
            groupBoxOutPutData.Location = new Point(9, 6);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(652, 483);
            groupBoxOutPutData.TabIndex = 0;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Вывод:";
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.AllowUserToAddRows = false;
            dataGridViewOutPut.AllowUserToDeleteRows = false;
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Dock = DockStyle.Fill;
            dataGridViewOutPut.Location = new Point(3, 19);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.ReadOnly = true;
            dataGridViewOutPut.Size = new Size(646, 461);
            dataGridViewOutPut.TabIndex = 0;
            // 
            // splitterBetweenTwoPanels
            // 
            splitterBetweenTwoPanels.Location = new Point(511, 160);
            splitterBetweenTwoPanels.Name = "splitterBetweenTwoPanels";
            splitterBetweenTwoPanels.Size = new Size(3, 501);
            splitterBetweenTwoPanels.TabIndex = 3;
            splitterBetweenTwoPanels.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(splitterBetweenTwoPanels);
            Controls.Add(panelOuPutData);
            Controls.Add(panelInPutData);
            Controls.Add(panel2);
            Controls.Add(panelButtons);
            MinimumSize = new Size(1200, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | таск 7 | Вариант 12 | Бровкин А.А.";
            panelButtons.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelInPutData.ResumeLayout(false);
            panelInPutData.PerformLayout();
            groupBoxInPutData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).EndInit();
            panelOuPutData.ResumeLayout(false);
            panelOuPutData.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Panel panel2;
        private Button buttonLoadFromFile;
        private ToolTip toolTipOptionalInfo;
        private OpenFileDialog openFileDialogTask;
        private Button buttonDone;
        private Button buttonSaveInFile;
        private Button buttonInfo;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panelInPutData;
        private Panel panelOuPutData;
        private GroupBox groupBoxInPutData;
        private GroupBox groupBoxOutPutData;
        private Splitter splitterBetweenTwoPanels;
        private DataGridView dataGridViewInPut;
        private DataGridView dataGridViewOutPut;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
