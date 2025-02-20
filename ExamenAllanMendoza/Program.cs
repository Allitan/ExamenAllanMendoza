using ExamenAllanMendoza;

Asignatura asignatura = new Asignatura();

try
{
    Console.WriteLine("Ingrese el nombre del Alumno: ");
    asignatura.NombreAlumno = Console.ReadLine();

    Console.WriteLine("Ingrese el numero de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();

    Console.WriteLine("Ingrese correo electronico: ");
    asignatura.Email = Console.ReadLine();

    Console.WriteLine("Ingrese nombre de la clase: ");
    asignatura.NombreAsingnatura = Console.ReadLine();

    Console.WriteLine("Ingrese horario de la clase: ");
    asignatura.Horario = Console.ReadLine();

    Console.WriteLine("Ingrese el nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();

    Console.WriteLine("Ingrese nota del primer parcial: ");
    asignatura.N1 = int.Parse(Console.ReadLine());
    if(asignatura.N1 > 30)
    {
        throw new Exception("La nota del primer parcial no puede ser mayor a 30");
    }

    Console.WriteLine("Ingrese nota del segundo parcial: ");
    asignatura.N2 = int.Parse(Console.ReadLine());
    if (asignatura.N2 > 30)
    {
        throw new Exception("La nota del segundo parcial no puede ser mayor a 30");
    }

    Console.WriteLine("Ingrese la nota del tercer parcial: ");
    asignatura.N3 = int.Parse(Console.ReadLine());
    if(asignatura.N3 > 40)
    {
        throw new Exception("La nota del tercer parcial no puede ser mayor a 40");
    }


    asignatura.Imprimir();
}
catch (Exception ex) 
{
    Console.WriteLine($"Error {ex.Message}");
}