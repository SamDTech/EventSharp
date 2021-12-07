using System;

namespace eventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "my video"};

            var videoEncoder = new VideoEncoder(); // publisher

            var mailService = new MailService(); // subscriber

            var messageService = new MessageService(); //subscriber

            // subscribe
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            // call the encode method in videoEncoder and pass in the video to be encoded
            videoEncoder.Encode(video);
        }
    }
}
