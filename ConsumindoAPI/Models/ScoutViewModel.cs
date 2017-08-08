using System.ComponentModel;

namespace ConsumindoAPI.Models
{
    public class ScoutViewModel
    {
        //Scout
        [DisplayName("Faltas Cometidas")]
        public int FC { get; set; }

        [DisplayName("Finalizações para fora")]
        public int FF { get; set; }

        [DisplayName("Faltas Sofridas")]
        public int FS { get; set; }

        [DisplayName("Passes Errados")]
        public int PE { get; set; }

        [DisplayName("Roubadas de Bola")]
        public int RB { get; set; }

        [DisplayName("Pênalti perdido")]
        public int PP { get; set; }

        [DisplayName("Assistência")]
        public int A { get; set; }

        [DisplayName("Cartão Amarelo")]
        public int CA { get; set; }

        [DisplayName("Finalização defendida")]
        public int FD { get; set; }

        [DisplayName("Jogos sem sofrer gol")]
        public int SG { get; set; }

        [DisplayName("Impedimentos")]
        public int I { get; set; }

        [DisplayName("Finalização na trave")]
        public int FT { get; set; }

        [DisplayName("Gols Feitos")]
        public int G { get; set; }

        [DisplayName("Defesas difíceis")]
        public int DD { get; set; }

        [DisplayName("Gols Sofridos")]
        public int GS { get; set; }

        [DisplayName("Cartçao Vermelho")]
        public int CV { get; set; }

        [DisplayName("Defesa de Pênalti")]
        public int DP { get; set; }

        [DisplayName("Gols contra")]
        public int GC { get; set; }
    }
}