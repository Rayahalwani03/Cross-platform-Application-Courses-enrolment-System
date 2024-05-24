using mobileprogrammingproject.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileprogrammingproject.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;

        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void InitStudent()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Student>();
        }

        public void InitCourse()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Course>();
        }

        public void InitEnroll()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Enroll>();
        }

        public List<Student> GetAllStudents() {
        
         InitStudent();
            return conn.Table<Student>().ToList();
        
        }

        public List<Course> GetAllCourses()
        {

            InitCourse();
            return conn.Table<Course>().ToList();

        }

        public List<Enroll> GetAllEnrolls()
        {

            InitEnroll();
            return conn.Table<Enroll>().ToList();

        }

        public void AddStudent(Student student)
        {

            conn = new SQLiteConnection(this.dbPath);

            conn.Insert(student);

        }

        public void AddCourse(Course course)
        {

            conn = new SQLiteConnection(this.dbPath);

            conn.Insert(course);

        }

        public void AddEnroll(Enroll enroll)
        {

            conn = new SQLiteConnection(this.dbPath);

            conn.Insert(enroll);

        }

        public void DeleteStudent(int studentid)
        {

            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Student { StudentID = studentid  });

        }

        public void DeleteCourse(int courseid)
        {

            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Course { CourseID = courseid });

        }

        public void DeleteEnroll(int enrollid)
        {

            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Enroll { EnrollID = enrollid });

        }
    }
}
