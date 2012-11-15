using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using SIGERHSis.Controladores.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
using SIGERHSis.Controladores.ModuloExpedientes;

namespace SIGERHSis.Interface.ModuloUsuarios
{
    public partial class WFDRHPrincipal : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarExpedientes();

            Label1.Text = Request.QueryString["dato1"];
        }

        private string obtenerOpcionSeleccionada()
        {
            RadioButton rb = new RadioButton();
            foreach (TableRow tr in tblData.Controls)
            {
                foreach (TableCell tc in tr.Controls)
                {
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
        }
        private void cargarExpedientes()
        {
            List<Colaborador> colaboradores = controladorOrganizacion.obtenerColaboradores(true);
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

            obtenerOpcionSeleccionada();
            Response.Redirect("http://localhost:17482/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx");
            //Response.Redirect("http://201.206.189.98/SIGERHSis/Interface/ModuloExpedientes/WFDRHInfoGeneral.aspx");
        }
    }
}
