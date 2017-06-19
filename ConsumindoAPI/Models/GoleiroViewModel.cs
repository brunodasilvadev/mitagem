using System.ComponentModel.DataAnnotations;

namespace ConsumindoAPI.Models
{
    public class GoleiroViewModel
    {
        //Atleta -> Goleiro
        [Key]
        public int atleta_id { get; set; }
        public string nome { get; set; }
        public string apelido { get; set; }
        public int posicao_id { get; set; }
        public int status_id { get; set; }
        public int jogos_num { get; set; }

        //Scout -> Goleiro
        //Defesa difícil
        public int DD { get; set; }
        //Gols sofridos
        public int GS { get; set; }

        //Média
        public float media { get; set; }
    }
}