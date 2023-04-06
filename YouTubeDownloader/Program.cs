using System;

namespace YouTubeDownloader
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Вставьте ссылку на You-Tube-видео: ");

            Console.WriteLine();

            var videosURL = "https://www.youtube.com/watch?v=tG7wLK4aAOE"; //Console.ReadLine();

            Client.CLientRun(videosURL);
        }
        
    }
}