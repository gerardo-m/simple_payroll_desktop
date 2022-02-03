using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_payroll_desktop.forms
{
    public class ControlUtils
    {

        private readonly I18nService i18n;
        public ControlUtils(I18nService i18n)
        {
            this.i18n = i18n;
        }

        public void comboBoxEnumDelegate(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is Enum)
                e.Value = i18n.Enum((Enum)e.Value);
            
        }
    }
}
