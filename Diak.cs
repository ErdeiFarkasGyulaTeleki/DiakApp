namespace DiakApp
{
    public class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }

        private int pontszam;
        public int Pontszam
        {
            get { return pontszam; }
            set { pontszam = Math.Clamp(value, 0, 100); }
        }

        public Diak(string _nev, string _osztaly, int _pontszam)
        {
            Nev = _nev;
            Osztaly = _osztaly;
            Pontszam = _pontszam;
        }

        public override string ToString()
        {
            return $"{Nev} ({Osztaly}) - {Pontszam} pont";
        }
    }
}
