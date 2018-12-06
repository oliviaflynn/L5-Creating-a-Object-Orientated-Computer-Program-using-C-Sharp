using System;
using System.Text;
namespace Exercise_03_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program calc;
            calc = new Program();
            calc.runApp();
            Console.ReadKey();
        }

        public void runApp()
        {
            double firstNum = 0.0; // first number
            double secondNum = 0.0; // second number
            char oper = ' '; // operator
                             // notice the apostrophes
            double answer = 0.0; // value of expression
            firstNum = 2;
            oper = '+';
            secondNum = 3;
            answer = doDaCalculation(firstNum, oper, secondNum);
            displayDaCalculation(firstNum, oper, secondNum, answer);
            firstNum = 12;
            oper = '-';
            secondNum = 9;
            answer = doDaCalculation(firstNum, oper, secondNum);
            displayDaCalculation(firstNum, oper, secondNum, answer);
            firstNum = 3.14159;
            oper = '*';
            secondNum = 4.7;
            answer = doDaCalculation(firstNum, oper, secondNum);
            displayDaCalculation(firstNum, oper, secondNum, answer);
            firstNum = 99.99;
            oper = '/';
            secondNum = 9;
            answer = doDaCalculation(firstNum, oper, secondNum);
            displayDaCalculation(firstNum, oper, secondNum, answer);
        }
        double doDaCalculation(double num1, char oper, double num2)
        {
            double result = 0.0;

            // insert switch statement block here
            switch (oper)
            {
                case '+':
                    result = num1 + num2;                    
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    break;
            }


            return result;
        }
        private void displayDaCalculation(double num1, char oper,
        double num2, double result)
        {
            StringBuilder strB = new StringBuilder();
            strB.Append(num1);
            strB.Append(" " + oper + " ");
            strB.Append(num2);
            strB.Append(" = ");
            strB.Append(result);
            Console.WriteLine(strB.ToString());
        }
    }
}