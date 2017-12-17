using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voiture
{
   public class Voiture
    {
        //données membres
        string constructeur;
        string marque;
        string numImmatriculation;
        DateTime dateMiseCirculation;
        int nbPortes;
        int Energie;
        decimal prix;
        int kilometrage;
        int vitesse;
        int capaciteReservoir;
        bool cleSurVolant;
        bool ceintureBouclee;
       // méthodes pour accéder aux données
        public string getNumImmat()
        {
            return numImmatriculation;
        }
        public void setNumImmat(string numImmat)
        {
            numImmatriculation = numImmat;
        }
       // constructeur
        public Voiture(string construct, string marq, string num)
        {
            constructeur = construct;
            marque = marq;
            numImmatriculation = num;
        }
        public Voiture(string construct, string marq, string num,int nbp, DateTime mcircul)
        {
            constructeur = construct;
            marque = marq;
            numImmatriculation = num;
            nbPortes = nbp;
            dateMiseCirculation = mcircul;
        }
            public void affiche()
        {
        Console.WriteLine("véhicule de constructeur {0} de marque {1} n° d'immatriculation {2} roule à {3}", constructeur, marque, numImmatriculation, vitesse);
	    Console.ReadLine();
        }
            public void ceintureBoucle()
        {
            ceintureBouclee = false;

        }
            public void démarrer()
        {
            vitesse = 10;
	}
    }
}
