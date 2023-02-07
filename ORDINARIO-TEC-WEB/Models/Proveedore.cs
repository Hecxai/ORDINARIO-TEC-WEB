using System;
using System.Collections.Generic;

namespace ORDINARIO_TEC_WEB.Models;

public partial class Proveedore
{
    public int IdProv { get; set; }

    public string NombreProv { get; set; } = null!;

    public string DireccionProv { get; set; } = null!;

    public string TelefonoProv { get; set; } = null!;

    public string CorreoProv { get; set; } = null!;
}
