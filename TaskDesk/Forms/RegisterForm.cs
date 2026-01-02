using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskDesk.Repositories;

namespace TaskDesk.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            var repo = new UserRepository();
            var success = await repo.RegisterAsync(txtEmail.Text.Trim(), txtPassword.Text, txtName.Text, txtSurnames.Text);

            if (success)
            {
                MessageBox.Show("Usuario registrado");
                this.Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

    }
}
