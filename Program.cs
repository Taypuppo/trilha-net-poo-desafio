using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "2584", modelo: "Nokia X-30", imei: "NO-1603", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1406", modelo: "Iphone 7", imei: "I-1706", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");