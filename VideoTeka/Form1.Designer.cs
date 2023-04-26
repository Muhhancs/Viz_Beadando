namespace VideoTeka
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
            this.userText = new System.Windows.Forms.TextBox();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userText.BackColor = System.Drawing.SystemColors.Window;
            this.userText.Font = new System.Drawing.Font("PanRoman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userText.Location = new System.Drawing.Point(315, 182);
            this.userText.MaxLength = 100;
            this.userText.MinimumSize = new System.Drawing.Size(500, 50);
            this.userText.Name = "userText";
            this.userText.PlaceholderText = "Username or Email";
            this.userText.Size = new System.Drawing.Size(500, 50);
            this.userText.TabIndex = 0;
            // 
            // pwdText
            // 
            this.pwdText.Font = new System.Drawing.Font("PanRoman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pwdText.Location = new System.Drawing.Point(318, 273);
            this.pwdText.MaxLength = 50;
            this.pwdText.MinimumSize = new System.Drawing.Size(500, 50);
            this.pwdText.Name = "pwdText";
            this.pwdText.PlaceholderText = "Password";
            this.pwdText.Size = new System.Drawing.Size(500, 50);
            this.pwdText.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("PanRoman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(403, 376);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(312, 58);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(521, 124);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(38, 15);
            this.errorMsg.TabIndex = 3;
            this.errorMsg.Text = "label1";
            this.errorMsg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1145, 639);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.userText);
            this.Name = "Form1";
            this.Text = "VideoTeka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userText;
        private TextBox pwdText;
        private Button loginBtn;
        private Label errorMsg;
    }
}