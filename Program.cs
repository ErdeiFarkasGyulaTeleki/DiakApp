using DiakApp;

List<Diak> diakok = new List<Diak>();

int hibasSorokSzama = 0;

try
{
    string[] sorok = File.ReadAllLines("eredmenyek.csv", System.Text.Encoding.UTF8);

    sorok.Skip(1);

    for (int i = 0; i < sorok.Length; i++)
    {
        string sor = sorok[i];

        if (string.IsNullOrEmpty(sor) || sor.Equals(""))
        {
            continue;
        }

        string[] adatok = sor.Split(';');

        if (adatok.Length != 3)
        {
            hibasSorokSzama++;
            continue;
        }

        string nev = adatok[0];

        if (string.IsNullOrEmpty(nev))
        {
            hibasSorokSzama++;
            continue;
        }

        string osztaly = adatok[1];

        if (string.IsNullOrEmpty(osztaly))
        {
            hibasSorokSzama++;
            continue;
        }

        int pontszam = 0;
        bool pontszamParseSikeres = int.TryParse(adatok[2], out pontszam);

        if (!pontszamParseSikeres)
        {
            hibasSorokSzama++;
            continue;
        }

        Diak diak = new Diak(nev, osztaly, pontszam);
        diakok.Add(diak);
    }
} 
catch (Exception exception)
{
    Console.WriteLine("Hiba:" + exception.Message);
}

Console.WriteLine("Beolvasott diákok száma: " + diakok.Count);
foreach (Diak diak in diakok)
{
    Console.WriteLine(diak);
}