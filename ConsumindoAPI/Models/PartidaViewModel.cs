using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsumindoAPI.Models
{
    public class PartidaViewModel
    {
        [Key]
        public int PartidaId { get; set; }

        [DisplayName("Mandante")]
        public string clube_casa { get; set; }

        [DisplayName("Visitante")]
        public string clube_visitante { get; set; }

        [DisplayName("Gols")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double clube_casa_gols { get; set; }

        [DisplayName("Gols")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        public double clube_visitante_gols { get; set; }
    }
}