namespace _0926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //magyarkártya
            string[] cards = {"a","f","k","7","8","9","10","asz"};
            int[] values = {2,3,4,7,8,9,10,11};
            Console.WriteLine("Adja meg a kártyáját");
            string card = Console.ReadLine();
            int value = 0;
            /*for(int i = 0; i < cards.Length; i++) { 
                if(card == cards[i])
                {
                    value = values[i];
                }
            }*/
            int i = 0;
            while (cards[i] != card)
            {
                i++;
            }
            value = values[i];
            if (value == 0)
            {
                Console.WriteLine("Nincs ilyen kártya");
            }
            else
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}