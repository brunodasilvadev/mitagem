using ConsumindoAPI.Entities;
using ConsumindoAPI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumindoAPI.Services
{
    public class ConsultaApi
    {
        public async Task<List<Atleta>> RetornaAtletas()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.cartolafc.globo.com/atletas/mercado");

            var atletaLista = JsonConvert.DeserializeObject<List<Atleta>>(json);

            return atletaLista;
        }

        public async Task<List<GoleiroViewModel>> RetornaGoleiroViewModel()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.cartolafc.globo.com/atletas/mercado");

            var goleiroLista = JsonConvert.DeserializeObject<List<GoleiroViewModel>>(json);

            return goleiroLista;
        }
    }
}