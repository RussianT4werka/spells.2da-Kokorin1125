using System;
using System.IO;
using System.Linq;

                namespace spells._2da
                {
                class Program
                {
                static void Main(string[] args)
                {
                // Так как я понял лишь первое задание, то сделаю только его(во 2 и 3 я даже не понимаю чего от меня хотят а уж как это реализовать я и подавно не знаю)
                int a = 0, b = 0, c = 0;
                string path = @"C:\Users\sanya\Desktop\spells.2da";
                string line = File.ReadAllLines(path).First();
                string line1 = File.ReadAllLines(path).Skip(1).First();
                string line2 = File.ReadAllLines(path).Skip(2).First();
                char[] s = new char[] { ' ' };
                string[] spells = line2.Split(s, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < spells.Length; i++)
                {
                if (spells[i] == "Label")
                {
                    Console.Write($"{spells[i]} ");
                    a = i;
                }
                if (spells[i] == "ImpactScript")
                {
                    Console.Write($"\t\t\t\t{spells[i]} ");
                    b = i;
                }
                if (spells[i] == "Paladin")
                {
                    Console.Write($"\t\t\t\t{spells[i]} ");
                    c = i;
                }
                }
                Console.WriteLine();
                for (int i = 3; i < line2.Length; i++)
                {
                line2 = File.ReadAllLines(path).Skip(i).First();
                char[] s1 = new char[] { ' ' };
                string[] subs = line2.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (subs[c + 1] != "****")
                {
                    
                    Console.Write($"{subs[a + 1]} ");
                    Console.Write($"\t\t\t\t{subs[b + 1]} ");
                    Console.Write($"\t\t\t\t{subs[c + 1]} ");
                    Console.WriteLine(); // Ну а дальше, как я уже говорил, я не знаю))
                }
            }     
        }
    }
}
