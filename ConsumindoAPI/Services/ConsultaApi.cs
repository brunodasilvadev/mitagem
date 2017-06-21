using ConsumindoAPI.Entities;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            Mercado mercado = JsonConvert.DeserializeObject<Mercado>(File.ReadAllText(@"C:\Projetos\ConsumindoAPI\Json\cartola.json"));

            return mercado;
        }


        public Rodada RetornaRodada()
        {
            Rodada rodada = JsonConvert.DeserializeObject<Rodada>(File.ReadAllText(@"C:\Projetos\ConsumindoAPI\Json\rodada.json"));

            return rodada;
        }

        //public List<String> RetornaClassificacaoMandante()
        //{
        //    string url = "http://www.mat.ufmg.br/futebol/classificacao-como-mandante_seriea/";

        //    var Webget = new HtmlWeb();

        //    var doc = Webget.Load(url);

        //    List<String> lstNode = new List<String>();

        //    foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//table//tbody//tr//td"))
        //    {
        //        lstNode.Add(node.InnerText.ToString().Trim());
        //    }

        //    return lstNode;
        //}
    }
}