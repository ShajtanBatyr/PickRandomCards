using System;


namespace PickRandomCards
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                string[] cardArray = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in cardArray)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Число не действительно");
            }
        }
    }
}
