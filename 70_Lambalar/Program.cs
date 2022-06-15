bool Lamp1, Lamp2;
Lamp1 = Lamp2 = true;

//Lamp1=true Lamp2=false olarak ayrı değerde verebiliriz

Console.Write("Lamp1 : ");
if (Lamp1==true)
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

if (Lamp1==true && Lamp2==true)
{
    Console.WriteLine("Lambalardan biri yanıyor");
}


if (Lamp1 && Lamp2)
{
    Console.WriteLine("Lambalardan biri yanıyor");
}
   else if (Lamp1 == true || Lamp2 == false)
{
    Console.WriteLine("Lambalardan biri yanmıyor");
}
else
{
    Console.WriteLine("Karanlık");
}

    //burayı bi kurcala 1. lamba yanıyor 2.lamba yanmıyor gibi yazmaya çalış

    //biraz yaklaşarak yazdım yinede kurcalanabilir

// 3 lamba olarak yap. lambalardan 1i yanıyorsa aydınlık yazcaz. hepsi kapalıysa karanlık yazcaz

