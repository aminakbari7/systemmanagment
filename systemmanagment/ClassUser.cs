using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemmanagment
{
    internal class ClassUser
    {
        public int Id { get; set; }
        public int Role_Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }

        public string Family { get; set; }
        public string LastLogin{ get; set; }
        
    }
}
