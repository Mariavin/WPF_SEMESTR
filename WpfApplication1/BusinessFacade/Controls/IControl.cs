using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Controls
{
    public interface IControl
    {
        IEnumerable <Programm> GetProgramm(int User);
    }
}
