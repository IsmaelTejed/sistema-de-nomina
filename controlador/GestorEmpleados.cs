using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sy.nomina.clases;

namespace sy.nomina.controlador
{
    public class GestorEmpleados
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void EliminarEmpleado(string numeroSeguroSocial)
        {
            empleados.RemoveAll(e => e.numeroSeguroSocial == numeroSeguroSocial);
        }

        public void ListarEmpleados()
        {
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"{empleado.primerNombre} {empleado.ApellidoPaterno} - Pago: {empleado.CalcularPago():C}");
            }
        }

        public void GenerarReporte()
        {
            Console.WriteLine("REPORTE DE PAGOS SEMANALES\n");

            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.primerNombre} {empleado.ApellidoPaterno}");
                Console.WriteLine($"SSN: {empleado.numeroSeguroSocial}");
                Console.WriteLine($"Pago calculado: {empleado.CalcularPago():C}\n");
            }
        }



        public void ActualizarEmpleado(string ssn, Action<Empleado> actualizar)
        {
            var emp = empleados.FirstOrDefault(e => e.numeroSeguroSocial == ssn);
            if (emp != null) actualizar(emp);
        }



                











    }
}
