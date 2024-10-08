using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Lista1.Modelos;

namespace Lista1
{
    public partial class Form1 : Form
    {
        List<cPersonas> lista = new List<cPersonas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cPersonas p = new cPersonas();
            try
            {
                p.pNombres = txtNombres.Text.Trim();
                p.pFechaNac = dtpFecha.Value;
                p.pSexo = cmbSexo.Text;

                if (p.pSexo.Equals("Mujer"))
                {
                    lista.Insert(0, p);
                    dgvRegistrados.DataSource = lista.ToArray();
                    return;

                }
                if (p.Edad() >= 60)

                {
                    lista.Insert(0, p);
                    dgvRegistrados.DataSource = lista.ToArray();
                    return;
               }
                if (p.pSexo.Equals("Mujer") && p.Edad() >=60)
                {
                    lista.Insert(0, p);
                    dgvRegistrados.DataSource = lista.ToArray();
                    return;
                }

                lista.Add(p);
                groupBox3.Text = "Registros Agregados" + lista.Count();
                dgvRegistrados.DataSource = lista.ToArray();
            }
            catch (Exception ex) { }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int Posicion = dgvRegistrados.CurrentRow.Index;
                lista.RemoveAt(Posicion);
                dgvRegistrados.DataSource = lista.ToArray();

            }
            catch (Exception ex)
            { 
            }
        }
    }
}
