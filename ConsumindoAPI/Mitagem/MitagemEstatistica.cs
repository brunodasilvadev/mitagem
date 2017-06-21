using ConsumindoAPI.Entities;
using ConsumindoAPI.Services;
using System.Collections.Generic;
using System.Linq;

namespace ConsumindoAPI.Mitagem
{
    public class MitagemEstatistica
    {
        private readonly ConsultaApi _cs;
        private readonly Clube _clube;

        public MitagemEstatistica()
        {
            _cs = new ConsultaApi();
            _clube = new Clube();
        }

        public IEnumerable<Atleta> Mitos(int posicao)
        {
            //var retornoGoleiro = await _cs.RetornaAtletas();

            var retornoAtletas = _cs.RetornaMercado();

            var atletas = retornoAtletas.Atletas.Where(g => g.posicao_id == posicao && g.status_id == 7).AsEnumerable();

            //Lista de Clubes
            
            foreach (var item in atletas)
            {
                //Atleta que não jogou
                if (item.jogos_num == 0)
                    item.media = 0.0;

                //Goleiro posicao 1
                else if (posicao == 1)
                    item.media = (double)((item.scout.DD * 3) + (item.scout.GS * -2)) / item.jogos_num;

                //Defesa posicao 2-Lateral / 3-Zagueiro
                else if (posicao == 2 || posicao == 3)
                    item.media = (double)((item.scout.RB * 1.7) + (item.scout.PE * -0.3) + (item.scout.FC * -0.5) + (item.scout.FS * 0.5)) / item.jogos_num;

                //Meia posicao 4-Meias / 5-Atacantes
                else if (posicao == 4 || posicao == 5)
                    item.media = (double)((item.scout.PE * -0.3) + (item.scout.RB * 1.7) + (item.scout.FC * -0.5) +
                        (item.scout.FT * 3.5) + (item.scout.FD * 1) + (item.scout.FF * 0.7) +  (item.scout.I * -0.5) + (item.scout.FS * 0.5)) / item.jogos_num;
            }
            
            return atletas.OrderByDescending(a => a.media);
        }
    }
}