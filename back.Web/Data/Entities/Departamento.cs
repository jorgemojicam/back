﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Web.Data.Entities
{
    public class Departamento:IEntity
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
