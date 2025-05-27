using sy.nomina.clases;
using sy.nomina.controlador;

class Program
{
    static void Main()
    {
        var gestor = new GestorEmpleados();

        gestor.AgregarEmpleado(new EmpleadoAsalariado("Ana", "Ramírez", "123-45-6789", 1200));
        gestor.AgregarEmpleado(new EmpleadoPorHoras("Luis", "Gómez", "987-65-4321", 20, 42));
        gestor.AgregarEmpleado(new EmpleadoPorComision("Laura", "Martínez", "555-11-2222", 10000, 0.1m));
        gestor.AgregarEmpleado(new EmpleadoAsalariadoPorComision("Pedro", "López", "444-22-3333", 8000, 0.05m, 500));

        gestor.GenerarReporte();

        Console.ReadKey();


        for (int i = 0; i < 1000; i++)
        {
            gestor.AgregarEmpleado(new EmpleadoAsalariado(
                $"Nombre{i}", $"Apellido{i}", $"SSN{i}", 1000 + i));
        }

        
        var inicio = DateTime.Now;

        gestor.GenerarReporte(); 

        var fin = DateTime.Now;
        var duracion = fin - inicio;

        Console.WriteLine($"⏱ Tiempo total de procesamiento: {duracion.TotalSeconds} segundos");

        if (duracion.TotalSeconds <= 2)
        {
            Console.WriteLine("✅ Cumple con el requisito de rendimiento (menos de 2 segundos).");
        }
        else
        {
            Console.WriteLine("❌ No cumple con el requisito de rendimiento.");
        }
    }






























}
        












