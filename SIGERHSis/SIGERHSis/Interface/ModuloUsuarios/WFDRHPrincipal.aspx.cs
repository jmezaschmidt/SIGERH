using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using SIGERHSis.Controladores.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
<<<<<<< HEAD
using SIGERHSis.Controladores.ModuloExpedientes;
=======

>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682

namespace SIGERHSis.Interface.ModuloUsuarios
{
    public partial class WFDRHPrincipal : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======

            /* controladorOrganizacion = new ControladorOrganizacion();
             String tabla = controladorOrganizacion.obtenerColaboradores();
             ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:cargarDatosTabla('" + tabla + "');</script>");
             //TextBox1.Attributes.Add("onKeyUp", "cargarDatosTabla('" + tabla + "')");
             * */
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
            cargarExpedientes();

            Label1.Text = Request.QueryString["dato1"];
        }

<<<<<<< HEAD
        private string obtenerOpcionSeleccionada()
        {
=======
        protected void prueba_Click(object sender, EventArgs e)
        {

>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
            RadioButton rb = new RadioButton();
            foreach (TableRow tr in tblData.Controls)
            {
                foreach (TableCell tc in tr.Controls)
                {
<<<<<<< HEAD
                    if (tc.HasControls())
                    {
                        if (tc.Controls[0] is RadioButton)
                        {
                            rb = (RadioButton)tc.Controls[0];
                            if (rb.Checked)
                            {
                                ControladorExpedientes.obtenerControladorExpedientes().iniciarExpediente(int.Parse(rb.ID));
                            }
                            break;
                        }
                    }
                }
            }
            return "";
=======
                    if (tc.Controls[0] is RadioButton)
                    {
                        rb = (RadioButton)tc.Controls[0];
                        if (rb.Checked)
                        {
                            Label1.Text = rb.Text;
                        }
                        break;
                    }
                }
            }

>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
        }
        private void cargarExpedientes()
        {
            List<Colaborador> colaboradores = controladorOrganizacion.obtenerColaboradores(true);
<<<<<<< HEAD
=======
            /*colaboradores = new List<Colaborador>();
            //
            Colaborador cola = new Colaborador();
            cola.Cedula = 304500160;
            cola.Nombre = "Alejandra Monge Granados";
            cola.Puesto = "Ingenieria en Computacion";
            cola.Departamento = "Desarrollo de Software";
            colaboradores.Add(cola);
            //
            Colaborador cola1 = new Colaborador();
            cola1.Cedula = 114740899;
            cola1.Nombre = "Mauricio Munoz Chaves";
            cola1.Puesto = "Ingenieria en Software";
            cola1.Departamento = "Analisis de Sistemas";
            colaboradores.Add(cola1);
            //
            Colaborador cola2 = new Colaborador();
            cola2.Cedula = 304520706;
            cola2.Nombre = "Javier Meza Schmidt";
            cola2.Puesto = "Ingenieria en Computacion";
            cola2.Departamento = "Redes y mas";
            colaboradores.Add(cola2);*/
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
            int numColaboradores = colaboradores.Count;
            string claseFilaImpar = "impar";
            string claseFilaPar = "par";
            string claseFila = "";
            TableRow tRow2 = new TableRow();
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = "Cédula";
            headerCell.Width = Unit.Percentage(10);
            tRow2.Cells.Add(headerCell);
            TableHeaderCell headerCell2 = new TableHeaderCell();
            headerCell2.Text = "Nombre";
            headerCell2.Width = Unit.Percentage(30);
            tRow2.Cells.Add(headerCell2);
            TableHeaderCell headerCell3 = new TableHeaderCell();
            headerCell3.Text = "Puesto";
            headerCell3.Width = Unit.Percentage(30);
            tRow2.Cells.Add(headerCell3);
            TableHeaderCell headerCell4 = new TableHeaderCell();
            headerCell4.Text = "Departamento";
            headerCell4.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell4);
            tblData.Rows.Add(tRow2);
            for (int i = 0; i < numColaboradores; i++)
            {
                if (i % 2 == 0)
                {
                    claseFila = claseFilaPar;
                }
                else
                {
                    claseFila = claseFilaImpar;
                }
                // Create new row and add it to the table.
                TableRow tRow = new TableRow();
                tRow.CssClass = claseFila;
                tblData.Rows.Add(tRow);
                // Create a new cell and add it to the row.
                TableCell tCell = new TableCell();
                tCell.Text = colaboradores[i].Cedula + "";
                tRow.Cells.Add(tCell);
                // Create a new cell and add it to the row.
                TableCell tCell2 = new TableCell();
                tCell2.Text = colaboradores[i].Nombre;
                tRow.Cells.Add(tCell2);
                // Create a new cell and add it to the row.
                TableCell tCell3 = new TableCell();
                tCell3.Text = colaboradores[i].Puesto;
                tRow.Cells.Add(tCell3);
                // Create a new cell and add it to the row.
                TableCell tCell4 = new TableCell();
                tCell4.Text = colaboradores[i].Departamento;
                tRow.Cells.Add(tCell4);

                RadioButton radioButton = new RadioButton();
                radioButton.ID = colaboradores[i].Cedula + "";
                radioButton.GroupName = "Expedientes";

                TableCell cell = new TableCell();
                cell.Controls.Add(radioButton);
                tRow.Cells.Add(cell);
            }
        }

        protected void btnVerExpediente_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            obtenerOpcionSeleccionada();
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx");
<<<<<<< HEAD
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx");
=======
=======
            String cedula = "3452706"; 
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx?cedula="+cedula);
>>>>>>> c644c5d97d3426adfef5ab5ba77c67c367e69682
>>>>>>> 67b3c6b91f5f0f1e640eb5c453b4a8617e72620d
        }
    }
}
