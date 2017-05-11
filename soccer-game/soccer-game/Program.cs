using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soccer_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string equipoElegido;
            string estadioElegido;
            string pelotaElegida;
            int equipo = 0;
            int estadio = 0;
            int pelota = 0;

            Estadio monumental = new Estadio("el Monumental");
            Estadio bombonera = new Estadio("la Bombonera");

            Pelota blanca = new Pelota("blanca");
            Pelota negra = new Pelota("negra");

            Equipo river = new Equipo("River");
            Equipo boca = new Equipo("Boca");

            //Selección de equipo
            Console.WriteLine();
            Console.WriteLine("Elija su equipo:");
            Console.WriteLine("Para jugar como River, ingrese 1.");
            Console.WriteLine("Para jugar como Boca, ingrese 2.");
            equipo = Convert.ToInt32(Console.ReadLine());
            if (equipo == 1)
            {
                Console.WriteLine("Jugará como River");
                equipoElegido = river.nombreEquipo;

            }
            else
            {
                Console.WriteLine("Jugará como Boca");
                equipoElegido = boca.nombreEquipo;
            }

            //Selección de cancha
            Console.WriteLine();
            Console.WriteLine("Desea jugar de local o visitante?");
            Console.WriteLine("Si desea ser local ingrese 1, si desea ser visitante, ingrese 2");
            estadio = Convert.ToInt32(Console.ReadLine());
            if (estadio == 1 && equipo == 1)
            {
                Console.WriteLine("Jugará de local");
                estadioElegido = monumental.nombreEstadio;
            }
            else if(estadio == 2 && equipo == 1)
            {
                Console.WriteLine("Jugará de visitante");
                estadioElegido = bombonera.nombreEstadio;
            }
            else if(estadio == 1 && equipo == 2)
            {
                Console.WriteLine("Jugará de local");
                estadioElegido = bombonera.nombreEstadio;
            }
            else
            {
                Console.WriteLine("Jugará de visitante");
                estadioElegido = monumental.nombreEstadio;
            }

            //Selección de pelota
            Console.WriteLine();
            Console.WriteLine("Elija el color de la pelota:");
            Console.WriteLine("Para que la pelota sea blanca, ingrese 1.");
            Console.WriteLine("Para que la pelota sea negra, ingrese 2.");
            pelota = Convert.ToInt32(Console.ReadLine());
            if (pelota == 1)
            {
                Console.WriteLine("La pelota será blanca");
                pelotaElegida = blanca.colorPelota;
            }
            else
            {
                Console.WriteLine("La pelota será negra");
                pelotaElegida = negra.colorPelota;
            }

            Console.WriteLine();
            Console.WriteLine("Usted está jugando como " + equipoElegido + " en " + estadioElegido + " con la pelota " + pelotaElegida);
            Console.ReadLine();
        }
    }
}