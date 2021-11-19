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

            for (int j=0; j <text.Length; j++)
            {

                index_init = Alphabet.IndexOf(Char.ToLower(text[j]));
                index_key=Alphabet.IndexOf(Char.ToLower(Result_KeyWord[j]));
                isHigh = index_init < 0 ? false : (text[j] == Char.ToUpper(Alphabet[index_init])) ? true : false;
                if (!ToDecrypt)
                {
                    symb_toadd = (index_init < 0) ? text[j] : Alphabet[(index_init + index_key) % Alphabet.Length];
                }
                else
                {
                    symb_toadd = (index_init < 0) ? text[j] : Alphabet[(index_init - index_key+Alphabet.Length) % Alphabet.Length];
                }

                if (isHigh) symb_toadd = Char.ToUpper(symb_toadd);
                res.Append(symb_toadd);

            }

            File.WriteAllText(file_path,res.ToString());
            return res;    
        }

        public void Encrypt(string file_path, string keyword, bool Decrypt) => ToVijener(file_path, keyword, Decrypt);
        public void Decrypt(string file_path, string keyword, bool Decrypt) => ToVijener(file_path, keyword,  Decrypt);
    }
    class Program
    {
        static void Main(string[] args)
        {

            var Test1 = new Vijener();
            Console.WriteLine(Test1.ToVijener(@"C:\Users\Konstantin\Downloads\text.txt", "Lemon", true));

        }
    }
}
