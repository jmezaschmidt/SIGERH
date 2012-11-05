using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGERHSis;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloUsuarios;
using SIGERHSis.Controladores.ModuloUsuarios;
using SIGERHSis.Controladores.ModuloExpedientes;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ControladorUsuarios cu = new ControladorUsuarios();
            Usuario u = Usuario.obtenerUsuarioActual();
            u.Nickname = "javier.meza1";
            u.Password = "3452706";
            u.TipoUsuario = "Administrador";
            Console.WriteLine(cu.autenticarUsuario());*/

            ControladorExpedientes ce = new ControladorExpedientes();
            Colaborador c = new Colaborador();
            c = ce.obtenerInformacionGeneral(3452706);

            Console.WriteLine("1234");
            Console.ReadLine();
        }
    }
}
