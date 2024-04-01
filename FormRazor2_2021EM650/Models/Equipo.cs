using System;
using System.Collections.Generic;

namespace FormRazor2_2021EM650.Models;

public partial class Equipo
{
    public int IdEquipos { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? TipoEquipoId { get; set; }

    public int? MarcaId { get; set; }

    public string? Modelo { get; set; }

    public int? AnioCompra { get; set; }

    public decimal? Costo { get; set; }

    public int? VidaUtil { get; set; }

    public int? EstadoEquipoId { get; set; }

    public string? Estado { get; set; }

    public virtual EstadosEquipo? EstadoEquipo { get; set; }

    public virtual Marca? Marca { get; set; }

    public virtual TipoEquipo? TipoEquipo { get; set; }
}
