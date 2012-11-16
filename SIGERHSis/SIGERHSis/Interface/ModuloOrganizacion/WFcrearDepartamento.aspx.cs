using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;
using System.Drawing;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFcrearDepartamento : System.Web.UI.Page
    {
        ControladorOrganizacion _controlador = ControladorOrganizacion.obtenerControladorOrganizacion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<String> lista = _controlador.obtenerDepartamentos();
                lista.Add("Nulo");
                ListDepartamento.DataSource = lista;
                ListDepartamento.DataBind();
            }
        }

        protected void BotonCrearDepartamento_Click(object sender, EventArgs e)
        {
            String nombre = TextBoxNombre.Text;
            String descripcion = TextBoxDescripcion.Text;
            String padre = ListDepartamento.SelectedItem.Value;
            if (nombre.Equals("") || descripcion.Equals(""))
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Campos en Blanco";
            }
            else
            {
                bool resultado = _controlador.crearDepartamento(nombre, descripcion, padre);
                if(resultado)
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Departamento creado con exito";
                }
                else 
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = "Nombre especificado para el nuevo departamento ya existe";
                }
            }
        }
    }
}