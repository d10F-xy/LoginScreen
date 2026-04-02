namespace LoginScreen
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
            Title = new Label();
            loginIdBox = new TextBox();
            loginPwBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("맑은 고딕", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Title.Location = new Point(179, 58);
            Title.Name = "Title";
            Title.Size = new Size(151, 62);
            Title.TabIndex = 0;
            Title.Text = "Login";
            // 
            // loginIdBox
            // 
            loginIdBox.Font = new Font("맑은 고딕", 13F);
            loginIdBox.Location = new Point(104, 182);
            loginIdBox.Name = "loginIdBox";
            loginIdBox.Size = new Size(284, 31);
            loginIdBox.TabIndex = 1;
            // 
            // loginPwBox
            // 
            loginPwBox.Font = new Font("맑은 고딕", 13F);
            loginPwBox.Location = new Point(104, 264);
            loginPwBox.Name = "loginPwBox";
            loginPwBox.Size = new Size(284, 31);
            loginPwBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            loginButton.Location = new Point(179, 337);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(129, 39);
            loginButton.TabIndex = 2;
            loginButton.Text = "로그인";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(loginButton);
            Controls.Add(loginPwBox);
            Controls.Add(loginIdBox);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox loginIdBox;
        private TextBox loginPwBox;
        private Button loginButton;
    }
}
