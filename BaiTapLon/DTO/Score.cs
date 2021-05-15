using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Score : StudentClass
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string ScoreMedium { get; set; }
        public string ScoreOral { get; set; }
        public string ScoreSementer { get; set; }
        public string SubId { get; set; }
        public string SubName { get; set; }
    }
}
