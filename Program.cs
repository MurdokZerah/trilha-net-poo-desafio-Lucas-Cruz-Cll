using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Test iPhone ===");
        Smartphone iphone = new Iphone("97777-1111", "iPhone 15 Pro Max", "111222333444", 256);
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
        iphone.ReceberLigacao();

        Console.WriteLine();

        Console.WriteLine("=== Test Nokia ===");
        Smartphone nokia = new Nokia("98888-2222", "Nokia Tijolão", "555666777888", 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
        nokia.ReceberLigacao();
    }
}
