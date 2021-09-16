using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeirAulaCSharp
{
    public partial class FraseDia : Form
    {
        public FraseDia()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtFrase.Text + "\n" + txtAutor.Text;
            txtAutor.Text = " ";
            txtFrase.Text = " ";
        }
    }
}
