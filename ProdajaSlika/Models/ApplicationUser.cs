using Microsoft.AspNetCore.Identity;

namespace ProdajaSlika.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
