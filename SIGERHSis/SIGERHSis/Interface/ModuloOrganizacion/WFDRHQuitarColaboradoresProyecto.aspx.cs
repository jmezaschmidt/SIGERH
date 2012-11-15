﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGERHSis.Controladores.ModuloOrganizacion;
using SIGERHSis.LibreriaComun.ModuloOrganizacion;

namespace SIGERHSis.Interface.ModuloOrganizacion
{
    public partial class WFDRHQuitarColaboradoresProyecto : System.Web.UI.Page
    {
        ControladorOrganizacion controladorOrganizacion = ControladorOrganizacion.obtenerControladorOrganizacion();
        List<Colaborador> colaboradoresProyecto = new List<Colaborador>();
        List<Proyecto> proyectos = new List<Proyecto>();
        Proyecto _proyectoActual;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                obtenerProyectos();
            }
        }
        public void obtenerProyectos()
        {
            proyectos = controladorOrganizacion.obtenerProyectos();
            foreach (Proyecto proyecto in proyectos)
            {
                DropDownListProyectos.Items.Add(proyecto.Nombre);
            }
        }

        protected void DropDownListProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            proyectos = controladorOrganizacion.obtenerProyectos();
            _proyectoActual = proyectos[DropDownListProyectos.SelectedIndex];
            lblNombreInfo.Text = _proyectoActual.Nombre;
            lblEstadoInfo.Text = _proyectoActual.Estado;
            lblFechaIncialInfo.Text = _proyectoActual.FechaInicial.Day + "-" + _proyectoActual.FechaInicial.Month + "-" + _proyectoActual.FechaInicial.Year;
            lblFechaFinalInfo.Text = _proyectoActual.FechaFinal.Day + "-" + _proyectoActual.FechaFinal.Month + "-" + _proyectoActual.FechaFinal.Year;
            lblDescripcionInfo.Text = _proyectoActual.Descripcion;
            cargarColaboradores();
        }
        private void cargarColaboradores()
        {
            List<Colaborador> colaboradores = controladorOrganizacion.obtenerColaboradoresProyecto(_proyectoActual.Nombre);
            int numColaboradores = colaboradores.Count;
            string claseFilaImpar = "impar";
            string claseFilaPar = "par";
            string claseFila = "";
            TableRow tRow2 = new TableRow();
            TableHeaderCell headerCell = new TableHeaderCell();
            headerCell.Text = "Cédula:";
            headerCell.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell);
            TableHeaderCell headerCell2 = new TableHeaderCell();
            headerCell2.Text = "Nombre";
            headerCell2.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell2);
            TableHeaderCell headerCell3 = new TableHeaderCell();
            headerCell3.Text = "Puesto";
            headerCell3.Width = Unit.Percentage(25);
            tRow2.Cells.Add(headerCell3);
            TableHeaderCell headerCell4 = new TableHeaderCell();
            headerCell4.Text = "Departamento";
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
                tCell.Text = colaboradores[i].Cedula.ToString();
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
                radioButton.ID = i.ToString();
                //radioButton.GroupName = "Vacaciones";

                TableCell cell = new TableCell();
                cell.Controls.Add(radioButton);
                tRow.Cells.Add(cell);
            }
        }
        private string obtenerColaboradoresSeleccionados()
        {
            List<Colaborador> colaboradoresSeleccionados = new List<Colaborador>();
            colaboradoresProyecto = controladorOrganizacion.obtenerColaboradoresFueraProyecto(_proyectoActual.Nombre);
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
                                //return rb.ID;
                                colaboradoresSeleccionados.Add(colaboradoresProyecto[int.Parse(rb.ID)]);
                            }
                            //break;
                        }
                    }
                }
            }
            controladorOrganizacion.quitarColaboradoresProyecto(colaboradoresSeleccionados, DropDownListProyectos.SelectedItem.Value);
            return "";
        }
    }
}