namespace ProvaGitConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call the Sum method from ProvaGitLib

            int a = 10;
            int b = 20;
            int c = ProvaGitLib.Calc.Sum(a, b);
            System.Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);

        }
    }
}