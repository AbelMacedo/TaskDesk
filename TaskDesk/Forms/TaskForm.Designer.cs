namespace TaskDesk.Forms
{
    partial class TaskForm
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
            button1 = new Button();
            dtpDueDate = new DateTimePicker();
            lblDueDate = new Label();
            cmbPriority = new ComboBox();
            lblPriority = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtTitle = new TextBox();
            lblTitleTask = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtpDueDate);
            panel1.Controls.Add(lblDueDate);
            panel1.Controls.Add(cmbPriority);
            panel1.Controls.Add(lblPriority);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblTitleTask);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(525, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 899);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(107, 606);
            button1.Name = "button1";
            button1.Size = new Size(509, 87);
            button1.TabIndex = 9;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(19, 457);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(695, 31);
            dtpDueDate.TabIndex = 8;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(19, 415);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(308, 35);
            lblDueDate.TabIndex = 7;
            lblDueDate.Text = "Fecha de vencimiento:";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(19, 350);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(695, 33);
            cmbPriority.TabIndex = 6;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(19, 312);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(149, 35);
            lblPriority.TabIndex = 5;
            lblPriority.Text = "Prioridad:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(19, 252);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(695, 31);
            txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(19, 214);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(325, 35);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Descripción de la tarea:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(19, 156);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(695, 31);
            txtTitle.TabIndex = 2;
            // 
            // lblTitleTask
            // 
            lblTitleTask.AutoSize = true;
            lblTitleTask.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleTask.Location = new Point(19, 117);
            lblTitleTask.Name = "lblTitleTask";
            lblTitleTask.Size = new Size(252, 35);
            lblTitleTask.TabIndex = 1;
            lblTitleTask.Text = "Titulo de la tarea: ";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Constantia", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(107, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(531, 66);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registro de tareas";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 944);
            Controls.Add(panel1);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitleTask;
        private Label lblTitle;
        private DateTimePicker dtpDueDate;
        private Label lblDueDate;
        private ComboBox cmbPriority;
        private Label lblPriority;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtTitle;
        private Button button1;
    }
}