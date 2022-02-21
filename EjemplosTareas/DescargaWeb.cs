using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTareas
{
    public class DescargaWeb
    {
        public async Task<String> Descargar(string url)
        {
            HttpClient cliente = new HttpClient();
            var respuesta = await cliente.GetAsync(url);
            var contenido = await respuesta.Content.ReadAsStringAsync();
            return contenido;
        }
    }
}
