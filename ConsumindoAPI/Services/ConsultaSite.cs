using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Web;

namespace ConsumindoAPI.Services
{
    public class ConsultaSite
    {
        public List<String> RetornaClassificacao(string _url)
        {
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