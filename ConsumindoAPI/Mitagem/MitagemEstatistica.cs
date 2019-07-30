using ConsumindoAPI.Data;
using ConsumindoAPI.Data.Repository;
using ConsumindoAPI.Entities;
using ConsumindoAPI.Services;
using System.Collections.Generic;
using System.Linq;

namespace ConsumindoAPI.Mitagem
{
    public class MitagemEstatistica
    {
        private readonly ConsultaApi _cs;
        private readonly ClubeRepository _clube;

        public MitagemEstatistica()
        {
            _cs = new ConsultaApi();
            _clube = new ClubeRepository(new CartolaContext());
        }

        public IEnumerable<Atleta> Todos()
        {
            var retornoAtletas = _cs.RetornaMercado();

            IEnumerable<Atleta> todosAtletas;

            todosAtletas = retornoAtletas.Atletas.AsEnumerable();

            foreach (var item in todosAtletas)
            {
                item.totalPontos = (double)(item.scout.A * 5 + item.scout.CA * -2 + item.scout.CV * -5 + item.scout.DD * 3 + item.scout.DP * 7 + item.scout.FC * -0.5 +
                    item.scout.FD * 1.2 + item.scout.FF * 0.8 + item.scout.FS * 0.5 + item.scout.FT * 3 + item.scout.G * 8 + item.scout.GS * -2 + item.scout.I * -0.5 +
                    item.scout.PE * -0.3 + item.scout.PP * -4 + item.scout.RB * 1.5 + item.scout.SG * 5);

                if (item.jogos_num > 0)
                    item.media = (double)(item.totalPontos / item.jogos_num);
                else item.media = 0;

                item.nomeClube = _clube.ObterNomeTimePorIdClube(item.clube_id);
            }

            return todosAtletas.OrderBy(a => a.totalPontos);
        }

        public IEnumerable<Atleta> Mitos(int posicao)
        {
            var retornoAtletas = _cs.RetornaMercado();

            var atletas = retornoAtletas.Atletas.Where(g => g.posicao_id == posicao && (g.status_id == 7 || g.status_id == 2)).AsEnumerable();
            //var atletas = retornoAtletas.Atletas.Where(g => g.posicao_id == posicao).AsEnumerable();

            foreach (var item in atletas)
            {
                //Atleta que não jogou
                if (item.jogos_num == 0)
                    item.media = 0.0;

                //Goleiro posicao 1
                else if (posicao == 1)
                {
                    item.media = (double)((item.scout.DD * 3) + (item.scout.GS * -2)) / item.jogos_num;
                    item.mediaGolsSofridos = (double)(item.scout.GS) / item.jogos_num;
                    item.mediaDefesasDificeis = (double)(item.scout.DD) / item.jogos_num;
                    item.pontuacaoMediaDD = item.mediaDefesasDificeis * 3;
                    if (item.scout.SG > 0)
                        item.intervaloMedioSemSofrerGol = (double)item.jogos_num / item.scout.SG;
                    else
                        item.intervaloMedioSemSofrerGol = -1;
                    //item.golsFeitos = item.scout.G;
                }
                //Defesa posicao 2-Lateral / 3-Zagueiro
                else if (posicao == 2 || posicao == 3)
                {
                    item.media = (double)((item.scout.RB * 1.5) + (item.scout.PE * -0.3) + (item.scout.FC * -0.5) + (item.scout.FS * 0.5)) / item.jogos_num;
                    if (item.scout.SG > 0)
                        item.intervaloMedioSemSofrerGol = (double)item.jogos_num / item.scout.SG;
                    else
                        item.intervaloMedioSemSofrerGol = 0;
                    //item.golsFeitos = item.scout.G;
                    item.mediaRB = (double)((item.scout.RB)) / (item.jogos_num);
                    item.mediaPE = (double)((item.scout.PE)) / (item.jogos_num);
                }
                //Meia posicao 4-Meias / 5-Atacantes
                else if (posicao == 4 || posicao == 5)
                {
                    item.media = (double)((item.scout.PE * -0.3) + (item.scout.RB * 1.5) + (item.scout.FC * -0.5) + (item.scout.A * 5) +
                        (item.scout.FT * 3) + (item.scout.FD * 1.2) + (item.scout.FF * 0.8) + (item.scout.I * -0.5) + (item.scout.FS * 0.5)) / item.jogos_num;

                    item.mediaRB = (double)((item.scout.RB)) / (item.jogos_num);
                    item.mediaPE = (double)((item.scout.PE)) / (item.jogos_num);
                    item.finalizacoes = (double)(item.scout.FT + item.scout.FD + item.scout.FF + item.scout.G) / item.jogos_num;
                   // item.golsFeitos = item.scout.G;
                }
                item.nomeClube = _clube.ObterNomeTimePorIdClube(item.clube_id);
                item.golsFeitos = (double)(item.scout.G) / (item.jogos_num);
            }

            if (posicao == 1)
                return atletas.OrderByDescending(a => a.pontuacaoMediaDD);

            return atletas.OrderByDescending(a => a.media);
        }
    }
}