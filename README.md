# votaciones-confech

## File Main 

```c#
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
```

## Clase University

Almacena el nombre de la Universidad y se usan 4 Contadores para almacenar la cantidad de estudiantes que 
Aceptan, Rechazan, Voto en blanco y Nulos.

```c#
public class University
{

    public string NameUniversity { get; set; }
    public int Aceptan { get; set; }
    public int Rechazan { get; set; }
    public int Blancos { get; set; }
    public int Nulos { get; set; }
    public List<string> Votes { get; set; }    
}
```

## File MyFunctions

## Function RegisterCantUnivesities()

```c#
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
```

## Function RegisterUnivesities(int number)

```c#
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
```

## Function ShowResults(List<University> universities, int number)

```c#
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
```
