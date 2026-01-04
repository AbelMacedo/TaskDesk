namespace TaskDesk.Forms
{
    partial class MainForm
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
            lblknProfile = new LinkLabel();
            btnLogout = new Button();
            lblProfile = new Label();
            lblEmail = new Label();
            lblknCompletedTasks = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblnkIncompleteTasks = new LinkLabel();
            lblMain = new Label();
            lblWelcome = new Label();
            label1 = new Label();
            dgvIncompleteTasks = new DataGridView();
            pbNewTask = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIncompleteTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewTask).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblknProfile);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblProfile);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblknCompletedTasks);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblnkIncompleteTasks);
            panel1.Controls.Add(lblMain);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 942);
            panel1.TabIndex = 0;
            // 
            // lblknProfile
            // 
            lblknProfile.AutoSize = true;
            lblknProfile.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblknProfile.Location = new Point(10, 451);
            lblknProfile.Name = "lblknProfile";
            lblknProfile.Size = new Size(103, 29);
            lblknProfile.TabIndex = 5;
            lblknProfile.TabStop = true;
            lblknProfile.Text = "Mi perfil";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(20, 847);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(343, 75);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblProfile
            // 
            lblProfile.BackColor = Color.Gray;
            lblProfile.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.Location = new Point(0, 410);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(390, 37);
            lblProfile.TabIndex = 4;
            lblProfile.Text = "Perfil";
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(224, 224, 224);
            lblEmail.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(1, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(389, 39);
            lblEmail.TabIndex = 1;
            lblEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblknCompletedTasks
            // 
            lblknCompletedTasks.AutoSize = true;
            lblknCompletedTasks.Font = new Font("Constantia", 12F);
            lblknCompletedTasks.Location = new Point(10, 365);
            lblknCompletedTasks.Name = "lblknCompletedTasks";
            lblknCompletedTasks.Size = new Size(219, 29);
            lblknCompletedTasks.TabIndex = 3;
            lblknCompletedTasks.TabStop = true;
            lblknCompletedTasks.Text = "Tareas completadas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = Properties.Resources.foto_usuario;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblnkIncompleteTasks
            // 
            lblnkIncompleteTasks.AutoSize = true;
            lblnkIncompleteTasks.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnkIncompleteTasks.Location = new Point(10, 320);
            lblnkIncompleteTasks.Name = "lblnkIncompleteTasks";
            lblnkIncompleteTasks.Size = new Size(73, 29);
            lblnkIncompleteTasks.TabIndex = 1;
            lblnkIncompleteTasks.TabStop = true;
            lblnkIncompleteTasks.Text = "Inicio";
            // 
            // lblMain
            // 
            lblMain.BackColor = Color.Gray;
            lblMain.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(0, 270);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(390, 33);
            lblMain.TabIndex = 2;
            lblMain.Text = "Principal";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Constantia", 28F, FontStyle.Bold);
            lblWelcome.Location = new Point(406, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1241, 90);
            lblWelcome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 118);
            label1.Name = "label1";
            label1.Size = new Size(302, 35);
            label1.TabIndex = 2;
            label1.Text = "TAREAS PENDIENTES";
            // 
            // dgvIncompleteTasks
            // 
            dgvIncompleteTasks.AllowUserToAddRows = false;
            dgvIncompleteTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIncompleteTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncompleteTasks.Location = new Point(406, 170);
            dgvIncompleteTasks.Name = "dgvIncompleteTasks";
            dgvIncompleteTasks.ReadOnly = true;
            dgvIncompleteTasks.RowHeadersWidth = 62;
            dgvIncompleteTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIncompleteTasks.Size = new Size(1337, 225);
            dgvIncompleteTasks.TabIndex = 3;
            dgvIncompleteTasks.CellDoubleClick += dgvIncompleteTasks_CellDoubleClick;
            // 
            // pbNewTask
            // 
            pbNewTask.Image = Properties.Resources.addTask;
            pbNewTask.Location = new Point(1653, 18);
            pbNewTask.Name = "pbNewTask";
            pbNewTask.Size = new Size(90, 90);
            pbNewTask.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewTask.TabIndex = 4;
            pbNewTask.TabStop = false;
            pbNewTask.Click += pbNewTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1778, 944);
            Controls.Add(pbNewTask);
            Controls.Add(dgvIncompleteTasks);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIncompleteTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblEmail;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Label lblMain;
        private LinkLabel lblnkIncompleteTasks;
        private LinkLabel lblknCompletedTasks;
        private Label lblProfile;
        private LinkLabel lblknProfile;
        private Label lblWelcome;
        private Label label1;
        private DataGridView dgvIncompleteTasks;
        private PictureBox pbNewTask;
    }
}