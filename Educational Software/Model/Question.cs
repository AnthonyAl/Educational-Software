using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Software.Model
{
    public class Question
    {
        public int LessonCode { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Sentence { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public List<Paragraph> Choices { get; set; }
        public List<Paragraph> Corrects { get; set; }
        public List<Paragraph> Rows { get; set; }
    }
}
