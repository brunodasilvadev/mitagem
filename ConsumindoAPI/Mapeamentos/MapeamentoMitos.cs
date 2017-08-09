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
        private RodadaAtual _rodadaAtual;

        public MapeamentoMitos()
        {
            _mitagemEstatisca = new MitagemEstatistica();
            _rodadaAtual = new RodadaAtual();
        }

        public IEnumerable<AtletaViewModel> Mitos(int posicao)
        {
            return Mapper.Map<IEnumerable<Atleta>, IEnumerable<AtletaViewModel>>(_mitagemEstatisca.Mitos(posicao));
        }

        public IEnumerable<PartidaViewModel> Partidas()
        {
            return Mapper.Map<IEnumerable<Partida>, IEnumerable<PartidaViewModel>>(_rodadaAtual.Partidas());
        }

        public IEnumerable<AtletaViewModel> Todos()
        {
            return Mapper.Map<IEnumerable<Atleta>, IEnumerable<AtletaViewModel>>(_mitagemEstatisca.Todos());

        }
    }
}