namespace Delivera.Models
{
    public class BaseUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string NationalId { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public GlobalRole GlobalRole { get; set; }
        public OrganizationRole OrganizationRole { get; set; } = OrganizationRole.Rider;


        public Guid? CreatedById { get; set; }
        public BaseUser? CreatedByUser { get; set; }

        public Guid? OrganizationId { get; set; }
        public Organization? Organization { get; set; }

    }
}