using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
using DocumentFormat.OpenXml.Wordprocessing;

namespace UI
{
    public partial class FormPlanEjercicio : Form
    {
        PlanDeEjercicio planDeEjercicio;
        PlanDeEjercicioService planDeEjercicioService;
        public FormPlanEjercicio()
        {
            planDeEjercicioService = new PlanDeEjercicioService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarListaDePlanes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Consultar plan de ejercicio
        private void CargarListaDePlanes()
        {
            ConsultaPlanDeEjercicioRespuesta respuesta = new ConsultaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.ConsultarTodos();
            var planesDeEjercicios = respuesta.PlanesDeEjercicios.ToList();
            if (planesDeEjercicios != null)
            {
                dataGridPlanEjercicio.DataSource = planesDeEjercicios;
            }
            else
            {
                if (planesDeEjercicios == null)
                {
                    labelAlerta.Text = "No hay planes registrados";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
            }
        }
        private void comboFiltroJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jornada = comboFiltroJornada.Text;
            BuscarPorJornada(jornada);
        }
        private void BuscarPorJornada(string busqueda)
        {
            BusquedaPlanDeEjercicioRespuesta respuesta = new BusquedaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.BuscarPorJornada(busqueda);
            var buscado = respuesta.PlanDeEjercicio;
            if (buscado != null)
            {
                dataGridPlanEjercicio.DataSource = null;
                dataGridPlanEjercicio.DataSource = buscado;
            }
            else
            {
                if (buscado == null)
                {
                    labelAlerta.Text = "No hay registro relacionados a este filtro";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
            }
        }
        //Registrar plan de ejercicio
        private void BuscarPorObjetivo(string busqueda)
        {
            BusquedaPlanDeEjercicioRespuesta respuesta = new BusquedaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.BuscarPorObjetivo(busqueda);
            var buscado = respuesta.PlanDeEjercicio;
            if (buscado != null)
            {
                panelDatosBasicosPlan.Enabled = true;
                panelDetallesPlanes.Enabled = true;
                labelCodigoPlan.Text = buscado.IdPlanDeEjercicio;
                comboJornada.Text = buscado.Jornada;
                textCatidadDiasMeses.Text = buscado.NumeroDiasMeses.ToString();
                comboDiasMeses.Text = buscado.TipoDeTiempo;
                dateTimeFechaInicio.Value = buscado.FechaDeEntreno;
                textObjetivo.Text = buscado.Objetivo;
                textDescripcion.Text = buscado.DescripcionPlanEjercicio;
                comboEstado.Text = buscado.Estado;
                comboCiclo.Text = buscado.Ciclo;
                textPrecio.Text = buscado.Precio.ToString();
            }
            else
            {
                if (buscado == null)
                {
                    labelAlerta.Text = "No hay registro sobre esta busqueda";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
            }
        }
        private void BuscarPorIdentificacion(string busqueda)
        {
            BusquedaPlanDeEjercicioRespuesta respuesta = new BusquedaPlanDeEjercicioRespuesta();
            respuesta = planDeEjercicioService.BuscarPorIdentificacion(busqueda);
            var buscado = respuesta.PlanDeEjercicio;
            if (buscado != null)
            {
                panelDatosBasicosPlan.Enabled = true;
                panelDetallesPlanes.Enabled = true;
                labelCodigoPlan.Text = buscado.IdPlanDeEjercicio;
                comboJornada.Text = buscado.Jornada;
                textCatidadDiasMeses.Text = buscado.NumeroDiasMeses.ToString();
                comboDiasMeses.Text = buscado.TipoDeTiempo;
                dateTimeFechaInicio.Value = buscado.FechaDeEntreno;
                textObjetivo.Text = buscado.Objetivo;
                textDescripcion.Text = buscado.DescripcionPlanEjercicio;
                comboEstado.Text = buscado.Estado;
                comboCiclo.Text = buscado.Ciclo;
                textPrecio.Text = buscado.Precio.ToString();
            }
            else
            {
                if (buscado == null)
                {
                    labelAlerta.Text = "No hay registro sobre esta busqueda";
                    labelAlerta.Visible = true;
                    pictureAlerta.Visible = true;
                }
            }
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textSearch.Text;
            if (textSearch.Text != "" && textSearch.Text != "Buscar")
            {
                BuscarPorIdentificacion(busqueda);
                BuscarPorObjetivo(busqueda);
            }
        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == "Buscar")
            {
                textSearch.Text = "";
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
            {
                textSearch.Text = "Buscar";
            }
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            tabControlPlanes.SelectedIndex = 1;
        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            tabControlPlanes.SelectedIndex = 1;
        }
        private PlanDeEjercicio MapearPlan()
        {
            planDeEjercicio = new PlanDeEjercicio();
            planDeEjercicio.IdPlanDeEjercicio = labelCodigoPlan.Text;
            planDeEjercicio.Jornada = comboJornada.Text;
            planDeEjercicio.NumeroDiasMeses = Convert.ToInt32(textCatidadDiasMeses.Text);
            planDeEjercicio.NumeroDiasMeses = Convert.ToInt32(comboDiasMeses.Text);
            planDeEjercicio.FechaDeEntreno = dateTimeFechaInicio.Value;
            planDeEjercicio.Objetivo = textObjetivo.Text;
            planDeEjercicio.DescripcionPlanEjercicio = textDescripcion.Text;
            planDeEjercicio.Estado = comboEstado.Text;
            planDeEjercicio.Ciclo = comboCiclo.Text;
            planDeEjercicio.Precio = Convert.ToInt32(textPrecio.Text);
            return planDeEjercicio;
        }
        private void Limpiar()
        {
            labelCodigoPlan.Text = "*";
            comboJornada.Text = "Seleccione una jornada";
            textCatidadDiasMeses.Text = "0";
            comboDiasMeses.Text = "Dias/Meses";
            dateTimeFechaInicio.Value = DateTime.Now;
            textObjetivo.Text = "";
            textDescripcion.Text = "";
            comboEstado.Text = "Seleccione unestado";
            comboCiclo.Text = "Seleccione un ciclo";
            textPrecio.Text = "0";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            PlanDeEjercicio planDeEjercicio = MapearPlan();
            string mensaje = planDeEjercicioService.Guardar(planDeEjercicio);
            MessageBox.Show(mensaje, "Registro de plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarListaDePlanes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PlanDeEjercicio planDeEjercicio = MapearPlan();
            string mensaje = planDeEjercicioService.Modificar(planDeEjercicio);
            MessageBox.Show(mensaje, "Modificacion de plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarListaDePlanes();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            btnCloseTextSearch.Visible = true;
            textSearch.Visible = true;
        }

        private void btnCloseTextSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnCloseTextSearch.Visible = false;
            textSearch.Visible = false;
        }
    }
}
