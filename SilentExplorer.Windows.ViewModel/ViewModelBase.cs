using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentExplorer.Windows.ViewModel
{
    public class ViewModelBase : ReactiveObject, IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
