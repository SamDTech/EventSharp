using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventDelegate
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("MessageService: sending text message " + e.Video.Title);
        }
    }
}