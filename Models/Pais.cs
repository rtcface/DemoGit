using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webappaApi.Models
{
    public class Pais
    {
        public Pais()
        {
            Provincias = new List<Providencia>();
        }
        public int id { get; set; }
        [StringLength(200)]
        public string Nombre { get; set; }
        public List<Providencia> Provincias { get; set; }
    }
}
