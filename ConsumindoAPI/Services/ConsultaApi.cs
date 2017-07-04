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
            String path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            path += "\\Json\\cartola.json";
            Mercado mercado = JsonConvert.DeserializeObject<Mercado>(File.ReadAllText(path));

            return mercado;
        }


        public Rodada RetornaRodada()
        {
            String path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            path += "\\Json\\rodada.json";
            Rodada rodada = JsonConvert.DeserializeObject<Rodada>(File.ReadAllText(path));

            return rodada;
        }

        public List<String> RetornaClassificacao(string _url)
        {
            var Webget = new HtmlWeb();

            //var teste = Webget.StatusCode;
 
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