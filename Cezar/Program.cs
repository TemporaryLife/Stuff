using System;
using System.IO;
using System.Text;

namespace Cezar
{
    class Cezar
    {
        private string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        private StringBuilder ToCezar(string file_path, int key)
        {
            string a = File.ReadAllText(file_path);
            var res = new StringBuilder();
            int index;
            char symb_toadd;
            bool isHigh;

            foreach (char symb in a)
            {

                index = Alphabet.IndexOf(Char.ToLower(symb));
                isHigh = index < 0 ? false : (symb == Char.ToUpper(Alphabet[index])) ? true : false;
                symb_toadd = (index < 0) ? symb : Alphabet[(Alphabet.Length + index + key) % Alphabet.Length];
                if (isHigh) symb_toadd = Char.ToUpper(symb_toadd);
                res.Append(symb_toadd);

            }

            File.WriteAllText(file_path, res.ToString());
            return res;
        }

        public void Encrypt(string file_path, int key) => ToCezar(file_path, key);
        public void Decrypt(string file_path, int key) => ToCezar(file_path, -key);

    }


    class Vijener
    {
        private string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        public StringBuilder ToVijener(string file_path, string key_word, bool ToDecrypt)
        {
            int i = 0, index_init, index_key;
            char symb_toadd;
            bool isHigh;
            string text = File.ReadAllText(file_path);
            StringBuilder Result_KeyWord = new StringBuilder();
            StringBuilder KeyWord_B = new StringBuilder(key_word);
            StringBuilder res = new StringBuilder();


            while (Result_KeyWord.Length < text.Length)
            {
                Result_KeyWord.Append(KeyWord_B[i % KeyWord_B.Length]);
                i++;
            }

            for (int j = 0; j < text.Length; j++)
            {

                index_init = Alphabet.IndexOf(Char.ToLower(text[j]));
                index_key = Alphabet.IndexOf(Char.ToLower(Result_KeyWord[j]));
                isHigh = index_init < 0 ? false : (text[j] == Char.ToUpper(Alphabet[index_init])) ? true : false;
                if (!ToDecrypt)
                {
                    symb_toadd = (index_init < 0) ? text[j] : Alphabet[(index_init + index_key) % Alphabet.Length];
                }
                else
                {
                    symb_toadd = (index_init < 0) ? text[j] : Alphabet[(index_init - index_key + Alphabet.Length) % Alphabet.Length];
                }

                if (isHigh) symb_toadd = Char.ToUpper(symb_toadd);
                res.Append(symb_toadd);

            }

            File.WriteAllText(file_path, res.ToString());
            return res;
        }

        public void Encrypt(string file_path, string keyword, bool Decrypt) => ToVijener(file_path, keyword, Decrypt);
        public void Decrypt(string file_path, string keyword, bool Decrypt) => ToVijener(file_path, keyword, Decrypt);
    }

    class Abonents
    {
        private Random rnd = new Random();
        public int g;
        public int p;
        public int x;
        public int X;
        public Abonents(int g, int p)
        {

            this.g = g;

            this.p = p;

            this.x = rnd.Next(1, 20);
            Console.WriteLine("-------");
            Console.WriteLine(Math.Pow(g, x));
            Console.WriteLine("-------");
            this.X = (int)(Math.Pow(g, x) % p);
            Console.Write("Остаток ");
            Console.WriteLine(Math.Pow(g, x) % p);
            Console.WriteLine((int)Math.Pow(g, x) % p);
        }



        public int GetKey(int X)
        {
            return (int)(Math.Pow(X, x) % p);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            /*var Test1 = new Vijener();
            Console.WriteLine(Test1.ToVijener(@"C:\Users\Konstantin\Downloads\text.txt", "Lemon", true));*/

            /*var rnd = new Random();
            int p = rnd.Next(1, 10);


            int g = rnd.Next(1, 10);
            Console.WriteLine($"P:{p}");
            Console.WriteLine($"g:{g}");
            var A1 = new Abonents(g, p);
            var A2 = new Abonents(g, p);
            Console.WriteLine($"a: {A1.x}");
            Console.WriteLine($"b: {A2.x}");
            Console.WriteLine($"A: {A1.X}");
            Console.WriteLine($"B: {A2.X}");

            Console.WriteLine(A1.GetKey(A2.X));
            Console.WriteLine(A2.GetKey(A1.X));*/

            decimal i=135136712371124265124123136m%317;
            Console.WriteLine(i);


        }
    }
}
