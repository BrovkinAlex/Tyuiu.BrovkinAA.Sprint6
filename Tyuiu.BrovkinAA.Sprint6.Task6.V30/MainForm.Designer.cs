namespace Tyuiu.BrovkinAA.Sprint6.Task6.V30
{
    partial class Form1
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
            buttonLoadFile = new Button();
            buttonDone = new Button();
            textBox1 = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipLoad = new ToolTip(components);
            buttonInfo = new Button();
            SuspendLayout();
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Location = new Point(121, 10);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(75, 66);
            buttonLoadFile.TabIndex = 0;
            buttonLoadFile.Text = "Загрузить";
            toolTipLoad.SetToolTip(buttonLoadFile, "Выберите файл");
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(281, 36);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(193, 40);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            toolTipLoad.SetToolTip(buttonDone, "Выполнить сложные вычисления");
            buttonDone.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 155);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(442, 239);
            textBox1.TabIndex = 2;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipLoad
            // 
            toolTipLoad.ToolTipIcon = ToolTipIcon.Info;
            toolTipLoad.ToolTipTitle = "Подсказка";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(655, 77);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(75, 44);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            toolTipLoad.SetToolTip(buttonInfo, "Получить справку");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo);
            Controls.Add(textBox1);
            Controls.Add(buttonDone);
            Controls.Add(buttonLoadFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoadFile;
        private Button buttonDone;
        private TextBox textBox1;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipLoad;
        private Button buttonInfo;
    }
}
