namespace Tyuiu.BrovkinAA.Sprint6.Task7.V12
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAuthorInfo = new TextBox();
            pictureBoxPhoto = new PictureBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // textBoxAuthorInfo
            // 
            textBoxAuthorInfo.BorderStyle = BorderStyle.None;
            textBoxAuthorInfo.Location = new Point(137, 12);
            textBoxAuthorInfo.Multiline = true;
            textBoxAuthorInfo.Name = "textBoxAuthorInfo";
            textBoxAuthorInfo.ReadOnly = true;
            textBoxAuthorInfo.Size = new Size(308, 143);
            textBoxAuthorInfo.TabIndex = 0;
            textBoxAuthorInfo.TabStop = false;
            textBoxAuthorInfo.Text = resources.GetString("textBoxAuthorInfo.Text");
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxPhoto.Image = (Image)resources.GetObject("pictureBoxPhoto.Image");
            pictureBoxPhoto.Location = new Point(12, 12);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(119, 167);
            pictureBoxPhoto.TabIndex = 1;
            pictureBoxPhoto.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(395, 161);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(50, 23);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 191);
            Controls.Add(buttonOk);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(textBoxAuthorInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAuthorInfo;
        private PictureBox pictureBoxPhoto;
        private Button buttonOk;
    }
}