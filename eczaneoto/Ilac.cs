using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Ilac")]
public class Ilac
{
    [Key]
    public int Ilac_Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Ilac_Adi { get; set; }

    [Required]
    [MaxLength(50)]
    public string Ilac_Barkod { get; set; }

    [Required]
    public decimal Ilac_Fiyat { get; set; }

    [Required]
    public int Ilac_Stok { get; set; }

    
    [Required]
    public int Kategori_Id { get; set; }
    public virtual Kategori Kategori { get; set; }

    [Required]
    public virtual ICollection<Recete> Receteler { get; set; }
}