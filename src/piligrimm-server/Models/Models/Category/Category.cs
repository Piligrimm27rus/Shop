﻿using System;

namespace APIModels.Category
{
    public class Category
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}