using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_interfaz form2 = new form_interfaz();
            form2.Show();
        }

        private void btn_singup_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_regisro form3 = new form_regisro();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
