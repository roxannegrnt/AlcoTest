using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoTest
{
    class ModeleAlcoTest
    {
        private int _masse;
        private int _sexe;
        private int _clitre;
        private List<string> _alcFav;
        private List<string> _toutAlc;
        private double _TauxAlc;
        private int _timer;

        public int Masse
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
        public List<string> AlcFav
        {
            get { return _alcFav; }
            set { _alcFav = value; }
        }

        public List<string> ToutAlc
        {
            get { return _toutAlc; }
            set { _toutAlc = value; }
        }

        public double TauxAlc
        {
            get { return _TauxAlc; }
            set { _TauxAlc = value; }
        }

        public int Timer
        {
            get { return _timer; }
            set { _timer = value; }
        }
        public ModeleAlcoTest()
        {
            this.TauxAlc = 0;
        }
        public double CalculerGrammeAlc(int pourcentage)
        {
            // grams of alcool for 1L.
            return (pourcentage * 800) / 100;
        }
        public double Boire(int pourcentage)
        {
            //TauxGenre takes 0.6 if gender is Female and 0.7 if gender is Male.
            double Tauxgenre = ((this.Sexe == 0) ? 0.6 : 0.7);
            //Quantity drank in cl * quantity of alcool for 1l gives grams for quantity drank.
            double gramme = (this.Litre*CalculerGrammeAlc(pourcentage))/100;
            this.TauxAlc += gramme / (this.Masse * Tauxgenre);
            return this.TauxAlc;
        }
        public void Rafraichir()
        {

        }
        public void DessineGraphique()
        {

        }
        public void SauverData()
        {

        }
        public void AfficherAlcool()
        {

        }
    }
}
