using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Web.Data.Entities
{
    public class CentroCosto : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Direccion { get; set; }
        public Municipio Municipio { get; set; }
        public Regional Regional { get; set; }
        public string Codigo { get; set; }
        public bool? Activo { get; set; }
    }
}
