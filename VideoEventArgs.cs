using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventDelegate
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}