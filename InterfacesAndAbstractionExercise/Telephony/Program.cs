using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            string[] numbersInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (numbersInput[i].Length == 10)
                {
                    smartphone.Calling(numbersInput[i]);
                }
                else if (numbersInput[i].Length == 7)
                {
                    stationaryPhone.Calling(numbersInput[i]);
                }
            }

            string[] siteInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < siteInput.Length; i++)
            {
                smartphone.Browsing(siteInput[i]);
            }

            
        }
    }
}
