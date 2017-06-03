using System.Collections.Generic;
using System.Data.SqlClient;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Services
{
    public class UserService
    {
        private static SqlConnection Con;

        public UserService(SqlConnection con)
        {
            Con = con;
        }

        public IEnumerable<User> GetUsers()
        {
            Con.Open();

            IEnumerable<User> u = new LinkedList<User>();
            return u;
        }

    }
}
