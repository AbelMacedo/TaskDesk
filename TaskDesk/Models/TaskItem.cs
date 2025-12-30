using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDesk.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public int Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public int UserId { get; set; }
        public bool Completed { get; set; }

    }
}
