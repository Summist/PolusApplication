using System;
using System.Collections.Generic;

namespace PolusApplication.WinForms.Database.Entities
{
    public partial class Request
    {
        public Request()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int OrgTechTypeId { get; set; }
        public string OrgTechModel { get; set; } = null!;
        public string ProblemDescription { get; set; } = null!;
        public int StatusId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? RepairParts { get; set; }
        public int? MasterId { get; set; }
        public int ClientId { get; set; }

        public virtual User Client { get; set; } = null!;
        public virtual User? Master { get; set; }
        public virtual OrgTechType OrgTechType { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
