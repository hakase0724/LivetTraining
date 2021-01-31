using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using LivetApp1.Models;

namespace LivetApp1.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel() 
        {
            mModel = new Model();
            var listener = new PropertyChangedEventListener(mModel);
            listener.RegisterHandler(nameof(Model.BindText), (s,e) => { RaisePropertyChanged(nameof(BindText)); });
            CompositeDisposable.Add(listener);
        }

        private Model mModel;

        public string BindText 
        {
            get => mModel.BindText;
            set => mModel.BindText = value;
        }

        // Some useful code snippets for ViewModel are defined as l*(llcom, llcomn, lvcomm, lsprop, etc...).
        public void Initialize()
        {
        }

    }
}
