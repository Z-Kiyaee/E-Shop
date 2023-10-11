using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }   //throw exception on login
        public string? PhoneNumber { get; set; }
    }
}
