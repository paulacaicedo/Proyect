using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{
    public class DocumentoBase
    {
        
        private string nombreEmpresa;
        private string contacto;
        private string telefono;
        private string direccion;

        public DocumentoBase() { }
        public DocumentoBase(String nombreEmpresa, string contacto, string telefono, string direccion)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.contacto = contacto;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public DocumentoBase(string nombreEmpresa,string contacto)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.contacto = contacto;
        }

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}