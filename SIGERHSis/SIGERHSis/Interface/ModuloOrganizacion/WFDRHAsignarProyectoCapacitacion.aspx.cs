using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloExpedientes;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;
namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFDRHAsignarProyectoCapacitacion : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                obtenerCapacitaciones();
            }
        }
        public void obtenerCapacitaciones()
        {
            //capacitaciones = controladorOrganizacion.obtenerCapacitaciones();
            List<Capacitacion> capacitaciones = controladorOrganizacion.obtenerCapacitaciones();
            foreach (Capacitacion capacitacion in capacitaciones)
            {
                DropDownListProyectos.Items.Add(capacitacion.Nombre);
            }
        }
        protected void btnAsignarProyecto_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownListProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Capacitacion> capacitaciones = controladorOrganizacion.obtenerCapacitaciones();
            Capacitacion capacitacionActual = capacitaciones[DropDownListProyectos.SelectedIndex];
            lblNombreInfo.Text = capacitacionActual.Nombre;
            lblDuracion.Text = capacitacionActual.DuracionEnHoras.ToString();
            lblFechaIncialInfo.Text = capacitacionActual.FechaInicial.Day + "-" + capacitacionActual.FechaInicial.Month + "-" + capacitacionActual.FechaInicial.Year;
            lblFechaFinalInfo.Text = capacitacionActual.FechaFinal.Day + "-" + capacitacionActual.FechaFinal.Month + "-" + capacitacionActual.FechaFinal.Year;
            lblDescripcionInfo.Text = capacitacionActual.Descripcion;
            cargarProyectos();
        }
        private void cargarProyectos()
        {
            List<Proyecto> proyectos = controladorOrganizacion.obtenerProyectos();
            
            int numColaboradores = proyectos.Count;
            string claseFilaImpar = "impar";
            string claseFilaPar = "par";
            string claseFila = "";
            TableRow tRow2 = new TableRow();
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = "Nombre:";
            headerCell.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell);
            TableHeaderCell headerCell2 = new TableHeaderCell();
            headerCell2.Text = "Fecha inicial";
            headerCell2.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell2);
            TableHeaderCell headerCell3 = new TableHeaderCell();
            headerCell3.Text = "Fecha final";
            headerCell3.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell3);
            TableHeaderCell headerCell4 = new TableHeaderCell();
            headerCell4.Text = "Descripcion";
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
                tCell.Text = proyectos[i].Nombre;
                tRow.Cells.Add(tCell);
                // Create a new cell and add it to the row.
                TableCell tCell2 = new TableCell();
                tCell2.Text = proyectos[i].FechaInicial.Day+"-"+proyectos[i].FechaInicial.Month+"-"+proyectos[i].FechaInicial.Year;
                tRow.Cells.Add(tCell2);
                // Create a new cell and add it to the row.
                TableCell tCell3 = new TableCell();
                tCell3.Text = proyectos[i].FechaFinal.Day+"-"+proyectos[i].FechaFinal.Month+"-"+proyectos[i].FechaFinal.Year;
                tRow.Cells.Add(tCell3);
                // Create a new cell and add it to the row.
                TableCell tCell4 = new TableCell();
                tCell4.Text = proyectos[i].Descripcion;
                tRow.Cells.Add(tCell4);

                RadioButton radioButton = new RadioButton();
                radioButton.ID = proyectos[i].Nombre;
                radioButton.GroupName = "Proyectos";

                TableCell cell = new TableCell();
                cell.Controls.Add(radioButton);
                tRow.Cells.Add(cell);
            }
        }
    }
}