﻿namespace FormGetData
{
    partial class ShowData
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
            lblNameSurname = new Label();
            SuspendLayout();
            // 
            // lblNameSurname
            // 
            lblNameSurname.AutoSize = true;
            lblNameSurname.Location = new Point(176, 72);
            lblNameSurname.Name = "lblNameSurname";
            lblNameSurname.Size = new Size(38, 15);
            lblNameSurname.TabIndex = 0;
            lblNameSurname.Text = "label1";
            // 
            // ShowData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 232);
            Controls.Add(lblNameSurname);
            Name = "ShowData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblNameSurname;
    }
}