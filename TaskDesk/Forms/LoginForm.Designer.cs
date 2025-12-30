namespace TaskDesk.Forms
{
    partial class LoginForm
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 31);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 31);
            txtPassword.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 9);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(157, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Correo electrónico";
            lblEmail.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 157);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(97, 203);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(106, 25);
            lnkRegister.TabIndex = 5;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Registrarme";
            lnkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(lnkRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
    }
}