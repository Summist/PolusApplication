﻿using System;
using System.Collections.Generic;

namespace PolusApplication.WinForms.Database.Entities
{
    public partial class OrgTechType
    {
        public OrgTechType()
        {
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Request> Requests { get; set; }
    }
}
