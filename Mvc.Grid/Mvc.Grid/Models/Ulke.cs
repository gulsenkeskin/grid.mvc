using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Grid.Models
{
    [Table("Ulkeler")]
    public class Ulke
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Personel> Personeller { get; set; } //bir ülkede birden fazla personel olabilir
    }
}