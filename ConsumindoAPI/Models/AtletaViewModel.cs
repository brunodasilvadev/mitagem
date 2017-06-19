using System.ComponentModel.DataAnnotations;

namespace ConsumindoAPI.Models
{
    public class AtletaViewModel
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
        public int FC { get; set; }
        public int FF { get; set; }
        public int FS { get; set; }
        public int PE { get; set; }
        public int RB { get; set; }
        public int PP { get; set; }
        public int A { get; set; }
        public int CA { get; set; }
        public int FD { get; set; }
        public int SG { get; set; }
        public int I { get; set; }
        public int FT { get; set; }
        public int G { get; set; }
        public int DD { get; set; }
        public int GS { get; set; }
        public int CV { get; set; }
        public int DP { get; set; }
        //Média
        public double media { get; set; }
    }
}