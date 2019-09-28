using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Empresa
{
    public abstract class Factura
    {
        public int datosDelCliente
        {
            get => default;
            set
            {
            }
        }

        public int fecha
        {
            get => default;
            set
            {
            }
        }

        public int observaciones
        {
            get => default;
            set
            {
            }
        }

        public Vendedor Vendedor
        {
            get => default;
            set
            {
            }
        }

        public Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        public void CalcularValoresTotales()
        {
            throw new System.NotImplementedException();
        }

        public void GuardarReporte()
        {
            throw new System.NotImplementedException();
        }
    }
}