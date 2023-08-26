using System;

class Program
{
    public static void Main()
    {
        int intValue = 5;
        float floatValue = 3.23f;
        string stringValue = "World";

        FirstMethod(intValue);
        SecondMethod(floatValue);
        ThirdMethod(stringValue);
    }

    public static void FirstMethod(int intDeger)
    {
        if (intDeger % 2 == 0)
        {
            Console.WriteLine("Girilen Sayı Çift Sayıdır.");
        }
        else
        {
            Console.WriteLine("Girilen Sayı Tek Sayıdır");
        }
    }
    public static void SecondMethod(float floatDeger)
    {
        switch(floatDeger)
        {
            case 1:
                Console.WriteLine("Tam sayı.");
                break;
            case 2:
                Console.WriteLine("Tam sayı.");
                break;
            case 3.23f:
                Console.WriteLine("Ondalıklı sayı.");
                break;
                default: 
                Console.WriteLine("Ne tür bir sayı olduğu bilinmiyor.");
                break;
        }
    }
    public static void ThirdMethod(string stringDeger)
    {
        int i = 0;
        while (i < 2)
        {
            Console.WriteLine("Hello " + stringDeger);
            i++;
        }
    }
}
