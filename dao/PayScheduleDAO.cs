using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.dao
{
    public interface PayScheduleDAO
    {

        IList<PaySchedule> allPaySchedules();

        void savePaySchedule(PaySchedule paySchedule);
        void updatePaySchedule(PaySchedule paySchedule);
        void deletePaySchedule(PaySchedule paySchedule);
    }
}
