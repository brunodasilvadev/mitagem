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
        [DisplayName("Média GS")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double mediaGS { get; set; }
        public ScoutViewModel Scout { get; set; }
    }
}