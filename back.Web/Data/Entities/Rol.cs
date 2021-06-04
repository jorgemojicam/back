﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Web.Data.Entities
{
    public class Rol : IEntity
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
