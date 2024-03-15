using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.Sql;
using System.Data.SqlClient;

namespace carvideogame
{
    public partial class Form1 : Form
    {
        private SoundPlayer reproductor;
        private bool colisionConMoneda = false;
        bool izq, der, abj, arb;
        Point dizzy;
        int velocidad = 0;
        int puntaje = 0;
        public Form1()
        {
            reproductor = new SoundPlayer("D:/proyectos para presentar/visual 4cuatri tabajos/carvideogame/carvideogame/Resources/sonido.wav");
            InitializeComponent();
            int[] posicion = new int[5];
            posicion[0] = 1;
            posicion[1] = 55;
            posicion[2] = 110;
            posicion[3] = 165;
            posicion[4] = 220;
            int post = 50;
            int posf = 50;
            Random r1 = new Random();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (der == true)
            {
                lambo.Left += 8;
            }
            if (izq == true)
            {
                lambo.Left -= 8;
            }
            if (arb == true)
            {
                lambo.Top -= 8;
            }
            if (abj == true)
            {
                lambo.Top += 8;
            }


            dizzy = lambo.Location;
            if (lambo.Location.X + lambo.Width > pantalla.Width)
            {
                dizzy.X = pantalla.Width - lambo.Width;
            }
            else if (lambo.Location.X < 0)
                dizzy.X = 0;

            if (lambo.Location.Y + lambo.Height > pantalla.Height)
                dizzy.Y = pantalla.Height - lambo.Height;
            else if (lambo.Location.Y < 0)
                dizzy.Y = 0;

            if (lambo.Location != dizzy)
            {
                lambo.Location = dizzy;
            }

            blo.Top += 3;
            blo2.Top += 4;
            blo3.Top += 5;
            monedas.Top += 2;
            
        }

       

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                der = false;
            }
            if (e.KeyCode == Keys.A)
            {
                izq = false;
            }
            if (e.KeyCode == Keys.S)
            {
                abj = false;
            }
            if (e.KeyCode == Keys.W)
            {
                arb = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                der = true;
            }
            if (e.KeyCode == Keys.A)
            {
                izq = true;
            }
            if (e.KeyCode == Keys.S)
            {
                abj = true;
            }
            if (e.KeyCode == Keys.W)
            {
                arb = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

        }

        private void monedas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Form resultados = new Form2();
            resultados.Show();*/
            label2.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C50J5VJH; INITIAL CATALOG=gamecar; USER ID=sa; PASSWORD='123456789'");
            SqlCommand cdc;
            con.Open();
            string query1;
            string t1 = textBox1.Text;
            int t2 = puntaje;
            query1 = "insert into puntajes values ('" + t1 + "','" + t2 + "');";
            cdc = new SqlCommand(query1, con);

            int filasAfectadas = cdc.ExecuteNonQuery();
            con.Close();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Puntaje ha sido registrado.");
            }
            else
            {
                MessageBox.Show("No se pudo registrar el puntaje.");
            }
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form resultado = new Form2();
            resultado.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           

            Random r1 = new Random();
            int r2 = r1.Next(1, 83);
            Random r3 = new Random();
            int r4 = r3.Next(166, 250);
            Random r5 = new Random();
            int r6 = r5.Next(83, 166);
            if (blo.Top < pantalla.Bottom)
            {
                blo.Top += 3;
                if (blo.Bounds.IntersectsWith(lambo.Bounds))
                {
                    timer2.Stop();
                    MessageBox.Show("GAME OVER");
                    button1.Visible = true;
                    button2.Visible = true;
                }

            }
            else
            {
                blo.Top = velocidad;
                blo.Left = r2;
                velocidad++;


            }


            if (blo2.Top < pantalla.Bottom)
            {
                blo2.Top += 4;
                if (blo2.Bounds.IntersectsWith(lambo.Bounds))
                {
                    timer2.Stop();
                    MessageBox.Show("GAME OVER");
                    button1.Visible = true;
                    button2.Visible = true;
                }

            }
            else
            {
                blo2.Top = velocidad;
                blo2.Left = r4;
                velocidad++;

            }

            if (blo3.Top < pantalla.Bottom)
            {
                blo3.Top += 5;
                if (blo3.Bounds.IntersectsWith(lambo.Bounds))
                {
                    timer2.Stop();
                    MessageBox.Show("GAME OVER");
                    button1.Visible = true;
                    button2.Visible = true;
                }

            }
            else
            {
                blo3.Top = velocidad;
                blo3.Left = r6;
                velocidad++;

            }

            if (monedas.Top < pantalla.Bottom)
            {
                monedas.Top += 5;

                if (monedas.Bounds.IntersectsWith(lambo.Bounds) && !colisionConMoneda)
                {
                    puntaje++;
                    label1.Text = puntaje.ToString();
                    colisionConMoneda = true;
                    monedas.Visible = false;
                    reproductor.Play();
                }
            }
            else
            {
                monedas.Visible = true;
                monedas.Top = velocidad; 
                Random randomPosicion = new Random();
                int posicionAleatoria = randomPosicion.Next(1, 4);

                switch (posicionAleatoria)
                {
                    case 1:
                        monedas.Left = r2;
                        break;
                    case 2:
                        monedas.Left = r4;
                        break;
                    case 3:
                        monedas.Left = r6;
                        break;
                }
                velocidad++;
                colisionConMoneda = false;
            }


        }

        private void blo2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
