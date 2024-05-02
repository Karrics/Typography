using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Typography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Text_Rule1(string input)
        {
            // Исключение пробелов перед знаками препинания из строки
            string str = Regex.Replace(input, @"\s+([.,:;!?""”[)}\]>»])", "$1");

            // Постановка пробела после знаков препинания 
            str = Regex.Replace(str, @"(\w)([.,:;!?])(\w)", "$1$2 $3");

            // Постановка пробела до и после тире
            str = Regex.Replace(str, @"\s*-\s*", " - ");

            // Сслитное написание скобочек и кавычек
            str = Regex.Replace(str, @"([""“([{<«])\s*(\w)", " $1$2");
            str = Regex.Replace(str, @"(\w)([""”[)}\]>»])(\w)", "$1$2 $3");

            return str;
        }

        public static string Text_Rule2(string input)
        {
            return Regex.Replace(input, @"\s{2,}", " ");
        }

        public static string Text_Rule9(string input)
        {
            return input.Replace("+-", "±").Replace("-+", "±");
        }

        public static string Text_Rule12(string input)
        {
            input = Regex.Replace(input, @"\^2", "²");
            input = Regex.Replace(input, @"\^3", "³");

            return input; 
        }

        public static string Text_Rule13(string input)
        {
            return input.Replace("...", "…");
        }

        // Чередование заглавных и прописных букв
        public static string My_Rule1(string input)
        {
            char[] characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (char.IsLetter(characters[i]))
                {
                    characters[i] = i % 2 == 0 ? char.ToUpper(characters[i]) : char.ToLower(characters[i]);
                }
            }

            return new string(characters);
        }

        // Удаление каждого пятого символа
        public static string My_Rule2(string input)
        {
            int charIndex = 0;
            string result = "";

            foreach (char c in input)
            {
                charIndex++;
                if (charIndex % 5 != 0) 
                {
                    result += c;
                }
            }

            return result;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            textBox1.Text = My_Rule1(Text_Rule2(Text_Rule1(My_Rule2(Text_Rule13(Text_Rule12(Text_Rule9(text)))))));
        }
    }
}
