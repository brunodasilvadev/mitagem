using ConsumindoAPI.Data;
using ConsumindoAPI.Data.Repository;
using ConsumindoAPI.Entities;
using ConsumindoAPI.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsumindoAPI.Mitagem
{
    public class RodadaAtual
    {
        private readonly ConsultaApi _ca;
        private readonly ClubeRepository _clube;
        private readonly ConsultaSite _consultaSite;

        public RodadaAtual()
        {
            _ca = new ConsultaApi();
            _clube = new ClubeRepository(new CartolaContext());
        }

        public IEnumerable<Partida> Partidas()
        {
            var retornoRodada = _ca.RetornaRodada();

            var partidas = retornoRodada.partidas.AsEnumerable();

            var classificacaoMandante = _consultaSite.RetornaClassificacao("http://www.mat.ufmg.br/futebol/classificacao-como-mandante_seriea/");

            Thread.Sleep(15000);

            var classificacaoVisitante = _consultaSite.RetornaClassificacao("http://www.mat.ufmg.br/futebol/classificacao-como-visitante_seriea/");

            int indice = 0;

            foreach (var item in partidas)
            {
                indice = 0;
                item.clube_casa = _clube.ObterNomeTimePorIdClube(item.clube_casa_id);

                item.clube_visitante = _clube.ObterNomeTimePorIdClube(item.clube_visitante_id);
                double _clube_casa_gols = 0.0;
                double _clube_casa_gols_2 = 0.0;
                double _clube_visitante_gols = 0.0;
                double _clube_visitante_gols_2 = 0.0;

                foreach (var classificao in classificacaoMandante)
                {
                    if (classificao.Contains(item.clube_casa.ToUpper()))
                    {
                        _clube_casa_gols = (double)Convert.ToInt32(classificacaoMandante[indice + 6]) / Convert.ToInt32(classificacaoMandante[indice + 2]);
                        _clube_visitante_gols = (double)Convert.ToInt32(classificacaoMandante[indice + 7]) / Convert.ToInt32(classificacaoMandante[indice + 2]);
                    }
                    indice++;
                }

                //
                indice = 0;
                foreach (var classificao in classificacaoVisitante)
                {
                    if (classificao.Contains(item.clube_visitante.ToUpper()))
                    {
                        _clube_casa_gols_2 = (double)Convert.ToInt32(classificacaoVisitante[indice + 7]) / Convert.ToInt32(classificacaoVisitante[indice + 2]);
                        _clube_visitante_gols_2 = (double)Convert.ToInt32(classificacaoVisitante[indice + 6]) / Convert.ToInt32(classificacaoVisitante[indice + 2]);
                    }
                    indice++;
                }


                item.clube_casa_gols = (_clube_casa_gols + _clube_casa_gols_2) / 2;
                item.clube_visitante_gols = (_clube_visitante_gols + _clube_visitante_gols_2) / 2;
                //
            }

            return partidas;
        }
    }
}