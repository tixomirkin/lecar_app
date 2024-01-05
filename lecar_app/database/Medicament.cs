using System;
using System.Collections.Generic;

namespace lecar_app.database;

public partial class Medicament
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Count { get; set; }

    public string? ActiveSubstance { get; set; }
}
