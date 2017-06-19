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
        public Scout scout { get; set; }
    }
}