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
            string text;
            int number;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la cantidad de Universidades que participaran en el proceso\n\nMinimo de Universidades: 2");
                text=Console.ReadLine();
            } while (!int.TryParse(text, out number) || number < 2);
            return number;
        }

        public static List<University> RegisterUnivesities(int number)
        {
            Console.Clear();
            string text;
            string voto;
            List<University> Universities = new List<University>();
            for (int i = 0; i < number; i++)
            {
                University universidad = new University();
                List<string> votos = new List<string>();
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
                    voto=Console.ReadLine().ToUpper();
                    while (voto != "A" && voto != "X" && voto != "R" && voto != "N" && voto != "B")
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingrese un voto valido para el estudiante");
                        voto=Console.ReadLine().ToUpper();
                    }
                    switch (voto)
                    {
                        case "A":
                            universidad.Aceptan+=1;
                            break;
                        case "R":
                            universidad.Rechazan+=1;
                            break;
                        case "N":
                            universidad.Nulos+=1;
                            break;
                        case "B":
                            universidad.Blancos+=1;
                            break;
                    }
                    votos.Add(voto);
                } while (voto != "X");
                universidad.Votes=votos;
                Universities.Add(universidad);
            }        
            return Universities;
        }

        public static void ShowResults(List<University> universities, int number)
        {
            int aceptan=0;
            int rechazan=0;
            int empates=0;
            foreach (var i in universities)
            {
                if (i.Aceptan > i.Rechazan)
                {
                    aceptan+=1;
                }else if (i.Aceptan == i.Rechazan)
                {
                    empates+=1;
                }
                else 
                {
                    rechazan+=1;
                }
            }
            Console.Clear();
            Console.WriteLine($"Numero de universidades: {number}\n");
            foreach (var item in universities)
            {
                Console.WriteLine($"Universidad: {item.NameUniversity}");
                foreach (var i in item.Votes)
                {
                    Console.WriteLine($"Voto: {i}");
                }
                Console.WriteLine($"{item.NameUniversity}: {item.Aceptan} aceptan, {item.Rechazan} rechazan, {item.Blancos} blancos, {item.Nulos} nulos.\n");
            }
            Console.WriteLine($"Universidades que aceptan: {aceptan}\nUniversidades que rechazan: {rechazan}\nUniversidades con empate: {empates}");
            Console.ReadLine();
        }
    }
}