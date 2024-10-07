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
            List<int> comb = new List<int>();
            int[] choice = { 1, 1, 1, 1, 1, 1 };
            int rand;
            int answer;
            

            while (true)
            {
                Console.WriteLine("Ready presets:\n[0] Schule\n[1] Denim\n[2] Manual");
                answer = int.Parse(Console.ReadLine());
                if (answer == 0) choice[0] = 0;

                Console.WriteLine($"[0] T-Shirt: {choice[0]}\n[1] Shirt: {choice[1]}\n[2] Jacket: {choice[2]}\n[3] Trouser: {choice[3]}\n[4] Belt: {choice[4]}\n[5] Shoe: {choice[5]}\n[6] OK");
                answer = int.Parse(Console.ReadLine());
                if (answer == 6) break;
                else if (choice[answer] == 0) choice[answer] = 1;
                else choice[answer] = 0;
            }

            if (choice[0] == 1)
            {
                StreamReader tR = new StreamReader("E:\\esatCloset\\tshirt.txt");
                string line = tR.ReadLine();

                while (line != null)
                {
                    tshirt.Add(line);
                    line = tR.ReadLine();
                }

                rand = random.Next(0, tshirt.Count - 1);
                Console.WriteLine(tshirt[rand]);
                comb.Add(rand);
            } else comb.Add(-1);

            if (choice[1] == 1)
            {
                StreamReader sR = new StreamReader("E:\\esatCloset\\shirt.txt");
                string line = sR.ReadLine();

                while (line != null)
                {
                    shirt.Add(line);
                    line = sR.ReadLine();
                }

                rand = random.Next(0, shirt.Count - 1);
                Console.WriteLine(shirt[rand]);
                comb.Add(rand);
            } else comb.Add(-1);

            if (choice[2] == 1)
            {
                StreamReader jR = new StreamReader("E:\\esatCloset\\jacket.txt");
                string line = jR.ReadLine();

                while (line != null)
                {
                    jacket.Add(line);
                    line = jR.ReadLine();
                }

                rand = random.Next(0, jacket.Count - 1);
                Console.WriteLine(jacket[rand]);
                comb.Add(rand);
            } else comb.Add(-1);

            if (choice[3] == 1)
            {
                StreamReader trR = new StreamReader("E:\\esatCloset\\trouser.txt");
                string line = trR.ReadLine();

                while (line != null)
                {
                    trouser.Add(line);
                    line = trR.ReadLine();
                }

                rand = random.Next(0, trouser.Count - 1);
                Console.WriteLine(trouser[rand]);
                comb.Add(rand);
            } else comb.Add(-1);

            if (choice[4] == 1)
            {
                StreamReader bR = new StreamReader("E:\\esatCloset\\belt.txt");
                string line = bR.ReadLine();

                while (line != null)
                {
                    belt.Add(line);
                    line = bR.ReadLine();
                }

                rand = random.Next(0, belt.Count - 1);
                Console.WriteLine(belt[rand]);
                comb.Add(rand);
            } else comb.Add(-1);

            if (choice[5] == 1)
            {
                StreamReader sR = new StreamReader("E:\\esatCloset\\shoe.txt");
                string line = sR.ReadLine();

                while (line != null)
                {
                    shoe.Add(line);
                    line = sR.ReadLine();
                }

                rand = random.Next(0, shoe.Count - 1);
                Console.WriteLine(shoe[rand]);
                comb.Add(rand);
            } else comb.Add(-1);

            StreamWriter w = new StreamWriter("E:\\esatCloset\\combinations.txt",true);
            w.WriteLine(string.Join(" ", comb));
            w.Close();
        }
    }
}
