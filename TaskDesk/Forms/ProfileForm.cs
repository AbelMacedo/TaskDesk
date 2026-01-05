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
    public partial class ProfileForm : Form
    {
        private readonly User _user;
        private readonly UserRepository _userRepository;
        public ProfileForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userRepository = new UserRepository();
        }

        private async void updateProfile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) ||  string.IsNullOrWhiteSpace(txtSurnames.Text))
            {
                MessageBox.Show("El nombre y apellidos son obligatorios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _user.Name = txtName.Text.Trim();
            _user.Surnames = txtSurnames.Text.Trim();

            try
            {
                await _userRepository.UpdateAsync(_user);
                MessageBox.Show("Perfil actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el perfil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = _user.Name;
            txtSurnames.Text = _user.Surnames;
        }
    }
}
