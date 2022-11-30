namespace DelegatePractice
{
    internal class Starter
    {
        public static void Run()
        {
            int num1 = 10;
            int num2 = 5;
            int divider = 25;

            Console.WriteLine($"Num1: {num1}\nNum2: {num2}\n");

            var class1 = new Class1();
            var class2 = new Class2();
            var resultFunc = class2.Calc(num1, num2, class1.Pow);

            Console.WriteLine($"Multiplication result: {class2.MultResult}");
            Console.WriteLine($"Divider: {divider}\n");

            class1.Show(resultFunc(divider));
        }
    }
}
