using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discorse.MVVM.Model
{
    class MessageModel
    {
        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
#pragma warning disable IDE1006 // Naming Styles
        public bool isNativeOrigin { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        public bool? FirstMessage { get; set; }
    }
}
