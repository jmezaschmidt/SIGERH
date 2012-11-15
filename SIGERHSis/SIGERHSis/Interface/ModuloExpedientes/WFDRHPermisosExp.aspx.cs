using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloUsuarios;
using SIGERHSis.Controladores.ModuloUsuarios;

using SIGERHSis.Controladores.ModuloExpedientes;

namespace SIGERHSis.Interface.ModuloExpedientes
{
    public partial class WFDRHPermisosExp : System.Web.UI.Page
    {
        ControladorExpedientes controladorExpediente = ControladorExpedientes.obtenerControladorExpedientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarPermisos();
            if (this.IsPostBack)
            {
                cargarPermisos();
            }
        }
        private void cargarPermisos()
        {
            List<Permiso> permisos = controladorExpediente.obtenerPermisosColaboradorPxy();
            tblData.Rows.Clear();
            int numColaboradores = permisos.Count;
            string claseFilaImpar = "impar";
            string claseFilaPar = "par";
            string claseFila = "";
            TableRow tRow2 = new TableRow();
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = "Fecha de Solicitud";
            headerCell.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell);
            TableHeaderCell headerCell2 = new TableHeaderCell();
            headerCell2.Text = "Fecha Inicial";
            headerCell2.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell2);
            TableHeaderCell headerCell3 = new TableHeaderCell();
            headerCell3.Text = "Fecha Final";
            headerCell3.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell3);
            TableHeaderCell headerCell4 = new TableHeaderCell();
            headerCell4.Text = "Estado";
            headerCell4.Width = Unit.Percentage(20);
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
                tCell.Text = permisos[i].FechaSolicitud.Day + "-" + permisos[i].FechaSolicitud.Month + "-" + permisos[i].FechaSolicitud.Year;
                tRow.Cells.Add(tCell);
                // Create a new cell and add it to the row.
                TableCell tCell2 = new TableCell();
                tCell2.Text = permisos[i].FechaInicial.Day + "-" + permisos[i].FechaInicial.Month + "-" + permisos[i].FechaInicial.Year;
                tRow.Cells.Add(tCell2);
                // Create a new cell and add it to the row.
                TableCell tCell3 = new TableCell();
                tCell3.Text = permisos[i].FechaFinal.Day + "-" + permisos[i].FechaFinal.Month + "-" + permisos[i].FechaFinal.Year;
                tRow.Cells.Add(tCell3);
                // Create a new cell and add it to the row.
                TableCell tCell4 = new TableCell();
                tCell4.Text = permisos[i].Estado;
                tRow.Cells.Add(tCell4);

                RadioButton radioButton = new RadioButton();
                //radioButton.ID = "Permisos";
                radioButton.ID = permisos[i].Id.ToString();
                radioButton.GroupName = "Permisos";

                TableCell cell = new TableCell();
                cell.Controls.Add(radioButton);
                tRow.Cells.Add(cell);
            }
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
                                return rb.ID;
                            }
                            break;
                        }
                    }
                }
            }
            return "";
        }



        protected void btnAprobar_Click(object sender, EventArgs e)
        {
            if (obtenerOpcionSeleccionada() != "")
            {
                controladorExpediente.cambiarEstadoPermisoPxy(int.Parse(obtenerOpcionSeleccionada()), "Aprobada");
                cargarPermisos();
            }
        }

        protected void btnNegar_Click(object sender, EventArgs e)
        {
            if (obtenerOpcionSeleccionada() != "")
            {
                controladorExpediente.cambiarEstadoPermisoPxy(int.Parse(obtenerOpcionSeleccionada()), "No Aprobada");
                cargarPermisos();
            }
        }

        
    }
}