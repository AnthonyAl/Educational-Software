using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Software.Model
{
    public class Profession
    {
        public string Name { get; set; }
        public List<Paragraph> SoftSkills { get; set; }
        public List<Paragraph> HardSkills { get; set; }
        public List<Paragraph> Paragraphs { get; set; }
        public List<Paragraph> Requirements { get; set; }
    }
}

