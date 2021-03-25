using System;

namespace _04.PasswordValidator
{
    class Program
    {

        static void ValidatePassword(string text)
        {

            bool invalid = false;

            if (!(text.Length >= 6 && text.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }

            if (!PasswordConsistanci(text))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }

            if (PasswordCounter(text) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }

            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool PasswordConsistanci(string text)
        {

            for (int i = 0; i < text.Length; i++)
            {
                if (!(char.IsLetterOrDigit(text[i])))
                {
                    return false;
                    
                }
                
            }

            return true;
        }

        static int PasswordCounter(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] >= 48 && text[i] <= 57)
                {
                    counter++;
                }
                
            }
            return counter;
        }

        
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            ValidatePassword(password);

            
        }
    }
}
