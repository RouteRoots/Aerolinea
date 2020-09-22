using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aerolinea
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lis_pasajerosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lis_pasajerosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aerolineaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.Pasajeros' Puede moverla o quitarla según sea necesario.
            this.pasajerosTableAdapter.Fill(this.aerolineaDataSet.Pasajeros);
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.Vuelos' Puede moverla o quitarla según sea necesario.
            this.vuelosTableAdapter.Fill(this.aerolineaDataSet.Vuelos);
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.lis_pasajeros' Puede moverla o quitarla según sea necesario.
            this.lis_pasajerosTableAdapter.Fill(this.aerolineaDataSet.lis_pasajeros);

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            lis_pasajerosBindingSource.Position = 0;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            lis_pasajerosBindingSource.Position -= 1;
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            lis_pasajerosBindingSource.Position -= 1;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            lis_pasajerosBindingSource.Position = lis_pasajerosBindingSource.Count - 1;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DataTable miTabla = aerolineaDataSet.lis_pasajeros;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow nuevafila;
            try
            {
                nuevafila = miTabla.NewRow();
                //Datos por omision para las columnas del nuevo registro
                nuevafila[0] = "";
                nuevafila[1] = "";
           
                cfilas.Add(nuevafila);
                btn_ultimo.PerformClick();


            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.lis_pasajerosBindingSource.EndEdit();
                this.lis_pasajerosTableAdapter.Update(this.aerolineaDataSet);
                MessageBox.Show("datos guardados");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("error al guardar");

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataRowView vistaFilaActual;
            String NL = Environment.NewLine;

            if (MessageBox.Show("Desea borrar este registro" + NL, "Buscar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vistaFilaActual = ((DataRowView)lis_pasajerosBindingSource.Current);
                vistaFilaActual.Row.Delete();

            }
        }

        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String NL = Environment.NewLine;
            if (MessageBox.Show("Desea regresar al menu" +NL,"menu", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inicio menu = new Inicio();
                menu.Show();
                this.Hide();

            }
        }

        private void lis_pasajerosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
