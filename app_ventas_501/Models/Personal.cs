﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_ventas_501.Models
{
    [Table("tb_personal")]
    public class Personal
    {
        [Key]
        [Required(ErrorMessage = "Escriba número de DNI")]
        [MinLength(8, ErrorMessage = "Escriba 8 digitos")]
        [Display(Name = "Numero DNI")]
        public String dni { get; set; }

        [Required(ErrorMessage = "Escriba Apellido Paterno")]
        [StringLength(25)]
        [Display(Name = "Apellido Paterno")]
        public String ap_paterno { get; set; }

        [Required(ErrorMessage = "Escriba Apellido Materno")]
        [StringLength(25)]
        [Display(Name = "Apellido Materno")]
        public String ap_materno { get; set; }

        [Required(ErrorMessage = "Escriba Nombre")]
        [StringLength(25)]
        [Display(Name = "Nombre")]
        public String nombre { get; set; }

        [Display(Name = "Genero")]
        public String genero { get; set; }

        [Required(ErrorMessage = "Escriba Fecha de nacimiento")]
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }

        [Required(ErrorMessage = "Ingrese Sueldo")]
        [Display(Name ="Sueldo")]
        public double sueldo { get; set; }
    }
}
