using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGERHSis;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloUsuarios;
using SIGERHSis.Controladores.ModuloUsuarios;
<<<<<<< HEAD
using SIGERHSis.Controladores.ModuloExpedientes;
=======
>>>>>>> 6f467f880a9322b753e8bbd8452fb9467e94d912

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            /*ControladorUsuarios cu = new ControladorUsuarios();
=======
            ControladorUsuarios cu = new ControladorUsuarios();
>>>>>>> 6f467f880a9322b753e8bbd8452fb9467e94d912
            Usuario u = Usuario.obtenerUsuarioActual();
            u.Nickname = "javier.meza1";
            u.Password = "3452706";
            u.TipoUsuario = "Administrador";
<<<<<<< HEAD
            Console.WriteLine(cu.autenticarUsuario());*/

            ControladorExpedientes ce = new ControladorExpedientes();
            Colaborador c = new Colaborador();
            c = ce.obtenerInformacionGeneral(3452706);

            Console.WriteLine("1234");
=======
            //Console.WriteLine(cu.autenticarUsuario());
            Console.WriteLine("mau2");
>>>>>>> 6f467f880a9322b753e8bbd8452fb9467e94d912
            Console.ReadLine();
        }
    }
}
