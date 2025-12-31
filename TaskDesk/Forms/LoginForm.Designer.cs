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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblSinCuenta = new Label();
            lblInstrucciones = new Label();
            lblheader = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(38, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(651, 31);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(38, 370);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(651, 31);
            txtPassword.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(38, 206);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(651, 38);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Correo electrónico:";
            lblEmail.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(38, 323);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(651, 33);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gray;
            btnLogin.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(38, 437);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(651, 73);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Constantia", 12F);
            lnkRegister.Location = new Point(294, 583);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(140, 29);
            lnkRegister.TabIndex = 5;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Registrarme";
            lnkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tasks;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(lblSinCuenta);
            panel1.Controls.Add(lblInstrucciones);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblheader);
            panel1.Controls.Add(lnkRegister);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(961, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 704);
            panel1.TabIndex = 7;
            // 
            // lblSinCuenta
            // 
            lblSinCuenta.AutoSize = true;
            lblSinCuenta.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinCuenta.Location = new Point(222, 543);
            lblSinCuenta.Name = "lblSinCuenta";
            lblSinCuenta.Size = new Size(272, 29);
            lblSinCuenta.TabIndex = 7;
            lblSinCuenta.Text = "¿Aun no tienes cuenta?";
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Constantia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstrucciones.Location = new Point(47, 139);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(642, 35);
            lblInstrucciones.TabIndex = 6;
            lblInstrucciones.Text = "Antes de continuar por favor ingresa tus credenciales";
            lblInstrucciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblheader
            // 
            lblheader.BackColor = Color.Transparent;
            lblheader.Font = new Font("Britannic Bold", 36F);
            lblheader.Location = new Point(38, 35);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(651, 71);
            lblheader.TabIndex = 3;
            lblheader.Text = "Inicio de sesión";
            lblheader.TextAlign = ContentAlignment.MiddleCenter;
            lblheader.Click += lblheader_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1778, 944);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblheader;
        private Label lblInstrucciones;
        private Label lblSinCuenta;
    }
}