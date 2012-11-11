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
using SIGERHSis.Controladores.ModuloOrganizacion;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ControladorUsuarios cu = new ControladorUsuarios();
            //Usuario u = Usuario.obtenerUsuarioActual();
            /*cu.UsuarioActual.Nickname = "Javier.Meza1";
            cu.UsuarioActual.Password = "3452706";
            cu.UsuarioActual.TipoUsuario = "Administrador";*/
            //Console.WriteLine(cu.autenticarUsuario("Javier.Meza1", "3452706", "Administrador"));

            /*ControladorExpedientes ce = new ControladorExpedientes();
            ce.obtenerInformacionGeneral(3452706);*/

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

            //ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            //ce.obtenerInformacionGeneral(3452706);
            //List<Vacaciones> lp = ce.obtenerVacacionesColaboradorPxy();
            //for (int i = 0; i < lp.Count; i++)
            //{
            //    Vacaciones p = lp.ElementAt(i);
            //    Console.WriteLine(lp.ElementAt(i).FechaSolicitud);
            //    Console.WriteLine(lp.ElementAt(i).FechaInicial);
            //    Console.WriteLine(lp.ElementAt(i).FechaFinal);
            //    Console.WriteLine(lp.ElementAt(i).Motivo);
            //    Console.WriteLine(lp.ElementAt(i).Estado);
            //    Console.WriteLine(lp.ElementAt(i).Id);
            //}

            //Console.WriteLine(ce.cambiarEstadoVacacionesPxy(11, "En Espera"));

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = co.obtenerColaboradores(true);
            //for (int i = 0; i < lc.Count; i++)
            //{
            //    Colaborador c = lc.ElementAt(i);
            //    Console.WriteLine(lc.ElementAt(i).Cedula);
            //    Console.WriteLine(lc.ElementAt(i).Nombre);
            //    Console.WriteLine(lc.ElementAt(i).Puesto);
            //    Console.WriteLine(lc.ElementAt(i).Departamento);
            //    Console.WriteLine("-----------");
            //}

            ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            ce.obtenerInformacionGeneral(3452706);
            Contrato c = ce.obtenerContratoColaboradorPxy();
            Console.WriteLine(c.CantidadHorasLaborales);
            Console.WriteLine(c.FechaCreacion);
            Console.WriteLine(c.Estado);

            //ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            //ce.obtenerInformacionGeneral(3452706);
            //List<Capacitacion> lp = ce.obtenerCapacitacionesColaboradorPxy();
            //for (int i = 0; i < lp.Count; i++)
            //{
            //    Capacitacion p = lp.ElementAt(i);
            //    Console.WriteLine(lp.ElementAt(i).Nombre);
            //    Console.WriteLine(lp.ElementAt(i).Descripcion);
            //    Console.WriteLine(lp.ElementAt(i).FechaInicial);
            //    Console.WriteLine(lp.ElementAt(i).FechaFinal);
            //    Console.WriteLine(lp.ElementAt(i).DuracionEnHoras);
            //    Console.WriteLine("-----------");
            //}

            Console.ReadLine();
        }
    }
}
