using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
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
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
