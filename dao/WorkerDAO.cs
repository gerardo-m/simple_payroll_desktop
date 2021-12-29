using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.dao
{
    public interface WorkerDAO
    {

        IList<Worker> allWorkers();

        IList<Worker> workersWithPaySchedule(int PayScheduleId);
        Worker getWorker(int id);
        void saveWorker(Worker worker);
        void updateWorker(Worker worker);
        void deleteWorker(Worker worker);
    }
}
