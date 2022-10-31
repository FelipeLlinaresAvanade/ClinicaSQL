using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSQL
{
    public partial class frmCitas : Form
    {
        public frmCitas()
        {
            InitializeComponent();
        }

        #region Enumerado

        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        #region Eventos
        private void frmCitas_Load(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCitas.Rows[e.RowIndex].Selected = true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Cita c = ObtenerInformacion();
                correcto = Repositorio.EliminarCita(c);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("La acción se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la información
                Cita c = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repositorio.CrearCita(c);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repositorio.ModificarCita(c);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("La acción se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Medico y Paciente son obligatorios.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir de la edición?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (dgvCitas.SelectedRows.Count == 1)
                {
                    // Recargamos su información en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvCitas.SelectedRows[0]);
                }
            }
        }

        private void dgvCitas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operación que no sea que ha cambiado la selección de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Método para establecer el modo de la pantalla a edición.
        /// </summary>
        public void ModoPantallaEdicion()
        {
            // Limpiamos sólo si es modo creación, si es modo edición dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                LimpiarCampos();
            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtpaciente.Enabled = true;
            dtpfecha.Enabled = true;
            dtphora.Enabled = true;
            txtmedico.Enabled = true;
            txtnumeroConsulta.Enabled = true;
            txtId.Enabled = false;

            btnAñadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            dgvCitas.Enabled = false;
        }

        /// <summary>
        /// Método para limpiar los campos del formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            txtpaciente.Text = "";
            txtmedico.Text = "";
            dtpfecha.Value = DateTime.Now;
            dtphora.Value = DateTime.Now;
            txtnumeroConsulta.Text = "";
            txtId.Text = "";
        }
        /// <summary>
        /// Método para establecer el modo de la pantalla a edición.
        /// </summary>
        public void ModoPantallaLectura()
        {
            LimpiarCampos();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtpaciente.Enabled = false;
            dtpfecha.Enabled = false;
            dtphora.Enabled = false;
            txtmedico.Enabled = false;
            txtnumeroConsulta.Enabled = false;
            txtId.Enabled = false;

            dgvCitas.Enabled = true;
        }

        /// <summary>
        /// Método para obtener la información del formulario.
        /// </summary>
        /// <returns>Contacto con la información del formulario.</returns>
        public Cita ObtenerInformacion()
        {
            Cita cita = new Cita();

            cita.paciente = txtpaciente.Text;
            cita.medico = txtmedico.Text;
            cita.numeroConsulta = Convert.ToInt32(txtnumeroConsulta.Text);
            cita.fechaYhora = dtpfecha.Value + dtphora.Value.TimeOfDay;
 
            if (!String.IsNullOrEmpty(txtId.Text))
            {
                cita.Id = Convert.ToInt32(txtId.Text);
            }

            return cita;
        }

        /// <summary>
        /// Método que carga y configura el grid.
        /// </summary>
        /// <param name="Contactos">DataTable con la info de los contactos</param>
        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerCitas();
            dgvCitas.DataSource = ds.Tables[0];

            // Tamaños columnas
            dgvCitas.Columns["Id"].Width = 50;
            dgvCitas.Columns["Paciente"].Width = 150;
            dgvCitas.Columns["Medico"].Width = 150;
            dgvCitas.Columns["FechaYhora"].Width = 160;
            dgvCitas.Columns["numeroConsulta"].Width = 100;

            // Renombrado columnas
            dgvCitas.Columns["FechaYhora"].HeaderText = "Fecha y hora";
            dgvCitas.Columns["numeroConsulta"].HeaderText = "Consulta";

            // Formato fecha en español
            dgvCitas.Columns["FechaYhora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        /// <summary>
        /// Método que selecciona la primera fila del grid si existe.
        /// </summary>
        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvCitas.Rows.Count > 0)
            {
                dgvCitas.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// Método que carga la información de la fila seleccionada en los controles.
        /// </summary>
        /// <param name="filaSeleccionada"></param>
        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtpaciente.Text = filaSeleccionada.Cells["paciente"].Value.ToString();
            dtpfecha.Value = (DateTime)filaSeleccionada.Cells["FechaYhora"].Value;
            dtphora.Value = (DateTime)filaSeleccionada.Cells["FechaYhora"].Value;
            txtnumeroConsulta.Text = filaSeleccionada.Cells["numeroConsulta"].Value.ToString();
            txtmedico.Text = filaSeleccionada.Cells["medico"].Value.ToString();

        }

        /// <summary>
        /// Función que nos indica si la información obligatoria está cumplimentada o no.
        /// </summary>
        /// <returns></returns>
        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtpaciente.Text) || String.IsNullOrEmpty(txtmedico.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        #endregion

        
    }

}
