using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_From10ToBinary
{
    static class ConverterFrom10ToBinary
    {
        static public string result1 = "";
        static public string result2 = "";

        static public void Convert1(int i)
        {
            int temp = Convert.ToInt32(Convert.ToString(i));
            result1 = Convert.ToString(temp, 2);
        }

        static public void Convert2(int i)
        {
            StringBuilder s = new StringBuilder("");
            while (i > 0)
            {
                int digit = i % 2;
                i /= 2;
                s.Insert(0,Convert.ToString(digit));
            }

            result2 = s.ToString();
            
        }
    }
}
