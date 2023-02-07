using System;
using System.Collections.Generic;

namespace ORDINARIO_TEC_WEB.Models;

public partial class Cliente
{
    public int IdCli { get; set; }

    public string NombreCli { get; set; } = null!;

    public string DireccionCli { get; set; } = null!;

    public string TelfonoCli { get; set; } = null!;
}
