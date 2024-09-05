using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


System.Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia("1234-567","Modelo 1","111111",128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


System.Console.WriteLine(" \n");

System.Console.WriteLine("Smartphone Iphone");

Smartphone iphone  = new Iphone("555-1234","Modelo 15","2222",64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");