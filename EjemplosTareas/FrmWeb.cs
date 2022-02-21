using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosTareas
{
    public partial class FrmWeb : Form
    {
        public FrmWeb()
        {
            InitializeComponent();
        }

        private async void btnDescargar_Click(object sender, EventArgs e)
        {
            DescargaWeb dw = new DescargaWeb();
            txtResultado.Text = await dw.Descargar("https://itesrc.edu.mx");
        }
    }
}
