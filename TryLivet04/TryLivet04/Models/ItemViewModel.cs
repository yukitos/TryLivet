using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Livet;

namespace TryLivet04.Models
{
    public class ItemViewModel : ViewModel
    {
        public ItemViewModel(string tabName)
        {
            this.Name = tabName;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (EqualityComparer<string>.Default.Equals(_name, value))
                    return;
                _name = value;
                RaisePropertyChanged();
            }
        }
    }
}
