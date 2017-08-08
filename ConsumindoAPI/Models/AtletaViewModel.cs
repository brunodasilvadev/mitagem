using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsumindoAPI.Models
{
    public class AtletaViewModel
    {
        //Atleta -> 
        [Key]
        public int atleta_id { get; set; }

        public string nome { get; set; }
        [DisplayName("Jogador")]
        public string apelido { get; set; }
        [DisplayName("Clube")]
        public string nome_clube { get; set; }
        public int posicao_id { get; set; }
        public int status_id { get; set; }
        [DisplayName("Jogos")]
        public int jogos_num { get; set; }
        [DisplayName("Preço")]
        public double preco_num { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        //Média
        [DisplayName("Média")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double media { get; set; }

        //Média
        [DisplayName("Média Gols Sofridos")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double mediaGolsSofridos { get; set; }

        [DisplayName("Média Finalizações")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double finalizacoes { get; set; }
        [DisplayName("Média DD")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double mediaDefesasDificeis { get; set; }

        [DisplayName("Pontos Média DD")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double pontuacaoMediaDD { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0.00}", ApplyFormatInEditMode = true)]
        [DisplayName("Total Pontos")]
        public double totalPontos { get; set; }

        public ScoutViewModel Scout { get; set; }
    }
}