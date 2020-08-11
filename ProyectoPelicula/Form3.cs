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
    public partial class Form3 : Form
    {
        string NombreUsuario;
        int id;
        public Form3()
        {


            InitializeComponent();
            llenacmbusuarios();
            



        }

        SqlConnection con = new SqlConnection(@"Data Source = JOEL\SQLEXPRESS; Initial Catalog = Peliculas; Integrated Security = True");

        private void Form3_Load(object sender, EventArgs e)
        {
            lbNombreUsu.Text = NombreUsuario;


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("P1 " + NombreUsuario, con);


                SqlDataReader dr = cmd.ExecuteReader();

                //lbNombreUsu.Text = Convert.ToString(dr["NombreUsuario"]);

                SqlCommand com1 = new SqlCommand("select IdUsuario, Nombre, NombreUsuario, PasswordU from Usuariowhere NombreUsuario =" + NombreUsuario, con);


                dr = com1.ExecuteReader();

                this.id = Convert.ToInt32(dr["IdUsuario"]);

                dr.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deceas serrar sesion?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Visible = true;

                this.Visible = false;


            }
        }

        public void llenacmbusuarios()
        {
            DataTable dt = new DataTable();
            ConexionBD c = new ConexionBD();
            c.AbrirConexion();

            
                String consulta = "select NombrePeli from Peliculas";
                SqlCommand cmd = new SqlCommand(consulta, con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);
            
            cmbPelicula.ValueMember = "tipo";
            cmbPelicula.DataSource = dt;

        }
        private void BtnMostrarFavoritos_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Visible = true;
            this.Visible = false;

        }

        private void Img1_Click(object sender, EventArgs e)
        {


        }


        private void BtnFavoritos_Click(object sender, EventArgs e)
        {
         
        }


        private void Button1_Click(object sender, EventArgs e)
        {
       

        }

        private void Button2_Click(object sender, EventArgs e)
        {


        }

        private void Button3_Click(object sender, EventArgs e)
        {
         
        }

        private void Button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Button5_Click(object sender, EventArgs e)
        {
         
        }

        private void Button6_Click(object sender, EventArgs e)
        {
       
        }

        private void Button7_Click(object sender, EventArgs e)
        {
        }
    }
    }

        
    

