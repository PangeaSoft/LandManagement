﻿namespace LandManagement
{
    partial class frmImportarExcel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombreHoja = new System.Windows.Forms.TextBox();
            this.prbImportarExcel = new System.Windows.Forms.ProgressBar();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPathArchivoExcel = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbNombreHoja);
            this.groupBox1.Controls.Add(this.prbImportarExcel);
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbPathArchivoExcel);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar datos de Excel";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 147);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el nombre de la hoja a importar";
            // 
            // txbNombreHoja
            // 
            this.txbNombreHoja.Location = new System.Drawing.Point(13, 91);
            this.txbNombreHoja.Name = "txbNombreHoja";
            this.txbNombreHoja.Size = new System.Drawing.Size(258, 20);
            this.txbNombreHoja.TabIndex = 5;
            this.txbNombreHoja.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido);
            // 
            // prbImportarExcel
            // 
            this.prbImportarExcel.Location = new System.Drawing.Point(13, 117);
            this.prbImportarExcel.Name = "prbImportarExcel";
            this.prbImportarExcel.Size = new System.Drawing.Size(258, 23);
            this.prbImportarExcel.TabIndex = 4;
            this.prbImportarExcel.Visible = false;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(326, 45);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la ubicación de su archivo";
            // 
            // txbPathArchivoExcel
            // 
            this.txbPathArchivoExcel.Location = new System.Drawing.Point(10, 48);
            this.txbPathArchivoExcel.Name = "txbPathArchivoExcel";
            this.txbPathArchivoExcel.Size = new System.Drawing.Size(261, 20);
            this.txbPathArchivoExcel.TabIndex = 1;
            this.txbPathArchivoExcel.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(291, 45);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(29, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "...";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControles.Controls.Add(this.groupBox1);
            this.pnlControles.Location = new System.Drawing.Point(12, 12);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(463, 342);
            this.pnlControles.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(291, 117);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 366);
            this.Controls.Add(this.pnlControles);
            this.Name = "frmImportarExcel";
            this.Text = "frmImportarExcel";
            this.Load += new System.EventHandler(this.frmImportarExcel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPathArchivoExcel;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.ProgressBar prbImportarExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombreHoja;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAceptar;
    }
}