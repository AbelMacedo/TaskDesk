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
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
