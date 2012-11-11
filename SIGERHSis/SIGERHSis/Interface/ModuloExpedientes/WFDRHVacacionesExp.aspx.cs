using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloExpedientes;

namespace SIGERHSis.Interface.ModuloExpedientes
{
    public partial class WFDRHVacacionesExp : System.Web.UI.Page
    {
        ControladorExpedientes controladorExpediente = ControladorExpedientes.obtenerControladorExpedientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarVacaciones();
        }

        protected void btnAprobar_Click(object sender, EventArgs e)
        {

        }
        private void cargarVacaciones()
        {
            List<Vacaciones> vacaciones = controladorExpediente.obtenerVacacionesColaboradorPxy();

            int numColaboradores = vacaciones.Count;
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
                tCell.Text = vacaciones[i].FechaSolicitud.Day + "-" + vacaciones[i].FechaSolicitud.Month + "-" + vacaciones[i].FechaSolicitud.Year;
                tRow.Cells.Add(tCell);
                // Create a new cell and add it to the row.
                TableCell tCell2 = new TableCell();
                tCell2.Text = vacaciones[i].FechaInicial.Day + "-" + vacaciones[i].FechaInicial.Month + "-" + vacaciones[i].FechaInicial.Year;
                tRow.Cells.Add(tCell2);
                // Create a new cell and add it to the row.
                TableCell tCell3 = new TableCell();
                tCell3.Text = vacaciones[i].FechaFinal.Day + "-" + vacaciones[i].FechaFinal.Month + "-" + vacaciones[i].FechaFinal.Year;
                tRow.Cells.Add(tCell3);
                // Create a new cell and add it to the row.
                TableCell tCell4 = new TableCell();
                tCell4.Text = vacaciones[i].Estado;
                tRow.Cells.Add(tCell4);

                RadioButton radioButton = new RadioButton();
                radioButton.ID = vacaciones[i].Id.ToString();
                radioButton.GroupName = "Vacaciones";

                TableCell cell = new TableCell();
                cell.Controls.Add(radioButton);
                tRow.Cells.Add(cell);
            }
        }
    }
}