using DesafioPOO.Models;



Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "81993382269", modelo: "Nokia C30", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");


Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "81995460819", modelo: "Iphone 13", imei: "1111111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Linkedin");