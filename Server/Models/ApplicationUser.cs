using BlazorIdentityTutoriaL.Shared;
using Microsoft.AspNetCore.Identity;

namespace BlazorIdentityTutoriaL.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}