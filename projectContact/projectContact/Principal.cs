using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace projectContact {
    class Principal {
        static void Main(string[] args) {
            int i = 0;
            Contatos contato = new Contatos();
            do {
                Console.WriteLine("\n -- -- -- -- -- --\n");
                Console.WriteLine("  1- Salvar Contato");
                Console.WriteLine("  2- Buscar Contato");
                Console.WriteLine("  3- Remover Contato");
                Console.WriteLine("  4- Alterar Contato");
                Console.WriteLine("  5- Limpar Tela Console");
                Console.WriteLine("  6- Salvar Arquivo");
                Console.WriteLine("  7- Ler Arquivo");
                Console.WriteLine("  8- Modo Navegacao");
                Console.WriteLine("  9- Ordenar Por Nome");
                Console.WriteLine(" 10- Ordenar Por Email");
                Console.WriteLine(" 11- Listar Contatos");
                Console.WriteLine(" 12- Sair");
                Console.WriteLine("\n -- -- -- -- -- --");
                Console.Write(" Opção:  ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        contato.addContato(contato);
                        break;
                    case 2:
                        contato.bscContato();
                        break;
                    case 3:
                        contato.rmvContato();
                        break;
                    case 4:
                        contato.altContato();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        //Salvar Arquivo em Binário
                        FileStream arquivoCriar = new FileStream(@"C:\src\ArquivoComOsDados.Data", FileMode.Create);
                        BinaryFormatter arquivoParaBinario = new BinaryFormatter();
                        arquivoParaBinario.Serialize(arquivoCriar, contato.contatos);
                        arquivoCriar.Close();
                        Console.WriteLine("\n Arquivo Salvo!\n");
                        break;
                    case 7:
                        //Ler Arquivo Binário
                        FileStream arquivoLer = new FileStream(@"C:\src\ArquivoComOsDados.Data", FileMode.Open);
                        BinaryFormatter arquivoLerBinario = new BinaryFormatter();
                        contato.contatos = (List<Contatos>)arquivoLerBinario.Deserialize(arquivoLer);
                        arquivoLer.Close();
                        Console.WriteLine("\n Leitura Finalizada!\n");
                        break;
                    case 8:
                        contato.modoNavegacao();
                        break;
                    case 9:
                        contato.ordenarPorNome();
                        break;
                    case 10:
                        contato.ordenarPorEmail();
                        break;
                    case 11:
                        contato.listarContatos();
                        break;
                    case 12:
                        Console.WriteLine("\n Finalizado com Sucesso ! \n");
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("\n Entrada Invalida ! \n");
                        break;
                }
            } while (i != 1);
            
        }
    }
}
