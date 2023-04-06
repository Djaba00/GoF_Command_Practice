using System;

namespace YouTubeDownloader
{
    class CommandPanel
    {
        ICommand _command;

        public void SetCommandPanel(ICommand setCommand)
        {
            _command = setCommand;
        }

        public void StartCommand()
        {
            _command.Excecute();
        }

        public void UndoCommand() 
        {
            throw new NotImplementedException(); 
        }
    }
}