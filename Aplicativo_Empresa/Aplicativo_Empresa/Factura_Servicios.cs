using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{
    public class Factura_Servicios : DocumentoBase   
    {
        private string date;
        private string producto;
        private string total;


        public Factura_Servicios():base() { }
        public Factura_Servicios(string date,string nombreEmpresa, string contacto,string telefono,string direccion,string producto,string total)
            :base(nombreEmpresa,contacto,telefono,direccion)
        {
            this.Date = date;
            this.Total = total;
            this.producto = producto;
        }
        
        public string Producto { get => producto; set => producto = value; }
        public string Date { get => date; set => date = value; }
        public string Total { get => total; set => total = value; }

        public override string ToString()
        {
            return base.ToString()+string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6:C2}",Producto,Date,NombreEmpresa,Contacto,Telefono,Direccion,Total);
        }
    }
}