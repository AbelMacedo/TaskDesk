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
    public partial class LoginForm : Form
    {
        public event EventHandler<User>? LoginSuccess;

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var user = await repo.LoginAsync(txtEmail.Text.Trim(), txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Credenciales incorrectas");
                return;
            }

            LoginSuccess?.Invoke(this, user);
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
