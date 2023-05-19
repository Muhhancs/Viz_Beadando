namespace VideoTeka
{
    partial class modify
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
            this.valueTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.uNameRBtn = new System.Windows.Forms.RadioButton();
            this.emailRBtn = new System.Windows.Forms.RadioButton();
            this.pwdRBtn = new System.Windows.Forms.RadioButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valueTB
            // 
            this.valueTB.Location = new System.Drawing.Point(295, 78);
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(124, 23);
            this.valueTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set value to:";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(6, 108);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(184, 24);
            this.uploadBtn.TabIndex = 3;
            this.uploadBtn.Text = "Update Data";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // uNameRBtn
            // 
            this.uNameRBtn.AutoSize = true;
            this.uNameRBtn.Location = new System.Drawing.Point(35, 28);
            this.uNameRBtn.Name = "uNameRBtn";
            this.uNameRBtn.Size = new System.Drawing.Size(78, 19);
            this.uNameRBtn.TabIndex = 5;
            this.uNameRBtn.TabStop = true;
            this.uNameRBtn.Text = "Username";
            this.uNameRBtn.UseVisualStyleBackColor = true;
            // 
            // emailRBtn
            // 
            this.emailRBtn.AutoSize = true;
            this.emailRBtn.Location = new System.Drawing.Point(35, 54);
            this.emailRBtn.Name = "emailRBtn";
            this.emailRBtn.Size = new System.Drawing.Size(54, 19);
            this.emailRBtn.TabIndex = 6;
            this.emailRBtn.TabStop = true;
            this.emailRBtn.Text = "Email";
            this.emailRBtn.UseVisualStyleBackColor = true;
            // 
            // pwdRBtn
            // 
            this.pwdRBtn.AutoSize = true;
            this.pwdRBtn.Location = new System.Drawing.Point(35, 80);
            this.pwdRBtn.Name = "pwdRBtn";
            this.pwdRBtn.Size = new System.Drawing.Size(75, 19);
            this.pwdRBtn.TabIndex = 7;
            this.pwdRBtn.TabStop = true;
            this.pwdRBtn.Text = "Password";
            this.pwdRBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(291, 162);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(128, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uNameRBtn);
            this.groupBox1.Controls.Add(this.emailRBtn);
            this.groupBox1.Controls.Add(this.uploadBtn);
            this.groupBox1.Controls.Add(this.pwdRBtn);
            this.groupBox1.Location = new System.Drawing.Point(53, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 138);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select What you want to change";
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 239);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox valueTB;
        private Label label1;
        private Button uploadBtn;
        private RadioButton uNameRBtn;
        private RadioButton emailRBtn;
        private RadioButton pwdRBtn;
        private Button backBtn;
        private GroupBox groupBox1;
    }
}