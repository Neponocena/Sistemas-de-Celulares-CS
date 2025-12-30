using DesafioPOO.Models;


class Program
{
    static void Main(string[]args)
    {
        Smartphone nokia = new Nokia
        (
            numero: "11999999",
            modelo: "Nokia G21",
            imei: "1234567184",
            memoria: 128

        );

        Smartphone iphone = new Iphone
        (
            numero: "1197160546",
            modelo:"Iphone 13",
            imei:"782146",
            memoria:128
        );

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
