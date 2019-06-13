using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
    public class Desk
    {
        /*public int width { get; set;}
        public int depth { get; set; }
        public int numOfDrawers { get; set; }
        public enum DesktopMaterial {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        };

        public string material { get; set; }

        public int size { get; set; }*/

        public int ID { get; set; }
        [Display(Name = "Customer Name")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string name { get; set; }
        [Display(Name = "Width")]
        [Range(24, 96)]
        [Required]
        public double width { get; set; }
        [Display(Name = "Depth")]
        [Range(12, 48)]
        [Required]
        public double depth { get; set; }
        [Display(Name = "Num Drawers")]
        [Range(0, 7)]
        [Required]
        public int numOfDrawers { get; set; }
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal price { get; set; }
        [Display(Name = "Surface Material")]
        [Required]
        public string material { get; set; }
        [Display(Name = "Rush Order")]
        [Required]
        public string rushOrder { get; set; }
        [Display(Name = "Date Added")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public enum DesktopMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        };


    }
}
