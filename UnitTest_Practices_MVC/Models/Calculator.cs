namespace UnitTest_Practices_MVC.Models
{
    public class Calculator
    {
        public static double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Substraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static double Division(double firstNumber, double secondNumber)
        {
            double result = 0;
            if (firstNumber > secondNumber)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                result = secondNumber / firstNumber;

            }
            return result;
        }
    }
}