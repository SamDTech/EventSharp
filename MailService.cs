using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("MailService: sending email to client " + e.Video.Title);
        }
    }
}