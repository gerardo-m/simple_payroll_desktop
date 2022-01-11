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

        /// <summary>
        /// Must return a Denomination object if there is an existing denomination with the provided name 
        /// in the database.
        /// Must return null otherwise.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Denomination getDenominationByName(string name);
    }
}
