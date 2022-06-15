bool Lamp1, Lamp2, Lamp3;
Lamp1 = true;
Lamp2 = false;
Lamp3 = true;

Console.Write("Lamp1 ; ");

if (Lamp1 == true)
{
    Console.WriteLine("Açık");
}
else
{
    Console.WriteLine("Kapali");
}

Console.Write("Lamp2 : ");
if (Lamp2)
{
    Console.WriteLine("Açık");
}
else
{
    Console.WriteLine("Kapali");
}

Console.Write("Lamp3 : ");

if (Lamp3)
{
    Console.WriteLine("Açık");
}
else
{
    Console.WriteLine("Kapali");
}

Console.WriteLine("---------------------");

if (Lamp1 && Lamp2 && Lamp3)
{
    Console.WriteLine("Lambaların Hepsi Yanıyor");
}
else if (Lamp1 == true && Lamp2 == true && Lamp3 == false)
{
    Console.WriteLine("Lambaların ikisi yaniyor");
}
else if (Lamp1 == true && Lamp2 == false && Lamp3 == true)
{
    Console.WriteLine("Lambaların ikisi yaniyor");
}
else if (Lamp1 == false && Lamp2 == true && Lamp3 == true)
{
    Console.WriteLine("Lambaların ikisi yaniyor");
}
else if (Lamp1 == true && Lamp2 == false && Lamp3 == false)
{
    Console.WriteLine("Lambaların biri yaniyor");
}
else if (Lamp1 == false && Lamp2 == true && Lamp3 == false)
{
    Console.WriteLine("Lambaların biri yaniyor");
}
else if (Lamp1 == false && Lamp2 == false && Lamp3 == true)
{
    Console.WriteLine("Lambaların biri yaniyor");
}
else if (Lamp1 == false && Lamp2 == false && Lamp3 == false)
{
    Console.WriteLine("Sen yanmazsam ben yanmazsam nasıl çıkar karanlıklar aydınlığa");
}
else
{
    Console.WriteLine("Bir sıkıntı var elektrikçi çağır");
}