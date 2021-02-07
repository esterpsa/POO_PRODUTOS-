using System;

namespace POO_PRODUTOS.Classes
{
    public class Login
    {
        public bool Logado {get; set;}

        public Login()
        {
            usuario user = new usuario();
            logar(user);

            if(Logado)
            {
                GerarMenu();
            }
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();

            Marca Marca = new Marca();

            string opcao = "n";

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produto");
                Console.WriteLine("3 - Deletar Produto");
                Console.WriteLine("4 - Cadastrar Marca");
                Console.WriteLine("5 - Listar Marca");
                Console.WriteLine("7 - Deletar Marca");
                Console.WriteLine("0 - Sair da opcao");

                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar(Marca);
                        break;

                    case "2":
                        produto.Listar();
                        break;

                    case "3":
                        Console.WriteLine("Digite um código para deletar: ");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;

                    case "4":
                        Marca.CadastrarMarca();
                        break;

                    case "5":
                        Marca.Listar();
                        break;

                    case "6":
                        Console.WriteLine("Digite um código para deletar: ");
                        int codMarca = int.Parse(Console.ReadLine());
                        produto.Deletar(codMarca);
                        break;

                    case "0":
                        break;


                    default:
                        break;
                }
                

            } while (opcao != "0");
            
        }
        public void logar(usuario usuario)
        {
            Console.WriteLine("Dígite o seu e-mail: ");
            string emaillogin = Console.ReadLine();
            
            Console.WriteLine("Dígite a sua senha: ");
            string senhalogin = Console.ReadLine();
            
            if(emaillogin == usuario.Email && senhalogin == usuario.Senha)
            {
                Logado = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login efetuado com sucesso");
                Console.ResetColor();

            }else{
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falha ao efetuar o login");
                Console.ResetColor();
            }
            
        }

        public void Deslogar()
        {
            Logado = false;
        }
    }
}