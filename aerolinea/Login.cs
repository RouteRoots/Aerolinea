using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace aerolinea
{

    public partial class Login : Form
    {
       
    

    static public bool contra;

        public Login()
        {

            
            InitializeComponent();
        
        }






        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Root")
            {
                
                contra = true;
                MessageBox.Show("Bienvenido " + textBox1.Text);
                Inicio abrir = new Inicio();
                abrir.Show();
                
                this.Hide();
            
                
                
            }
            else
            {
                contra=false;
                MessageBox.Show("contraseña incorrecta");
                
                
            }

            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
