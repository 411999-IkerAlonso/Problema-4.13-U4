using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4._13
{
    public  class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDoc {  get; set; }
        public string Documento { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public bool Fallecido { get; set; }

        public Persona()
        {
            Apellido = string.Empty;
            Nombre = string.Empty;
            TipoDoc = string.Empty;
            Documento = string.Empty;
            EstadoCivil = string.Empty;
            Sexo = string.Empty;
            Fallecido = false;
        }

        public Persona(string apellido, string nombre, string tipoDoc, string documento,string estadoCivil, string sexo, bool fallecido)
        {
            Apellido = apellido;
            Nombre = nombre;
            TipoDoc = tipoDoc;
            Documento = documento;
            EstadoCivil= estadoCivil;
            Sexo = sexo;
            Fallecido = fallecido;
        }
    }
}
