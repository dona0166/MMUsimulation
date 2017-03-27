using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMUsimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.run();
            Console.ReadKey();
        }

        public void menu(int input)
        {
            bool running = true;

            while (running)
            {
                switch (input)
                {
                    case 1:
                        CreateProcess();
                        break;
                    case 2:
                        DeleteProcess();
                        break;
                    case 3:
                        ShowProcess();
                        break;
                    case 4:
                        GenerateAdress();
                        break;
                    case 5:
                        MemoryDump();
                        break;
                    case 6:
                        Compaction();
                        break;
                    case 0:
                        running = false;
                        break;
                }
            }
        }
        public void run()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Create a new process");
            Console.WriteLine("2) Delete the process");
            Console.WriteLine("3) Show process");
            Console.WriteLine("4) Generate adress");
            Console.WriteLine("5) Memory dump");
            Console.WriteLine("6) Compaction");
            Console.WriteLine("0) EXIT");
            //string result;
            //int input = int.Parse(Console.ReadLine());
            int result;
            if (Int32.TryParse(Console.ReadLine(), out result) == false)
            {
                result = 0;
            }
            menu(result);



        }
    }
}
