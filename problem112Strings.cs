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
                string strA = Console.ReadLine();
                string strB = Console.ReadLine();
                int result = string.CompareOrdinal(strA.ToLower(), strB.ToLower());
                if (result>0)
                {
                    Console.WriteLine("1");
                }
                if (result == 0)
                {
                    Console.WriteLine("0");
                }
                if (result<0)
                {
                    Console.WriteLine("-1");
                }
            }
        }
    }
