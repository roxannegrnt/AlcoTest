using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
namespace AlcoTest
{
    [Serializable()]
    public class ModeleAlcoTest
    {
        private double _masse;
        private int _sexe;
        private int _clitre;
        private Dictionary<string, int> _alcFav;
        private Dictionary<string, int> _toutAlc;
        private double _TauxAlc;
        private DateTime _timer;

        public double Masse
        {
            get { return _masse; }
            set { _masse = value; }
        }

        public int Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }
        public int Litre
        {
            get { return _clitre; }
            set { _clitre = value; }
        }
        public Dictionary<string, int> AlcFav
        {
            get { return _alcFav; }
            set { _alcFav = value; }
        }

        public Dictionary<string, int> ToutAlc
        {
            get { return _toutAlc; }
            set { _toutAlc = value; }
        }

        public double TauxAlc
        {
            get { return _TauxAlc; }
            set { _TauxAlc = value; }
        }

        public DateTime Timer
        {
            get { return _timer; }
            set { _timer = value; }
        }
        public ModeleAlcoTest()
        {
            AlcFav = new Dictionary<string, int>();
            ToutAlc = new Dictionary<string, int>();
            //this.TauxAlc = 0;
            this.Masse = 0.06;
            this.Sexe = 0;
            this.Timer = DateTime.Now;
        }
        public double CalculerGrammeAlc(int pourcentage)
        {
            // grams of alcool for 1L.
            double gramsL = (pourcentage * 800) / 100;
            return (pourcentage * 800) / 100;
        }
        public double Boire(int pourcentage)
        {
            //TauxGenre takes 0.6 if gender is Female and 0.7 if gender is Male.
            double Tauxgenre = ((this.Sexe == 0) ? 0.6 : 0.7);
            //Quantity drank in cl * quantity of alcool for 1l gives grams for quantity drank.
            double gramme = (this.Litre * CalculerGrammeAlc(pourcentage)) / 100;
            this.TauxAlc += (gramme / (this.Masse * Tauxgenre))/10;
            this.TauxAlc = Math.Round(this.TauxAlc,2);
            return this.TauxAlc;
        }
        public void Rafraichir()
        {
            TimeSpan current = DateTime.Now - this.Timer;
            int diff = Convert.ToInt32(current.TotalSeconds);
            this.Timer = DateTime.Now;
            //15mg per h
            this.TauxAlc-=0.00416*diff;
            this.TauxAlc=Math.Round(this.TauxAlc, 5);
        }
        public void SauverData(double paramMasse, char paramSexe)
        {
            this.Masse = paramMasse/1000;
            this.Sexe = ((paramSexe == 'F') ? 0 : 1);
        }
        public void SauverAlcfav(Dictionary<string, int> paramListAlc, string filename)
        {
            StreamWriter swAlc = new StreamWriter(filename);
            foreach (var item in paramListAlc)
            {
                swAlc.WriteLine(item.Key + "," + item.Value);
            }
            this.AlcFav = paramListAlc;
            swAlc.Close();
        }
        public void AfficherToutAlcool(string filename)
        {
            string ligne = "";
            StreamReader srAlc = new StreamReader(filename, Encoding.UTF8);
            while (srAlc.EndOfStream == false)
            {
                ligne = srAlc.ReadLine();
                ligne = ligne.Replace("%", "");
                this.ToutAlc.Add(ligne.Split(',')[0], Convert.ToInt32(ligne.Split(',')[1]));
            }
            srAlc.Close();
        }
        //public void AfficherAlcoolFav(string filename)
        //{
        //    string ligne = "";
        //    StreamReader srAlc = new StreamReader(filename, Encoding.UTF8);
        //    while (srAlc.EndOfStream == false)
        //    {
        //        ligne = srAlc.ReadLine();

        //        this.AlcFav.Add(ligne.Split(',')[0], Convert.ToInt32(ligne.Split(',')[1]));

        //    }
        //    srAlc.Close();
        //}
    }
}
