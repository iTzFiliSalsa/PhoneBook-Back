using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace agenda.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int Usuario { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Cargo { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Url { get; set; }

    }
}
