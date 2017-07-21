namespace ConsumindoAPI.Entities
{
    public class Atleta
    {
        public int atleta_id { get; set; }
        public string nome { get; set; }
        public string apelido { get; set; }
        public int posicao_id { get; set; }
        public int status_id { get; set; }
        public int jogos_num { get; set; }
        public double media { get; set; }
        public double mediaGolsSofridos { get; set; }
        public int clube_id { get; set; }
        public string nomeClube { get; set; }
        public double preco_num { get; set; }
        public double mediaGS { get; set; }
        public double finalizacoes { get; set; }
        public double mediaDefesasDificeis { get; set; }
        public double pontuacaoMediaDD { get; set; }
        public Scout scout { get; set; }
    }
}