namespace PatternFetish
{
    internal interface IPrintStrategy
    {
        void EnablePrinting(bool enable);
        void Print(string message);
    }
}