// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
int r1y = rnd.Next(1, 3); //robot 1 yonu
int r2y = rnd.Next(1, 3); //robot 2 yonu 
// 1 cikarsa - yon , 2 cikarsa + yon 

int r1 = rnd.Next(-800, 800); //robot 1 indigi yer
int r2 = rnd.Next(-800, 800); //robot 2 indigi yer

int p1 = r1; //1. robot parasutu
int p2 = r2; //2. robot parasutu

int r1p = r1; //robot 1 pozitif yon
int r1n = r1; // robot 1 negatif yon
int r2p = r2; //robot 2 pozitif yon
int r2n = r2; // robot 2 negatif yon

Boolean r1Parasutbulundu = false;
Boolean r2Parasutbulundu = false;

Console.WriteLine($"r1 = {r1}");
Console.WriteLine($"r2 = {r2}");
Console.WriteLine($"r1y = {r1y}");
Console.WriteLine($"r2y = {r2y}");


while (r1 != r2 && r2 != r1 + 1 && r2 != r1 - 1)
{

    if (r1Parasutbulundu || r2Parasutbulundu)
    {
        while (r1 != r2 && r2 != r1 + 1 && r2 != r1 - 1)
        {
            if (r1y % 2 == 0)
            {
                r1 += 1;
                r2 -= 1;
            }
            else
            {
                r1 -= 1;
                r2 += 1;
            }
        }

        Console.WriteLine($"r2 r1i {r1}de buldu");
        return;

    }


    //R1
    if (r1y % 2 == 0)
    {


        r1p += 1;
        r1 = r1p;  // robotun son konumunu r1'de kayit altina aliyorum

        if (r1p == p2)
        {
            Console.WriteLine($" r1 p2 parasutunu {r1p}'de buldu");
            r1Parasutbulundu = true;

        }

        if (!r1Parasutbulundu)
        {
            r1y += 1; //eger parasutu bulamadiysa gittigi yonu degistiriyorum , bulduysa ayni yone devam ediyor.
        }
        Console.WriteLine($"r1 = {r1p}");
    }

    else if (r1y % 2 == 1)
    {
        r1n -= 1;
        r1 = r1n; // robotun son konumunu r1'de kayit altina aliyorum

        if (r1n == p2)
        {
            Console.WriteLine($" r1 p2 parasutunu {r1n}'de buldu");
            r1Parasutbulundu = true;

        }

        if (!r1Parasutbulundu)
        {
            r1y += 1;
        }


        Console.WriteLine($"r1 = {r1n}");
    }



    // R2
    if (r2y % 2 == 0)
    {
        r2p += 1;
        r2 = r2p;

        if (r2p == p1)
        {
            Console.WriteLine($" r2 p1'in parasutunu {r2p}'de buldu");
            r2Parasutbulundu = true;
        }

        if (!r2Parasutbulundu)
        {
            r2y += 1;
        }
        Console.WriteLine($"r2 = {r2p}");
    }
    else if (r2y % 2 == 1)
    {
        r2n -= 1;
        r2 = r2n;

        if (r2n == p1)
        {
            Console.WriteLine($" r2 p1'in parasutunu {r2n}'de buldu");
            r2Parasutbulundu = true;

        }


        if (!r2Parasutbulundu)
        {
            r2y += 1;
        }
        Console.WriteLine($"r2 = {r2n}");
    }

}

Console.WriteLine($"r2 r1i {r1}de buldu");