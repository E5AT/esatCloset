using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace esatCloset
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> tshirt = new List<string>();
            List<string> shirt = new List<string>();
            List<string> jacket = new List<string>();
            List<string> trouser = new List<string>();
            List<string> belt = new List<string>();
            List<string> shoe = new List<string>();
            int[] choice = { 1, 1, 1, 1, 1, 1 };
            int rand, answer;
            bool again = false;
            string line = "", razdelitel = "------";

            Console.WriteLine("Ready presets:\n[0] Schule\n[1] Denim\n[2] Manual");
            answer = int.Parse(Console.ReadLine());
            if (answer == 0) choice[0] = 0;

            if (answer == 2)
            {
                while (true)
                {
                    Console.WriteLine(razdelitel);
                    Console.WriteLine($"[0] T-Shirt: {choice[0]}\n[1] Shirt: {choice[1]}\n[2] Jacket: {choice[2]}\n[3] Trouser: {choice[3]}\n[4] Belt: {choice[4]}\n[5] Shoe: {choice[5]}\n[6] OK");
                    answer = int.Parse(Console.ReadLine());
                    if (answer == 6) break;
                    else if (choice[answer] == 0) choice[answer] = 1;
                    else choice[answer] = 0;
                }
            }

                do
                {
                    Console.WriteLine(razdelitel);
                    if (choice[0] == 1)
                    {
                        StreamReader r = new StreamReader("tshirt.txt");
                        line = r.ReadLine();

                        while (line != null)
                        {
                            tshirt.Add(line);
                            line = r.ReadLine();
                        }

                        rand = random.Next(0, tshirt.Count - 1);
                        Console.WriteLine(tshirt[rand]);
                    }

                    if (choice[1] == 1)
                    {
                        StreamReader r = new StreamReader("shirt.txt");
                        line = r.ReadLine();

                        while (line != null)
                        {
                            shirt.Add(line);
                            line = r.ReadLine();
                        }

                        rand = random.Next(0, shirt.Count - 1);
                        Console.WriteLine(shirt[rand]);
                    }

                    if (choice[2] == 1)
                    {
                        StreamReader r = new StreamReader("jacket.txt");
                        line = r.ReadLine();

                        while (line != null)
                        {
                            jacket.Add(line);
                            line = r.ReadLine();
                        }

                        rand = random.Next(0, jacket.Count - 1);
                        Console.WriteLine(jacket[rand]);
                    }

                    if (choice[3] == 1)
                    {
                        StreamReader r = new StreamReader("trouser.txt");
                        line = r.ReadLine();

                        while (line != null)
                        {
                            trouser.Add(line);
                            line = r.ReadLine();
                        }

                        rand = random.Next(0, trouser.Count - 1);
                        Console.WriteLine(trouser[rand]);
                    }

                    if (choice[4] == 1)
                    {
                        StreamReader r = new StreamReader("belt.txt");
                        line = r.ReadLine();

                        while (line != null)
                        {
                            belt.Add(line);
                            line = r.ReadLine();
                        }

                        rand = random.Next(0, belt.Count - 1);
                        Console.WriteLine(belt[rand]);
                    }

                    if (choice[5] == 1)
                    {
                        StreamReader r = new StreamReader("shoe.txt");
                        line = r.ReadLine();

                        while (line != null)
                        {
                            shoe.Add(line);
                            line = r.ReadLine();
                        }

                        rand = random.Next(0, shoe.Count - 1);
                        Console.WriteLine(shoe[rand]);
                    }

                    Console.WriteLine(razdelitel);
                    if (Console.ReadLine() == string.Empty) again = true;
                    else again = false;
                } while (again == true);
        }
    }
}