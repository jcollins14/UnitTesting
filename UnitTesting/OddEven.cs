using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class OddEven
    {
        public string DoOddEven(int num)
        {
            string output = "";
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (num == 2)
                    {
                        Console.WriteLine("Prime");
                        output = "Prime";
                    }
                    else
                    {
                        Console.WriteLine("Even");
                        if (i == num)
                        {
                            output = "Even";
                        }
                    }
                    
                }
                else
                {
                    for (int b = i-1; b < i; b++)
                    {
                        if (b % i == 0)
                        {
                            Console.WriteLine("Prime");
                            output = "Prime";
                        }
                        else
                        {
                            Console.WriteLine("Odd");
                            if (i == num)
                            {
                                output = "Odd";
                            }
                        }
                    }
                    
                }
            }
            return output;
        }
    }
}
