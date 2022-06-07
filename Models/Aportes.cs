
using System.ComponentModel.DataAnnotations;

public class Aportes
{
    [Key]
    public int AporteId { get; set; }
     
    [Required(ErrorMessage ="Favor Llenar este campo")]
    public string Persona{ get; set; }

   [Range(1,1_000_000, ErrorMessage ="Favor llenar este campo")]
    public double Monto { get; set; }

    
}