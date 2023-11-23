namespace ProvaGitLib
{
    public class Calc
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        //create Diff Mult DIv methods
        public static int Diff(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }

        //create a method that returns the max between two numbers
        public static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
 

    }
}