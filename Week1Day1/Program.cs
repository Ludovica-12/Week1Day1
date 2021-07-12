using System;

namespace Week1Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //serve per stampare a video Hello World!

            /*Questo è
             * un commento 
             * su più righe*/

            int a; //Dichiaro una variabile (contenitore) di dati di tipo intero (numeri interi)

            a = 1; //Nella variabile a c'è il calore uno e posso fare più modifiche

            // int a = 1 ; Darebbe errore (quindi non continuerebbe la conpilazione del programma) perchè già esistente

            int b = 2; //Dichiarazione e assegnazione = inizializzazione
            b = 5; //Cambio valore

            const int N = 50; //Per dichiarare una costante e il suo valore non può essere cambiato diverso da variabile
            //Costante lettere maiuscole
            int var1 = 1, var2 = 2, var3 = 3; //Inizializzazione di più valori su un'unica riga. Si può fare perchè sono dello stesso tipo
            //Variabile lettere minuscole
            string parola = "ciao a tutte";

            char carattere = 'a';

            string s = "20";

            //Value type
            //Interi
            byte c; //tra 0 a 255 8 bit
            short d; //16 bit
            int i; //32 bit
            long l; //64 bit

            //Numeri a virgola mobile
            float f = 2.33f;//cifre limitate dopo la virgola max7
            double pi = 3.1427328971d;//più cifre dopo la virgola 15 cifre
            decimal dec = 123.126m;//Si utilizza quandi si parla di importi 27/29 cifre decimal

            //Booleani: true/false;
            bool isSunny = true;

            Console.WriteLine(parola);
            Console.WriteLine(carattere);

            //Come fare per averli vicini
            int x = 1;
            int y = 2;

            Console.WriteLine($"Ciao il valore della prima variabile è {x} invece il valore della seconda è {y}");
            Console.WriteLine("Ciao il valore della prima variabile è {0}. Il valore della seconda variabile è {1}",x, y);

            Console.WriteLine($"{x}\n{y}"); //Va a capo
            Console.WriteLine($"{x}\t{y}");//Tabulato

            Console.WriteLine("Ciao come ti chiami?");

            string nome;
            nome = Console.ReadLine(); //Legge la linea e la trasforma in una stringa
            Console.WriteLine($"Il tuo nome è {nome}");

            Console.WriteLine("Scrivi un carattere");
            char caracter = Console.ReadKey().KeyChar;//Lettura del singlo carattere

            DateTime today = new DateTime(2021, 6, 8); //Anno mese e giorno (è una classe)
            DateTime now = DateTime.Now; //Data di oggi
            Console.WriteLine(now);

            DateTime day = DateTime.Today;
            Console.WriteLine(day);
            Console.WriteLine(day.ToShortDateString());

        }
    }
}
