using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskadodo
{
    internal class Post
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? Text { get; set; }
        public bool IsOpen { get; set; } = true;
        public string ImgPath { get; set; }
        public List<Tag> Tags { get; set; } = [];
    }
}
