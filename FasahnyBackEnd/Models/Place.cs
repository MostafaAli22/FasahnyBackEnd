using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace FasahnyBackEnd.Models
{
    public class Place
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Display(Name = "City")]
        
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }

        public string Descrition { get; set; }
        public string? Thumb{ get; set; }


        //[Column(TypeName = "decimal(9, 6)")]
        public string? Latitude { get; set; }

        //[Column(TypeName = "decimal(9, 6)")]
        public string? Langtitude { get; set; }

        [Display(Name = "Indevidual Price")]
        //[Column(TypeName = "decimal(5, 2)")]
        public string? IndevidualPrice { get; set; }

        [Display(Name = "Group Price")]
        //[Column(TypeName = "decimal(5, 2)")]
        public string? GroupPrice { get; set; }

        [Display(Name = "Backage Price")]
        //[Column(TypeName = "decimal(5, 2)")]
        public string? BackagePrice { get; set; }

        //[Column(TypeName = "decimal(9, 6)")]
        //public decimal? Latitude { get; set; }

        //[Column(TypeName = "decimal(9, 6)")]
        //public decimal? Langtitude { get; set; }

        //[Display(Name= "Indevidual Price")]
        //[Column(TypeName = "decimal(5, 2)")]
        //public decimal? IndevidualPrice{ get; set; }

        //[Display(Name = "Group Price")]
        //[Column(TypeName = "decimal(5, 2)")]
        //public decimal? GroupPrice { get; set; }

        //[Display(Name = "Backage Price")]
        //[Column(TypeName = "decimal(5, 2)")]
        //public decimal? BackagePrice { get; set; }





    }
}
