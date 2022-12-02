namespace MVP
{
    public interface IView
    {
        event Action<string> ToUpperTextEvent;
        event Action<string> ToLowerTextEvent;
        event Action ToReversTextEvent;

        string InputText { get; set; }

        int CommandHandler(string command);

        void ConsoleUpdate();
    }
}