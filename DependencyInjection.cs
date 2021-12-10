using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.local_dao;

namespace simple_payroll_desktop
{
    class DependencyInjection
    {

        private static List<Object> singletons = new List<object>();

        public static void registerSingletons()
        {
            singletons.Add(new DenominationDAOLocal());
            DbContext.up();
        }

        public static T get<T>()
        {
            return (T)singletons.Where(item => item is T).First();
        }

    }
}
