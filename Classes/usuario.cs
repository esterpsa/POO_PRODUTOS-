using System;

namespace POO_PRODUTOS.Classes
{
    public class usuario
    {
       public usuario() {
            //Cadastrar usuário automaticamente quando esta classe for instanciada
            Cadastrar();
        }

        public usuario(int _codigo, string _nome, string _email, string _senha) {
            Codigo = _codigo;
            Nome   = _nome;
            Email  = _email;
            Senha  = _senha;
            DataCadastro = DateTime.UtcNow;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar() {
            Nome = "Ester";
            Email = "ester.albuquerque500@gmail.com";
            Senha = "beta123E_";
            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(int codigo) {
            Nome = "";
            Email = "";
            Senha = "";
            //2020-12-21T08:44:25
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
        
    }
}