using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Software.Model
{
    internal class Lesson
    {
        public string Name { get; set; } = string.Empty;
        public int Code { get; set; }

        public string Description { get; set; }

        public List<Paragraph> Paragraphs { get; set; }
        public List<Goal> Goals { get; set; }

        public List<Extra> Extras { get; set; }
    }
}
