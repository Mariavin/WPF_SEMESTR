using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Helpers
{
    public class Connection
    {
        private const string StrConnection = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Semester;Integrated Security=True;";
        private static SqlConnection con = new SqlConnection(StrConnection);

        public Connection()
        {

        }

        public List<User> GetListOfStudents()
        {
            string sql = "SELECT * FROM [Users]";
            return GetStudentsByRequest(sql);

        }

        public List<Course> GetListOfCourses()
        {
            string sql = "SELECT * FROM [Course]";
            return GetCoursesByRequest(sql);

        }

        public SqlConnection Open()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            return con;
        }

        public void Close()
        {

        }

        private static List<Course> GetCoursesByRequest(string sql)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var cmd = new SqlCommand(sql, con);

            var courses = new List<Course>();

            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    var course = new Course(
                        Convert.ToInt32(sqlDataReader["id_course"].ToString()),
                        sqlDataReader["Name"].ToString(),
                        sqlDataReader["Describe"].ToString());
                    courses.Add(course);
                }
            }
            con.Close();
            return courses;
        }

        private static List<User> GetStudentsByRequest(string sql)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var cmd = new SqlCommand(sql, con);

            var students = new List<User>();

            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    var student = new User(
                        Convert.ToInt32(sqlDataReader["id_user"].ToString()),
                        sqlDataReader["Login"].ToString(),
                        sqlDataReader["Passwod"].ToString());
                    students.Add(student);
                }
            }
            con.Close();
            return students;
        }

        public Course GetCourseByName(string name)
        {
            string sql = "SELECT * FROM [Semester].[dbo].[Course] where Name = '" + name + "'";
            if (con.State != ConnectionState.Open) con.Open();

            var cmd = new SqlCommand(sql, con);
            Course course = null;
            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows && sqlDataReader.Read())
            {
                course = new Course(
                    Convert.ToInt32(sqlDataReader["id_course"].ToString()),
                    sqlDataReader["Name"].ToString(),
                    sqlDataReader["Describe"].ToString());
            }
            con.Close();
            return course;
        }
    }
}
