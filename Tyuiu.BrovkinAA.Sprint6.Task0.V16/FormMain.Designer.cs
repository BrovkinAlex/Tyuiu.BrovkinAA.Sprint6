namespace Tyuiu.BrovkinAA.Sprint6.Task0.V16
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
            pictureBoxFormula = new PictureBox();
            groupBoxMain = new GroupBox();
            textBoxUslovie = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxVarInfo = new TextBox();
            textBoxVariable = new TextBox();
            groupBoxOutput = new GroupBox();
            textBoxResultInfo = new TextBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxMain.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Anchor = AnchorStyles.None;
            pictureBoxFormula.Image = Properties.Resources.FormulaTask0;
            pictureBoxFormula.Location = new Point(623, 27);
            pictureBoxFormula.Margin = new Padding(5);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Padding = new Padding(5);
            pictureBoxFormula.Size = new Size(149, 84);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBoxFormula_Click;
            // 
            // groupBoxMain
            // 
            groupBoxMain.CausesValidation = false;
            groupBoxMain.Controls.Add(textBoxUslovie);
            groupBoxMain.Controls.Add(pictureBoxFormula);
            groupBoxMain.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxMain.Location = new Point(12, 12);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(776, 244);
            groupBoxMain.TabIndex = 2;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Условие";
            groupBoxMain.Enter += groupBox1_Enter;
            // 
            // textBoxUslovie
            // 
            textBoxUslovie.CausesValidation = false;
            textBoxUslovie.Location = new Point(6, 27);
            textBoxUslovie.Multiline = true;
            textBoxUslovie.Name = "textBoxUslovie";
            textBoxUslovie.ReadOnly = true;
            textBoxUslovie.Size = new Size(609, 203);
            textBoxUslovie.TabIndex = 1;
            textBoxUslovie.TabStop = false;
            textBoxUslovie.Text = "Вычислить выражение по формуле\r\n";
            textBoxUslovie.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxVarInfo);
            groupBoxInput.Controls.Add(textBoxVariable);
            groupBoxInput.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInput.Location = new Point(18, 262);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(367, 124);
            groupBoxInput.TabIndex = 3;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Введите данные";
            // 
            // textBoxVarInfo
            // 
            textBoxVarInfo.BackColor = SystemColors.ControlLight;
            textBoxVarInfo.BorderStyle = BorderStyle.None;
            textBoxVarInfo.CausesValidation = false;
            textBoxVarInfo.Font = new Font("Times New Roman", 11F);
            textBoxVarInfo.Location = new Point(124, 53);
            textBoxVarInfo.Name = "textBoxVarInfo";
            textBoxVarInfo.ReadOnly = true;
            textBoxVarInfo.Size = new Size(100, 17);
            textBoxVarInfo.TabIndex = 1;
            textBoxVarInfo.TabStop = false;
            textBoxVarInfo.Text = "Переменная Х:";
            // 
            // textBoxVariable
            // 
            textBoxVariable.AccessibleDescription = "";
            textBoxVariable.AccessibleName = "";
            textBoxVariable.Location = new Point(124, 76);
            textBoxVariable.Name = "textBoxVariable";
            textBoxVariable.Size = new Size(100, 26);
            textBoxVariable.TabIndex = 0;
            textBoxVariable.Tag = "";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.CausesValidation = false;
            groupBoxOutput.Controls.Add(textBoxResultInfo);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxOutput.Location = new Point(391, 262);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(397, 124);
            groupBoxOutput.TabIndex = 4;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxResultInfo
            // 
            textBoxResultInfo.BackColor = SystemColors.ControlLight;
            textBoxResultInfo.BorderStyle = BorderStyle.None;
            textBoxResultInfo.CausesValidation = false;
            textBoxResultInfo.Location = new Point(136, 51);
            textBoxResultInfo.Name = "textBoxResultInfo";
            textBoxResultInfo.Size = new Size(100, 19);
            textBoxResultInfo.TabIndex = 1;
            textBoxResultInfo.TabStop = false;
            textBoxResultInfo.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(136, 76);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 26);
            textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone.Location = new Point(391, 400);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 38);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonResult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxMain);
            ForeColor = SystemColors.ControlText;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 16 | Бровкин А.А.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxMain;
        private TextBox textBoxUslovie;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private TextBox textBoxVariable;
        private TextBox textBoxVarInfo;
        private Button buttonDone;
        private TextBox textBoxResultInfo;
        private TextBox textBoxResult;
    }
}
