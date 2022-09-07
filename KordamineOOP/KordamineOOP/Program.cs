using KordamineOOP;
using System.IO;
using static KordamineOOP.Kass;
using static KordamineOOP.Koer;


Koer koer = new Koer(Koer.toug.Haski, "Sarik", "Punane", koduloom.sugu.isane, koduloom.sugu1.hight, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
//File.WriteAllText(path, createText);
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Nika");
veelkoer.muudaVarv("Pruun");
veelkoer.muudaLoomaSugu(koduloom.sugu.emane);
veelkoer.muudaKaal(15.5);
veelkoer.muudaVanus(5);
veelkoer.muudaElav(true);
veelkoer.muudaToug1(Koer.toug.Jorkširi_terjer);
veelkoer.print_Info();

Console.WriteLine("---------------------------------------------------------------");
Console.ReadLine();
Kass kass = new Kass(Kass.toug1.sfinks, "Murka", "Rosa", koduloom.sugu.emane, koduloom.sugu1.hight, 20.4, 5, true);
kass.print_Info();
kass.print_Haal();
try
{
    //Pass the filepath and filename to the StreamWriter Constructor
    StreamWriter sw = new StreamWriter("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\loom.txt");
    //Write a line of text
    sw.WriteLine($"{kass.toug2}, {kass.varv}, {kass.nimi}, ta on {kass.loomaSugu}, ja tema kaal on {kass.kaal}, ja ta on {kass.vanus},aastat vana, tema salapära {kass.stealth} ");
    //Write a second line of text
    sw.WriteLine($"{koer.toug1}, {koer.varv}, {koer.nimi}, ta on {koer.loomaSugu}, ja tema kaal on {koer.kaal}, ja ta on {koer.vanus} aastat vana");
    //Close the file
    sw.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}
List<Koer> list = new List<Koer>();
StreamReader sr = new StreamReader("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\loom.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    list.Add(new Koer(rida[0], rida[1]));
}
Console.WriteLine("\n");
foreach (var item in list)
{
    
    Console.WriteLine("\n" + item.varv +", "+ item.nimi+", " + item.loomaSugu);
}


