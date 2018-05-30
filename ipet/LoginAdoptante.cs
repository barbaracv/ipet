using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipet
{
    public partial class LoginAdoptante : Form
    {
        public LoginAdoptante()
        {
            InitializeComponent();
        }

        private void registrarse1_Click(object sender, EventArgs e)
        {
            Form reg = new Registro();
            reg.Show();
        }
    }
}
