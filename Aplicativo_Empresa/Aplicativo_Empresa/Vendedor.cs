using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicativo_Empresa
{
    class Vendedor
    {
        private string name;
        private string password;

        public Vendedor() { }
        public Vendedor(string line)
        {
            string[] datos = line.Split(';');
            Name = datos[0];
            Password = datos[1];
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        
    }
}
