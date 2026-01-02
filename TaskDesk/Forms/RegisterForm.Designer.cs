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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtSurnames = new TextBox();
            lblSurnames = new Label();
            txtName = new TextBox();
            lblName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(44, 367);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(624, 39);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Correo electrónico:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(43, 458);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(175, 35);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gray;
            btnRegister.Font = new Font("Constantia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(44, 659);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(624, 62);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Registrarme";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 409);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(624, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(44, 496);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(624, 31);
            txtPassword.TabIndex = 4;
            // 
            // lnkBack
            // 
            lnkBack.AutoSize = true;
            lnkBack.Font = new Font("Constantia", 12F);
            lnkBack.Location = new Point(306, 786);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(104, 29);
            lnkBack.TabIndex = 5;
            lnkBack.TabStop = true;
            lnkBack.Text = "Regresar";
            lnkBack.LinkClicked += linkLogin_LinkClicked;
            // 
            // lblConfirmLabel
            // 
            lblConfirmLabel.AutoSize = true;
            lblConfirmLabel.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmLabel.Location = new Point(43, 548);
            lblConfirmLabel.Name = "lblConfirmLabel";
            lblConfirmLabel.Size = new Size(312, 35);
            lblConfirmLabel.TabIndex = 6;
            lblConfirmLabel.Text = "Confirmar contraseña:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(44, 586);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(624, 31);
            txtConfirmPassword.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tasks;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(txtSurnames);
            panel1.Controls.Add(lblSurnames);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lnkBack);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblConfirmLabel);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(970, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 881);
            panel1.TabIndex = 9;
            // 
            // txtSurnames
            // 
            txtSurnames.Location = new Point(43, 317);
            txtSurnames.Name = "txtSurnames";
            txtSurnames.Size = new Size(625, 31);
            txtSurnames.TabIndex = 14;
            // 
            // lblSurnames
            // 
            lblSurnames.AutoSize = true;
            lblSurnames.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSurnames.Location = new Point(44, 279);
            lblSurnames.Name = "lblSurnames";
            lblSurnames.Size = new Size(148, 35);
            lblSurnames.TabIndex = 13;
            lblSurnames.Text = "Apellidos:";
            // 
            // txtName
            // 
            txtName.Location = new Point(44, 227);
            txtName.Name = "txtName";
            txtName.Size = new Size(624, 31);
            txtName.TabIndex = 12;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(44, 189);
            lblName.Name = "lblName";
            lblName.Size = new Size(166, 35);
            lblName.TabIndex = 11;
            lblName.Text = "Nombre(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 748);
            label3.Name = "label3";
            label3.Size = new Size(309, 35);
            label3.TabIndex = 10;
            label3.Text = "¿Ya tienes una cuenta?";
            // 
            // label2
            // 
            label2.Font = new Font("Constantia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 129);
            label2.Name = "label2";
            label2.Size = new Size(636, 39);
            label2.TabIndex = 9;
            label2.Text = "Completa todo los campos solicitados";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Britannic Bold", 32F);
            label1.Location = new Point(45, 27);
            label1.Name = "label1";
            label1.Size = new Size(624, 80);
            label1.TabIndex = 8;
            label1.Text = "Registro de usuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1778, 944);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSurnames;
        private Label lblSurnames;
        private TextBox txtName;
        private Label lblName;
    }
}