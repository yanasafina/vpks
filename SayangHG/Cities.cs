﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SayangHG
{
    public partial class Cities
    {
        public Cities()
        {
            Hotels = new HashSet<Hotels>();
        }

        public int Id { get; set; }
        public string Cityname { get; set; }

        public virtual ICollection<Hotels> Hotels { get; set; }
    }
}
