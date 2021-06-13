using System;

namespace Test_No._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumofItem = int.Parse(Console.ReadLine());
            string[] Item = new string [NumofItem];
            string[] ItemType = new string[NumofItem];

            int slot = 0;
            for (int i = 1; i <= NumofItem; i++)
            {
                Console.Write("Item: ");
                Item [slot] = Console.ReadLine();
                Console.Write("Type: ");
                ItemType [slot] = Console.ReadLine();
                slot++;
            }

            while (true)
            {
                Console.Write("Input Mode: ");
                string Mode = Console.ReadLine();


                if (Mode == "Showall")
                {
                    int slot1 = 0;
                    for (int j = 1; j <= NumofItem; j++)
                    {
                        Console.WriteLine(Item[slot1]);
                        Console.WriteLine(ItemType[slot1]);
                        Console.WriteLine();
                        slot1++;
                    }
                }
                else
                {
                    Console.WriteLine("End;");
                    return;
                }
            }
        }
    }
}
