using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Controls
{
        public class ClientControl : IControl
        {
            public Client client;

            public ClientControl(Client c)
            {
                client = c;
            }

            public IEnumerable<Programm> GetProgramm(int idUser)
            {
                throw new NotImplementedException();
            }

            public void SetOnCorse()
            {
                Console.WriteLine("Клиент записался на курс");
            }
        }
    
}
