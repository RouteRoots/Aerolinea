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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void vuelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vuelosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aerolineaDataSet);

        }

        private void vuelosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vuelosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aerolineaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.Aviones' Puede moverla o quitarla según sea necesario.
            this.avionesTableAdapter.Fill(this.aerolineaDataSet.Aviones);
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.Vuelos' Puede moverla o quitarla según sea necesario.
            this.vuelosTableAdapter.Fill(this.aerolineaDataSet.Vuelos);

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            vuelosBindingSource.Position = 0;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            vuelosBindingSource.Position -= 1;
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
           vuelosBindingSource.Position += 1;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            vuelosBindingSource.Position = vuelosBindingSource.Count - 1;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DataTable miTabla = aerolineaDataSet.Vuelos;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow nuevafila;
            try
            {
                nuevafila = miTabla.NewRow();
                //Datos por omision para las columnas del nuevo registro
                nuevafila[0] = "";
                nuevafila[1] = "";
                nuevafila[2] = "";
                nuevafila[3] = "";
                nuevafila[4] = new DateTime();
                nuevafila[5] = new DateTime();
                nuevafila[6] = new DateTime();
                nuevafila[7] = new DateTime();

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
                this.vuelosBindingSource.EndEdit();
                this.vuelosTableAdapter.Update(this.aerolineaDataSet);
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
                vistaFilaActual = ((DataRowView)vuelosBindingSource.Current);
                vistaFilaActual.Row.Delete();

            }
        }

        private void btn_sear_Click(object sender, EventArgs e)
        {
            DataTable miTabla = aerolineaDataSet.Vuelos;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow[] filaBuscada;
            string NL = Environment.NewLine;

            string criterio = "id_vuelo Like'*" + tb_search.Text + "*'";
            filaBuscada = miTabla.Select(criterio);

            if (filaBuscada.GetUpperBound(0) == -1)
            {
                MessageBox.Show("No se encontraron los registros coincidentes", "Buscar");
                return;
            }
            int i, j;
            for (i = 0; i <= filaBuscada.GetUpperBound(0); i++)
            {
                if (MessageBox.Show("¿Es este el nombre buscado?" + NL + (string)filaBuscada[i]["id_vuelo"] + NL, "Buscar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    for (j = 0; j <= cfilas.Count - 1; j++)
                        if (cfilas[j].Equals(filaBuscada[i]))
                        {
                            vuelosBindingSource.Position = j;

                            break;
                        }
                }
            }
        }

        private void h_salidaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            h_salidaDateTimePicker.CustomFormat = "HH:mm";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String NL = Environment.NewLine;
            if (MessageBox.Show("Desea regresar al menu" + NL,"menu" ,MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inicio menu = new Inicio();
                menu.Show();
                this.Hide();

            }
        }
    }
}
