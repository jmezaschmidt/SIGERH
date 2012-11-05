using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGERHSis;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloUsuarios;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = Usuario.obtenerUsuarioActual();
            Usuario usuario2 = Usuario.obtenerUsuarioActual();
            usuario1.Nickname = "javi";
            usuario2.Nickname = "mau";
            Console.WriteLine("uno: " + usuario1.Nickname);
            Console.WriteLine("dos: " + usuario2.Nickname);
            Console.ReadLine();
            
        }
    }
}
