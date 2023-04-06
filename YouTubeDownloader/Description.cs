using System;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeDownloader
{
    class Description
    {
        public async void ShowDescription(string videoURL)
        {
            var youtube = new YoutubeClient();

            var description = await youtube.Videos.GetAsync(videoURL);

            Console.WriteLine();
            Console.WriteLine($"Название видео: {description.Title}");
            Console.WriteLine();
            Console.WriteLine($"Описание: {description.Description}");
        }
    }
}