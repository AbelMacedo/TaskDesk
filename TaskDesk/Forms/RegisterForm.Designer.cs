namespace TaskDesk.Forms
{
    partial class RegisterForm
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
            lblEmail = new Label();
            lblPassword = new Label();
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lnkBack = new LinkLabel();
            lblConfirmLabel = new Label();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 9);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(157, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Correo electrónico";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 71);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 199);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(225, 34);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Registrarme";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(225, 31);
            txtPassword.TabIndex = 4;
            // 
            // lnkBack
            // 
            lnkBack.AutoSize = true;
            lnkBack.Location = new Point(75, 236);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(80, 25);
            lnkBack.TabIndex = 5;
            lnkBack.TabStop = true;
            lnkBack.Text = "Regresar";
            lnkBack.LinkClicked += linkLogin_LinkClicked;
            // 
            // lblConfirmLabel
            // 
            lblConfirmLabel.AutoSize = true;
            lblConfirmLabel.Location = new Point(12, 133);
            lblConfirmLabel.Name = "lblConfirmLabel";
            lblConfirmLabel.Size = new Size(182, 25);
            lblConfirmLabel.TabIndex = 6;
            lblConfirmLabel.Text = "Confirmar contraseña";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(12, 161);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(225, 31);
            txtConfirmPassword.TabIndex = 7;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmLabel);
            Controls.Add(lnkBack);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private LinkLabel lnkBack;
        private Label lblConfirmLabel;
        private TextBox txtConfirmPassword;
    }
}