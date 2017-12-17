using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voiture
{
    class utilisationVoiture
    {
        static void Main(string[] args)
        {
            // saisie des informations du véhicule;
            string construct;
            string marq;
            string num;
            int nbp;
            DateTime mcircul = new DateTime(2016, 01, 07);
            Console.WriteLine("saisissez le constructeur");
            construct = Console.ReadLine();

            Console.WriteLine("saisissez la marque");
            marq = Console.ReadLine();

            Console.WriteLine("saisissez le numéro d'immatriculation");
            num = Console.ReadLine();




            Voiture v1 = new Voiture(construct, marq, num);
            v1.affiche();
            Console.WriteLine("n° d'immatriculation : {0}",v1.getNumImmat());

            Console.WriteLine("saisissez le constructeur");
            construct = Console.ReadLine();

            Console.WriteLine("saisissez la marque");
            marq = Console.ReadLine();

            Console.WriteLine("saisissez le numéro d'immatriculation");
            num = Console.ReadLine();
            Console.WriteLine("saisissez le nb portes");
            nbp = Int32.Parse(Console.ReadLine());

            Voiture v2 = new Voiture(construct, marq, num, nbp, mcircul);

            Console.WriteLine("n° d'immatriculation : {0}", v2.getNumImmat());

            Console.ReadLine();







        }
    }
}
