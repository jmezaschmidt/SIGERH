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
            ControladorUsuarios cu = new ControladorUsuarios();
            Usuario u = Usuario.obtenerUsuarioActual();
            u.Nickname = "javier.meza1";
            u.Password = "3452706";
            u.TipoUsuario = "Administrador";
            Console.WriteLine(cu.autenticarUsuario());*/

            ControladorExpedientes ce = new ControladorExpedientes();
            Colaborador c = new Colaborador();
            c = ce.obtenerInformacionGeneral(114740899);
            Console.WriteLine(c.Cedula);
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.FechaNacimiento);
            Console.WriteLine(c.Puesto);
            Console.WriteLine(c.Departamento);
            Console.WriteLine(c.FechaIngreso);
            Console.WriteLine(c.Estado);
            Console.WriteLine("-----------------------");
            c = ce.obtenerInformacionGeneral(3452706);
            Console.WriteLine(c.Cedula);
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.FechaNacimiento);
            Console.WriteLine(c.Puesto);
            Console.WriteLine(c.Departamento);
            Console.WriteLine(c.FechaIngreso);
            Console.WriteLine(c.Estado);
            Console.WriteLine("-----------------------");
            DataTable dt = new DataTable();
            dt = ce.obtenerContactos();
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["Tipo Contacto"]);
                Console.WriteLine(dr["Contacto"]);
            }
            
            Console.WriteLine("mau23");
            Console.ReadLine();
        }
    }
}
