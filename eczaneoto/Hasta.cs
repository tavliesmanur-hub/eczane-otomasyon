using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Hasta")]
public class Hasta
{
    [Key]
    public int Hasta_Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Hasta_Ad { get; set; }

    [Required]
    [MaxLength(50)]
    public string Hasta_Soyad { get; set; }

    [Required]
    [MaxLength(11)]
    public string Hasta_TcNo { get; set; }

    [MaxLength(20)]
    public string Hasta_Telefon { get; set; }

   
    public virtual ICollection<Recete> Receteler { get; set; }
}