using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace PointOfSale_1.Misc
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : class
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection => false;

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }

}
