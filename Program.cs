using DesafioPOO.Models;

Console.WriteLine("");

Console.WriteLine("SMARTPHONE NOKIA:");
Nokia g1 = new Nokia("81790712","MODELO 01","11111111",567);
g1.Ligar();
g1.InstalarAplicativo("Whatsapp");
Console.WriteLine("CONFIGURAÇÃO");
g1.Configuracao();

//////////////////////////////////////////////////////////////////
Console.WriteLine("");
//////////////////////////////////////////////////////////////////////

Console.WriteLine("SMARTPHONE IPHONE:");
Iphone s14 = new Iphone("83243256","MODELO 01","2222222",123);
s14.ReceberLigacao();
s14.InstalarAplicativo("Telegram");

Console.WriteLine("CONFIGURAÇÃO");
s14.Configuracao();


Console.WriteLine("");

