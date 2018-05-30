using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ipet
{
    public partial class LoginVoluntario : Form
    {
        public LoginVoluntario()
        {
            InitializeComponent();
        }

        private void inicio_sesionV_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoFinalConnectionString"];
            SqlConnection conn = new SqlConnection(setting.ConnectionString);

            string query = "SELECT [dbo].[fn_comprobar_usuario_contraseña] ("+Codigo.Text+",'"+contraseñaV.Text+"')";
            SqlCommand cmdLogV = new SqlCommand(query, conn);



            public bool Comprobar(query)
            {
                bool res = true;
                if (pLibros.Count >= 5)
                    res = false;
                else
                    if (pLibros.Contains(this))
                    res = false;
                else
                {
                    this.fechaDevolucion = DateTime.Now.AddDays(10);
                    pLibros.Add(this);
                }

                return res;
            }

        }

        private void Codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
