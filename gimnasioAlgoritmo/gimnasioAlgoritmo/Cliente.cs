using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gimnasioAlgoritmo
{
    class Cliente
    {
        public string nombreCompleto { get; set; }
        public string documento { get; set; }
        public string eps {  get; set; }

        public string correoElectronico { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad {  get; set; }
        public string gradoEscolaridad { get; set; }
        public List<string> Comorbilidades { get; set; }
        public double peso { get; set; }
        public double estatura { get; set; }
        public DateTime fechaMatriculacion { get; set; }
    }
}
