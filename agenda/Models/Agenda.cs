using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace agenda.Models
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; }
    }
}
