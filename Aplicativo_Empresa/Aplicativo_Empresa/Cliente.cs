using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{
    public class Cliente
    {
        private string nombreEmpresa;
        private string contacto;
        private string temaVisita;

        public Cliente() { }
        public Cliente(String nombreEmpresa, string contacto, string temaVisita)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.contacto = contacto;
            this.temaVisita = temaVisita;
        }

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string TemaVisita { get => temaVisita; set => temaVisita = value; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}",NombreEmpresa,Contacto,TemaVisita);
        }
    }
}