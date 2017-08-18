using ConsumindoAPI.Entities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsumindoAPI.Services
{
    public class ConsultaApi
    {
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
    }
}