using ConsumindoAPI.Entities;
using Newtonsoft.Json;
using System.IO;

namespace ConsumindoAPI.Services
{
    public class ConsultaApi
    {
        //public async Task<IEnumerable<Atleta>> RetornaAtletas()
        //{
        //    var httpClient = new HttpClient();
        //    var json = await httpClient.GetStringAsync("https://api.cartolafc.globo.com/atletas/mercado");
        //    var atletaLista = JsonConvert.DeserializeObject<List<Atleta>>(json);
        //}

        public Mercado RetornaMercado()
        {
            Mercado mercado = JsonConvert.DeserializeObject<Mercado>(File.ReadAllText(@"C:\Projetos\ConsumindoAPI\cartola.json"));

            return mercado;
        }
    }
}