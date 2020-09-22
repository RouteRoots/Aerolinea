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
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
        }
        private Login otherForm = new Login();


        private void btn_edaviones_Click(object sender, EventArgs e)
        {
            
            Login contraseña = new Login();
            contraseña.Show();

            bool cont = Login.contra;
            contraseña.Refresh();

            if (cont == true)
            {
                contraseña.Hide();
                Form1 aviones = new Form1();
                aviones.Show();
                this.Hide();

            }
        
           
            
            
            

        }

        private void btn_edpasajeros_Click(object sender, EventArgs e)
        {

            Login contraseña = new Login();
            contraseña.Show();

            bool cont = Login.contra;
            contraseña.Refresh();

            if (cont == true)
            {
                contraseña.Hide();
                Form2 pasajeros = new Form2();
                pasajeros.Show();
                this.Hide();

            }
        }

        private void btn_edvuelos_Click(object sender, EventArgs e)
        {

            Login contraseña = new Login();
            contraseña.Show();

            bool cont = Login.contra;
            contraseña.Refresh();

            if (cont == true)
            {
                contraseña.Hide();
                Form3 vuelos = new Form3();
                vuelos.Show();
                this.Hide();

            }
        }

        private void btn_edlist_Click(object sender, EventArgs e)
        {

            Login contraseña = new Login();
            contraseña.Show();

            bool cont = Login.contra;
            contraseña.Refresh();

            if (cont == true)
            {
                contraseña.Hide();
                Form4 lista = new Form4();
                lista.Show();
                this.Hide();

            }
        }

        private void btn_conaviones_Click(object sender, EventArgs e)
        {
            Form7 con_aviones = new Form7();
            con_aviones.Show();
            this.Hide();
        }

        private void btn_conpasajeros_Click(object sender, EventArgs e)
        {
            Form8 con_pasajeros = new Form8();
            con_pasajeros.Show();
            this.Hide();
        }

        private void btn_convuelos_Click(object sender, EventArgs e)
        {
            Form9 con_vuelos = new Form9();
            con_vuelos.Show();
            this.Hide();
        }

        private void btn_conlis_Click(object sender, EventArgs e)
        {
            Form10 con_lista = new Form10();
            con_lista.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
