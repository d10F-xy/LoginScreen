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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            loginInfoWrong = new Label();
            idLabel = new Label();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(179, 58);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(151, 62);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 13F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(104, 182);
            txtID.Name = "txtID";
            txtID.Size = new Size(284, 31);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 13F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(104, 249);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(284, 31);
            txtPW.TabIndex = 2;
            txtPW.Text = "비밀번호";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(179, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 39);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // loginInfoWrong
            // 
            loginInfoWrong.AutoSize = true;
            loginInfoWrong.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            loginInfoWrong.ForeColor = Color.Red;
            loginInfoWrong.Location = new Point(140, 294);
            loginInfoWrong.Name = "loginInfoWrong";
            loginInfoWrong.Size = new Size(218, 15);
            loginInfoWrong.TabIndex = 0;
            loginInfoWrong.Text = "아이디 혹은 비밀번호가 맞지 않습니다.";
            loginInfoWrong.Visible = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            idLabel.Location = new Point(104, 162);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(47, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "아이디";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            passwordLabel.Location = new Point(104, 229);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 17);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "비밀번호";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Controls.Add(loginInfoWrong);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label loginInfoWrong;
        private Label idLabel;
        private Label passwordLabel;
    }
}
