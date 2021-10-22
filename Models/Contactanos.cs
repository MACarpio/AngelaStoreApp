using System;
using AngelaStoreApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngelaStoreApp.Models
{
    [Table("t_contactanos")]
    public class Contactanos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("asunto")]
        public string Asunto { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("mensaje")]
        public string Mensaje { get; set; }
        
         [NotMapped]
        public String Status {get; set;}
    

        
    }
}