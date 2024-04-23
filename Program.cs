using System.ComponentModel;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creare una classe di helper CalcoliHelper.
            Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
            - Somma di due numeri interi
            - Somma di due numeri double
            - Differenza tra due numeri interi
            - Differenza tra due numeri double
            - Moltiplicazione di due numeri interi
            - Moltiplicazione di due numeri double
            - Valore assoluto di un numero intero
            - Valore assoluto di un numero double
            - Maximo tra due numeri interi
            - Maximo tra due numeri double
            - Massimo tra due numeri interi
            - Massimo tra due numeri double
            Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
            Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).
            **BONUS**:
            Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente. Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
            (caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)
            Buon lavoro!*/


            Console.WriteLine("====== BENVENUTO ======");
            string index = "";
            while (index != "esci") {

                Console.WriteLine("Scegli quale funzione vuoi testare: \n");
                Console.WriteLine("1 - Somma di due numeri interi\r\n" +
                    "2 - Somma di due numeri double\r\n" +
                    "3 - Differenza tra due numeri interi\r\n" +
                    "4 - Differenza tra due numeri double\r\n" +
                    "5 - Moltiplicazione di due numeri interi\r\n" +
                    "6 - Moltiplicazione di due numeri double\r\n" +
                    "7 - Valore assoluto di un numero intero\r\n" +
                    "8 - Valore assoluto di un numero double\r\n" +
                    "9 - Minimo tra due numeri interi\r\n" +
                    "10 - Minimo tra due numeri double\r\n" +
                    "11 - Massimo tra due numeri interi\r\n" +
                    "12 - Massimo tra due numeri double\r\n" +
                    "13 - Elevamento a potenza\r\n");
                Console.WriteLine("Inserisci 'esci' per terminare il programma \n");
                index = Console.ReadLine();
                Console.WriteLine("============");


                if (index == "1") {

                    Console.WriteLine("1 - Somma di due numeri interi\r\n" );
                    Console.WriteLine("inserisci i due numeri da sommare");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.SommaInteri(num1, num2)} \n");

                }

                if (index == "2")
                {

                    Console.WriteLine("2 - Somma di due numeri double\r\n");
                    Console.WriteLine("inserisci i due numeri da sommare");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.SommaDouble(num1, num2)} \n");

                }

                if (index == "3")
                {

                    Console.WriteLine("3 - Differenza tra due numeri interi\r\n");
                    Console.WriteLine("inserisci i due numeri da sottrarre");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.DiffInteri(num1, num2)}  \n");

                }

                if (index == "4")
                {

                    Console.WriteLine("4 - Differenza tra due numeri double\r\n");
                    Console.WriteLine("inserisci i due numeri da sottrarre");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.DiffDouble(num1, num2)}  \n");

                }

                if (index == "5")
                {

                    Console.WriteLine("5 - Moltiplicazionetra due numeri interi\r\n");
                    Console.WriteLine("inserisci i due numeri da moltiplicare");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.MultInteri(num1, num2)}  \n");

                }

                if (index == "6")
                {

                    Console.WriteLine("6 - Moltiplicazione tra due numeri double\r\n");
                    Console.WriteLine("inserisci i due numeri da moltiplicare");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.MultDouble(num1, num2)}   \n");

                }

                if(index == "7")
                {
                    Console.WriteLine("7 - Valore assoluto di un numero intero\r\n");
                    Console.WriteLine("inserisci il numero intero da cui ricavare il valore assoluto");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.AbsoluteInt(num1)}");
                }

                if (index == "8")
                {
                    Console.WriteLine("8 - Valore assoluto di un numero double\r\n");
                    Console.WriteLine("inserisci il numero intero da cui ricavare il valore assoluto");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.AbsoluteDouble(num1)}");
                }

                if (index == "9")
                {

                    Console.WriteLine("9 - Minimo tra due numeri interi\r\n");
                    Console.WriteLine("inserisci i due numeri da indicare il Minimo");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.MinInt(num1, num2)}   \n");

                }

                if (index == "10")
                {

                    Console.WriteLine("10 - Minimo tra due numeri double\r\n");
                    Console.WriteLine("inserisci i due numeri da indicare il Minimo");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.MinDouble(num1, num2)}   \n");

                }

                if (index == "11")
                {

                    Console.WriteLine("11 - Massimo tra due numeri interi\r\n");
                    Console.WriteLine("inserisci i due numeri da indicare il Massimo");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.MaxInt(num1, num2)}   \n");

                }

                if (index == "12")
                {

                    Console.WriteLine("12 - Massimo tra due numeri double\r\n");
                    Console.WriteLine("inserisci i due numeri da indicare il Massimo");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ora il secondo");
                    var num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("il risultato è:\n");
                    Console.WriteLine($"{CalcoliHelper.MaxDouble(num1, num2)}   \n");

                }

                if (index == "13")
                {
                    Console.WriteLine("12 - elevamento a potenza di un intero\r\n");
                    Console.WriteLine("== Inserisci la base:\r\n");
                    var num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("== Inserisci l'esponente:\r\n");
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"il numero {num1} elevato a {num2} è : {CalcoliHelper.ExpInt(num1, num2)}   \n");


                }

            }





        }
    }
}



