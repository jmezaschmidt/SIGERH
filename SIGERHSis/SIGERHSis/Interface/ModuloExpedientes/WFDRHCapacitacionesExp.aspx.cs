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
    public partial class WFDRHCapacitacionesExp : System.Web.UI.Page
    {

        ControladorExpedientes controladorExpediente = ControladorExpedientes.obtenerControladorExpedientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarCapacacitaciones();
        }


        private void cargarCapacacitaciones()
        {
            List<Capacitacion> capacitaciones = controladorExpediente.obtenerCapacitacionesColaboradorPxy();

            int numColaboradores = capacitaciones.Count;
            string claseFilaImpar = "impar";
            string claseFilaPar = "par";
            string claseFila = "";
            TableRow tRow2 = new TableRow();
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = "Capacitación";
            headerCell.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell);
            TableHeaderCell headerCell2 = new TableHeaderCell();
            headerCell2.Text = "Duración";
            headerCell2.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell2);
            TableHeaderCell headerCell3 = new TableHeaderCell();
            headerCell3.Text = "Fecha Inicial";
            headerCell3.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell3);
            TableHeaderCell headerCell4 = new TableHeaderCell();
            headerCell4.Text = "Fecha Final";
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
                tCell.Text = capacitaciones[i].Nombre;
                tRow.Cells.Add(tCell);
                // Create a new cell and add it to the row.
                TableCell tCell2 = new TableCell();
                tCell2.Text = capacitaciones[i].DuracionEnHoras + " horas";
                tRow.Cells.Add(tCell2);
                // Create a new cell and add it to the row.
                TableCell tCell3 = new TableCell();
                tCell3.Text = capacitaciones[i].FechaInicial.Day + "-" + capacitaciones[i].FechaInicial.Month + "-" + capacitaciones[i].FechaInicial.Year;
                tRow.Cells.Add(tCell3);
                // Create a new cell and add it to the row.
                TableCell tCell4 = new TableCell();
                tCell4.Text = capacitaciones[i].FechaFinal.Day + "-" + capacitaciones[i].FechaFinal.Month + "-" + capacitaciones[i].FechaFinal.Year;
                tRow.Cells.Add(tCell4);
            }
        }
    }
}