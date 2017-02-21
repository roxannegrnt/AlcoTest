using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoTest
{
    class ControleurAlcoTest
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
        public void sauverAlcFav(Dictionary<string, int> paramListAlc, string filename)
        {
            modele.SauverAlcfav(paramListAlc, filename);
        }
        public void AfficherAlcool(string filename)
        {
            modele.AfficherAlcool(filename);
        }


    }
}
