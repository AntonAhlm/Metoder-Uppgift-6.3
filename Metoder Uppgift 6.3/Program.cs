using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Addera tre tal \n" +
            "2. Största talet av två tal \n" +
            "3. Avsluta Programmet");
        string val = Console.ReadLine();

        switch (val)
        {
            case "1":
                {
                    Console.Write("Tal 1 : ");
                    int tal1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 2 : ");
                    int tal2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 3 : ");
                    int tal3 = Convert.ToInt32(Console.ReadLine());

                    MenyvalAddera(tal1, tal2, tal3);
                }
                break;

            case "2":
                {
                    Console.Write("Tal 1 : ");
                    int tal1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 2 : ");
                    int tal2 = Convert.ToInt32(Console.ReadLine());

                    MenyvalStörstaTalet(tal1, tal2);
                    break;
                }

            case "3":
                break;

        }

    }

    static void MenyvalAddera(int tal1, int tal2, int tal3)
    {
        Console.WriteLine((tal1 + tal2 + tal3));

    }

    static void MenyvalStörstaTalet(int tal1, int tal2)
    {
        int StörstaTalet=0;
        if (tal1 > tal2)
            StörstaTalet = tal1;
       

        else if (tal1 < tal2)
            StörstaTalet = tal2;

        Console.WriteLine("Största talet är : " + StörstaTalet);
    }


}
