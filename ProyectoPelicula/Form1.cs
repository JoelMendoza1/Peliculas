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
   
    public partial class Form1 : Form
    {
        string id;
        string usuario;
        public Form1()
        {
            InitializeComponent();

        }
        
        SqlConnection con = new SqlConnection(@"Data Source = JOEL\SQLEXPRESS; Initial Catalog = Peliculas; Integrated Security = True");

        public void logear(string usuario, string password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("login1 @Usuario,@PasswordU", con);

                cmd.Parameters.AddWithValue("@Usuario", SqlDbType.VarChar).Value=usuario;
                cmd.Parameters.AddWithValue("@PasswordU", SqlDbType.VarChar).Value=password;  

                //Nombre = Convert.ToString(cmd.ExecuteScalar());

                SqlDataReader dr = cmd.ExecuteReader();

                id = Convert.ToString(dr["IdUsuario"]);

                if (dr.Read())
                {

                    //id = Convert.ToInt32(dr["IdUsuario"]);
                    Form3 f3 = new Form3();
                    Form4 f4 = new Form4();
                    //Form3 form3 = new Form3();
                    f3.Visible = true;
                    this.Visible = false;

                    dr.Close();

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LbPassword_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Visible = true;
            this.Visible = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtUsuario.Text == "")
            {
                MessageBox.Show("Llene los datos requeridos");
            }
            else
            {
                logear(this.txtUsuario.Text, this.txtPassword.Text);

            }
            

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
