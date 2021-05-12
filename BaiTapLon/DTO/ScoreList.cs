using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ScoreList:Student
    {
        public string Id { get; set; }
        public new string StudentId { get; set; }
        public string CSharp { get; set; }
        public string SQLServerDB { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
