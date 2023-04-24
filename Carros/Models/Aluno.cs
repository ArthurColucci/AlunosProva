using System.ComponentModel.DataAnnotations;

namespace Alunos.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Curso { get; set; }
    }
}
