using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sel = 0;
            string T1 = string.Empty;
            string T2 = string.Empty;
            string T3 = string.Empty;
            string val = string.Empty;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            Console.WriteLine("choices");
            do
            {

                Console.WriteLine("1.enter the dimensions");
                Console.WriteLine("2.Exit");
                string selSide = Console.ReadLine();
                int.TryParse(selSide, out sel);
                if (sel == 1)
                {
                    Console.WriteLine("Enter 1st sides");
                    T1 = Console.ReadLine();
                    bool ans1 = int.TryParse(T1, out n1);
                    Console.WriteLine("Enter 2nd sides");
                    T2 = Console.ReadLine();
                    bool ans2 = int.TryParse(T2, out n2);
                    Console.WriteLine("Enter 3rd sides");
                    T3 = Console.ReadLine();
                    bool ans3 = int.TryParse(T3, out n3);
                    val = Traiangle_solver.Analyze(n1, n2, n3);
                    if (ans1 == false || ans2 == false || ans3 == false)
                    {
                        Console.WriteLine("Not Valid Input");
                    }
                    else if (n1 <= 0 || n2 <= 0 || n3 == 0)
                    {
                        Console.WriteLine("Value cannot be less than 0");
                    }
                    else
                    {
                        Console.WriteLine("{0}", val);

                    }

                }
                else
                {
                            System.Environment.Exit(0);
                        }
                    } while (sel == 1 || sel == 2);
                    

                }
            }
} 
