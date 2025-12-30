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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            var mainForm = new MainForm(user);
            mainForm.Show();
            this.Hide();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
