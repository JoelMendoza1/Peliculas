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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LinklbIniciar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible=true;
            this.Visible=false;

           
        }


        private void BntRegistar_Click(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "" || txtApellido.Text == "" || txtUsuario.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("PORFAVOR LLENAR TODOS LOS CAMPOS");
            }
            else
            {
                try
                {

                    SqlConnection db1 = new SqlConnection(@"Data Source = JOEL\SQLEXPRESS; Initial Catalog = Peliculas; Integrated Security = True");
                    SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO" , db1);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = (txtNombreR.Text);
                    cmd.Parameters.Add("@Apellid0", SqlDbType.VarChar).Value = (txtApellido.Text);
                    cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = (txtUsuario.Text);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = (txtEmail.Text);
                    cmd.Parameters.Add("@PasswordU", SqlDbType.VarChar).Value =(txtPassword.Text);
                    
                    
                    db1.Open();
                    cmd.ExecuteNonQuery();
                    db1.Close();
                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreR.Clear();
                    txtApellido.Clear();
                    txtUsuario.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();

                    Form1 form1 = new Form1();
                    form1.Visible = true;
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }

        }
    }
    }
