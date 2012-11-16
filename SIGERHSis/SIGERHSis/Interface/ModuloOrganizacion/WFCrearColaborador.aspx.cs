using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
using SIGERHSis.Controladores.ModuloOrganizacion;
using System.Drawing;
using SIGERHSis.Controladores.ModuloExpedientes;
=======
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFCrearColaborador : System.Web.UI.Page
    {

<<<<<<< HEAD
        ControladorOrganizacion _controlador = ControladorOrganizacion.obtenerControladorOrganizacion();
        ControladorExpedientes _controladorExp = ControladorExpedientes.obtenerControladorExpedientes();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ListDepartamento.DataSource = _controlador.obtenerDepartamentos();
                ListDepartamento.DataBind();

                ListPuesto.DataSource = _controlador.obtenerPuestos();
                ListPuesto.DataBind();
                Calendar.SelectedDate = DateTime.Now;
            }
=======

        
        protected void Page_Load(object sender, EventArgs e)
        {
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
            
        }

        protected void botonCrearUsuario_Click(object sender, EventArgs e)
        {
            String nombre = TextBoxNombre.Text;
            String apellido1 = TextBoxApellido1.Text;
            String apellido2 = TextBoxApellido2.Text;
            String strCedula = TextBoxCedula.Text;
            DateTime fechaNacimiento = Calendar.SelectedDate;
            String tipoUsuario = ListTipoUsuario.SelectedItem.Value;
            String departamento = ListDepartamento.SelectedItem.Value;
            String puesto = ListPuesto.SelectedItem.Value;

            if (nombre.Equals("") || apellido1.Equals("") || apellido2.Equals("") || strCedula.Equals(""))
            {
<<<<<<< HEAD
                labelResultado.ForeColor = Color.Red;
=======
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
                labelResultado.Text = "Campos en blanco";
            }
            else
            {
                int cedula;
                bool parsed = int.TryParse(strCedula, out cedula);
                if (!parsed)
                {
<<<<<<< HEAD
                    labelResultado.ForeColor = Color.Red;
=======
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
                    labelResultado.Text = "Debe ingresar un entero valido en cedula";
                }
                else
                {
<<<<<<< HEAD
                    bool resultado = _controladorExp.crearColaborador(nombre, apellido1, apellido2, cedula, fechaNacimiento, tipoUsuario, departamento, puesto);
                    if (resultado)
                    {
                        labelResultado.ForeColor = Color.Green;
                        labelResultado.Text = "Colaborador creado exitosamente";
                    }
                    else
                    {
                        labelResultado.ForeColor = Color.Red;
                        labelResultado.Text = "El numero de cedula dado ya se encuentra registrado";
                    }                    
=======
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
                }

            }

        }
    }
}