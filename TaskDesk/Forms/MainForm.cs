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
            dgvIncompleteTasks.DataSource = tasks.Where(t => !t.Completed).ToList();
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
            taskForm.ShowDialog();
            _ = LoadTaskAsync();
        }
    }
}
