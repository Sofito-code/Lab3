using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[] {1,2,3,4,7,8,5,9,0,6,11};
            int[] vector2 = new int[] { };
            int[] vector3 = new int[10];
            
            Console.WriteLine(vector1[4]);
            Console.WriteLine(vector1.Length);
            Console.WriteLine(vector3[4]);

            //Ejemplo con Jugadores
            Jugador j1 = new Jugador("Felipe", "Felipe@correo.com", "endulzada: de todo", "regalo: cualquier cosa");
            Jugador j2 = new Jugador("Oswald", "Oswald@correo.com", "endulzada: de todito", "regalo: muchas cositas");
            Jugador j3 = new Jugador("Alexa", "Alexa@correo.com", "endulzada: de todoooo", "regalo: una moto");
            //Vector de jugadores
            Jugador[] jugadoresAmigoSecreto = new Jugador[3];
            // Asigno el jugador1 a la pos 0
            jugadoresAmigoSecreto[0] = j1;
            jugadoresAmigoSecreto[1] = j2;
            jugadoresAmigoSecreto[2] = j3;
            Console.WriteLine(jugadoresAmigoSecreto[0].mostrarJugador());
            Console.WriteLine(jugadoresAmigoSecreto[1].getNombre());
            Console.WriteLine(j2.getNombre());


        }
    }
}
