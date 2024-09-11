using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n = new Nokia("(19)97150-9525", "G60", "001970-01-010000-0", 64);

Iphone i = new Iphone("(19)97150-9522", "15", "001970-01-010000-1", 256);

Console.WriteLine("Nokia: ");
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Nubank");

Console.WriteLine("Iphone: ");
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Spotify");