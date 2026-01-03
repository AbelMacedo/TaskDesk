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
    public partial class TaskForm : Form
    {
        private readonly User _user;
        public TaskForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
