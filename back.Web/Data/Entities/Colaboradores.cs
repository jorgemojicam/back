using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Web.Data.Entities
{
    public class Colaboradores : IEntity
    {
        public int Id { get; set; }

        public string Nombre { get; set;}

        public string Username { get; set; }

        public CentroCosto CentroCosto { get; set; }

        public int CentroCostoId { get; set; }

        public Rol Rol { get; set; }

        public int RolId { get; set; }

        public decimal Celular { get; set; }
    }
}
