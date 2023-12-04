using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise.Classes;

namespace Exercise.Core
{
    public class Functions
    {
        public static int RegisterCantUnivesities()
        {
            Console.Clear();
            /* string text; */
            int number=4;
            /* do
            {
                Console.WriteLine("Ingrese la cantidad de Universidades que participaran en el proceso");
                text=Console.ReadLine();
                number=int.Parse(text);
            } while (); */
            return number;
        }

        public static int RegisterUnivesities(int number)
        {
            Console.Clear();
            string text;
            string voto;
            List<University> Universities = new List<University>();
            for (int i = 0; i < number; i++)
            {
                University universidad = new University();
                Console.WriteLine($"Ingrese el nombre de la universidad {i+1}");
                text=Console.ReadLine();
                universidad.NameUniversity=text;
                Console.Clear();
                Console.WriteLine("A continuacion se le pediran los votos de los diferentes estudiantes\n\nSi no quiere ingresar más votos ingrese la letra 'X'");
                Console.ReadLine();
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Ingrese el voto del estudiante");
                    voto=Console.ReadLine();
                    voto.ToUpper();
                    while (voto != "A" /* || voto != "R" || voto != "N" || voto != "B" */)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingrese un voto valido para el estudiante");
                        voto=Console.ReadLine();
                    }
                    universidad.Votes.Add(voto);
                } while (voto !="X");
                Universities.Add(universidad);
            }
            foreach (var item in Universities)
            {
                Console.WriteLine($"Universidad:{item.NameUniversity}");
                Console.WriteLine($"Voto:{item.Votes}");
            }
            Console.Clear();
            Console.ReadLine();
            return number;
        }
    }
}