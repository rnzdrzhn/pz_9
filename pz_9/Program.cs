using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("1-2 задание:");
            string[][] str = new string[9][];
            string[] last = new string[9];
            string[] max = new string[9];
            

            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                str[i] = new string[rnd.Next(6, 21)];
                for (int j = 0; j < str[i].Length; j++)
                {
                    str[i][j] = Convert.ToString(rnd.Next(6, 21));
                    Console.Write(str[i][j] + " ");

                    if (j == str[i].Length-1)
                    {
                        last[count] = str[i][j];
                        count++;
                    }
                    
                } 
                Console.WriteLine(" "); 
            } 
            Console.WriteLine("\n3 задание:");
            foreach (string i in last)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("4 задание:");
           
            Console.WriteLine(" ");
            

            Console.WriteLine("5 задание:");
            int m = 0;
            string s1 = m.ToString();
            int f = 0;
            string s2 = f.ToString();

            for (int i = 0; i < 9; i++)
            {
                s1 = max[i];
                s2 = str[i][0];
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j] == s1)
                    {
                        str[i][0] = (string)s1;
                        str[i][j] = (string)s2;
                    }
                }

            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    Console.Write(str[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("6 задание:");
            count = 0;
            string v;

            for (int a = 0; a < 9; a++)
            {
                for (int b = 0, j = str[a].Length - 1; b < j; b++, j--)
                {
                    v = str[a][b];
                    str[a][b] = str[a][j];
                    str[a][j] = (string)v;
                }
            }

            for (int b = 0; b < 9; b++)
            {
                for (int j = 0; j < str[b].Length; j++)
                {
                    Console.Write(str[b][j] + " ");
                }
                Console.WriteLine();
            }
            count = 0;
            Console.WriteLine(" ");

            Console.WriteLine("7 задание:");
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    int n = str[i].Length;
                    Console.Write(n);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
    }
}
