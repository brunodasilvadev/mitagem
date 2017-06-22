using ConsumindoAPI.Entities;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ConsumindoAPI.Services
{
    public class ConsultaApi
    {
        public async Task<Rodada> RetornaRodadaAPI()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.cartolafc.globo.com/atletas/mercado");
            var rodada = JsonConvert.DeserializeObject<Rodada>(json);

            return rodada;
        }

        public Mercado RetornaMercado()
        {
            Mercado mercado = JsonConvert.DeserializeObject<Mercado>(File.ReadAllText(@"C:\Projetos\ConsumindoAPI\ConsumindoAPI\Json\cartola.json"));

            return mercado;
        }


        public Rodada RetornaRodada()
        {
            Rodada rodada = JsonConvert.DeserializeObject<Rodada>(File.ReadAllText(@"C:\Projetos\ConsumindoAPI\ConsumindoAPI\Json\rodada.json"));

            return rodada;
        }

        public List<String> RetornaClassificacao(string _url)
        {
            //string url = "";
            var Webget = new HtmlWeb();
            

            var doc = Webget.Load(_url);

            List<String> lstNode = new List<String>();

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//table//tbody//tr//td"))
            {
                var text = HttpUtility.HtmlDecode(node.InnerText.ToString().Trim());
                lstNode.Add(text);
            }

            

            return lstNode;
        }
    }
}