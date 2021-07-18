using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public void Browsing(string site)
        {
            bool isSite = false;

            for (int i = 0; i < site.Length; i++)
            {
                char siteChar = site[i];

                if (Char.IsDigit(siteChar))
                {
                    isSite = false;
                    break;
                }
                else
                {
                    isSite = true;
                }
            }

            if (isSite == true)
            {
                Console.WriteLine($"Browsing: {site}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void Calling(string number)
        {
            bool isNumber = false;

            for (int i = 0; i < number.Length; i++)
            {
                char numberChar = number[i];
                
                if (!Char.IsDigit(numberChar))
                {
                    isNumber = false;
                    break;
                }
                else
                {
                    isNumber = true;
                }
            }

            if (isNumber == true)
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
