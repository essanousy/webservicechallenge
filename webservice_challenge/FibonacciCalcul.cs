using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webservice_challenge
{
    public class FibonacciCalcul
    {
        public Int64 GetFibonacci(int value)
        {
            if (value < 2) return (Int64)value;
            Int64 a = 0;
            Int64 b = 1;
            Int64 result = 0;
            for (int i = 1; i < value; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }
}