using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    [Table("WEATHER")]
    public class Weather
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Column("DATETIME", TypeName = "date")]
        public DateTime dateTime { get; set; }

        [Required(ErrorMessage = "TemperatureC is required")]
        [Column("TEMPERATURE_C", TypeName = "double")]
        public double TemperatureC { get; set; }

        [Required(ErrorMessage = "TemperatureF is required")]
        [Column("TEMPERATURE_F", TypeName = "double")]
        public double TemperatureF { get; set; }

        [MaxLength(256)]
        [Column("SUMMARY", TypeName = "varchar(256)")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Latitude is required")]
        [Column("LATITUDE", TypeName = "double")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is required")]
        [Column("LONGITUDE", TypeName = "double")]
        public double Longitude { get; set; }
    }
}
