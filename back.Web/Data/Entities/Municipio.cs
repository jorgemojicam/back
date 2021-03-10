using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Web.Data.Entities
{
    public class Municipio:IEntity

    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public Departamento Departamento { get; set; }
    }
}
