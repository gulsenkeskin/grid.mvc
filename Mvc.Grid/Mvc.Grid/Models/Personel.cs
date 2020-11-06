using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Grid.Models
{
    [Table("Personeller")]
    public class Personel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50),Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public Ulke Ulke { get; set; } //bir personelin 1 ülkesi olabilir
    }
}