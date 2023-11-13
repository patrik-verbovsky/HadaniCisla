int option;
Console.WriteLine("Hadani cisla\n\n1 - hada hrac\n2 - hada pocitac\n");
if (int.TryParse(Console.ReadLine(), out option))
{
    if (option == 1)
    {
        Console.Clear();
        int odpoved_hrace;
        Random random = new Random();
        int nahodne = random.Next(1, 101);
        Console.WriteLine("Myslim si cislo od 1 do 100...");
        bool true_answer = true;
        while (true_answer)
        {
            Console.Write("Cislo: ");
            if (int.TryParse(Console.ReadLine(), out odpoved_hrace))
            {
                if (odpoved_hrace >= 0 && odpoved_hrace == nahodne)
                {
                    Console.WriteLine("Gratuluji! Uhodls spravne...");
                    Console.WriteLine("Chces hrat znovu (ano/NE)?");
                    string pl = Console.ReadLine();
                    string cpl = pl.ToLower();
                    if (cpl == "ano")
                    {
                        true_answer = true;
                    }
                    else if (cpl == "ne")
                    {
                        true_answer = false;
                    }
                    else
                    {
                        true_answer = false;
                    }
                    true_answer = false;
                    Console.ReadLine();
                }
                else if (odpoved_hrace > nahodne && odpoved_hrace > 0 && odpoved_hrace < 101)
                {
                    Console.WriteLine("Neuhodls... hadej mensi cislo\n");
                    true_answer = true;
                }
                else if (odpoved_hrace < nahodne && odpoved_hrace > 0 && odpoved_hrace < 101)
                {
                    Console.WriteLine("Neuhodls... hadej vetsi cislo\n");
                    true_answer = true;
                }
                else
                {
                    Console.WriteLine("Cislo neni v rozsahu cisel (1-100).\n");
                }
            }
            else
            {
                Console.WriteLine("Neplatne cislo...\n");
            }
        }
    }
    else if (option == 2)
    {
        Console.Clear();
        bool true_answer = true;
        Console.WriteLine("Vymysli si cislo od 1 do 100...");
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i + " ");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Random random = new Random();
        while (true_answer)
        {
            int guess = random.Next(1, 101);
            Console.WriteLine("Je cislo, co si myslis " + guess + "?");
            Console.WriteLine("(ano/ne)");
            string ans = Console.ReadLine();
            string uans = ans.ToLower();
            if (uans == "ano")
            {
                Console.WriteLine("Vyhral jsem.");
                Console.WriteLine("Chces hrat znovu (ano/NE)?");
                string pl = Console.ReadLine();
                string cpl = pl.ToLower();
                if (cpl == "ano")
                {
                    true_answer = true;
                }
                else if (cpl == "ne")
                {
                    true_answer = false;
                }
                else
                {
                    true_answer = false;
                }
            }
            else
            {
                Console.WriteLine("Zkusim znova...\n");
                true_answer = true;
            }
        }
    }
    else
    {
        Console.WriteLine("Spatna volba.");
    }
}
else
{
    Console.WriteLine("Neplatne zadani.");
}