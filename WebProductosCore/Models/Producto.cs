using System.ComponentModel.DataAnnotations;

namespace WebProductosCore.Models
{
    public class Producto
    {
        [Key]
        public int Cod_Producto { get; set; }
        public string Nom_Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Fecha_elaboracion { get; set; }
        public string Fecha_caducidad{ get; set; }
        public int CodCategoria{ get; set; }
        public int Cod_Proovedor { get; set; }

                   

    }
}
