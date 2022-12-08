namespace DelegatePractice
{
    internal class Class2
    {
        public int MultResult { get; private set; }

        public Predicate<int> Calc(int x, int y, Func<int, int, int> powFunc)
        {
            MultResult = powFunc(x, y);

            return Result;
        }

        public bool Result(int num)
        {
            int modulo = MultResult % num;

            return modulo == 0 ? true : false;
        }
    }
}
