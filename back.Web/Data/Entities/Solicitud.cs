

namespace back.Web.Data.Entities
{
    using System;

    public class Solicitud : IEntity
    {
        public int Id { get; set; }

        public int Tipo { get; set; }

        public int Origen { get; set; }

        public string Solicitante { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaEnvio {get;set; }

        public CentroCosto CentroCosto { get; set; }

        public int CentroCostoId { get; set; }

        public int? Estado { get; set; }

        public int? EstadoCentroCosto { get; set; }

        public int? Guia { get; set;}

        public int? Modo { get; set; }

        public int? UnidadEmpaque { get; set; }

        public int? Precinto { get; set; }

        public int? Transportadora { get; set; }



    }
}
