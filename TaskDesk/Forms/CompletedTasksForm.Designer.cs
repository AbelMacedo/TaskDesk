namespace TaskDesk.Forms
{
    partial class CompletedTasksForm
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
            lblTitle = new Label();
            dgvCompletedTasks = new DataGridView();
            btnDelete = new Button();
            btnIncompleteTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompletedTasks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Constantia", 36F, FontStyle.Bold);
            lblTitle.Location = new Point(32, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(706, 88);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tareas completadas";
            // 
            // dgvCompletedTasks
            // 
            dgvCompletedTasks.AllowUserToAddRows = false;
            dgvCompletedTasks.AllowUserToDeleteRows = false;
            dgvCompletedTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompletedTasks.Location = new Point(32, 136);
            dgvCompletedTasks.MultiSelect = false;
            dgvCompletedTasks.Name = "dgvCompletedTasks";
            dgvCompletedTasks.ReadOnly = true;
            dgvCompletedTasks.RowHeadersWidth = 62;
            dgvCompletedTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompletedTasks.Size = new Size(1705, 657);
            dgvCompletedTasks.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1059, 838);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(256, 73);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnIncompleteTask
            // 
            btnIncompleteTask.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncompleteTask.Location = new Point(1360, 836);
            btnIncompleteTask.Name = "btnIncompleteTask";
            btnIncompleteTask.Size = new Size(377, 73);
            btnIncompleteTask.TabIndex = 3;
            btnIncompleteTask.Text = "Marcar como incompleta";
            btnIncompleteTask.UseVisualStyleBackColor = true;
            btnIncompleteTask.Click += btnIncompleteTask_Click;
            // 
            // CompletedTasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 944);
            Controls.Add(btnIncompleteTask);
            Controls.Add(btnDelete);
            Controls.Add(dgvCompletedTasks);
            Controls.Add(lblTitle);
            Name = "CompletedTasks";
            Text = "CompletedTasks";
            Load += CompletedTasks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompletedTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCompletedTasks;
        private Button btnDelete;
        private Button btnIncompleteTask;
    }
}