using System;

namespace YouTubeDownloader
{
    interface ICommand
    {
        void Excecute();
        void Undo();
    }
}