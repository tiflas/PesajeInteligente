using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica_PasajeInteligente.Controllers
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
