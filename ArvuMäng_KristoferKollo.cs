Random rnd = new();

int õigeArv = rnd.Next(1, 101);
int arv = 0;

while (arv != õigeArv)
{
    Console.Write("Arva number 1-100: ");
    arv = int.Parse(Console.ReadLine());

    if (arv == õigeArv)
    {
        Console.WriteLine("Õige! Sa arvasid numbri!");
    }
    else
    {
        if (arv < õigeArv)
        {
            Console.WriteLine("Arv on suurem.");
        }
        else
        {
            Console.WriteLine("Arv on väiksem.");
        }
    }
}