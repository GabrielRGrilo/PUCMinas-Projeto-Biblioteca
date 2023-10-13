using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUCMinas_Projeto_Biblioteca.Models {


    [Table("Livros")]
    public class Livros {
 


            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome!")]
            public string Titulo { get; set; }


            [Required(ErrorMessage = "Obrigatório informar o Autor!")]
            public string Autor { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o ISBN!")]
            public string ISBN { get; set; }

        }
    }



