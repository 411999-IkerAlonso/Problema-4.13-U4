using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Problema_4._13
{
    public partial class AMBPersonas : Form
    {
        public AMBPersonas()
        {
            InitializeComponent();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cboEstadoCivil.Enabled = false;
            cboTipoDoc.Enabled = false;
            txtDocumento.Enabled = false;
            rbtFemenino.Enabled = false;
            rbtMasculino.Enabled = false;
            cbFallecido.Enabled = false;
            lstPersonas.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            cboEstadoCivil.Enabled = true;
            cboTipoDoc.Enabled = true;
            txtDocumento.Enabled = true;
            rbtFemenino.Enabled = true;
            rbtMasculino.Enabled = true;
            cbFallecido.Enabled = true;
            txtApellido.Clear();
            txtNombre.Clear();
            cboTipoDoc.SelectedIndex = -1;
            txtDocumento.Clear();
            rbtMasculino.Select();
            cbFallecido.Checked = false;
            txtApellido.Focus();
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            cboEstadoCivil.Enabled = true;
            cboTipoDoc.Enabled = true;
            txtDocumento.Enabled = true;
            rbtFemenino.Enabled = true;
            rbtMasculino.Enabled = true;
            cbFallecido.Enabled = true;
            txtApellido.Clear();
            txtNombre.Clear();
            cboTipoDoc.SelectedIndex = -1;
            txtDocumento.Clear();
            rbtMasculino.Select();
            cbFallecido.Checked = false;
            txtApellido.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result== DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cboEstadoCivil.Enabled = false;
            cboTipoDoc.Enabled = false;
            txtDocumento.Enabled = false;
            rbtFemenino.Enabled = false;
            rbtMasculino.Enabled = false;
            cbFallecido.Enabled = false;
            txtApellido.Clear();
            txtNombre.Clear();
            cboTipoDoc.SelectedIndex = -1;
            txtDocumento.Clear();
            rbtMasculino.Select();
            cbFallecido.Checked = false;
            lstPersonas.Focus();
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que desea borrar a la persona?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grabacion Exitosa");
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cboEstadoCivil.Enabled = false;
            cboTipoDoc.Enabled = false;
            txtDocumento.Enabled = false;
            rbtFemenino.Enabled = false;
            rbtMasculino.Enabled = false;
            cbFallecido.Enabled = false;
            txtApellido.Clear();
            txtNombre.Clear();
            cboTipoDoc.SelectedIndex = -1;
            txtDocumento.Clear();
            rbtMasculino.Select();
            cbFallecido.Checked = false;
            lstPersonas.Focus();
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;

        }
    }
}
