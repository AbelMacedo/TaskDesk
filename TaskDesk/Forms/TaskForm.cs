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
    public partial class TaskForm : Form
    {
        private readonly User _user;
        private TaskItem? _taskToEdit;
        private readonly TaskRepository _taskRepository;
        public TaskForm(User user)
        {
            InitializeComponent();
            _user = user;
            _taskRepository = new TaskRepository();
        }

        public TaskForm(User user, TaskItem taskToEdit) : this(user)
        {
            _taskToEdit = taskToEdit;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPriority.Items.AddRange(new object[]
            {
                "1 - Baja",
                "2 - Media",
                "3 - Alta"
            });

            cmbPriority.SelectedIndex = 0;

            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
            dtpDueDate.MinDate = DateTime.Today;

            if (_taskToEdit != null)
            {
                lblTitle.Text = "Editar Tarea";
                button1.Text = "Guardar Cambios";

                txtTitle.Text = _taskToEdit.Title;
                txtDescription.Text = _taskToEdit.Description;
                cmbPriority.SelectedIndex = _taskToEdit.Priority - 1;
                if (_taskToEdit.DueDate.HasValue)
                {
                    dtpDueDate.Value = _taskToEdit.DueDate.Value;
                }
            }
            else
            {
                cmbPriority.SelectedIndex = 0;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("El título es obligatorio");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            if (_taskToEdit == null)
            {
                var newTask = new TaskItem
                {
                    Title = txtTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Priority = cmbPriority.SelectedIndex + 1,
                    DueDate = dtpDueDate.Value,
                    UserId = _user.Id,
                    Completed = false
                };

                await _taskRepository.AddAsync(newTask);
                MessageBox.Show("Tarea creada con éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _taskToEdit.Title = txtTitle.Text.Trim();
                _taskToEdit.Description = txtDescription.Text.Trim();
                _taskToEdit.Priority = cmbPriority.SelectedIndex + 1;
                _taskToEdit.DueDate = dtpDueDate.Value;

                await _taskRepository.UpdateAsync(_taskToEdit);
                MessageBox.Show("Tarea actualizada con éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /*
        private void LimpiarFormulario()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            cmbPriority.SelectedIndex = 0;
            dtpDueDate.Value = DateTime.Today;
        }
        */
    }
}
