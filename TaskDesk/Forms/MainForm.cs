using Microsoft.Data.SqlClient;
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
    public partial class MainForm : Form
    {
        private readonly User _user;
        private readonly TaskRepository _taskRepository;
        private BindingList<TaskItem> _tasks;
        public event EventHandler? Logout;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            _taskRepository = new TaskRepository();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            lblEmail.Text = $"{_user.Email}";
            lblWelcome.Text = $"Bienvenido, {_user.Name} {_user.Surnames}!";

            await LoadTaskAsync();
        }

        private async Task LoadTaskAsync()
        {
            var tasks = await _taskRepository.GetAllByUserAsync(_user.Id);
            _tasks = new BindingList<TaskItem>(tasks);
            dgvIncompleteTasks.DataSource = tasks;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvIncompleteTasks.ReadOnly = true;
            dgvIncompleteTasks.AllowUserToAddRows = false;
            dgvIncompleteTasks.AllowUserToDeleteRows = false;
            dgvIncompleteTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIncompleteTasks.MultiSelect = false;

            dgvIncompleteTasks.Columns["Id"].Visible = false;
            dgvIncompleteTasks.Columns["UserId"].Visible = false;
            dgvIncompleteTasks.Columns["Title"].HeaderText = "Título";
            dgvIncompleteTasks.Columns["Description"].HeaderText = "Descripción";
            dgvIncompleteTasks.Columns["Priority"].HeaderText = "Prioridad";
            dgvIncompleteTasks.Columns["DueDate"].HeaderText = "Fecha de Vencimiento";
            dgvIncompleteTasks.Columns["Completed"].Visible = false;

            dgvIncompleteTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void pbNewTask_Click(object sender, EventArgs e)
        {
            var taskForm = new TaskForm(_user);
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                _ = LoadTaskAsync();
            }
        }

        private void dgvIncompleteTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var task = (TaskItem)dgvIncompleteTasks.Rows[e.RowIndex].DataBoundItem;

            var taskForm = new TaskForm(_user, task);
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                _ = LoadTaskAsync();
            }
        }

        private async void btnTaskCompleted_Click(object sender, EventArgs e)
        {
            if (dgvIncompleteTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una tarea primero");
                return;
            }

            var task = (TaskItem)dgvIncompleteTasks.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show($"¿Marcar la tarea \"{task.Title}\" como completada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            await _taskRepository.MarkAsCompletedAsync(task.Id);
            await LoadTaskAsync();
        }

        private void dgvIncompletedTask_SelectionChanged(Object sender, EventArgs e)
        {
            btnTaskCompleted.Enabled = dgvIncompleteTasks.SelectedRows.Count > 0;
            btnDeleteTask.Enabled = dgvIncompleteTasks.SelectedRows.Count > 0;
        }

        private async void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvIncompleteTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una tarea primero");
                return;
            }

            var task = (TaskItem)dgvIncompleteTasks.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show($"¿Esta seguro de eliminar la tarea \"{task.Title}\" ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            await _taskRepository.DeleteAsync(task.Id);
            await LoadTaskAsync();
        }

        private async void lblknCompletedTasks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var completedTasks = new CompletedTasksForm(_user);
            if (completedTasks.ShowDialog() == DialogResult.OK)
            {
                await LoadTaskAsync();
            }
        }
    }
}
