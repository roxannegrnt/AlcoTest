/*
 * Authors: Roxanne Grant and Ardi Ramushi
 * Project: AlcoTest
 * Description: Gives you your level of alcohol according to what you drink
 * Version: 1.0
 * Date: April 2017
 */
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
        private bool serializer=true;

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
        //Returns masse
        public double Getmasse()
        {
            return modele.Masse * 1000;
        }
        //Returns sexe, 0 is female, 1 is male
        public char GetSexe()
        {
            char sexe = (modele.Sexe == 0) ? 'F' : 'H';
            return sexe;
        }
        //Returns dictionary of favorite alcohols
        public Dictionary<string, int> GetAlcFav()
        {
            return modele.AlcFav;
        }
        //Saves settings 
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
        //Returns all alcohol from file Alcoool.txt
        public Dictionary<string, int> AfficherToutAlcool(string filename)
        {
            modele.AfficherToutAlcool(filename);
            return modele.ToutAlc;
        }
        public Dictionary<string, int> AfficherAlcDemande(string filenameAlcFav, string filenameAlc)
        {
            //If nothing in favorite alcohol file then uploads file with all alcohols otherwise uploads favorite alcohol file
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
        //Serializes the Model when program is closed
        public void SerializeModel()
        {
            serializer = true;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, modele);
            stream.Close();
        }
        //Deserializes the Model when program is opened
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
