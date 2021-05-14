using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ScoreList
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public float Score { get; set; }
        public string SubId { get; set; }
        public string SubName { get; set; }
    }
}
