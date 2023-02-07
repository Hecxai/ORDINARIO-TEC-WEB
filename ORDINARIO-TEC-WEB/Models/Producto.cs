using System;
using System.Collections.Generic;

namespace ORDINARIO_TEC_WEB.Models;

public partial class Producto
{
    public int IdProd { get; set; }

    public string NombreProd { get; set; } = null!;

    public decimal PrecioProd { get; set; }

    public short StockProd { get; set; }

    public string? DescripcionProd { get; set; }
}
