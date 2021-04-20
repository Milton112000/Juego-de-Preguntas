using AppPreguntas.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPreguntas.COMPETIDOR2
{
    public partial class FrmC2Pregunta1 : Form
    {
        public FrmC2Pregunta1()
        {
            InitializeComponent();

        }
        public int conunter = 0;
        public String estadoUsuario;
        int horas;
        int min;
        int segun;
        public void temporizador()
        {
            for (int i = 0; i < 60; i++)
            {
                cbMinutos.Items.Add(i);
                cbSegundos.Items.Add(i);
                if (i < 24)
                {
                    cbHoras.Items.Add(i);
                }
                cbMinutos.SelectedIndex = 0;
                cbSegundos.SelectedIndex = 0;
                cbHoras.SelectedIndex = 0;

            }
        }
        public void cambiarCuenta()
        {
            if (rdbRespuesta2.Checked == true)
            {
                txtTotal.Text = "0.25";

            }
            else
            {
                txtTotal.Text = "0.00";
            }




        }
        public void Perdio()
        {
            if (rdbRespuesta2.Checked == true)
            {

            }
            else
            {
                this.Hide();
                MessageBox.Show("Lo sentimos pero usted perdio( su Monto es $0.00) ");
                Usuario1 usu = new Usuario1();
                usu.Show();

            }
        }
        private void FrmC2Pregunta1_Load(object sender, EventArgs e)
        {
            panelPregunta.Visible = false;
            lblCorrecto.Visible = false;
            lblIncorrecto.Visible = false;
            btnSiguientePregunta.Visible = false;

            temporizador();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuario1 Volver = new Usuario1();
        }

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
            FrmC2Pregunta2 avanzar = new FrmC2Pregunta2();
            avanzar.recibirClik = conunter;

            avanzar.txtTotal.Text = txtTotal.Text;
            avanzar.lblUsuarioActual.Text = lblUsuarioActual.Text;
            
            avanzar.Show();
            this.Close();
        }

        private void ComprobarRes1_Click(object sender, EventArgs e)
        {
            cambiarCuenta();
            if (rdbRespuesta2.Checked == true)
            {
                lblCorrecto.Visible = true;
                lblIncorrecto.Visible = false;
                btnSiguientePregunta.Visible = true;
            }
            else
            {
                lblCorrecto.Visible = false;
                lblIncorrecto.Visible = true;
                btnSiguientePregunta.Visible = false;

            }
            timer1.Stop();
            Perdio();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segun -= 1;
            string minutos = min.ToString();
            string h = horas.ToString();
            string seg = segun.ToString();

            if (horas < 10) { h = "0" + horas.ToString(); }
            if (min < 10) { minutos = "0" + min.ToString(); }
            if (segun < 10) { seg = "0" + segun.ToString(); }

            if (segun == 0 && min > 0)
            {
                min -= 1;
                segun = 60;
            }
            if (min == 0 && horas > 0 && segun == 0)
            {

                segun = 60;
                horas -= 1;
                min = 59;
            }
            if (min == 0 && horas == 0 && segun == 0)
            {
                Usuario1 usu = new Usuario1();
                timer1.Stop();
                MessageBox.Show("se acabo el tiempo");
                this.Hide();
                usu.Show();
            }
            lblTiempo.Text = h + ":" + minutos + ":" + seg;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
                if (btnIniciar.Text == "Iniciar")
                {
                    timer1.Start();
                    panelPregunta.Visible = true;
                    btnIniciar.ForeColor = Color.Firebrick;
                    btnPausar.Enabled = true;
                    horas = cbHoras.SelectedIndex;
                    min = cbMinutos.SelectedIndex;
                    segun = cbSegundos.SelectedIndex;
                    btnIniciar.Text = "Restablecer";


                }
                else
                {
                    timer1.Stop();
                    horas = 0;
                    min = 0;
                    segun = 0;
                    lblTiempo.Text = "00.00.00";
                    btnIniciar.ForeColor = Color.ForestGreen;
                    btnPausar.Enabled = false;
                    btnPausar.ForeColor = Color.RoyalBlue;
                    btnPausar.Text = "Pausar";
                    btnIniciar.Text = "Iniciar";

                }
           
           
           
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Pausar")
            {
                timer1.Stop();
                btnPausar.ForeColor = Color.DarkOrange;
                btnPausar.Text = "Reanudar";


            }
            else
            {
                timer1.Start();
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rdbRespuesta2.Checked == true)
            {
                MessageBox.Show("Usted Se lleva a su casa $0.25");
                this.Dispose();
                Usuario1 usu = new Usuario1();
                usu.Show();
            }
            else
            {
                this.Dispose();
                Usuario1 usu = new Usuario1();
                usu.Show();
            }
        }

        private void btn50a50_Click(object sender, EventArgs e)
        {
            conunter++;

            rdbRespuesta3.Visible = false;
            rdbRespuesta4.Visible = false;
            rdbRespuesta1.BackColor = Color.Green;
            rdbRespuesta2.BackColor = Color.Green;
            if (conunter == 0)
            {



                rdbRespuesta3.BackColor = Color.Green;
                rdbRespuesta4.BackColor = Color.Green;
                label3.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;



            }
            else
            {
                btn50a50.Enabled = false;
                btn50a50.BackColor = Color.Black;
            }
        }
    }
}
