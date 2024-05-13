using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_ventas_501.Models
{
    [Table("tb_producto")]
    public class Producto
    {
        [Key]
        [Required(ErrorMessage = "Escriba el codigo")]
        [MinLength(5, ErrorMessage = "Escriba 5 digitos")]
        [Display(Name = "Codigo Producto")]
        public String codigo_producto { get; set; }

        [Required(ErrorMessage = "Escriba Producto")]
        [StringLength(40)]
        [Display(Name = "Producto")]
        public String producto { get; set; }

        [Required(ErrorMessage = "Ingrese Stock")]
        [Display(Name = "Stock Disponible")]
        public int stock_disponible { get; set; }

        [Required(ErrorMessage = "Ingrese el Costo")]
        [Display(Name = "Costo")]
        public double costo { get; set; }

        [Required(ErrorMessage = "Ingrese la ganancia")]
        [Display(Name = "Ganancia")]
        public double ganancia { get; set; }

        [Required(ErrorMessage = "Escriba número de DNI")]
        [MinLength(5, ErrorMessage = "Escriba 5 digitos")]
        [Display(Name = "Codigo marca")]
        public String producto_codigo_marca { get; set; }

        [Required(ErrorMessage = "Escriba número de DNI")]
        [MinLength(5, ErrorMessage = "Escriba 5 digitos")]
        [Display(Name = "Codigo categoria")]
        public String producto_codigo_categoria { get; set; }
    }
}
