using System.ComponentModel.DataAnnotations;

namespace Udemy_MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateOnly? Birthdate { get; set; }

        public bool IsSubscribeToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}
