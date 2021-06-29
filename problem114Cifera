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
                long k = Int64.Parse(Console.ReadLine());
                long l = Int64.Parse(Console.ReadLine());
                int laCounter = 0;
                long buf = k;
                while (k < l)
                {
                    k = buf * k;
                    laCounter++;
                }
                if (k > l)
                    laCounter = 0;
                if (laCounter == 0 && k == l)
                    Console.WriteLine("YES\n{0}", laCounter);
                if (laCounter == 0 && k != l)
                    Console.WriteLine("NO");
                if (laCounter > 0)
                    Console.WriteLine("YES\n{0}", laCounter);
            }
        }
    }
