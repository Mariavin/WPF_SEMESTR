using System;
using System.Windows;
using WpfApplication1.BusinessFacade.Controls;
using WpfApplication1.BusinessFacade.Services;
using WpfApplication1.DataAccessLayer.Domains;
using WpfApplication1.DataAccessLayer.Model;

namespace WpfApplication1.UI
{
    /// <summary>
    /// Логика взаимодействия для AddingProgram.xaml
    /// </summary>
    public partial class AddingProgram : Window
    {
        CourseControl courseService = new CourseControl();
        ProgrammControl ProgrammService = new ProgrammControl();
        TrenerControl trener;
        public AddingProgram(IControl user)
        {
            InitializeComponent();
            trener = (TrenerControl)user;
            var courses = new CourseModel(courseService.GetListOfCourse());
            
            foreach (var c in courses.Course)
            {                
                comboBox.Items.Add(c.Name);
            }
        }
        private bool ExistStringOnlyLetter(string s)
        {
            bool flag = true;
            foreach (var c in s)
            {
                if(!Char.IsLetter(c))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        private bool ExistStringOnlyNumber(string s)
        {
            bool flag = true;
            foreach (var c in s)
            {
                if (!Char.IsDigit(c))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ExistStringOnlyNumber(textBox2.Text) && !string.IsNullOrEmpty(textBox.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                int id_course = courseService.GetCourseByName(comboBox.SelectedValue.ToString()).Id_course;

                var program = new Programm
                {
                    id_course = id_course,
                    Name = textBox.Text,
                    Price = Convert.ToDecimal(textBox2.Text),
                    Describe = textBox3.Text,
                    id_trener = trener.trener.id
                };
                ProgrammService.AddProgramm(program);
            }
            else {
                //MessageBox m = new MessageBox(;
            }
                
            //ListBox notesList = new ListBox();
        }

      
    }
}
