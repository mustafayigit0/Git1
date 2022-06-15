//Mini Atm Uygulaması
//1 Bakiye öğrenme
//2 Para Çekme
//3 Para Yatırma
//q Çıkış



Console.WriteLine("Mini ATM");

Console.WriteLine("-------------------------");

Console.WriteLine("Yapmak Istediginiz Islemi Seciniz");

int bakiye = 1000;
string secim = Console.ReadLine();

if(secim == "1")
{
    Console.WriteLine("Suanki Bakiyeniz : " + bakiye);

}

else if(secim == "2")
{
    Console.WriteLine("Cekmek Istediginiz Tutari Giriniz");
    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

    if(cekilecek_tutar<=bakiye)
    {
        Console.WriteLine("Kalan Tutar:" + (bakiye - cekilecek_tutar));
    }
    else
    { Console.WriteLine("Bakiyenizden Fazla Para Cekemezsiniz");
    }
    
   
}

else if(secim=="3")
    {
    Console.WriteLine("Yatirmak Istediginiz Tutari Giriniz");
    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yeni Bakiyeniz:" +(bakiye+yatirilacak_tutar));
}

else if (secim =="q")

{
    Console.WriteLine("Atm'den Cikis Yapiliyor");
    Console.WriteLine("Cikis Yapildi");

}

else 
{
    Console.WriteLine("Lutfen Gecerli Bir Deger Giriniz");
}