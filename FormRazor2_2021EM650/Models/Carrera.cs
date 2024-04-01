using System;
using System.Collections.Generic;

namespace FormRazor2_2021EM650.Models;

public partial class Carrera
{
    public int CarreraId { get; set; }

    public string? NombreCarrera { get; set; }

    public int? FacultadId { get; set; }
}
