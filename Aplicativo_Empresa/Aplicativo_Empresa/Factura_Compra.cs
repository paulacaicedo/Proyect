using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{

    public class Factura_Compra : Factura
    {
        private string factura;
        private string nombreEmpresa;
        private string contacto;
        private double TotalCompra;


        public Factura_Compra() { }
        public Factura_Compra(String factura, string nombreEmpresa, string contacto,double TotalCompra)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.contacto = contacto;
            this.factura = factura;
            this.TotalCompra = TotalCompra;
        }
        public string Factura { get => factura; set => factura = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public double TotalCompra1 { get => TotalCompra; set => TotalCompra = value; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}",Factura,NombreEmpresa,Contacto,TotalCompra);
        }
    }
}