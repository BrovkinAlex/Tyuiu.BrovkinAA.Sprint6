namespace Tyuiu.BrovkinAA.Sprint6.Task1.V24
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
            groupBoxInfo = new GroupBox();
            pictureBoxInfo = new PictureBox();
            textBoxInfo = new TextBox();
            groupBoxVariables = new GroupBox();
            textBoxStopValueInfo = new TextBox();
            textBoxStartValueInfo = new TextBox();
            textBoxStopValue = new TextBox();
            textBoxStartValue = new TextBox();
            groupBoxOutPut = new GroupBox();
            textBoxOutPut = new TextBox();
            textBoxResultInfo = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).BeginInit();
            groupBoxVariables.SuspendLayout();
            groupBoxOutPut.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(pictureBoxInfo);
            groupBoxInfo.Controls.Add(textBoxInfo);
            groupBoxInfo.Font = new Font("Segoe UI", 9F);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(559, 338);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Условие";
            // 
            // pictureBoxInfo
            // 
            pictureBoxInfo.Image = Properties.Resources.FormulaTask1;
            pictureBoxInfo.InitialImage = null;
            pictureBoxInfo.Location = new Point(6, 113);
            pictureBoxInfo.Name = "pictureBoxInfo";
            pictureBoxInfo.Size = new Size(301, 38);
            pictureBoxInfo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxInfo.TabIndex = 1;
            pictureBoxInfo.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.BackColor = SystemColors.Control;
            textBoxInfo.BorderStyle = BorderStyle.None;
            textBoxInfo.CausesValidation = false;
            textBoxInfo.Font = new Font("Times New Roman", 12F);
            textBoxInfo.Location = new Point(6, 25);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(547, 82);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // groupBoxVariables
            // 
            groupBoxVariables.Controls.Add(textBoxStopValueInfo);
            groupBoxVariables.Controls.Add(textBoxStartValueInfo);
            groupBoxVariables.Controls.Add(textBoxStopValue);
            groupBoxVariables.Controls.Add(textBoxStartValue);
            groupBoxVariables.Location = new Point(18, 356);
            groupBoxVariables.Name = "groupBoxVariables";
            groupBoxVariables.Size = new Size(301, 82);
            groupBoxVariables.TabIndex = 1;
            groupBoxVariables.TabStop = false;
            groupBoxVariables.Text = "Значения";
            // 
            // textBoxStopValueInfo
            // 
            textBoxStopValueInfo.BackColor = SystemColors.Control;
            textBoxStopValueInfo.BorderStyle = BorderStyle.None;
            textBoxStopValueInfo.Location = new Point(181, 22);
            textBoxStopValueInfo.Name = "textBoxStopValueInfo";
            textBoxStopValueInfo.ReadOnly = true;
            textBoxStopValueInfo.Size = new Size(100, 16);
            textBoxStopValueInfo.TabIndex = 3;
            textBoxStopValueInfo.TabStop = false;
            textBoxStopValueInfo.Text = "Конец шага:";
            // 
            // textBoxStartValueInfo
            // 
            textBoxStartValueInfo.BackColor = SystemColors.Control;
            textBoxStartValueInfo.BorderStyle = BorderStyle.None;
            textBoxStartValueInfo.Location = new Point(22, 22);
            textBoxStartValueInfo.Name = "textBoxStartValueInfo";
            textBoxStartValueInfo.ReadOnly = true;
            textBoxStartValueInfo.Size = new Size(100, 16);
            textBoxStartValueInfo.TabIndex = 2;
            textBoxStartValueInfo.TabStop = false;
            textBoxStartValueInfo.Text = "Старт шага:";
            textBoxStartValueInfo.TextChanged += textBox1_TextChanged;
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.BorderStyle = BorderStyle.FixedSingle;
            textBoxStopValue.Location = new Point(181, 44);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(100, 23);
            textBoxStopValue.TabIndex = 1;
            textBoxStopValue.Text = "5";
            textBoxStopValue.MouseEnter += textBoxStopValue_Enter;
            textBoxStopValue.MouseLeave += textBoxStopValue_Leave;
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.BorderStyle = BorderStyle.FixedSingle;
            textBoxStartValue.Location = new Point(22, 44);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(100, 23);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.Text = "-5";
            textBoxStartValue.MouseEnter += textBoxStartValue_Enter;
            textBoxStartValue.MouseLeave += textBoxStartValue_Leave;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(textBoxOutPut);
            groupBoxOutPut.Controls.Add(textBoxResultInfo);
            groupBoxOutPut.Location = new Point(577, 12);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(295, 426);
            groupBoxOutPut.TabIndex = 2;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод данных";
            // 
            // textBoxOutPut
            // 
            textBoxOutPut.BackColor = SystemColors.ControlLight;
            textBoxOutPut.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutPut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxOutPut.Location = new Point(6, 39);
            textBoxOutPut.Multiline = true;
            textBoxOutPut.Name = "textBoxOutPut";
            textBoxOutPut.ReadOnly = true;
            textBoxOutPut.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut.Size = new Size(283, 372);
            textBoxOutPut.TabIndex = 1;
            textBoxOutPut.TabStop = false;
            // 
            // textBoxResultInfo
            // 
            textBoxResultInfo.BackColor = SystemColors.Control;
            textBoxResultInfo.BorderStyle = BorderStyle.None;
            textBoxResultInfo.Location = new Point(11, 17);
            textBoxResultInfo.Name = "textBoxResultInfo";
            textBoxResultInfo.ReadOnly = true;
            textBoxResultInfo.Size = new Size(100, 16);
            textBoxResultInfo.TabIndex = 0;
            textBoxResultInfo.TabStop = false;
            textBoxResultInfo.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Cyan;
            buttonHelp.CausesValidation = false;
            buttonHelp.Location = new Point(325, 363);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(96, 75);
            buttonHelp.TabIndex = 3;
            buttonHelp.TabStop = false;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Font = new Font("Segoe UI", 10F);
            buttonDone.Location = new Point(427, 363);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(138, 75);
            buttonDone.TabIndex = 4;
            buttonDone.TabStop = false;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutPut);
            Controls.Add(groupBoxVariables);
            Controls.Add(groupBoxInfo);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 24 | Бровкин А.А.";
            Load += Form1_Load;
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).EndInit();
            groupBoxVariables.ResumeLayout(false);
            groupBoxVariables.PerformLayout();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo;
        private TextBox textBoxInfo;
        private PictureBox pictureBoxInfo;
        private GroupBox groupBoxVariables;
        private TextBox textBoxStartValue;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValueInfo;
        private TextBox textBoxStopValueInfo;
        private GroupBox groupBoxOutPut;
        private TextBox textBoxOutPut;
        private TextBox textBoxResultInfo;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
