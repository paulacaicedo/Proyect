using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Empresa
{
    class Vendedor
    {
        private string name;
        private string password;


        public Vendedor() { }
        public Vendedor(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

    }
}
