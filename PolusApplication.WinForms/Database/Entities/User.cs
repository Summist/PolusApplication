using System;
using System.Collections.Generic;

namespace PolusApplication.WinForms.Database.Entities
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            RequestClients = new HashSet<Request>();
            RequestMasters = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Request> RequestClients { get; set; }
        public virtual ICollection<Request> RequestMasters { get; set; }
    }
}
