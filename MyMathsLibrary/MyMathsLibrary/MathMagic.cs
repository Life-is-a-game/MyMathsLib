using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathsLibrary
{
    /// <summary>
    /// This library performs basic math functions
    /// </summary>
    public class MathMagic
    {
        /// <summary>
        /// This function performs an addition calculation
        /// </summary>
        public double Add(List<double> vals)
        {
            double answer = vals[0];

            for (int i = 1; i < vals.Count; i++)
            {
                answer += vals[i];
            }
            return answer;
        }
        
        /// <summary>
        /// This function performs a subtraction calculation
        /// </summary>
       
        public double Subtract(List<double> vals)
        {
            double answer = vals[0];

            for (int i = 1; i < vals.Count; i++)
            {
                answer -= vals[i];
            }
            return answer;
        }

        /// <summary>
        /// This function performs a multiplication calculation
        /// </summary>

        public double Multiply(List<double> vals)
        {
            double answer = vals[0];

            for (int i = 1; i < vals.Count; i++)
            {
                answer *= vals[i];
            }
            return answer;
        }

        /// <summary>
        /// This function performs a division calculation
        /// </summary>

        public double Divide(List<double> vals)
        {
            double answer = vals[0];

            for (int i = 1; i < vals.Count; i++)
            {
                answer /= vals[i];
            }
            return answer;
        }

        /// <summary>
        /// This function performs a division calculation and then calculates the remainder
        /// </summary>

        public double Remainder(double val1, double val2)
        {
            double answer = val1 % val2;
            return answer;
        }

        /// <summary>
        /// This function takes a number - val1, and raises it to the power of the exponent - val2.
        /// </summary>

        public double Pow(double val1, double val2)
        {
            double answer = Math.Pow(val1, val2);
            return answer;
        }

        /// <summary>
        /// This function squares a given number
        /// </summary>

        public double Square(double val1)
        {
            double answer = Pow(val1, 2);
            return answer;
        }

        /// <summary>
        /// This function cubes a given number
        /// </summary>

        public double Cube(double val1) 
        {
            double answer = Pow(val1, 3);
            return answer;
        }

        /// <summary>
        /// This function performs a sqrt calculation
        /// </summary>

        public double Sqrt(double val1) 
        {
            double answer = Math.Sqrt(val1);
            return answer;
        }

        /// <summary>
        /// This function rounds the number to the nearest integer.
        /// </summary>

        public int Rounding(double val1)
        {
            double a = Math.Round(val1, 0, MidpointRounding.ToEven);
            int ans = (int)a;
            return ans;
        }

        /// <summary>
        /// This function removes everything after the decimal point
        /// </summary>
        

        public int RemoveDecimals(double val1) 
        {
            int x = (int)Math.Truncate(val1);
            return x;
        }
    }
}
