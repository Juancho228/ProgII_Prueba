﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormProblema1._1
{
    public partial class frmDetalleCarrera : Form
    {
        DBHelper datos = new DBHelper();
        bool nuevo = false;
        List<DetalleCarrera> lDetalles = new List<DetalleCarrera>();
        
        public frmDetalleCarrera()
        {
            InitializeComponent();
        }

        private void frmDetalleCarrera_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCombo();
            nuevo= true;
            LimpiarDetalle();

        }

        private void CargarGrilla() 
        {
            DataTable tabla = datos.consultarDB("pa_consultar_Detalle");
            dgvDetalleCarrera.DataSource = tabla;
        }

        //private void CargarGrilla()
        //{
        //    DataTable tabla = datos.consultarDB("pa_consultar_Detalle");
        //    lDetalles.Clear();
        //    foreach (DataRow fila in tabla.Rows) 
        //    {
        //        DetalleCarrera dc = new DetalleCarrera();
        //        dc.AnioCursado = Convert.ToInt32(fila[1]);
        //        dc.Materia.Nombre = fila[3].ToString();
        //        dc.Cuatrimestre = fila[2].ToString();

        //        lDetalles.Add(dc);


        //    }
        //    dgvDetalleCarrera.Columns.Contains()
        //    dgvDetalleCarrera.Rows.


        //}

        public void CargarCombo()
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarDB("pa_consultar_asignaturas");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = tabla.Columns[0].ColumnName;//"Id Marca"
            cboMateria.DisplayMember = tabla.Columns[1].ColumnName; // "Nombre marca"
        }
        //public void CargarLista()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = datos.consultarDB("pa_consultar_lista");
        //    lstx.DataSource = tabla;
        //    lstx.ValueMember = tabla.Columns[0].ColumnName;//"Id Marca"
        //    lstx.DisplayMember = tabla.Columns[1].ColumnName; // "Nombre marca"
        //}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                DetalleCarrera dC = new DetalleCarrera();
                dC.AnioCursado = int.Parse(txtAnioCursado.Text);
                dC.Materia = (int)(cboMateria.SelectedValue);
                if (rbtPrimerCuat.Checked==true) 
                {
                    dC.Cuatrimestre = "1C";
                } 
                else 
                {
                    dC.Cuatrimestre = "2C";
                }

                datos.insertarDetalle(dC.AnioCursado, dC.Cuatrimestre, dC.Materia);




            }
            
            else 
            {
                MessageBox.Show("No se pudo cargar su detalle de carrera!");
            }

            CargarGrilla();
            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            txtAnioCursado.Text= "";
            rbtPrimerCuat.Checked = false;
            rbtSegundoCuat.Checked = false;
            cboMateria.SelectedValue = -1;
            
        }

        //public bool Existe(DetalleCarrera detalle)
        //{
        //    bool valido = true;
        //    for (int i = 0; i < dgvDetalleCarrera.RowCount; i++)
        //    {
        //        if(detalle.AnioCursado==dgvDetalleCarrera.Rows)
        //    }

        //    return valido;
        //}

        public bool Validar()
        {
            bool valido = true;
            if (txtAnioCursado.Text == string.Empty)
            {
                MessageBox.Show("Debe Ingresar un año de cursado...");
                txtAnioCursado.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    int.Parse(txtAnioCursado.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe Ingresar un año de cursado válido...");
                    valido = false;
                    txtAnioCursado.Focus();
                }
            }

            if (rbtPrimerCuat.Checked ==false && rbtSegundoCuat.Checked==false )
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre");
                valido = false;
                rbtPrimerCuat.Focus();
            }
            if (cboMateria.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar una materia...");
                cboMateria.Focus();
                valido = false;
            }
            foreach (DataGridViewRow row in dgvDetalleCarrera.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(txtAnioCursado.Text) && (row.Cells[2].Value.ToString().Equals("1C") ||row.Cells[2].Value.ToString().Equals("2C"))
                    && row.Cells[3].Value.ToString().Equals(cboMateria.SelectedValue))
                {
                    MessageBox.Show("El detalle ya ha sido registrado previamente...");
                    txtAnioCursado.Focus();
                    valido = false;
                }
            }

            return valido;
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
