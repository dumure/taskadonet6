using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskadodo
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pswd { get; set; }
        public bool IsOpen { get; set; } = true;
        public bool Gender { get; set; } = true;
        public DateTime Birthday { get; set; }
        public List<Post> Posts { get; set; } = [];
    }
}
