using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Controls
{
    public class TrenerControl : IControl
    {
        public Trener trener;

        public TrenerControl(Trener t)
        {
            trener = t;
        }

        public IEnumerable<Programm> GetProgramm(int idUser)
        {
            throw new NotImplementedException();
        }

        public void UpdateCorse()
        {
            Console.WriteLine("Тренер редактирует курс");
        }
    }
}

