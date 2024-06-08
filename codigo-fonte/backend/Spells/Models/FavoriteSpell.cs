using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spells.Models
{
    [Table("FavoriteSpells")]
    public class FavoriteSpell
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set;}

        [ForeignKey("SpellId")]
        public string SpellId { get; set; }
    }

}
