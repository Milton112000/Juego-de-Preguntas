using AppPreguntas.COMPETIDOR1;
using AppPreguntas.COMPETIDOR2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPreguntas.Vistas
{
    public partial class Usuario1 : Form
    {
        
        public Usuario1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
                
                }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_de_Juego avanzar = new Menu_de_Juego();
            avanzar.Show();
         
        }

        private void Usuario1_Load(object sender, EventArgs e)
        {
            lblNombte.Visible = false;
            txtRegistrarNombre.Visible = false;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
    }

        private void button1_Click_2(object sender, EventArgs e)
        {

            

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmPregunta2 objetoFrm = new FrmPregunta2();
            Menu_de_Juego objetoFrm2 = new Menu_de_Juego();
            objetoFrm2.Close();
            objetoFrm.Close();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtRegistrarNombre.Text == "")
            {

                MessageBox.Show("Tiene que Rellenar con su Nombre");

            }
            else
            {
                this.Hide();
                FrmC2Pregunta1 avanzar = new FrmC2Pregunta1();
                avanzar.Show();
                avanzar.lblUsuarioActual.Text = txtRegistrarNombre.Text;

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           lblNombte.Visible = true;
            txtRegistrarNombre.Visible = true;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtRegistrarNombre.Text == "")
            {

                MessageBox.Show("Tiene que Rellenar con su Nombre");

            }
            else
            {
                this.Hide();
                Menu_de_Juego avanzar = new Menu_de_Juego();
                avanzar.Show();
                avanzar.lblUsuarioActual.Text = txtRegistrarNombre.Text;

            }
        }

       
    }
}
