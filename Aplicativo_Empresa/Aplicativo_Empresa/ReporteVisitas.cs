using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Empresa
{
    class ReporteVisitas : Cliente
    {

        private string date;
        private string hour;
        private string temaVisita;
        private string lugar;

        private List<Vendedor> vendedores;

        public ReporteVisitas() : base() { }

        public ReporteVisitas(string date, string hour, string nombreEmpresa, string contacto, string temaVisita, string lugar)
            : base(nombreEmpresa,contacto)
        {
            this.Date = date;
            this.Hour = hour;
            this.TemaVisita = temaVisita;
            this.Lugar = lugar;
        }

        public string Date { get => date; set => date = value; }
        public string Hour { get => hour; set => hour = value; }
        public string TemaVisita { get => temaVisita; set => temaVisita = value; }
        public string Lugar { get => lugar; set => lugar = value; }


        public override string ToString()
        {
            return base.ToString() + string.Format("{0}\t{1}\t{2}\t{3}", Date, Hour, TemaVisita, Lugar);
        }
    }
}
