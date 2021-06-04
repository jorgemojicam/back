using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Web.Data.Entities
{
    public class Envios : IEntity
    {
        public int Id { get; set; }

        public DateTime FechaEnvios { get; set; }

        public CentroCosto CentroCosto {get;set;}

        public int CentroCostoId { get; set; }
    }
}
