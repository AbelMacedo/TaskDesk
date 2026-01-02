using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDesk.Forms;
using TaskDesk.Models;
using System.Windows.Forms;

namespace TaskDesk
{
    public class AppContext : ApplicationContext
    {
        private LoginForm? _login;
        private MainForm? _main;

        public AppContext()
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            _login = new LoginForm();
            _login.LoginSuccess += OnLoginSuccess;
            _login.FormClosed += OnFormClosed;
            _login.Show();
        }

        private void OnLoginSuccess(object sender, User user)
        {
            _login!.FormClosed -= OnFormClosed;
            _login.Close();

            _main = new MainForm(user);
            _main.Logout += OnLogout;
            _main.FormClosed += OnFormClosed;
            _main.Show();
        }

        private void OnLogout(object sender, EventArgs e)
        {
            _main!.FormClosed -= OnFormClosed;
            _main.Close();
            ShowLogin();
        }

        private void OnFormClosed(object? sender, FormClosedEventArgs e)
        {
            ExitThread();
        }
    }
}