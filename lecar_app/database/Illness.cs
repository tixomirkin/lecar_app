﻿using System;
using System.Collections.Generic;

namespace lecar_app.database;

public partial class Illness
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Symptoms { get; set; }

    public string? Recommendations { get; set; }
}
