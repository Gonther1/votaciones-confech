using Exercise.Classes;
using Exercise.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        string menu;
        List<University> universities = new List<University>();
        int number=0;
        do 
        {
            Console.Clear();
            Console.WriteLine("1-Registrar Universidades");
            Console.WriteLine("2-Registrar Votos ");
            Console.WriteLine("3-Mostrar resultados de la Votacion");
            Console.WriteLine("");
            menu=Console.ReadLine();
            switch(menu)
            {
                case "1":
                    if (number < 1)
                    {
                        number=Functions.RegisterCantUnivesities();
                    } else 
                    {
                        Console.Clear();
                        Console.WriteLine($"La cantidad de Universidades establecida es {number}\n\nPresione enter para continuar");
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    Console.ReadLine();
                    if (universities.Count() < 1 && number > 0)
                    {
                        universities=Functions.RegisterUnivesities(number);
                    } else 
                    {
                        Console.Clear();
                        Console.WriteLine("No es posible realizar esta accion\n\nPresione enter para continuar");
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    if (number > 0)
                    {
                        Functions.ShowResults(universities,number);
                    } else 
                    {
                        Console.Clear();
                        Console.WriteLine("No es posible realizar esta accion\n\nPresione enter para continuar");
                        Console.ReadLine();
                    }
                    break;
                case "4":
                    Console.WriteLine("Adios :)");
                    break;
            }
        }
        while (menu!="4");
    }
}