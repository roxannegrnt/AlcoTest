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
        private bool serializer = false;

        public bool Serializer
        {
            get { return serializer; }
            set { serializer = value; }
        }

        public ControleurAlcoTest(VueAcloTest mavue)
        {
            vueAlc = mavue;

            modele = DeserializeModel();
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
        public double Getmasse()
        {
            return modele.Masse * 1000;
        }
        public char GetSexe()
        {
            char sexe = (modele.Sexe == 0) ? 'F' : 'H';
            return sexe;
        }
        public Dictionary<string, int> GetAlcFav()
        {
            return modele.AlcFav;
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
            modele.AfficherToutAlcool(filename);
            return modele.ToutAlc;
        }
        public Dictionary<string, int> AfficherAlcDemande(string filenameAlcFav, string filenameAlc)
        {
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
            serializer = true;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, modele);
            stream.Close();
        }
        public ModeleAlcoTest DeserializeModel()
        {
            serializer = false;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            ModeleAlcoTest modele = (ModeleAlcoTest)formatter.Deserialize(stream);
            stream.Close();
            return modele;
        }
        public void SupprimerAlcFav(string lsbItem, string filename)
        {
            modele.SupprimerAlcFav(lsbItem, filename);
        }


    }
}
