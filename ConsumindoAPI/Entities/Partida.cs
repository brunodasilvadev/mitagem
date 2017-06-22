namespace ConsumindoAPI.Entities
{
    public class Partida
    {
        public int clube_casa_id { get; set; }
        public string clube_casa { get; set; }
        public int clube_visitante_id { get; set; }
        public string clube_visitante { get; set; }
        public double clube_casa_gols { get; set; }
        public double clube_visitante_gols { get; set; }
    }
}