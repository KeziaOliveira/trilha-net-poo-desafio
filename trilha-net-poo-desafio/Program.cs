using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Teste com o Nokia
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "1111111111111", memoria: 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");
        
        // Teste com o Iphone
        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "2222222222222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}