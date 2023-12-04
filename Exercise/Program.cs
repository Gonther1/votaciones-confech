using Exercise.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        string menu;
        /* int number;
        byte cantUnis; */
        do 
        {
            Console.Clear();
            Console.WriteLine("1-Registrar Universidades");
            Console.WriteLine("");
            Console.WriteLine("");
            menu=Console.ReadLine();
            switch(menu)
            {
                case "1":
                    /* text=Console.ReadLine();
                    number=int.Parse(text); */
                    Console.Clear();
                    Functions.RegisterCantUnivesities();
                    break;
                case "2":
                    Functions.RegisterUnivesities(4);
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "7":
                    Console.WriteLine("Adios :)");
                    break;
            }
        }
        while (menu!="7");
    }
}