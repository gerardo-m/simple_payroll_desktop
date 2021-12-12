using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.dao
{
    public interface DenominationDAO
    {

        IList<Denomination> allDenominations();

        void saveDenomination(Denomination denomination);

        void updateDenomination(Denomination denomination);

        void deleteDenomination(Denomination denomination);

        Denomination getDenomination(int Id);
    }
}
