namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValidatePassword(string password) - methodunuz olur,
            //parameter olaraq qebul etdiyi stringin uzunlugu minimum 8, böyük hərflə başlamalı,
            //tərkibində minimum 1 rəqəm olmalı və minimum 1 karakter (hərf və ya rəqəm olmayan: misal  ?, !, @) olmalıdır.
            //Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır.

            //Console.Write("Enter password: ");
            //while (!ValidatePassword(Console.ReadLine()))
            //{
            //    Console.Write("Enter password: ");
            //}

            //String`in Replace(), Substring(),Trim() methodlarını custom şəkildə yazmaq.
            //Yəni sizin custom yazdığınız methodlarla stringin methodları eyni işi görməlidir.

            Console.WriteLine(CustomReplace("Hello World",'l','1'));
            Console.WriteLine(CustomSubstring("Hello World", 6));
            Console.Write(CustomTrim("      Hello     World    "));

        }

        static bool ValidatePassword (string password)
        {
            bool isDigit = false;
            bool isSymbol = false;
            bool result = false;
            if (password.Length>=8 && char.IsUpper(password[0]))
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                    {
                        isDigit = true;
                    }
                    if (!char.IsLetterOrDigit(password[i]))
                    {
                        isSymbol = true;
                    }
                }
                if (isDigit && isSymbol)
                {
                    result = true;
                }
            }
            return result;
        }

        static string CustomReplace(string text, char oldChar, char newChar)
        {
            string newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == oldChar)
                {
                    newText += newChar;
                }
                else {
                    newText += text[i];
                }
            }
            return newText;
        }

        static string CustomSubstring(string text, int index)
        {
            string newText = string.Empty;
            for (int i = index; i < text.Length; i++)
            {
                newText += text[i];
            }
            return newText;
        }

        static string CustomTrim(string text)
        {
            string newText = string.Empty;
            bool isEmpty = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && isEmpty)
                {
                    continue;
                }
                else
                {
                    newText += text[i];
                    isEmpty = false;
                }
            }
           
            return newText; 
        }

    }
}
