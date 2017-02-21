using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoTest
{
    public class ControleurAlcoTest
    {
        private ModeleAlcoTest modele;
        private VueAcloTest vueAlc;

        public ControleurAlcoTest(VueAcloTest mavue)
        {
            vueAlc = mavue;
            modele = new ModeleAlcoTest();
        }
        public void boire(int pourcentage)
        {
            modele.Boire(pourcentage);
        }
        public void CalculerGrammeAlc(int pourcentage)
        {
            modele.CalculerGrammeAlc(pourcentage);
        }
        public void SauverData(int paramMasse, char paramSexe)
        {
            modele.SauverData(paramMasse,paramSexe);
        }
        public void SauverAlcfav(Dictionary<string, int> paramListAlc, string filename)
        {
            modele.SauverAlcfav(paramListAlc, filename);
        }
        public void SetLitre(int litres)
        {
             modele.Litre=litres;
        }
        public Dictionary<string, int> AfficherToutAlcool(string filename)
        {
            modele.AfficherToutAlcool(filename);
            return modele.ToutAlc;
        }
        public Dictionary<string,int> AfficherAlcDemande(string filenameAlcFav, string filenameAlc)
        {
            modele.AfficherAlcoolFav(filenameAlcFav);
            if (modele.AlcFav.Count>0)
            {
                return modele.AlcFav;
            }
            else
            {
                AfficherToutAlcool(filenameAlc);
                return modele.ToutAlc;
            }
        }


    }
}
