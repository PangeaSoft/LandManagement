﻿namespace LandManagement
{
    partial class frmEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail));
            this.hleCuerpo = new System.Windows.Forms.WebBrowser();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.adjlabel = new System.Windows.Forms.Label();
            this.BoldtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.UnderlinetoolStrip = new System.Windows.Forms.ToolStripButton();
            this.ItalictoolStrip = new System.Windows.Forms.ToolStripButton();
            this.ColortoolStrip = new System.Windows.Forms.ToolStripButton();
            this.JustifyFulltoolStrip = new System.Windows.Forms.ToolStripButton();
            this.JustifyCentertoolStrip = new System.Windows.Forms.ToolStripButton();
            this.JustifyLtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.JustifyRtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.VinDtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.VinNtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.IMGtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currierNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstControlesFuente = new System.Windows.Forms.ToolStrip();
            this.gbxEmail = new System.Windows.Forms.GroupBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lbxPara = new System.Windows.Forms.ListBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tstControlesFuente.SuspendLayout();
            this.gbxEmail.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // hleCuerpo
            // 
            this.hleCuerpo.AllowWebBrowserDrop = false;
            this.hleCuerpo.IsWebBrowserContextMenuEnabled = false;
            this.hleCuerpo.Location = new System.Drawing.Point(6, 153);
            this.hleCuerpo.MinimumSize = new System.Drawing.Size(20, 20);
            this.hleCuerpo.Name = "hleCuerpo";
            this.hleCuerpo.ScriptErrorsSuppressed = true;
            this.hleCuerpo.Size = new System.Drawing.Size(646, 202);
            this.hleCuerpo.TabIndex = 5;
            // 
            // txtasunto
            // 
            this.txtasunto.Location = new System.Drawing.Point(63, 113);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(573, 20);
            this.txtasunto.TabIndex = 4;
            this.txtasunto.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingControl);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(6, 361);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(75, 23);
            this.btnAdjuntar.TabIndex = 6;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(496, 361);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Asunto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Para";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(577, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btncacelar_Click);
            // 
            // adjlabel
            // 
            this.adjlabel.AutoSize = true;
            this.adjlabel.Location = new System.Drawing.Point(707, 126);
            this.adjlabel.Name = "adjlabel";
            this.adjlabel.Size = new System.Drawing.Size(0, 13);
            this.adjlabel.TabIndex = 37;
            // 
            // BoldtoolStrip
            // 
            this.BoldtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("BoldtoolStrip.Image")));
            this.BoldtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldtoolStrip.Name = "BoldtoolStrip";
            this.BoldtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.BoldtoolStrip.Text = "Negrita";
            this.BoldtoolStrip.Click += new System.EventHandler(this.BoldtoolStrip_Click);
            // 
            // UnderlinetoolStrip
            // 
            this.UnderlinetoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlinetoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("UnderlinetoolStrip.Image")));
            this.UnderlinetoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlinetoolStrip.Name = "UnderlinetoolStrip";
            this.UnderlinetoolStrip.Size = new System.Drawing.Size(23, 22);
            this.UnderlinetoolStrip.Text = "Subrayar";
            this.UnderlinetoolStrip.Click += new System.EventHandler(this.UnderlinetoolStrip_Click);
            // 
            // ItalictoolStrip
            // 
            this.ItalictoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalictoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ItalictoolStrip.Image")));
            this.ItalictoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalictoolStrip.Name = "ItalictoolStrip";
            this.ItalictoolStrip.Size = new System.Drawing.Size(23, 22);
            this.ItalictoolStrip.Text = "Italica";
            this.ItalictoolStrip.Click += new System.EventHandler(this.ItalictoolStrip_Click);
            // 
            // ColortoolStrip
            // 
            this.ColortoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColortoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ColortoolStrip.Image")));
            this.ColortoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColortoolStrip.Name = "ColortoolStrip";
            this.ColortoolStrip.Size = new System.Drawing.Size(23, 22);
            this.ColortoolStrip.Text = "Color";
            this.ColortoolStrip.Click += new System.EventHandler(this.ColortoolStrip_Click);
            // 
            // JustifyFulltoolStrip
            // 
            this.JustifyFulltoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.JustifyFulltoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("JustifyFulltoolStrip.Image")));
            this.JustifyFulltoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JustifyFulltoolStrip.Name = "JustifyFulltoolStrip";
            this.JustifyFulltoolStrip.Size = new System.Drawing.Size(23, 22);
            this.JustifyFulltoolStrip.Text = "Justificar";
            this.JustifyFulltoolStrip.ToolTipText = "Justificar";
            this.JustifyFulltoolStrip.Click += new System.EventHandler(this.JustifyFulltoolStrip_Click);
            // 
            // JustifyCentertoolStrip
            // 
            this.JustifyCentertoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.JustifyCentertoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("JustifyCentertoolStrip.Image")));
            this.JustifyCentertoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JustifyCentertoolStrip.Name = "JustifyCentertoolStrip";
            this.JustifyCentertoolStrip.Size = new System.Drawing.Size(23, 22);
            this.JustifyCentertoolStrip.Text = "Centrar";
            this.JustifyCentertoolStrip.Click += new System.EventHandler(this.JustifyCentertoolStrip_Click);
            // 
            // JustifyLtoolStrip
            // 
            this.JustifyLtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.JustifyLtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("JustifyLtoolStrip.Image")));
            this.JustifyLtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JustifyLtoolStrip.Name = "JustifyLtoolStrip";
            this.JustifyLtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.JustifyLtoolStrip.Text = "Alinear a la izquierda";
            this.JustifyLtoolStrip.ToolTipText = "Alinear a la izquierda";
            this.JustifyLtoolStrip.Click += new System.EventHandler(this.JustifyLtoolStrip_Click);
            // 
            // JustifyRtoolStrip
            // 
            this.JustifyRtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.JustifyRtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("JustifyRtoolStrip.Image")));
            this.JustifyRtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JustifyRtoolStrip.Name = "JustifyRtoolStrip";
            this.JustifyRtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.JustifyRtoolStrip.Text = "Alinear a la derecha";
            this.JustifyRtoolStrip.Click += new System.EventHandler(this.JustifyRtoolStrip_Click);
            // 
            // VinDtoolStrip
            // 
            this.VinDtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VinDtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("VinDtoolStrip.Image")));
            this.VinDtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VinDtoolStrip.Name = "VinDtoolStrip";
            this.VinDtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.VinDtoolStrip.Text = "Viñeta";
            this.VinDtoolStrip.Click += new System.EventHandler(this.VinDtoolStrip_Click);
            // 
            // VinNtoolStrip
            // 
            this.VinNtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VinNtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("VinNtoolStrip.Image")));
            this.VinNtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VinNtoolStrip.Name = "VinNtoolStrip";
            this.VinNtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.VinNtoolStrip.Text = "Numeracion";
            this.VinNtoolStrip.Click += new System.EventHandler(this.VinNtoolStrip_Click);
            // 
            // IMGtoolStrip
            // 
            this.IMGtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IMGtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("IMGtoolStrip.Image")));
            this.IMGtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IMGtoolStrip.Name = "IMGtoolStrip";
            this.IMGtoolStrip.Size = new System.Drawing.Size(23, 22);
            this.IMGtoolStrip.Text = "Imagen de fondo";
            this.IMGtoolStrip.ToolTipText = "Imagen de fondo";
            this.IMGtoolStrip.Visible = false;
            this.IMGtoolStrip.Click += new System.EventHandler(this.IMGtoolStrip_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialToolStripMenuItem,
            this.verdanaToolStripMenuItem,
            this.currierNewToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripSplitButton1.Text = "Fuente";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // verdanaToolStripMenuItem
            // 
            this.verdanaToolStripMenuItem.Name = "verdanaToolStripMenuItem";
            this.verdanaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.verdanaToolStripMenuItem.Text = "Verdana";
            this.verdanaToolStripMenuItem.Click += new System.EventHandler(this.verdanaToolStripMenuItem_Click);
            // 
            // currierNewToolStripMenuItem
            // 
            this.currierNewToolStripMenuItem.Name = "currierNewToolStripMenuItem";
            this.currierNewToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.currierNewToolStripMenuItem.Text = "Currier New";
            this.currierNewToolStripMenuItem.Click += new System.EventHandler(this.currierNewToolStripMenuItem_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(67, 22);
            this.toolStripSplitButton2.Text = "Tamaño";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // tstControlesFuente
            // 
            this.tstControlesFuente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldtoolStrip,
            this.UnderlinetoolStrip,
            this.ItalictoolStrip,
            this.ColortoolStrip,
            this.JustifyFulltoolStrip,
            this.JustifyCentertoolStrip,
            this.JustifyLtoolStrip,
            this.JustifyRtoolStrip,
            this.VinDtoolStrip,
            this.VinNtoolStrip,
            this.IMGtoolStrip,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.tstControlesFuente.Location = new System.Drawing.Point(0, 0);
            this.tstControlesFuente.Name = "tstControlesFuente";
            this.tstControlesFuente.Size = new System.Drawing.Size(698, 25);
            this.tstControlesFuente.TabIndex = 34;
            // 
            // gbxEmail
            // 
            this.gbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEmail.Controls.Add(this.pnlControles);
            this.gbxEmail.Location = new System.Drawing.Point(12, 28);
            this.gbxEmail.Name = "gbxEmail";
            this.gbxEmail.Size = new System.Drawing.Size(674, 406);
            this.gbxEmail.TabIndex = 38;
            this.gbxEmail.TabStop = false;
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControles.Controls.Add(this.btnQuitar);
            this.pnlControles.Controls.Add(this.lbxPara);
            this.pnlControles.Controls.Add(this.btnAgregarCategoria);
            this.pnlControles.Controls.Add(this.cmbCategorias);
            this.pnlControles.Controls.Add(this.lblCategoria);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.label2);
            this.pnlControles.Controls.Add(this.btnEnviar);
            this.pnlControles.Controls.Add(this.btnAdjuntar);
            this.pnlControles.Controls.Add(this.btnCancelar);
            this.pnlControles.Controls.Add(this.txtasunto);
            this.pnlControles.Controls.Add(this.hleCuerpo);
            this.pnlControles.Location = new System.Drawing.Point(6, 11);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(662, 389);
            this.pnlControles.TabIndex = 0;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(274, 38);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(61, 21);
            this.btnQuitar.TabIndex = 41;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lbxPara
            // 
            this.lbxPara.FormattingEnabled = true;
            this.lbxPara.Location = new System.Drawing.Point(63, 38);
            this.lbxPara.Name = "lbxPara";
            this.lbxPara.Size = new System.Drawing.Size(201, 69);
            this.lbxPara.TabIndex = 40;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(274, 8);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(61, 21);
            this.btnAgregarCategoria.TabIndex = 39;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(63, 8);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(201, 21);
            this.cmbCategorias.TabIndex = 38;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 12);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 37;
            this.lblCategoria.Text = "Categoría";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(698, 446);
            this.Controls.Add(this.gbxEmail);
            this.Controls.Add(this.adjlabel);
            this.Controls.Add(this.tstControlesFuente);
            this.Name = "frmEmail";
            this.Text = "frmMail";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.tstControlesFuente.ResumeLayout(false);
            this.tstControlesFuente.PerformLayout();
            this.gbxEmail.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser hleCuerpo;
        private System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label adjlabel;
        private System.Windows.Forms.ToolStripButton BoldtoolStrip;
        private System.Windows.Forms.ToolStripButton UnderlinetoolStrip;
        private System.Windows.Forms.ToolStripButton ItalictoolStrip;
        private System.Windows.Forms.ToolStripButton ColortoolStrip;
        private System.Windows.Forms.ToolStripButton JustifyFulltoolStrip;
        private System.Windows.Forms.ToolStripButton JustifyCentertoolStrip;
        private System.Windows.Forms.ToolStripButton JustifyLtoolStrip;
        private System.Windows.Forms.ToolStripButton JustifyRtoolStrip;
        private System.Windows.Forms.ToolStripButton VinDtoolStrip;
        private System.Windows.Forms.ToolStripButton VinNtoolStrip;
        private System.Windows.Forms.ToolStripButton IMGtoolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currierNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStrip tstControlesFuente;
        private System.Windows.Forms.GroupBox gbxEmail;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ListBox lbxPara;
        private System.Windows.Forms.Button btnQuitar;
    }
}