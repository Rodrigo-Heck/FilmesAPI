using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]        
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo TITULO é obigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo DIRETOR é obigatório")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }


        [Range(1, 500, ErrorMessage = "Range de duração (1, 500)")]
        [Required(ErrorMessage = "Campo DURACAO é obigatório")]
        public int Duracao { get; set; }

        public DateTime HoraDaConsulta { get; set; }
    }
}
