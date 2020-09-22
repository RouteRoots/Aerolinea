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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void avionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aerolineaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.Aviones' Puede moverla o quitarla según sea necesario.
            this.avionesTableAdapter.Fill(this.aerolineaDataSet.Aviones);

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            avionesBindingSource.Position = 0;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            avionesBindingSource.Position -= 1;
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            avionesBindingSource.Position += 1;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            DataTable miTabla = aerolineaDataSet.Aviones;
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
                nuevafila[4] = 0;
                
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
                this.avionesBindingSource.EndEdit();
                this.avionesTableAdapter.Update(this.aerolineaDataSet);
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
                vistaFilaActual = ((DataRowView)avionesBindingSource.Current);
                vistaFilaActual.Row.Delete();

            }
        }

        private void btn_sear_Click(object sender, EventArgs e)
        {
            DataTable miTabla = aerolineaDataSet.Aviones;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow[] filaBuscada;
            string NL = Environment.NewLine;

            string criterio = "Id_avion Like'*" + tb_search.Text + "*'";
            filaBuscada = miTabla.Select(criterio);

            if (filaBuscada.GetUpperBound(0) == -1)
            {
                MessageBox.Show("No se encontraron los registros coincidentes", "Buscar");
                return;
            }
            int i, j;
            for (i = 0; i <= filaBuscada.GetUpperBound(0); i++)
            {
                if (MessageBox.Show("¿Es este el nombre buscado?" + NL + (string)filaBuscada[i]["id_avion"] + NL, "Buscar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    for (j = 0; j <= cfilas.Count - 1; j++)
                        if (cfilas[j].Equals(filaBuscada[i]))
                        {
                            avionesBindingSource.Position = j;

                            break;
                        }
                }
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            avionesBindingSource.Position = avionesBindingSource.Count - 1;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
            }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String NL = Environment.NewLine;
            if (MessageBox.Show("Desea regresar al menu" + NL,"menu", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inicio menu = new Inicio();
                menu.Show();
                this.Hide();

            }
        }
    }
}
