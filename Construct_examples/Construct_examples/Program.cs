using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct_examples
{
    class Program
    {
        //Her opretters en "struct" altså en structure
        struct Account
        {
            //"Structens" hoved emner
            public string Navn;
            public string cprNummer;
            public double saldo;
        }
        //Her opretters en "struct" altså en structure
        struct Beer
        {
            //"Structens" hoved emner
            public string fabrikat;
            public string type;
            public double procent;
            public double volumen;
        }
        static void Main(string[] args)
        {
            //Opret en struct Account indeholdende Navn, CPR-nr og Saldo. 
            //Opret et par variable af Account-typen, giv dem værdier og udskriv dem.
            //Opret en metode UdskrivAccount(), som modtager et Account-objekt som parameter og udskriver dens værdier. 

            //"Account a1" første account i "struct Accounten"
            Account a1;
            //For at sætte indhold ind
            a1.Navn = "Bo";
            a1.cprNummer = "16082018-1122";
            a1.saldo = 18000;

            //"Account a2" anden account i "struct Accounten"
            Account a2;
            //For at sætte indhold ind
            a2.Navn = "Tim";
            a2.cprNummer = "17082018-1122";
            a2.saldo = 10000;

            //"Beer b1" første øl i "struct Beer"
            Beer b1;
            b1.fabrikat = "Tuborg";
            b1.type = "Øl";
            b1.procent = 4.2;
            b1.volumen = 33.3;

            //Indkapsling af udskrivning af "Account bo" via en string
            string udskriv(Account bo)
            {
                return "navn : " + bo.Navn + " | " + "cpr-nr : " + bo.cprNummer + " | " + "saldo : " + bo.saldo;
            }
            //Indkapsling af udskrivning af "Beer øl" via en string
            string udskriv1(Beer øl)
            {
                return "Fabrikat : " + b1.fabrikat + " | " + "Type : " + b1.type + " | " + "Procent : " + b1.procent + " %" + " | " + "Volumen : " + b1.volumen + " cl";
            }

            //Udskrivning af de enkelte "Accounts" og "Beer"
            Console.WriteLine(udskriv(a1));
            Console.WriteLine(udskriv(a2));
            Console.WriteLine(udskriv1(b1));

            //Fra den opgave 1
            //Console.WriteLine("Navn : {0} | Cpr-Nummer : {1} | Saldo : {2}kr.",a1.Navn, a1.cprNummer, a1.saldo);
            Console.ReadKey();
        }
    }
}
