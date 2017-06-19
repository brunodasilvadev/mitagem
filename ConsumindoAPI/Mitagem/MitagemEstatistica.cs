using ConsumindoAPI.Models;
using ConsumindoAPI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumindoAPI.Mitagem
{
    public class MitagemEstatistica
    {
        private readonly ConsultaApi _cs;

        public MitagemEstatistica()
        {
            _cs = new ConsultaApi();
        }

        public async Task<List<AtletaViewModel>> Mitos(int posicao, int posicao2 = 0)
        {
            var retornoGoleiro = await _cs.RetornaAtletas();

            var atletas = retornoGoleiro.Where(g => g.posicao_id == posicao && g.status_id == 1).ToList();

            foreach (var item in atletas)
            {
                //Atleta que não jogou
                if (item.jogos_num == 0)
                    item.media = 0;
                //Goleiro posicao 1
                else if (posicao == 1)
                    item.media = ((item.DD * 3) + (item.GS * -2)) / item.jogos_num;
                //Defesa posicao 2-Lateral / 3-Zagueiro
                else if (posicao == 2 || posicao2 == 3)
                    item.media = ((item.RB * 1.7) + (item.PE * -0.3) + (item.FC * -0.5)) / item.jogos_num;
                //Meia posicao 4-Meias / 5-Atacantes
                else if (posicao == 4 || posicao == 5)
                    item.media = ((item.RB * 1.7) + (item.PE * -0.3) + (item.FC * -0.5) + 
                        (item.FF * 0.7) + (item.FD * 1) + (item.FT * 3.5) + (item.I * -0.5)) / item.jogos_num;
            }

            return atletas;
        }
    }
}