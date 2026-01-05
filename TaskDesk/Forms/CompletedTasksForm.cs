using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskDesk.Models;
using TaskDesk.Repositories;

namespace TaskDesk.Forms
{
    public partial class CompletedTasksForm : Form
    {
        private readonly User _user;
        private readonly TaskRepository _taskRepository;
        private BindingList<TaskItem> _tasks;
        public CompletedTasksForm(User user)
        {
            InitializeComponent();
            _user = user;
            _taskRepository = new TaskRepository();
        }

        private async void CompletedTasks_Load(object sender, EventArgs e)
        {
            await LoadTaskAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCompletedTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una tarea primero");
                return;
            }

            var task = (TaskItem)dgvCompletedTasks.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show($"¿Esta seguro de eliminar la tarea \"{task.Title}\" ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            await _taskRepository.DeleteAsync(task.Id);
            await LoadTaskAsync();
        }

        private async void btnIncompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvCompletedTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una tarea primero");
                return;
            }

            var task = (TaskItem)dgvCompletedTasks.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show($"¿Marcar la tarea \"{task.Title}\" como incompleta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            await _taskRepository.MarkAsIncompleteAsync(task.Id);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async Task LoadTaskAsync()
        {
            var tasks = await _taskRepository.GetCompletedTasksAsync(_user.Id);
            _tasks = new BindingList<TaskItem>(tasks);
            dgvCompletedTasks.DataSource = tasks;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvCompletedTasks.ReadOnly = true;
            dgvCompletedTasks.AllowUserToAddRows = false;
            dgvCompletedTasks.AllowUserToDeleteRows = false;
            dgvCompletedTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompletedTasks.MultiSelect = false;

            dgvCompletedTasks.Columns["Id"].Visible = false;
            dgvCompletedTasks.Columns["UserId"].Visible = false;
            dgvCompletedTasks.Columns["Title"].HeaderText = "Título";
            dgvCompletedTasks.Columns["Description"].HeaderText = "Descripción";
            dgvCompletedTasks.Columns["Priority"].HeaderText = "Prioridad";
            dgvCompletedTasks.Columns["DueDate"].HeaderText = "Fecha de Vencimiento";
            dgvCompletedTasks.Columns["Completed"].Visible = false;

            dgvCompletedTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
