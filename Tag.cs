using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskadodo
{
    internal class Tag
    {
        public int Id { get; set; }
        public string TagText { get; set; }
        public List<Post> Posts { get; set; } = [];
    }
}
