using AutoMapper;
using ConsumindoAPI.Entities;
using ConsumindoAPI.Mitagem;
using ConsumindoAPI.Models;
using System.Collections.Generic;

namespace ConsumindoAPI.Mapeamentos
{
    public class MapeamentoMitos
    {
        private MitagemEstatistica _mitagemEstatisca;

        public MapeamentoMitos()
        {
            _mitagemEstatisca = new MitagemEstatistica();
        }

        public IEnumerable<AtletaViewModel> Mitos(int posicao)
        {
            return Mapper.Map<IEnumerable<Atleta>, IEnumerable<AtletaViewModel>>(_mitagemEstatisca.Mitos(posicao));
        }
    }
}