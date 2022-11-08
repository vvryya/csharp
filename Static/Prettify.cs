using System;

namespace Static
{

    static class TextFrame
    {
        private static int _textsPretified;

        static TextFrame()
        {
            _textsPretified = 0;
        }

        private static void UpDown(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        public static void Prettify(int len,string text)
        {
            _textsPretified++;
            
            Console.WriteLine($"Processing text: {_textsPretified}");

            UpDown(len);

            string[] words = text.Split(' ');
            int wordsCount = words.Length;

            int wordIndex = 0;
            while(wordIndex < wordsCount)
            {
                Console.Write("*");
                int position = 1;

                while ((wordIndex < wordsCount) && (position + (words[wordIndex].Length + 1) <= len - 2))
                {
                    Console.Write(" " + words[wordIndex]);
                    position += words[wordIndex].Length + 1;
                    wordIndex++;
                }

                for(int i = position; i < len - 2; i++)
                    Console.Write(' ');

                Console.WriteLine(" *");
            }

            UpDown(len);
        }
    }


    class PresidentIsEvenMoreWeird
    {
        public static void Main()
        {
            var len = int.Parse(Console.ReadLine());
            var text = Console.ReadLine();

            while (text != "exit")
            {
                TextFrame.Prettify(len, text);
                text = Console.ReadLine();
            }
        }
    }
}