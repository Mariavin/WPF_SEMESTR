
namespace WpfApplication1.DataAccessLayer.Domains
{
    public class User
    {
        public User(int id, string login, string passwod, int role)
        {
            Id = id;
            Login = login;
            Passwod = passwod;
            Role = role;
        }

        public int Id;
        public string Login;
        public int Role;
        public string Passwod;
    }
}
