namespace MVP
{
    internal class TextPresenter
    {
        private TextRedactorModel _textRedactor;
        private ViewConsole _viewConsole;

        public TextPresenter(ViewConsole view)
        {
            _viewConsole = view;
            _textRedactor = new();

            _viewConsole.ToUpperTextEvent += TextToUpper;
            _viewConsole.ToLowerTextEvent += TextToLower;
            _viewConsole.ToReversTextEvent += TextToRevers;

        }

        private void TextToUpper(string text)
        {
            _viewConsole.InputText = text.ToUpper();
            Console.WriteLine(_viewConsole.InputText);
        }

        private void TextToLower(string text)
        {
            _viewConsole.InputText = text.ToLower();
            Console.WriteLine(_viewConsole.InputText);
        }

        private void TextToRevers()
        {
            string currentText = _viewConsole.InputText;
            _viewConsole.InputText = _textRedactor.ToRevers(currentText);
            Console.WriteLine(_viewConsole.InputText);
        }
    }
}
