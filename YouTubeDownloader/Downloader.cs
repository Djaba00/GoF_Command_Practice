using System;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeDownloader
{
    // Rонкретная реализация команды "Downloader"
    class Downloader
    {
        public async void DownloadAsync(string videoURL)
        {
            var youtube = new YoutubeClient();
            
            Console.WriteLine("Начало загрузки видео");

            var video = await youtube.Videos.GetAsync(videoURL);

            await youtube.Videos.DownloadAsync(videoURL, $@"Downloads/{video.Title}.mp4", v => v
            .SetContainer("mpeg")
            .SetPreset(ConversionPreset.UltraFast)
            .SetFFmpegPath(@"bin/Debug/net7.0/ffmpeg"));
        }

        public void StopDownload()
        {
            throw new NotImplementedException();
        }
    }
}