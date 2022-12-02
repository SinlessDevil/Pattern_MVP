namespace MVP
{
    internal class ViewConsole : IView
    {
        public event Action<string> ToUpperTextEvent;
        public event Action<string> ToLowerTextEvent;
        public event Action ToReversTextEvent;

        private string _inputCommand;
        private string _inputText;

        private TextPresenter _presenter;

        public ViewConsole()
        {
            _presenter = new(this);
        }
        public void ConsoleUpdate()
        {
            while (true)
            {
                Console.Write("Enter your text pls:  ");
                _inputText = Console.ReadLine();

                СheckStringForNumber();

                Console.WriteLine("=========================================");
                int checkStopCommad = CommandHandler(_inputCommand);

                if (checkStopCommad == 0) break;
            }
        }

        public int CommandHandler(string command)
        {
            int numberCommand = Convert.ToInt32(command);
            switch (numberCommand)
            {
                case 1:
                    Console.WriteLine("1");
                    ToUpperTextEvent?.Invoke(InputText);
                    break;
                case 2:
                    Console.WriteLine("2");
                    ToLowerTextEvent?.Invoke(InputText);
                    break;
                case 3:
                    Console.WriteLine("3");
                    ToReversTextEvent?.Invoke();
                    break;
                default:
                    Console.WriteLine("Exit");
                    return 0;
            }
            return numberCommand;
        }

        private void СheckStringForNumber()
        {
            while (true)
            {
                Console.Write("Enter your Command (1,2,3 or 0 - Exit):  ");
                _inputCommand = Console.ReadLine();

                if (int.TryParse(_inputCommand, out int number)) break;

                Console.WriteLine("Failed to recognize the number, try again.");
            }

        }

        public string InputText
        {
            get{ return _inputText; }
            set { _inputText = value; }
        }
    }
}