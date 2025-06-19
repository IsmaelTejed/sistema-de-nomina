using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sy.nomina.clases;

namespace sy.nomina.clases
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial,salarioSemanal)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPago() => SalarioSemanal;


    }

}
