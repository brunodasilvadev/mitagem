using ConsumindoAPI.Models;
using ConsumindoAPI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumindoAPI.Mitagem
{
    public class MitagemGoleiro
    {
        private readonly ConsultaApi _cs;

        public MitagemGoleiro()
        {
            _cs = new ConsultaApi();
        }

        public async Task<List<GoleiroViewModel>> MitosNoGol()
        {
            var retornoGoleiro = await _cs.RetornaGoleiroViewModel();

            //posição 1 Goleiro , status 1 provavel
            var goleiros = retornoGoleiro.Where(g => g.posicao_id == 1 && g.status_id == 1).ToList();
           
            foreach (var item in goleiros)
            {
                if (item.jogos_num == 0)
                    item.media = 0;
                else
                    item.media = ((item.DD * 3) - (item.GS * -2)) / item.jogos_num;
            }

            return goleiros;
        }
    }
}