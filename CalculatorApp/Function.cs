using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    class Function
    {
        private ArrayList numbers; 
        private ArrayList func;
        private double result;

        private double num1;
        private double num2;
        private Char fun;


        public Function()
        {
            numbers = new ArrayList();
            func = new ArrayList();
            result = 0;

        }

        public Function(double num1, double num2, Char func)
        {
            this.num1 = num1;
            this.num2 = num2;
            fun = func;
            Cal();
        }

        private void Cal()
        {
            if (fun == '+')
            {
                result = num1 + num2;
            }
            else if (fun == '-')
            {
                result = num1 - num2;
            }
            else if (fun == '*')
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

        }



        public void setNumber(double num)
        {
            numbers.Add(num);
        }

        public double getNumber(int index)
        {
            return Convert.ToDouble(numbers[index]);
        }

        

        public void setFunc(char c)
        {
            func.Add(c);
        }

        public char getFunc(int index)
        {
            
            return Convert.ToChar(func[index]);
        }

        public double getResult()
        {
            if(numbers.Count <= 1)
            {
                return Convert.ToDouble(numbers[0]);
            }
            else
            {
                calculateResults();
                return result;
            }
            
        }

        public void calculateResults()
        {
            result = Convert.ToDouble(numbers[0]);
            for (int i = 0; i < func.Count; i++)
            {
                if (Convert.ToChar(func[i]) == '+')
                {
                    result = result + Convert.ToDouble(numbers[i + 1]);
                }
                else if (Convert.ToChar(func[i]) == '-')
                {
                    result = result - Convert.ToDouble(numbers[i + 1]);
                }
                else if (Convert.ToChar(func[i]) == '*')
                {
                    result = result * Convert.ToDouble(numbers[i + 1]);
                }
                else
                {
                    result = result / Convert.ToDouble(numbers[i + 1]);
                }

            }

            Console.WriteLine("The result is  " + result);

        }

        public void removeLastFunction()
        {
            func.RemoveAt(func.Count - 1);
        }

        public int numSize()
        {
            return numbers.Count;
        }

        public int funcSize()
        {
            return func.Count;
        }
        


    }
}
