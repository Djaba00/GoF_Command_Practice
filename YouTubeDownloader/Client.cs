using System;

namespace YouTubeDownloader
{
    class Client
    {
        public static void CLientRun(string videosURL)
        {
            var commandPanel = new CommandPanel();

            var downloader = new Downloader();

            var description = new Description();

            commandPanel.SetCommandPanel(new DescriptionCommand(description, videosURL));

            commandPanel.StartCommand();

            commandPanel.SetCommandPanel(new DownloadCommand(downloader, videosURL));

            commandPanel.StartCommand();

            Console.Read();
        }
    }
}