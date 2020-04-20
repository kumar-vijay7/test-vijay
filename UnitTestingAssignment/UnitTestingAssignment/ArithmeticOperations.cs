using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingAssignment
{
    public class ArithmeticOperations
    {
       
        double result;
        /// <summary>
        /// Adding two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>double</returns>
        public double ArtiticmeticAdd(double number1, double number2)
        {
            result = number1 + number2;
            return result;
        }

        /// <summary>
        /// Subtract two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>double</returns>
        public double ArtiticmeticSubtract(double number1, double number2)
        {
            result = number1 - number2;
            return result;
        }
        /// <summary>
        /// Multiplication two values
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>double</returns>
        public double ArtiticmeticMultiplication(double number1, double number2)
        {
            result = number1 * number2;
            return result;
        }
        /// <summary>
        /// Division two values
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>double</returns>
        public double ArtiticmeticDivision(double number1, double number2)
        {
            if (number2 == 0)
            { throw new DivideByZeroException("number2"); }
            else
            {
                result = number1 * number2;
                return result;
            }
            
        }
        /// <summary>
        /// checking equals two values
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>bool</returns>
        public bool ArithmeticEqual(object number1,object number2)
        {
            if (number1 == null || number2==null)
            {
                throw new NullReferenceException("number1 ,number2");
            }
            else if (number1.Equals(number2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(String [] args)
        {

        }
    }
}
