using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Software.Model
{
    internal class Course
    {
        public int Code { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Number { get; set; }
        public string Introduction { get; set; } = string.Empty;
        public List<Lesson> Lessons { get; set; }
    }
}
