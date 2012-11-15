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

            //ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            //ce.obtenerInformacionGeneral(3452706);
            //Contrato c = ce.obtenerContratoColaboradorPxy();
            //Console.WriteLine(c.CantidadHorasLaborales);
            //Console.WriteLine(c.FechaCreacion);
            //Console.WriteLine(c.Estado);

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

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //DateTime dt = Convert.ToDateTime("01/08/2008");
            //Console.WriteLine(co.crearProyecto("Proyecto Nuevo Dos", dt, dt, "Esta es la descripción del Proyecto Nuevo Dos"));

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //DateTime dt = Convert.ToDateTime("01/08/2008");
            //Console.WriteLine(co.crearCapacitacion("Capacitacion Nueva Uno", dt, dt, "Esta es la descripción de la Capacitacion Nueva Uno", 50));

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            ////List<Colaborador> lc = co.obtenerColaboradoresFueraProyecto("ERP");
            //List<Colaborador> lc = co.obtenerColaboradoresFueraCapacitacion(1);
            //for (int i = 0; i < lc.Count; i++)
            //{
            //    Colaborador c = lc.ElementAt(i);
            //    Console.WriteLine(c.Cedula);
            //    Console.WriteLine(c.Nombre);
            //    Console.WriteLine(c.FechaNacimiento);
            //    Console.WriteLine(c.Puesto);
            //    Console.WriteLine(c.Departamento);
            //    Console.WriteLine(c.FechaIngreso);
            //    Console.WriteLine(c.Estado);
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Proyecto> lp = co.obtenerProyectos();
            //for (int i = 0; i < lp.Count; i++)
            //{
            //    Proyecto p = lp.ElementAt(i);
            //    Console.WriteLine(p.Nombre);
            //    Console.WriteLine(p.Descripcion);
            //    Console.WriteLine(p.FechaInicial);
            //    Console.WriteLine(p.FechaFinal);
            //    Console.WriteLine(p.Estado);
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Capacitacion> lc = co.obtenerCapacitaciones();
            //for (int i = 0; i < lc.Count; i++)
            //{
            //    Capacitacion c = lc.ElementAt(i);
            //    Console.WriteLine(c.Id);
            //    Console.WriteLine(c.Nombre);
            //    Console.WriteLine(c.DuracionEnHoras);
            //    Console.WriteLine(c.Descripcion);
            //    Console.WriteLine(c.FechaInicial);
            //    Console.WriteLine(c.FechaFinal);
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = new List<Colaborador>();
            //Colaborador c = new Colaborador();
            //c.Nombre = "Mau";
            //c.Cedula = 114740899;
            //lc.Add(c);
            //c = new Colaborador();
            //c.Nombre = "Javi";
            //c.Cedula = 3452706;
            //lc.Add(c);
            //List<String> ls = co.asignarColaboradoresProyecto(lc, "ERP");
            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls.ElementAt(i));
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = new List<Colaborador>();
            //Colaborador c = new Colaborador();
            //c.Nombre = "Mau";
            //c.Cedula = 114740898;
            //lc.Add(c);
            //c = new Colaborador();
            //c.Nombre = "Javi";
            //c.Cedula = 3452706;
            //lc.Add(c);
            //List<String> ls = co.asignarColaboradoresCapacitacion(lc, 2);
            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls.ElementAt(i));
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = co.obtenerColaboradoresProyecto("ERP");
            //for (int i = 0; i < lc.Count; i++)
            //{
            //    Colaborador c = lc.ElementAt(i);
            //    Console.WriteLine(lc.ElementAt(i).Cedula);
            //    Console.WriteLine(lc.ElementAt(i).Nombre);
            //    Console.WriteLine(lc.ElementAt(i).Puesto);
            //    Console.WriteLine(lc.ElementAt(i).Departamento);
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = new List<Colaborador>();
            //Colaborador c = new Colaborador();
            //c.Nombre = "Mau";
            //c.Cedula = 114740899;
            //lc.Add(c);
            //c = new Colaborador();
            //c.Nombre = "Javi";
            //c.Cedula = 3452706;
            //lc.Add(c);
            //List<String> ls = co.quitarColaboradoresProyecto(lc, "ERP");
            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls.ElementAt(i));
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = co.obtenerColaboradoresCapacitacion(1);
            //for (int i = 0; i < lc.Count; i++)
            //{
            //    Colaborador c = lc.ElementAt(i);
            //    Console.WriteLine(lc.ElementAt(i).Cedula);
            //    Console.WriteLine(lc.ElementAt(i).Nombre);
            //    Console.WriteLine(lc.ElementAt(i).Puesto);
            //    Console.WriteLine(lc.ElementAt(i).Departamento);
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<Colaborador> lc = new List<Colaborador>();
            //Colaborador c = new Colaborador();
            //c.Nombre = "Mau";
            //c.Cedula = 114740899;
            //lc.Add(c);
            //c = new Colaborador();
            //c.Nombre = "Javi";
            //c.Cedula = 3452706;
            //lc.Add(c);
            //c = new Colaborador();
            //c.Nombre = "Ale";
            //c.Cedula = 3450160;
            //lc.Add(c);
            //List<String> ls = co.quitarColaboradoresCapacitacion(lc, 1);
            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls.ElementAt(i));
            //    Console.WriteLine("-----------");
            //}

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //Console.WriteLine(co.asignarCapacitacionProyecto("ERP", 1));

            //ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            //Console.WriteLine(ce.crearColaborador("Caro", "Aguilar", "Segura", 123456, Convert.ToDateTime("05/06/94"), "Colaborador", "TI", "Contador"));

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //List<String> ls = co.obtenerDepartamentos();
            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls.ElementAt(i));
            //    Console.WriteLine("-----------");
            //}
            //Console.WriteLine("*****");
            //ls = co.obtenerPuestos();
            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls.ElementAt(i));
            //    Console.WriteLine("-----------");
            //}

            //ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            //Console.WriteLine(ce.crearContrato(123456, 48));

            //ControladorOrganizacion co = ControladorOrganizacion.obtenerControladorOrganizacion();
            //Console.WriteLine(co.crearDepartamento("Nuevo Depart", "Es un departamento de prueba", "TI"));

            //ControladorExpedientes ce = ControladorExpedientes.obtenerControladorExpedientes();
            //Console.WriteLine(ce.crearSolicitud(123456, Convert.ToDateTime("05/06/94"), Convert.ToDateTime("05/06/94"), "Motivo de la solicitud", "Vacaciones"));
            //Console.WriteLine(ce.crearSolicitud(123456, Convert.ToDateTime("05/06/94"), Convert.ToDateTime("05/06/94"), "Motivo de la solicitud", "Permiso"));
            //Console.WriteLine(ce.crearSolicitud(123456, Convert.ToDateTime("05/06/94"), Convert.ToDateTime("05/06/94"), "Motivo de la solicitud", "Incapacidad"));

            Console.ReadLine();
        }
    }
}
