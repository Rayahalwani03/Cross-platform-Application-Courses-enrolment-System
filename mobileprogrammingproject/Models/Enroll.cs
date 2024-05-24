using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileprogrammingproject.Models
{
    public class Enroll
    {
        [PrimaryKey, AutoIncrement]

        public int EnrollID { get; set; }

        public int StudentID { get; set; }
        public int CourseID { get; set; }
    }
}
