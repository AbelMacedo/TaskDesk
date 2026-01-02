using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDesk.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surnames { get; set; }
        public String Email { get; set; }
        public String PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
