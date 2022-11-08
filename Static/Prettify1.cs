using System;

namespace Static
{
    
    static class TextFramePretifier
    {
        private static int _textsPretified;

        static TextFramePretifier()
        {
            _textsPretified = 0;
        }

        public static void Prettify(string text)
        {
            _textsPretified++;

            Console.WriteLine($"Processing text: {_textsPretified}");

            for(int l = 0; l < 3; l++)
            {
                if (l == 1)
                    Console.WriteLine($"* {text} *");
                else
                {
                    for (int i = 0; i < text.Length + 4; i++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    class PresidentIsWeird
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            
            while(text != "exit")
            {
                TextFramePretifier.Prettify(text);
                text = Console.ReadLine();
            }
        }
    }
}