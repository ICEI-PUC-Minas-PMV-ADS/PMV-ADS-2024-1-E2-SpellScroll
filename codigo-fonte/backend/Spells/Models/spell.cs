using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace spellScrollBackend.Models
{
    [Table("Spell")]
    public class Spell
    {
        [Key]
        public string Id { get; set; }

        public string Classes { get; set; }

        public Boolean Concentration { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public int Level { get; set; }

        public string? Material { get; set; } //Allow NULL values

        public string Reach { get; set; }

        public Boolean Ritual { get; set; }
        public string School { get; set; }
        public Boolean Somatic { get; set; }
        public string SpellName { get; set; }
        public string Time { get; set; }
        public Boolean Verbal { get; set; }

    }
}
