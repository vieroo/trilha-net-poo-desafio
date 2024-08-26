using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("9998-0487", "Tijolao", 32, "as6d54ad654ada6");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");


Iphone iPhone = new Iphone("8899-8458", "13 Pro Max", 16, "asduhadu564856");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Netflix");