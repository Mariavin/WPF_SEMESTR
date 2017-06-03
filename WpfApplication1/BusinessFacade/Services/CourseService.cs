using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.BusinessFacade.Helpers;
using WpfApplication1.BusinessFacade.Repository;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Services
{
    public class CourseService
    {
        Connection connection = new Connection();
        CourseRepository courseRepository = new CourseRepository();
        public List<Course> GetListOfCourse()
        {
            List<Course> Courses = connection.GetListOfCourses();

            return Courses;
            //foreach (var user in users)
            //{
            //    if (user.Login == login && user.Passwod == password)
            //    {
            //        var rezult = GetUser(1);
            //        return rezult;
            //    }
            //}
            //return null;
        }

        public Course GetCourseByName(string name)
        {
            Course Courses = courseRepository.GetCourseByName(name);
            return Courses;
        }
    }
}
