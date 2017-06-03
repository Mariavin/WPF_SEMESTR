
namespace WpfApplication1.DataAccessLayer.Domains
{
    public class User
    {
        public User(int id, string login, string passwod)
        {
            Id = id;
            Login = login;
            Passwod = passwod;
        }

        public int Id;

        public string Login;

        public string Passwod;
    }
}
