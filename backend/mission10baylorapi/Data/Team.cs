using System.ComponentModel.DataAnnotations;

namespace mission10baylorapi.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
    }
}
