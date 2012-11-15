using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFCrearColaborador : System.Web.UI.Page
    {


        
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
                labelResultado.Text = "Campos en blanco";
            }
            else
            {
                int cedula;
                bool parsed = int.TryParse(strCedula, out cedula);
                if (!parsed)
                {
                    labelResultado.Text = "Debe ingresar un entero valido en cedula";
                }
                else
                {
                }

            }

        }
    }
}