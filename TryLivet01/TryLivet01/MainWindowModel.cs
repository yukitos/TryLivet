using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;

namespace TryLivet01
{
    class MainWindowModel : ViewModel
    {
        public MainWindowModel()
        {
            Message = "Hello Livet World!";
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                if (EqualityComparer<string>.Default.Equals(_message, value))
                    return;

                _message = value;
                RaisePropertyChanged();
            }
        }
    }
}
