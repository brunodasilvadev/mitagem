using System.ComponentModel.DataAnnotations;

namespace ConsumindoAPI.Models
{
    public class PartidaViewModel
    {
        [Key]
        public int PartidaId { get; set; }
        public int clube_casa_id { get; set; }
        public int clube_visitante_id { get; set; }
        public double clube_casa_gols { get; set; }
        public double clube_visitante_gols { get; set; }
    }
}