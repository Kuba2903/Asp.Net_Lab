﻿using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")]Low = 1,
        [Display(Name = "Średni")]Normal = 2,
        [Display(Name = "Wysoki")]High = 3,
        [Display(Name = "Pilny")]Urgent = 4
    }
}
