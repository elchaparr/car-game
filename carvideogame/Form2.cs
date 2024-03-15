using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace carvideogame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public DataTable ObtenerDatosDesdeBaseDeDatos()
        {
            DataTable dt = new DataTable();

            // Cadena de conexión a la base de datos
            string connectionString = @"Data Source=LAPTOP-C50J5VJH; INITIAL CATALOG=gamecar; USER ID=sa; PASSWORD='123456789'";

            // Consulta SQL para obtener los datos
            string query = "SELECT TOP 5 nombre, puntaje FROM puntajes ORDER BY puntaje DESC;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        private void MostrarDatosEnDataGridView()
        {
            // Obtener los datos desde la base de datos
            DataTable datos = ObtenerDatosDesdeBaseDeDatos();

            // Enlazar los datos al DataGridView
            dataGridView1.DataSource = datos;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarDatosEnDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
