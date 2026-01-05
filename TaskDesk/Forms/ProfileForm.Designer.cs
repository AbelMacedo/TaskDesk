namespace TaskDesk.Forms
{
    partial class ProfileForm
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
            panel1 = new Panel();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblSurnames = new Label();
            txtSurnames = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSurnames);
            panel1.Controls.Add(lblSurnames);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(528, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 706);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Constantia", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(48, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(611, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Perfil de usuario";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(48, 152);
            lblName.Name = "lblName";
            lblName.Size = new Size(138, 35);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(48, 204);
            txtName.Name = "txtName";
            txtName.Size = new Size(611, 31);
            txtName.TabIndex = 2;
            // 
            // lblSurnames
            // 
            lblSurnames.AutoSize = true;
            lblSurnames.Font = new Font("Constantia", 14F, FontStyle.Bold);
            lblSurnames.Location = new Point(48, 271);
            lblSurnames.Name = "lblSurnames";
            lblSurnames.Size = new Size(155, 35);
            lblSurnames.TabIndex = 3;
            lblSurnames.Text = "Apellidos: ";
            // 
            // txtSurnames
            // 
            txtSurnames.Location = new Point(48, 320);
            txtSurnames.Name = "txtSurnames";
            txtSurnames.Size = new Size(611, 31);
            txtSurnames.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(206, 409);
            button1.Name = "button1";
            button1.Size = new Size(293, 81);
            button1.TabIndex = 5;
            button1.Text = "Actualizar perfil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += updateProfile_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 944);
            Controls.Add(panel1);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Label lblTitle;
        private TextBox txtName;
        private Button button1;
        private TextBox txtSurnames;
        private Label lblSurnames;
    }
}