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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void lis_pasajerosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lis_pasajerosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aerolineaDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.lis_pasajeros' Puede moverla o quitarla según sea necesario.
            this.lis_pasajerosTableAdapter.Fill(this.aerolineaDataSet.lis_pasajeros);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String NL = Environment.NewLine;
            if (MessageBox.Show("Desea regresar al menu" +NL,"menu",  MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Inicio menu = new Inicio();
                menu.Show();
                this.Hide();

            }
        }

        private void id_vueloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
