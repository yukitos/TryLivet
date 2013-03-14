using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;
using Livet.Messaging;
using Livet.Messaging.Windows;

namespace TryLivet03
{
    class MainWindowModel : ViewModel
    {
        public MainWindowModel()
        {
        }

        public void Init()
        {
            Messenger.RaiseAsync(new InformationMessage(
                Properties.Resources.InformationMessage,
                Properties.Resources.InformationMessageCaption,
                System.Windows.MessageBoxImage.Information,
                "Info"));
        }

        public void RequestClose(ConfirmationMessage message)
        {
            if (message.Response == true)
            {
                Messenger.Raise(new WindowActionMessage("Close", WindowAction.Close));
            }
        }
    }
}
