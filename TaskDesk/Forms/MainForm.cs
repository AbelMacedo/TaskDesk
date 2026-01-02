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

namespace TaskDesk.Forms
{
    public partial class MainForm : Form
    {
        private User _user;
        public event EventHandler? Logout;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Bienvenido {_user.Name} {_user.Surnames}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(this, EventArgs.Empty);
        }
    }
}
