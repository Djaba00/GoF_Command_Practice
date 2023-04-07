using System;

namespace YouTubeDownloader
{
    //Получатель (Receiver) команды "Description"
    class DescriptionCommand : ICommand
    {
        Description _description;
        string _videoURL;

        public DescriptionCommand(Description setDescription, string setVideoURL)
        {
            _description = setDescription;
            _videoURL = setVideoURL;
        }

        public void Excecute()
        {
            _description.ShowDescription(_videoURL);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}