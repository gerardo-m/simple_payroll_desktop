using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{
    class Denomination
    {

        public Denomination() {}

        public Denomination(int id, String name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public String Name { get; set; }
    }
}
