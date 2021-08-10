using Core.Entities.Abstract;
using System;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public Guid RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}