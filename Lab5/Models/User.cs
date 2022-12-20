using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Nick { get; set; }
        
        public string? Email { get; set; }

        public string PasswordHash { get; set; }
    }
}
