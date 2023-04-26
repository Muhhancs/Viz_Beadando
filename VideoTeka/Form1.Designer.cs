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
            userText = new TextBox();
            pwdText = new TextBox();
            loginBtn = new Button();
            errorMsg = new Label();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            userText.BackColor = SystemColors.Window;
            userText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            userText.Location = new Point(315, 182);
            userText.MaxLength = 100;
            userText.MinimumSize = new Size(500, 50);
            userText.Name = "userText";
            userText.PlaceholderText = "Username or Email";
            userText.Size = new Size(500, 50);
            userText.TabIndex = 0;
            // 
            // pwdText
            // 
            pwdText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            pwdText.Location = new Point(318, 273);
            pwdText.MaxLength = 50;
            pwdText.MinimumSize = new Size(500, 50);
            pwdText.Name = "pwdText";
            pwdText.PlaceholderText = "Password";
            pwdText.Size = new Size(500, 50);
            pwdText.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(403, 376);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(312, 58);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.Location = new Point(521, 124);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(38, 15);
            errorMsg.TabIndex = 3;
            errorMsg.Text = "label1";
            errorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1145, 439);
            Controls.Add(errorMsg);
            Controls.Add(loginBtn);
            Controls.Add(pwdText);
            Controls.Add(userText);
            Name = "Form1";
            Text = "VideoTeka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userText;
        private TextBox pwdText;
        private Button loginBtn;
        private Label errorMsg;
    }
}