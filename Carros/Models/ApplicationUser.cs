using Microsoft.AspNetCore.Identity;

namespace Alunos.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fistname { get; set; }
        public string Lastname { get; set; }

        //Atributos inseridos na tabela ASPNETUSERS
    }
}
