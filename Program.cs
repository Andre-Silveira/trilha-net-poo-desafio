using DesafioPOO.Models;

Iphone iphone = new Iphone("99999-9999", "Iphone 13", "123456789", 16);
Nokia nokia = new Nokia("11111-1111", "Nokia 10", "987654321", 32);

Console.WriteLine("SmartPhone Iphone");
Console.WriteLine($"Número do Iphone: {iphone.Numero}");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("SmartPhone Nokia");
Console.WriteLine($"Número do Nokia: {nokia.Numero}");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");