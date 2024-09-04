using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Iphone iphone = new Iphone("12345", "Iphone", "123BCQ", 16);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Nokia nokia= new Nokia("67890", "Nokia", "B443C4", 32);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

