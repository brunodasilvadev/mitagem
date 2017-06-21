using ConsumindoAPI.Entities;
using ConsumindoAPI.Services;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsumindoAPI.Mitagem
{
    public class RodadaAtual
    {
        private readonly ConsultaApi _ca;

        public RodadaAtual()
        {
            _ca = new ConsultaApi();
        }

        public IEnumerable<Partida> Partidas()
        {
            var retornoRodada = _ca.RetornaRodada();

            var partidas = retornoRodada.partidas.AsEnumerable();

            return partidas;
        }
    }
}