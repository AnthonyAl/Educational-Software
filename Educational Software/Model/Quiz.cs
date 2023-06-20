using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Software.Model
{
    public class Quiz
    {
        public int Total { get; set; }
        public int Grade { get; set; }
        public List<Question> questions { get; set; }
    }
}
