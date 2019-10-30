using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{

    public class Factura_Compra : DocumentoBase
    {
       
        private string totalCompra;
        private string numeroFactura;


        public Factura_Compra() : base() { }
        public Factura_Compra(string numeroFactura, string nombreEmpresa, string contacto,string direccion,string telefono, string totalCompra) 
            : base (nombreEmpresa,contacto,telefono,direccion)
        {
           
            this.totalCompra = totalCompra;
            this.NumeroFactura = numeroFactura;
        }
        
        public string TotalCompra { get => totalCompra; set => totalCompra = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }

        public override string ToString()
        {
            return base.ToString()+ string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5:C2}",NumeroFactura,NombreEmpresa,Contacto,Telefono,Direccion,TotalCompra);
        }

    }
}