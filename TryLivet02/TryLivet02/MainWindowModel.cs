using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;

namespace TryLivet02
{
    class MainWindowModel : ViewModel
    {
        public MainWindowModel()
        {
            Message = "Hello world!";
            count = 0;
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

        private int count;

        public void UpdateMessage()
        {
            Message = string.Format("{0} 回更新しました", ++count);
        }
    }
}
