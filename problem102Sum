    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     
    namespace pepe
    {
        class Program
        {
            static void Main(string[] args)
            {
                string x = Convert.ToString(Console.ReadLine());
                int count = 0;
                int buf = 0;
                while (x.Length >= 2)
                {
                    for (int j = 0; j < x.Length; j++)
                    {
                        buf += (x[j] - 48);
                    }
                    x = Convert.ToString(buf);
                    buf = 0;
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }
