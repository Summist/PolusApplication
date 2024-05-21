using System;
using System.Collections.Generic;
using PolusApplication.WinForms.Database.Entities;

namespace PolusApplication.WinForms.Database
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public int MasterId { get; set; }
        public int RequestId { get; set; }

        public virtual User Master { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
    }
}
