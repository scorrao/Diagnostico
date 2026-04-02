// See https://aka.ms/new-console-template for more information
Console.WriteLine("La carrera");
Console.WriteLine();

List<Participante> participantes = new List<Participante>();

void CargarParticipantes()
{

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

}


CargarParticipantes();

void MejorTiempo()
{
    float? mejorTiempo = null;
    foreach (var p in participantes)
    {
        if(mejorTiempo == null || p.Tiempo < mejorTiempo )
        {
            mejorTiempo = p.Tiempo;
        }
    }
    Console.WriteLine($"El mejor tiempo es: {mejorTiempo}");

}

void MejorTiempoV2()
{
    Participante? mejorParticipante = null;
    foreach (var p in participantes)
    {
        if(mejorParticipante == null || p.Tiempo < mejorParticipante.Tiempo )
        {
            mejorParticipante = p;
        }
    }
    Console.WriteLine($"El mejor tiempo es: {mejorParticipante.Tiempo} del participante {mejorParticipante.Nombre} {mejorParticipante.Apellido}");
        
}

void MejorTiempoV3()
{
    var mejorParticipante = participantes.OrderBy(p => p.Tiempo).FirstOrDefault();
    Console.WriteLine($"El mejor tiempo es: {mejorParticipante.Tiempo} del participante {mejorParticipante.Nombre} {mejorParticipante.Apellido}");
}

void MejorTiempoV4()
{
    var mejorTiempo = participantes.Min(p => p.Tiempo);
    var mejoresParticipantes = participantes.Where(p => p.Tiempo == mejorTiempo);
    Console.WriteLine($"El mejor tiempo es: {mejorTiempo}");
    foreach (var p in mejoresParticipantes)
    {
        Console.WriteLine($"El mejor tiempo es: {mejorTiempo} del participante {p.Nombre} {p.Apellido}");
    }
}


MejorTiempoV2();



