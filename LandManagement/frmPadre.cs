﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using LandManagement.Business;
using LandManagement.Entities;
using System.Configuration;
using LandManagement.Utilidades;

namespace LandManagement
{
    public partial class frmPadre : Form
    {
        MenuStrip menuStrip;
        ToolStripMenuItem toolStripMenuItem;
        private MenuBusiness menuBusiness;
        private List<tbmenu> _listaMenu;
    
        public frmPadre()
        {
            InitializeComponent();
        }

        public frmPadre(List<tbmenu> listaMenuDelUsuario)
        {
            InitializeComponent();
            this._listaMenu = listaMenuDelUsuario;
        }

        private void frmPadre_Load(object sender, EventArgs e)
        {
            this.FormClosing += frmPadre_FormClosing;    

            VersionBusiness versionBusiness = new VersionBusiness();
            this.Text = "Land Management v" + versionBusiness.GetLastVersion().ver_version;
            this.Icon = (Icon)Recursos.ResourceImages.ResourceManager.GetObject("LogoLandManagement");

            //Controla entorno de prueba
            string connectionString = ConfigurationManager.ConnectionStrings["landmanagementbdEntities"].ToString();
            if (connectionString.Contains("test"))
                lblEntornoDeTest.Visible = true;

            this.WindowState = FormWindowState.Maximized;
            menuStrip = new MenuStrip();
            this.Controls.Add(menuStrip);
            this.IsMdiContainer = true;

            //Se carga el menu del usuario logueado
            var coleccion = this._listaMenu;

            foreach (var obj in coleccion)
            {
                if (obj.men_id_padre == null)
                {
                    toolStripMenuItem = new ToolStripMenuItem(obj.men_nombre);
                    if (TieneHijos(obj))
                        CargarHijos(toolStripMenuItem, obj);

                    //((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
                    //Oculto el margen de los iconos en el menu
                    ((ToolStripDropDownMenu)toolStripMenuItem.DropDown).ShowImageMargin = false;
                    ((ToolStripDropDownMenu)toolStripMenuItem.DropDown).ShowCheckMargin = false;

                    menuStrip.Items.Add(toolStripMenuItem);
                }
            }

            this.MainMenuStrip = menuStrip;
        }


        //CODIGO VIEJO QUE GENERA EL MENU DEL USUARIO
        public bool TieneHijos(tbmenu objeto)
        {
            bool salida = false;

            if (objeto.tbmenu1 != null && objeto.tbmenu1.Count > 0)
                salida = true;

            return salida;
        }

        public void CargarHijos(ToolStripMenuItem menuPadre, tbmenu padre)
        {
            foreach (var obj in padre.tbmenu1)
            {
                ToolStripMenuItem toolStripMenuItemHijo = new ToolStripMenuItem(obj.men_nombre);
                if (TieneHijos(obj))
                    CargarHijos(toolStripMenuItemHijo, obj);
                else
                    toolStripMenuItemHijo =
                        new ToolStripMenuItem(obj.men_nombre, null, new EventHandler(ChildClick));

                menuPadre.DropDownItems.Add(toolStripMenuItemHijo);
            }
        }

        public void SubMenu(ToolStripMenuItem pToolStripMenuItem, int pSubMenu)
        {
            menuBusiness = new MenuBusiness();
            var lista = ((List<tbmenu>)menuBusiness.GetList()).Where(x => x.men_id == pSubMenu);

            foreach (var obj in lista)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(obj.men_nombre_formulario, null, new EventHandler(ChildClick));
                pToolStripMenuItem.DropDownItems.Add(tsmi);
            }
        }

        private void ChildClick(object sender, EventArgs e)
        {
            menuBusiness = new MenuBusiness();
            var sbm = ((List<tbmenu>)menuBusiness.GetList()).Where(x => x.men_nombre == sender.ToString()).FirstOrDefault();
            string frmCode = ((tbmenu)sbm).men_nombre_formulario;
            string frmNombre = ((tbmenu)sbm).men_nombre;

            Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);

            foreach (Type type in frmAssembly.GetTypes())
            {
                if (type.BaseType == typeof(Form))
                {
                    if (type.Name == frmCode)
                    {
                        Form formShow;
                        if (Application.OpenForms.Cast<Form>().Any(form => form.Name == frmCode))
                        {
                            Form f = Application.OpenForms[frmCode];
                            f.WindowState = FormWindowState.Normal;
                            f.Activate();
                            //f.Show();
                        }
                        else
                        {
                            formShow = (Form)frmAssembly.CreateInstance(type.ToString());
                            formShow.ShowIcon = true;
                            formShow.Text = frmNombre;

                            formShow.Icon = (Icon)Recursos.ResourceImages.ResourceManager.GetObject("Tool");

                            formShow.MdiParent = this;
                            formShow.WindowState = FormWindowState.Maximized;
                            formShow.Show();

                            //Se utiliza para que no genere conflicto la carga del icono tool
                            ActivateMdiChild(null);
                            ActivateMdiChild(formShow);
                        }
                    }
                }
            }
        }
        //CODIGO VIEJO QUE GENERA EL MENU DEL USUARIO

        void frmPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                LicenciaBusiness licenciaBusiness = new LicenciaBusiness();
                var licenciaSalida =
                    licenciaBusiness.GetLicenciaByMacEthernet(
                        new tbsyslicencia() { sli_mac_ethernet = VariablesDeSesion.MACADDRESS_ETHERNET });

                licenciaBusiness.LiberarLicencia(licenciaSalida);
            }
            else if (result == DialogResult.No)
                e.Cancel = true;
            
            //else
            //{
            //    //...
            //} 
            //In case windows is trying to shut down, don't hold the process up
            //if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //if (this.DialogResult == DialogResult.Cancel)
            //{
            //    // Assume that X has been clicked and act accordingly.
            //    // Confirm user wants to close
            //    switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //    {
            //        //Stay on this form
            //        case DialogResult.No:
            //            e.Cancel = true;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
    }
}
