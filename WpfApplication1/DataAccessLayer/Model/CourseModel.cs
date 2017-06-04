using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.DataAccessLayer.Model
{
    public class CourseModel
    {
        public CourseModel(List<Course> course)
        {
            Course = course;
        }
        public List<Course> Course;
        public string test;


    }
}
