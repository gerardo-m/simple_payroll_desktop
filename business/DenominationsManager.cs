﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.dao;
using simple_payroll_desktop;

namespace simple_payroll_desktop.business
{
    public class DenominationsManager
    {

        private readonly I18nService i18n;
        private DenominationDAO denominationDAO;

        public DenominationsManager(I18nService i18n, DenominationDAO denominationDAO) {
            this.i18n = i18n;
            this.denominationDAO = denominationDAO;
        }

        public IList<Denomination> allDenominations()
        {
            return denominationDAO.allDenominations();
        }

        public void saveDenomination(Denomination denomination)
        {
            if (denomination.Id == 0)
            {
                if (existWithName(denomination.Name))
                {
                    throw new ArgumentException(i18n.DenominationManager_Messages("duplicatedName"));
                }
                else
                {
                    denominationDAO.saveDenomination(denomination);
                }
            }
            else
            {
                denominationDAO.updateDenomination(denomination);
            }
            
        }

        public void deleteDenomination(Denomination denomination)
        {
            if (canDelete(denomination))
            {
                denominationDAO.deleteDenomination(denomination);
            }
            else
            {
                throw new InvalidOperationException(i18n.DenominationManager_Messages("inUse"));
            }
        }

        public bool existWithName(String denominationName)
        {
            //TODO must check the existance of a denomination with this name in the DB
            return true;
        }

        public bool canDelete(Denomination denomination)
        {
            //TODO must check in the DB if the denomination is not in use
            return true;
        }
    }
}
