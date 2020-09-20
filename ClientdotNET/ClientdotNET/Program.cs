using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientdotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.BqServiceClient stub = 
                new ServiceReference1.BqServiceClient();
            Console.WriteLine(stub.ConversionEuroToDh(90));

            ServiceReference1.compte cpt = stub.getCompte(2);
            Console.WriteLine("Code :"+ cpt.code);
            Console.WriteLine("Solde :" + cpt.solde);

            Console.WriteLine("----------- Affichage de La listes ---------");
            ServiceReference1.compte[] cpts = stub.listCompte();
            foreach(var c in cpts)
            {
                Console.WriteLine("Code :" + c.code);
                Console.WriteLine("Solde :" + c.solde);
                Console.WriteLine("-----------------------");
            }

            Console.ReadLine();
        }
    }
}
