namespace MVP
{
    internal class TextRedactorModel : TextRedactor
    {
        public override string ToRevers(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}