﻿namespace WinFormProblema1._1
{
    partial class frmDetalleCarrera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.dgvDetalleCarrera = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Location = new System.Drawing.Point(38, 37);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(104, 16);
            this.lblAnioCursado.TabIndex = 1;
            this.lblAnioCursado.Text = "Año de Cursado";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(38, 89);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(75, 16);
            this.lblCuatrimestre.TabIndex = 2;
            this.lblCuatrimestre.Text = "Cuatrimetre";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(38, 146);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(204, 138);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(277, 24);
            this.cboMateria.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(317, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(116, 322);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 28);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(204, 37);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(277, 22);
            this.txtAnioCursado.TabIndex = 9;
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(204, 86);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(277, 22);
            this.txtCuatrimestre.TabIndex = 10;
            // 
            // dgvDetalleCarrera
            // 
            this.dgvDetalleCarrera.AllowUserToAddRows = false;
            this.dgvDetalleCarrera.AllowUserToDeleteRows = false;
            this.dgvDetalleCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmAnioCursado,
            this.clmCuatrimestre,
            this.clmMateria});
            this.dgvDetalleCarrera.Location = new System.Drawing.Point(12, 181);
            this.dgvDetalleCarrera.Name = "dgvDetalleCarrera";
            this.dgvDetalleCarrera.ReadOnly = true;
            this.dgvDetalleCarrera.RowHeadersWidth = 51;
            this.dgvDetalleCarrera.RowTemplate.Height = 24;
            this.dgvDetalleCarrera.Size = new System.Drawing.Size(556, 123);
            this.dgvDetalleCarrera.TabIndex = 11;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.MinimumWidth = 6;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            this.clmId.Width = 125;
            // 
            // clmAnioCursado
            // 
            this.clmAnioCursado.HeaderText = "Año de Cursado";
            this.clmAnioCursado.MinimumWidth = 6;
            this.clmAnioCursado.Name = "clmAnioCursado";
            this.clmAnioCursado.ReadOnly = true;
            this.clmAnioCursado.Width = 125;
            // 
            // clmCuatrimestre
            // 
            this.clmCuatrimestre.HeaderText = "Cuatrimestre";
            this.clmCuatrimestre.MinimumWidth = 6;
            this.clmCuatrimestre.Name = "clmCuatrimestre";
            this.clmCuatrimestre.ReadOnly = true;
            this.clmCuatrimestre.Width = 125;
            // 
            // clmMateria
            // 
            this.clmMateria.HeaderText = "Materia";
            this.clmMateria.MinimumWidth = 6;
            this.clmMateria.Name = "clmMateria";
            this.clmMateria.ReadOnly = true;
            this.clmMateria.Width = 125;
            // 
            // frmDetalleCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 396);
            this.Controls.Add(this.dgvDetalleCarrera);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnioCursado);
            this.Name = "frmDetalleCarrera";
            this.Text = "Detalle de la carrera";
            this.Load += new System.EventHandler(this.frmDetalleCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.DataGridView dgvDetalleCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMateria;
    }
}

