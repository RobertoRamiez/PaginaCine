using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinematronic.Models
{
    public class Cine
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        
        public decimal Hora { get; set; }
    }
}