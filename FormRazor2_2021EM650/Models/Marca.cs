using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FormRazor2_2021EM650.Models;

public partial class Marca
{
    [Key]
    [Display(Name = "ID")]
    public int IdMarcas { get; set; }
    [Display(Name ="Nombre de la marca")]
    public string? NombreMarca { get; set; }
    [Display(Name ="Estado")]
    public string? Estados { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
