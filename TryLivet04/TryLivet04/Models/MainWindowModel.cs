using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;

namespace TryLivet04.Models
{
    public class MainWindowModel : ViewModel
    {
        public MainWindowModel()
        {
            Items.Add(new ItemViewModel("Tab 1"));
            Items.Add(new ItemViewModel("Tab 2"));
        }

        private ObservableSynchronizedCollection<ItemViewModel> items = new ObservableSynchronizedCollection<ItemViewModel>();

        public ObservableSynchronizedCollection<ItemViewModel> Items
        {
            get { return items; }
        }
    }
}
