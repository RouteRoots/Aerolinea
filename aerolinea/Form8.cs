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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pasajerosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pasajerosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aerolineaDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aerolineaDataSet.Pasajeros' Puede moverla o quitarla según sea necesario.
            this.pasajerosTableAdapter.Fill(this.aerolineaDataSet.Pasajeros);

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
    }
}
