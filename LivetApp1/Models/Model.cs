using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;

namespace LivetApp1.Models
{
    public class Model : NotificationObject
    {
        private string mText = "HelloWorld";
        public string BindText 
        {
            get => mText;
            set => RaisePropertyChangedIfSet(ref mText,value);
        }
    }
}
