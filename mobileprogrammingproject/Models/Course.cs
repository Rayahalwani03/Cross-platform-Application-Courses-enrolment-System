using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileprogrammingproject.Models
{
    public class Course
    {
        [PrimaryKey, AutoIncrement]

        public int CourseID { get; set; }

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
    }
}
