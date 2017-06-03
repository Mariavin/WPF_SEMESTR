using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.BusinessFacade.Helpers;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Repository
{
    class ProgrammRepository
    {
        Connection connection = new Connection();
        private static SqlConnection con;

        public ProgrammRepository()
        {
            con = connection.Open();
        }
        public void AddProgramm(Programm programm)
        {
            if (con.State != ConnectionState.Open) con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Semester].[dbo].[Programms] (Name,id_course,Price,id_trener,Describe) VALUES(@Name,@id_course,@Price,@id_trener,@Describe)", con);
            cmd.Parameters.AddWithValue("@Name", programm.Name);
            cmd.Parameters.AddWithValue("@id_course", programm.id_course);
            cmd.Parameters.AddWithValue("@Price", programm.Price);
            cmd.Parameters.AddWithValue("@id_trener", programm.id_trener);
            cmd.Parameters.AddWithValue("@Describe", programm.Describe);
            var result = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
