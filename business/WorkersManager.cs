using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.dao;

namespace simple_payroll_desktop.business
{
    public class WorkersManager
    {
        private readonly I18nService i18n;
        private readonly WorkerDAO workerDAO;

        public WorkersManager(I18nService i18n,
                              WorkerDAO workerDAO)
        {
            this.i18n = i18n;
            this.workerDAO = workerDAO;
        }

        public IList<Worker> allWorkers()
        {
            return workerDAO.allWorkers();
        }

        public void saveWorker(Worker worker)
        {
            if (worker.Id == 0)
            {
                workerDAO.saveWorker(worker);
            }
            else
            {
                workerDAO.updateWorker(worker);
            }
        }

        public void deleteWorker(Worker worker)
        {
            if (canDelete(worker))
            {
                workerDAO.deleteWorker(worker);
            }
            else
            {
                throw new InvalidOperationException(i18n.Placeholder("The employee can't be deleted"));
            }
        }

        public bool canDelete(Worker worker)
        {
            //TODO
            return true;
        }
    }
}
