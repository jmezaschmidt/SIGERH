using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
            u.Nickname = "Javier.Meza1";
            u.Password = "3452706";
            u.TipoUsuario = "Administrador";
            Console.WriteLine(cu.autenticarUsuario());*/

            ControladorExpedientes ce = new ControladorExpedientes();
            ce.obtenerInformacionGeneral(3452706);

            /*Colaborador c = new Colaborador();
            c = ce.obtenerInformacionGeneral(114740899);*/
            /*Console.WriteLine(c.Cedula);
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.FechaNacimiento);
            Console.WriteLine(c.Puesto);
            Console.WriteLine(c.Departamento);
            Console.WriteLine(c.FechaIngreso);
            Console.WriteLine(c.Estado);
            Console.WriteLine("-----------------------");*/

            /*c = ce.obtenerInformacionGeneral(3452706);
            Console.WriteLine(c.Cedula);
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.FechaNacimiento);
            Console.WriteLine(c.Puesto);
            Console.WriteLine(c.Departamento);
            Console.WriteLine(c.FechaIngreso);
            Console.WriteLine(c.Estado);
            Console.WriteLine("-----------------------");*/

            /*List<Contacto> lc = ce.obtenerContactosPxy();
            for (int i = 0; i < lc.Count; i++)
            { Console.WriteLine(lc.ElementAt(i).TipoContacto + ": " + lc.ElementAt(i).ValorContacto); } */

            List<Permiso> lp = ce.obtenerPermisosColaboradorPxy();
            for (int i = 0; i < lp.Count; i++)
            {
                Permiso p = lp.ElementAt(i);
                Console.WriteLine(lp.ElementAt(i).FechaSolicitud);
                Console.WriteLine(lp.ElementAt(i).FechaInicial);
                Console.WriteLine(lp.ElementAt(i).FechaFinal);
                Console.WriteLine(lp.ElementAt(i).Motivo);
                Console.WriteLine(lp.ElementAt(i).Estado);
                Console.WriteLine(lp.ElementAt(i).Id);
            }


            Console.ReadLine();
        }
    }
}
