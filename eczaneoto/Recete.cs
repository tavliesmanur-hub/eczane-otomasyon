using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Recete")]
public class Recete
{
    [Key]
    public int Recete_Id { get; set; }

   
    [Required]
    public int Hasta_Id { get; set; }
    public virtual Hasta Hasta { get; set; }

   
    [Required]
    public int Ilac_Id { get; set; }
    public virtual Ilac Ilac { get; set; }

    [Required]
    public DateTime Recete_Tarih { get; set; }

    [Required]
    public int Recete_Miktar { get; set; }
}