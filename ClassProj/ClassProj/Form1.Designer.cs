namespace ClassProj
{
    partial class Form1
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
            this.getValue = new System.Windows.Forms.Button();
            this.setValue = new System.Windows.Forms.Button();
            this.txtEmployeeid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getValue
            // 
            this.getValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getValue.Location = new System.Drawing.Point(152, 70);
            this.getValue.Name = "getValue";
            this.getValue.Size = new System.Drawing.Size(99, 36);
            this.getValue.TabIndex = 0;
            this.getValue.Text = "Get";
            this.getValue.UseVisualStyleBackColor = true;
            // 
            // setValue
            // 
            this.setValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setValue.Location = new System.Drawing.Point(327, 70);
            this.setValue.Name = "setValue";
            this.setValue.Size = new System.Drawing.Size(99, 36);
            this.setValue.TabIndex = 1;
            this.setValue.Text = "Set";
            this.setValue.UseVisualStyleBackColor = true;
            this.setValue.Click += new System.EventHandler(this.setValue_Click);
            // 
            // txtEmployeeid
            // 
            this.txtEmployeeid.Location = new System.Drawing.Point(193, 165);
            this.txtEmployeeid.Name = "txtEmployeeid";
            this.txtEmployeeid.Size = new System.Drawing.Size(169, 20);
            this.txtEmployeeid.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 191);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(193, 217);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(169, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(482, 70);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(99, 36);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "Send";
            this.txtSend.UseVisualStyleBackColor = true;
            this.txtSend.Click += new System.EventHandler(this.txtSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployeeid);
            this.Controls.Add(this.setValue);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.getValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getValue;
        private System.Windows.Forms.Button setValue;
        private System.Windows.Forms.TextBox txtEmployeeid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button txtSend;
    }
}

