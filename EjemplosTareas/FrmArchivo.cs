using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EjemplosTareas
{
    public partial class FrmArchivo : Form
    {
        public FrmArchivo()
        {
            InitializeComponent();
        }

        public void EscribirEnArchivo(string ruta)
        {
            using(StreamWriter writer = new StreamWriter(ruta))
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    writer.WriteLine(i.ToString());
                }
            }
        }

        private void btnEscribirDatos_Click(object sender, EventArgs e)
        {
            string rutaMisDocumentos =
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments
                    );
            string ruta = Path.Combine(rutaMisDocumentos, "datos.txt");
            EscribirEnArchivo(ruta);
        }
    }
}
