using System;
using System.Collections.Generic;

namespace lecar_app.database;

public partial class Jurnal
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Name { get; set; }

    public string? IllnesName { get; set; }

    public string? Symtoms { get; set; }

    public string? Recomends { get; set; }

    public string? OtherText { get; set; }
}
