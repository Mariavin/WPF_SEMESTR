using System;
using System.Collections.Generic;
using WpfApplication1.BusinessFacade.Controls;
using WpfApplication1.BusinessFacade.Helpers;
using WpfApplication1.DataAccessLayer.Domains;
using WpfApplication1.DataAccessLayer.Enums;

namespace WpfApplication1.BusinessFacade.Services
{
    public class AvtorizationControl
    {
        
        public IControl Avtorize(string login, string password)
        {
            Connection connection = new Connection();
            List<User> users = connection.GetListOfStudents();
            foreach (var user in users)
            {
                if (user.Login == login && user.Passwod == password)
                {
                    var rezult = GetUser(user.Role);
                    return rezult;
                }
            }
            return null;
        }

        public IControl GetUser(int role)
        {
            
            if (role == (int)Role.trener)
            {
                return new TrenerControl(new Trener());
            }
            else
            {
                return new ClientControl(new Client());
            }
            
        }
    }
}
