

namespace back.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product:IEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode=false)]
        public double Price { get; set; }

        [Display(Name="Image")]
        public string ImageUrl { get; set; }

        [Display(Name="Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name="is avalible?")]
        public bool IsAvalible { get; set; }

        public User User { get; set; }
    }
}
