using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoPelicula
{
    public partial class Form4 : Form
    {
        

        int id;
        string nombreU;
        public Form4()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            id = f1.id;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        SqlConnection db = new SqlConnection(@"Data Source = JOEL\SQLEXPRESS; Initial Catalog = Peliculas; Integrated Security = True");
        private void Form4_Load(object sender, EventArgs e)
        {
            lbNombreU.Text = nombreU;
            ClsSentencias objPeli = new ClsSentencias();

            //lbTituloPelicula.Text= objPeli.ListaPeliculas().Rows(0).Columns(4);
            
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("Lista_Favoritos" + nombreU, db);


                SqlDataReader dr = cmd.ExecuteReader();

                //lbNombreUsu.Text = Convert.ToString(dr["NombreUsuario"]);

                dr = cmd.ExecuteReader();

                this.id = Convert.ToInt32(dr["IdUsuario"]);
                //lbTituloPelicula = Convert.ToString(dr["Peliculas.NombrePeli"]);



                dr.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                db.Close();

            }
           
            
              

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
