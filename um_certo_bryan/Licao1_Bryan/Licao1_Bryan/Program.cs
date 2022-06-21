using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoAdo;
using AppBancoDll;
using AppBancoDominio;
using MySql.Data.MySqlClient;

namespace Licao1_Bryan
{
    class Program
    {


        static void Main(string[] args)
        {
            
            var banco = new Banco();
            var usuarioDAO = new UsuarioDAO();
            var user = new Usuario();
            string Opcao;


            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;

            Console.BufferWidth = Console.WindowWidth = 38;
            Console.BufferHeight = Console.WindowHeight;

            while (true)
            {
                Console.SetWindowSize(80, 30);

                Console.Clear();

                Console.Write("\n\r");
                Console.WriteLine("\t\t\t+------------Menu------------+");
                Console.WriteLine("\t\t\t|                            |");
                Console.WriteLine("\t\t\t| 0 - Cadastrar Usuário      |");
                Console.WriteLine("\t\t\t|                            |");
                Console.WriteLine("\t\t\t| 1 - Editar Usuário         |");
                Console.WriteLine("\t\t\t|                            |");
                Console.WriteLine("\t\t\t| 2 - Excluir Usuário        |");
                Console.WriteLine("\t\t\t|                            |");
                Console.WriteLine("\t\t\t| 3 - Listar Usuário         |");
                Console.WriteLine("\t\t\t|                            |");
                Console.WriteLine("\t\t\t| 4 - Sair                   |");
                Console.WriteLine("\t\t\t|                            |");
                Console.WriteLine("\t\t\t+----------------------------+\n\r");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t\tSelecione uma opção\n\r");
                Console.Write("\t\t\t-> ");

                Opcao = Console.ReadLine();


                    switch (Opcao)
                    {
                        case "0":
                            {
                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tDigite o nome do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Nome_Usu = Console.ReadLine();

                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tDigite o cargo do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Cargo = Console.ReadLine();

                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tDigite a data de nascimento do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Nasc = DateTime.Parse(Console.ReadLine());

                                usuarioDAO.Insert(user);

                                break;
                            }

                        case "1":
                            {
                                Console.Write("\n\r");

                                var reader = usuarioDAO.Select();

                                foreach (var users in reader)
                                {

                                    Console.WriteLine("\t Id: {0}, Nome: {1}, Cargo: {2}, Nasc: {3}", users.Id_Usu, users.Nome_Usu, users.Cargo, users.Nasc);

                                };

                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tInsira o ID do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Id_Usu = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\t\t\tDigite o nome do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Nome_Usu = Console.ReadLine();

                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tDigite o cargo do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Cargo = Console.ReadLine();

                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tDigite a data de nascimento do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Nasc = DateTime.Parse(Console.ReadLine());     

                                usuarioDAO.Save(user);

                                break;
                            }

                        case "2":
                            {
                                Console.Write("\n\r");

                                var reader = usuarioDAO.Select();

                                foreach (var users in reader)
                                {

                                    Console.WriteLine("\t Id: {0}, Nome: {1}, Cargo: {2}, Nasc: {3}", users.Id_Usu, users.Nome_Usu, users.Cargo, users.Nasc);

                                };

                                Console.Write("\n\r");

                                Console.WriteLine("\t\t\tInsira o ID do usuário: \n\r");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\t\t\t-> ");
                                user.Id_Usu = Convert.ToInt32(Console.ReadLine());

                                usuarioDAO.Delete(user);

                                break;
                            }

                        case "3":
                            {
                                Console.Write("\n\r");

                                var reader = usuarioDAO.Select();

                        
                                break;
                            }

                        case "4":
                            {
                                Environment.Exit(0);
                                break;
                            }

                    }

            
                if (Opcao == "0" || Opcao == "1" || Opcao == "2" || Opcao == "3")
                {
                    Console.Write("\n\r");
                    var reader = usuarioDAO.Select();

                    foreach (var users in reader)
                    {
                        Console.WriteLine("\t Id: {0}, Nome: {1}, Cargo: {2}, Nasc: {3}", users.Id_Usu, users.Nome_Usu, users.Cargo, users.Nasc);

                    };
                        Console.WriteLine("\t\t\t\r\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\t\tAperte 'Enter' para continuar!");
                        Console.ReadLine();
                }
                else
                    {
                        Console.Write("\n\r");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\tDigite informações válidas");
                        Console.Write("\n\r");
                        Console.WriteLine("\t\t\tAperte 'Enter' para continuar!");
                        Console.ReadLine();
                    }
                
            }


            
        }
    }
}
