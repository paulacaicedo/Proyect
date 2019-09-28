using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{
    public class Factura_Servicios : Factura
    {
        private string factura;
        private string nombreEmpresa;
        private string contacto;
        private string producto;
        private double Total;


        public Factura_Servicios() { }
        public Factura_Servicios(String factura, string nombreEmpresa, string contacto, string producto,double Total)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.contacto = contacto;
            this.factura = factura;
            this.Total = Total;
            this.producto = producto;
        }
        public string Factura { get => factura; set => factura = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public double Total1 { get => Total; set => Total = value; }
        public string Producto { get => producto; set => producto = value; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4}", Factura, NombreEmpresa, Contacto,Producto,Total1);
        }
    }
}