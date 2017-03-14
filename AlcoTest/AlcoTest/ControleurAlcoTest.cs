using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
        public double boire(int pourcentage)
        {
            modele.Boire(pourcentage);
            return modele.TauxAlc;
        }
        public void CalculerGrammeAlc(int pourcentage)
        {
            modele.CalculerGrammeAlc(pourcentage);
        }
        public double GetTaux()
        {
            return modele.TauxAlc;
        }
        public void SauverData(double paramMasse, char paramSexe)
        {
            modele.SauverData(paramMasse, paramSexe);
        }
        public void SauverAlcfav(Dictionary<string, int> paramListAlc, string filename)
        {
            modele.SauverAlcfav(paramListAlc, filename);
        }
        public void SetLitre(int litres)
        {
            modele.Litre = litres;
        }
        public Dictionary<string, int> AfficherToutAlcool(string filename)
        {
            if (modele.ToutAlc.Count == 0)
            {
                modele.AfficherToutAlcool(filename);
            }
            return modele.ToutAlc;
        }
        public Dictionary<string, int> AfficherAlcDemande(string filenameAlcFav, string filenameAlc)
        {
            modele.AfficherAlcoolFav(filenameAlcFav);
            if (modele.AlcFav.Count > 0)
            {
                return modele.AlcFav;
            }
            else
            {
                AfficherToutAlcool(filenameAlc);
                return modele.ToutAlc;
            }
        }
        public void Rafraichir()
        {
           modele.Rafraichir();
        }
        public void SerializeModel()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, modele);
            stream.Close();
        }
        public void DeserializeModel()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            ModeleAlcoTest modele = (ModeleAlcoTest)formatter.Deserialize(stream);
            stream.Close();  
        }


    }
}
