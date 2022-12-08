namespace DelegatePractice
{
    internal class Class1
    {
        private ShowHandler? _handler;
        public Class1()
        {
            _handler = Program.Show;
        }

        public delegate void ShowHandler(bool result);

        public void Show(bool res) => _handler?.Invoke(res);

        public int Pow(int x, int y) => x * y;
    }
}
