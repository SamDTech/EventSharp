using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace eventDelegate
{
    public class VideoEncoder
    {
    // 2) Define an event based on that delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3) Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            // check if there is any subscriber
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
        }
    }
}