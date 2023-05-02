using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcadoMio
{
    internal class Program
    {
        static string nombre;
        static string edad;

        static void Main(string[] args)
        {
            solicitudDatos();
            lineas();
            inicioJuego();
            Console.Read();
        }

        public static void lineas()
        {   //usar Enumerable mas repeat ("string a utiliza ", ___ cantidad que uno quiere)
            string linE = string.Concat(Enumerable.Repeat("-", 40));

            Console.WriteLine(linE);
            
        }

        public static void solicitudDatos()
        {
            Console.WriteLine("¿Cual es su nombre? ");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cual es su edad?");
            edad = Console.ReadLine();
            Console.WriteLine("Bueno Bienvenido!!!");
            Console.WriteLine("Una cosa mas... " + nombre + " tan grande y jugando esto??? ");

        }

        public static void inicioJuego()
        {
            Console.WriteLine("Bien comencemos con el juego ");
            Console.WriteLine("Instrucciones: ");
            Console.WriteLine(" Son varias palabras que seran definidas en un random o en español aleatoriamente ");
            Console.WriteLine("Es el juego del ahorcado solo digite palabras en minuscula");

            //lista de palabras
            Random random1 = new Random();
            string[] listaPalabras = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska","papa","mama","automovil","vida","inuyasha","helio","programacion","materias" };
            int mIndex = random1.Next(listaPalabras.Length);//indices o campos en la memoria
            Console.WriteLine("   palabra     {0}", listaPalabras[mIndex]);  //comprobacion de que si funcione random
            


            //modificacion de palabras 
            StringBuilder mostrarPalabra = new StringBuilder();
            foreach (char letra in listaPalabras[mIndex])
            {
                if (letra == ' ')
                {
                    mostrarPalabra.Append(' ');

                }
                else
                {
                    mostrarPalabra.Append('-');
                }
            }
            
            Console.WriteLine(mostrarPalabra);

            StringBuilder mostrarPalabra1 = new StringBuilder();
            foreach (char numeroDeIntentos in listaPalabras[mIndex])
            {
                if(numeroDeIntentos == ' ')
                {
                    mostrarPalabra1 = ;
                        
                }
                
            }



            bool terminado = true;
            char palabraReservada;


            do
            {

                Console.WriteLine("Por favor introduzca una letra: ");
                Console.WriteLine("Digite una letra");
                palabraReservada = Convert.ToChar(Console.ReadLine());//transforma el dato entrante






            } while (!terminado);

            

        }
    }
}
