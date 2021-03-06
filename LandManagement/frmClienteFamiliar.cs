﻿using LandManagement.Business;
using LandManagement.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LandManagement.Utilidades;

namespace LandManagement
{
    public partial class frmClienteFamiliar : Form
    {
        public static readonly ILog log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private TipoFamiliarBusiness tipoFamiliarBusiness;
        private tbcliente familiar;
        private int idFamiliar = 0;
        private int indiceFila = -1;
        private Form formPadre;
        ValidarControles validarControles;
        private ErrorProvider errorProvider1 = new ErrorProvider();

        public frmClienteFamiliar(Form formularioPadre)
        {
            InitializeComponent();
            this.formPadre = formularioPadre;
        }

        public frmClienteFamiliar(tbcliente pFamiliar, int idxFila, Form formularioPadre)
        {
            InitializeComponent();

            this.formPadre = formularioPadre;
            this.familiar = pFamiliar;

            this.idFamiliar = pFamiliar.cli_id;
            this.indiceFila = idxFila;

            txbNombre.Text = pFamiliar.cli_nombre;
            txbApellido.Text = pFamiliar.cli_apellido;
            dtpFechaNacimiento.Value = pFamiliar.cli_fecha_nacimiento;

            btnGuardar.Click -= new EventHandler(btnGuardar_Click);
            btnGuardar.Click += new EventHandler(btnGuardarActualiza_Click);
        }

        private void frmClienteFamiliar_Load(object sender, EventArgs e)
        {
            pnlControles.AutoScroll = true;
            this.AutoValidate = AutoValidate.Disable;
            errorProvider1 = new ErrorProvider();
            this.CargarCombos();

            if(this.familiar != null)
            {
                cmbTipoFamiliar.Text = this.familiar.tbtipofamiliar.tif_descripcion;
                cmbTitulo.Text = this.familiar.tbtitulocliente.tcl_descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {

                    if (this.idFamiliar == 0)
                        this.familiar = new tbcliente();
                    CargaObjeto();
                    GuardaObjeto();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                if (ex.InnerException != null)
                    log.Error(ex.InnerException.Message);
                MessageBox.Show("Error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarActualiza_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {
                    CargaObjeto();
                    ((frmClienteABM)this.formPadre).ActualizarFamiliarSeleccionado(this.familiar, this.indiceFila);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                if (ex.InnerException != null)
                    log.Error(ex.InnerException.Message);
                MessageBox.Show("Error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MensajeCancelar();
        }

        #region Carga Combos

        private void CargarCombos()
        {
            this.SetearDisplayValue();
            this.CargarTitulo();
            this.CargarTipoFamiliar();
            SetearIndiceCombo();
        }

        private void SetearDisplayValue()
        {
            cmbTitulo.DisplayMember = "tcl_descripcion";
            cmbTitulo.ValueMember = "tcl_id";

            cmbTipoFamiliar.DisplayMember = "tif_descripcion";
            cmbTipoFamiliar.ValueMember = "tif_id";
        }

        private void SetearIndiceCombo()
        {
            cmbTitulo.SelectedIndex = 0;
        }

        private void CargarTitulo()
        {
            TituloClienteBusiness tituloClienteBusiness = new TituloClienteBusiness();
            List<tbtitulocliente> listaTituloCliente = (List<tbtitulocliente>)tituloClienteBusiness.GetList();

            foreach (var obj in listaTituloCliente)
                cmbTitulo.Items.Add(obj);
        }

        private void CargarTipoFamiliar()
        {
            tipoFamiliarBusiness = new TipoFamiliarBusiness();
            List<tbtipofamiliar> listaFamiliares = (List<tbtipofamiliar>)tipoFamiliarBusiness.GetList();

            foreach (var obj in listaFamiliares)
                cmbTipoFamiliar.Items.Add(obj);
        }

        private void CargarCombo(List<ComboBoxItem> lista, ComboBox combo)
        {
            foreach (var obj in lista)
                combo.Items.Add(obj);
        }

        #endregion

        private void CargaObjeto()
        {
            this.familiar.cli_id = this.idFamiliar;
            this.familiar.tif_id = ((tbtipofamiliar)cmbTipoFamiliar.SelectedItem).tif_id;
            this.familiar.tcl_id = ((tbtitulocliente)cmbTitulo.SelectedItem).tcl_id;
            this.familiar.cli_parentezco = ((tbtipofamiliar)cmbTipoFamiliar.SelectedItem).tif_descripcion;
            this.familiar.cli_nombre = txbNombre.Text;
            this.familiar.cli_apellido = txbApellido.Text;
            this.familiar.cli_fecha_nacimiento = dtpFechaNacimiento.Value;
        }

        private void GuardaObjeto()
        {
            ((frmClienteABM)this.formPadre).AgregaFamiliarAGrilla(this.familiar);
        }

        private void MensajeCancelar()
        {
            DialogResult dialogResult = DialogResult.None;

            dialogResult = MessageBox.Show("Se aplicaron cambios. Se perderán todos los datos que no hayan sido guardados. \n¿Desea cerrar la ventana?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                AutoValidate = AutoValidate.Disable;
                this.Close();
            }
        }

        #region Validación de campos requeridos
        private void ValidatingControl(object sender, CancelEventArgs e)
        {
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validarControles = new ValidarControles();
            Control control = validarControles.ObtenerControl(sender);
            string error = validarControles.ValidarControl(sender);

            if (!string.IsNullOrEmpty(error))
            {
                errorProvider1.SetError(control, error);

                //Me valida hasta ingresar el valor correcto
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(control, error);
        }
        #endregion

    }
}
