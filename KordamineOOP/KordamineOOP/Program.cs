using KordamineOOP;
using System.IO;
using System.Runtime.InteropServices;
using static KordamineOOP.Kass;
using static KordamineOOP.Koer;


Koer koer = new Koer(Koer.toug.Jorkširi_terjer, "Bobik", "Punane", koduloom.sugu.isane, koduloom.sugu1.hight, 35.5, 7, true);
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
koerSave();


Console.WriteLine("---------------------------------------------------------------");
Console.ReadLine();
Kass kass = new Kass(Kass.toug1.sfinks, "Anton", "Rosa", koduloom.sugu.emane, koduloom.sugu1.hight, 20.4, 5, true);
kass.print_Info();
kass.print_Haal();
kassSave();

void koerSave()
{
    try
    {
        //Pass the filepath and filename to the StreamWriter Constructor
        StreamWriter sw = new StreamWriter("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\KordamineOOP\\loom.txt");
        //Write a second line of text
        sw.WriteLine($"{koer.toug1},{koer.varv},{koer.nimi},{koer.loomaSugu},{koer.kaal},{koer.vanus}");
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
}
void kassSave()
{
    try
    {
        //Pass the filepath and filename to the StreamWriter Constructor
        StreamWriter sw = new StreamWriter("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\KordamineOOP\\loom2.txt");
        //Write a line of text
        sw.WriteLine($"{kass.toug2},{kass.varv},{kass.nimi},{kass.loomaSugu},{kass.kaal},{kass.vanus},{kass.stealth} ");
      
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

}
Console.WriteLine("---------------------------------------------------------------");
List<Koer> list = new List<Koer>();
StreamReader sr = new StreamReader("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\KordamineOOP\\loom.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    list.Add(new Koer(rida[1], rida[2], convertToEnum(rida[3])));
    
}
Console.WriteLine("\n");
foreach (var item in list)
{

    Console.WriteLine("\n" + item.nimi + ", " + item.varv + ", "  + item.loomaSugu);

}
List<Kass> list1 = new List<Kass>();
StreamReader sr1 = new StreamReader("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\KordamineOOP\\loom2.txt");
string textb;
while ((textb = sr1.ReadLine()) != null)
{
    string[] rida1 = textb.Split(',');
    list1.Add(new Kass(rida1[1], rida1[2], convertToEnum(rida1[3])));

}
Console.WriteLine("\n");
foreach (var item in list1)
{

    Console.WriteLine("\n" + item.varv + ", " + item.nimi + ", " + item.loomaSugu);
    try
    {
        //Pass the filepath and filename to the StreamWriter Constructor
        StreamWriter sw = new StreamWriter("C:\\Users\\opilane.TTHK\\source\\repos\\ArtjomKabilovTARpv20\\KordamineOOP\\loom3.txt");
        //Write a line of text
        sw.WriteLine("\n" + item.varv + ", " + item.nimi + ", " + item.loomaSugu);

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
}

koduloom.sugu convertToEnum(string data)
{
    switch (data)
    {
        case "isane":
            return koduloom.sugu.isane;
        default:
            return koduloom.sugu.emane;
    }
}

