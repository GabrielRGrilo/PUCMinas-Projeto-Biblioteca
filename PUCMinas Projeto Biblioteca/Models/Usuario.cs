using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PUCMinas_Projeto_Biblioteca.Models {

    [Table("Usuarios")]
    public class Usuario {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]

        public Perfil Perfil { get; set; }
    }

    public enum Perfil {
        Admin,
        User
    }


}
