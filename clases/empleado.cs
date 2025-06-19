using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy.nomina.clases
{
    public abstract class Empleado
    {

        public string primerNombre {  get; set; }
        public string ApellidoPaterno { get; set; }
        public string numeroSeguroSocial {  get; set; }

        public decimal salarioSemanal {  get; set; }

        public Empleado(string PrimerNombre, string apellidoPaterno,string NumeroSegurosocial, decimal tarifaComision, decimal tarifaComision1) 
        {
            primerNombre = PrimerNombre;
            ApellidoPaterno = apellidoPaterno;
            numeroSeguroSocial = NumeroSegurosocial;
               
        }

        protected Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal) : this(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
        }

        public abstract decimal CalcularPago(); 
       








    }
   
        










}


