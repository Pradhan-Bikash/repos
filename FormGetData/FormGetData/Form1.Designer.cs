namespace FormGetData
{
    partial class GetData
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
            Button button1;
            textName = new TextBox();
            textSurName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(262, 247);
            button1.Name = "button1";
            button1.Size = new Size(108, 30);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textName
            // 
            textName.Location = new Point(203, 65);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(227, 39);
            textName.TabIndex = 1;
            // 
            // textSurName
            // 
            textSurName.Location = new Point(203, 146);
            textSurName.Multiline = true;
            textSurName.Name = "textSurName";
            textSurName.Size = new Size(227, 39);
            textSurName.TabIndex = 2;
            // 
            // GetData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_20190808_170641;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(604, 329);
            Controls.Add(textSurName);
            Controls.Add(textName);
            Controls.Add(button1);
            Name = "GetData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textSurName;
    }
}