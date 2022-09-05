using System;

namespace ContandoCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            var m = "";

            while (true)
            {
                string entrada = Console.ReadLine();
                var l = entrada.Split(" ");

                if (entrada == "0")
                    break;

                foreach (var item in l)
                {


                    var n = item.Length;
                    if (item.Length >= t)
                    {
                        t = item.Length;
                        m = item;
                    }

                    Console.Write(n + "-");

                }

                Console.WriteLine(" ");
            }

            Console.WriteLine("The biggest word: " + m);
        }

    }
}
