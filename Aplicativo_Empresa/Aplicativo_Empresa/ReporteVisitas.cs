using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Empresa
{
    class ReporteVisitas : DocumentoBase
    {
        private string vendedor;
        private string date;
        private string hour;
        private string temaVisita;
        
        

        public ReporteVisitas() : base() { }

        public ReporteVisitas(string date, string hour, string vendedor, string nombreEmpresa, string contacto, string temaVisita,string telefono,string direccion)
            : base(nombreEmpresa,contacto,telefono,direccion)
        {
            this.Vendedor = vendedor;
            this.Date = date;
            this.Hour = hour;
            this.TemaVisita = temaVisita;
            
        }

        public string Date { get => date; set => date = value; }
        public string Hour { get => hour; set => hour = value; }
        public string TemaVisita { get => temaVisita; set => temaVisita = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", Date, Hour,Vendedor,NombreEmpresa,Contacto,TemaVisita,Direccion,Telefono);
        }
    }
}
