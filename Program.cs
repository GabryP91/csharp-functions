using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 

 Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

- void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
- int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
- int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
- int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
- Stampare l’array di numeri fornito a video
- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
- Stampare la somma di tutti i numeri
- Stampare la somma di tutti i numeri elevati al quadrati


**BONUS:**
Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. 
Rieseguire il programma con l’input preso esternamente dall’utente.
 
 */

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int valore;

            Console.WriteLine("Digitare lunghezza array");
            //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
            while (int.TryParse(Console.ReadLine(), out valore) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }

            int[] startArray=CreaArray(valore);

          

            //Dichiaro un array iniziale di quattro elementi
            int[] nuovoArray = new int[startArray.Length];

            int somma = 0;

            Console.WriteLine("\nL'array iniziale presenta i seguenti valori:");

            //richiamo la funzione stampaArray a cui passo il mio array
            StampaArray(startArray);

            Console.WriteLine();

            Console.WriteLine("\nInserire un numero:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nIl quadrato è: {Quadrato(userNumber)} ");

            //richiamo funzione ElevaArrayAlQuadrato e immagazzino il nuovo array
            nuovoArray = ElevaArrayAlQuadrato(startArray);

            Console.WriteLine("\nIl nuovo array avrà i seguenti elementi:");

            StampaArray(nuovoArray);


            Console.WriteLine();

            Console.WriteLine($"\nLa somma dei vari elementi del primo array sarà:{somma = sommaElementiArray(startArray)}");

            Console.WriteLine($"\nLa somma dei vari elementi del secondo array sarà:{somma = sommaElementiArray(nuovoArray)}");



            //Funzione che chiamo per creare e popolare il mio array iniziale
            int[] CreaArray(int numero)
            {
                int[] inizioArray = new int[numero];

                int elemento;

                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine("Inserisci valore");

                    //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
                    while (int.TryParse(Console.ReadLine(), out elemento) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    //inserisco il valore digitato nella posizione i-eseima del mio array
                    inizioArray[i] = elemento;

                }

                //restituisco l'array
                return inizioArray;
            }


            //dichiaro funzione che stampa a video una virgola e uno spazio 
            void StampaVirgolaESpazio()
            {
                Console.Write(", ");
            }

            //Funzione che stampa a video tutta la struttura dell'array passato
            void StampaArray(int[] array)
            {
                Console.Write("(");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        StampaVirgolaESpazio();
                }

                Console.Write(")");
            }

            //Funzione che restituisce il quadrato di un solo elemento
            int Quadrato(int numero)
            {
                int quadrato;

                quadrato = numero * numero;

                return quadrato;
            }

            //Funzione che restituisce il quadrato di ogni elemento presente nell'array che gli viene passato
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int val = 0;
                
                for (int i = 0; i < array.Length; i++)
                {
                    val = array[i] * array[i];
                  
                    nuovoArray[i] = val;

                }

                return nuovoArray;
            }

            //Funzione che passato un array in ingresso, restituisce la somma dei suoi elementi
            int sommaElementiArray(int[] array)
            {
                somma = 0;
                foreach (int numero in array)
                {
                    somma += numero;
                }
                return somma;
            }




            Console.ReadKey();
        }
    }
}
