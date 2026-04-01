// See https://aka.ms/new-console-template for more information
Console.WriteLine("La carrera");
Console.WriteLine();

List<Participante> participantes = new List<Participante>();

Participante p;
do 
{
    p = new Participante();
    Console.WriteLine("Ingrese el numero de participante:");
    p.Nro = int.Parse(Console.ReadLine());
    if (p.Nro == 0)
        break;
    Console.WriteLine("Ingrese el Nombre de participante:");
    p.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el Apellido de participante:");
    p.Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese la altura de participante:");
    p.Altura = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el Tiempo de participante:");
    p.Tiempo = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la Categoria de participante:");
    p.Categoria = Console.ReadLine();
    participantes.Add(p);
    
} while(true);


Console.WriteLine($"La lista tiene {participantes.Count} participantes");

