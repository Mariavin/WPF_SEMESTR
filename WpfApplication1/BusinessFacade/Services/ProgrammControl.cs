using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.BusinessFacade.Repository;
using WpfApplication1.DataAccessLayer.Domains;

namespace WpfApplication1.BusinessFacade.Services
{
    public class ProgrammControl
    {
        ProgrammRepository programmRepository = new ProgrammRepository();

        public void AddProgramm(Programm programm)
        {
            programmRepository.AddProgramm(programm);
        }
    }
}
