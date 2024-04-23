using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {

        //il tipo generico come mostrato a lezione//
        public static T Somma<T>(T num1, T num2) where T : INumber<T>    
        {
            return num1 + num2;

        }
        //per completezza di esercizio dividerò per tipi come richiesto
        //**********************************************************+//


        //**************** SOMME *********************//
        public static int SommaInteri(int num1, int num2)
        {

            return num1 + num2;
        }

        public static double SommaDouble(double num1, double num2)
        {

            return num1 + num2;
        }

        //**************** DIFFERENZE *******************//

        public static int DiffInteri(int num1, int num2)
        {

            return num1 - num2;
        }

        public static double DiffDouble(double num1, double num2)
        {

            return num1 - num2;
        }

        //**************** MOLTIPLICAZIONI *******************//

        public static double MultDouble(double num1, double num2)
        {

            return num1 * num2;
        }

        public static int MultInteri(int num1, int num2)
        {

            return num1 * num2;
        }


        //******************** VALORE ASSOLUTO ************************//


        public static int AbsoluteInt(int num1)
        {
            int temp = num1;
            if (temp > 0)
            {
                return temp;
            }
            else if (temp < 0)
            {
                return (-1) * temp;
            }
            else
            {
                return 0;
            }

        }

        public static double AbsoluteDouble(double num1)
        {
            double temp = num1;
            if (temp > 0)
            {
                return temp;
            }
            else if (temp < 0)
            {
                return (-1) * temp;
            }
            else
            {
                return 0;
            }

        }
        //******************** MINORE *************************//


        public static int MinInt(int num1, int num2)
        {
            int temp1 = num1;
            int temp2 = num2;
            if (temp1 > temp2)
            {
                return temp2;
            }
            else if (temp1 < temp2)
            {
                return temp1;
            }
            else
            {
                return temp1;
            }

        }

        public static double MinDouble(double num1, double num2)
        {
            double temp1 = num1;
            double temp2 = num2;
            if (temp1 > temp2)
            {
                return temp2;
            }
            else if (temp1 < temp2)
            {
                return temp1;
            }
            else
            {
                return temp1;
            }

        }

        //****************** MAGGIORE **********************//

        public static int MaxInt(int num1, int num2)
        {
            int temp1 = num1;
            int temp2 = num2;
            if (temp1 < temp2)
            {
                return temp2;
            }
            else if (temp1 > temp2)
            {
                return temp1;
            }
            else
            {
                return temp1;
            }

        }

        public static double MaxDouble(double num1, double num2)
        {
            double temp1 = num1;
            double temp2 = num2;
            if (temp1 < temp2)
            {
                return temp2;
            }
            else if (temp1 > temp2)
            {
                return temp1;
            }
            else
            {
                return temp1;
            }

        }

        //******************* ESPONENZIALE *********************//

        public static double ExpInt(int base1, int expo) 

        {
            double baseInterna = base1;
            double expoInterna = expo;


            if (expo == 0)  //ESPONENTE 0 -> RISULTATO 1
            {
                return 1;
            }

            if (base1 == 0) //BASE 0 ->RISULTATO è 0
            {
                return 0;
            }


            if (expo < 0) //ESPONENTE NEGATIVO RIPORTA A FRAZIONE
            {
                baseInterna = 1 / baseInterna;
                expoInterna = -expoInterna;
            }

            double risultato = 1;
            for (int i = 0; i < expoInterna; i++)  //MOLTIPLICA LA BASE PER SE STESSA EXPO VOLTE
            {
                risultato *= baseInterna;
            }

            return risultato;


        }


    }
}
