using System;

namespace YouTubeDownloader
{
    // Получатель (Receiver) команды "Downloader"
    class DownloadCommand : ICommand
    {
        Downloader _downloader;
        string _videoURL;

        public DownloadCommand(Downloader setDownloader, string setVideoURL)
        {
            _downloader = setDownloader;
            _videoURL = setVideoURL;
        }
        public async void Excecute()
        {
            _downloader.DownloadAsync(_videoURL);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}