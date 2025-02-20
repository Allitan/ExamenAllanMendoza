

namespace ExamenAllanMendoza
{
    public class Asignatura : Alumno , IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string? NombreAsingnatura { get; set; }
        public string? Horario { get; set; }
        public string? NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string? MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 90 && notaFinal <= 100)
            {
                return "Sobresaliente";

            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {

                return "Muy Bueno";
            }
            else if (notaFinal >= 60 && notaFinal <= 79)
            {
                return "Bueno";
            }
            else
            {
                return "Reprobado";
            }
        }
        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electronico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsingnatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota Final: {notaFinal} - {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal(N1,N2,N3)} - {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine("***********************************************************************************");
        }
    }
}
