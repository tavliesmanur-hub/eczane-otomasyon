using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Kategori")]
public class Kategori
{
    [Key]
    public int Kategori_Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Kategori_Adi { get; set; }

    [MaxLength(255)]
    public string Kategori_Aciklama { get; set; }

    // one-to-many: bir kategoride birden fazla ilaç olabilir
    public virtual ICollection<Ilac> Ilaclar { get; set; }
}