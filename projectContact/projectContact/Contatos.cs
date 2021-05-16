using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace projectContact {
    [Serializable]
    class Contatos {
        private String nome;
        private String numero;
        private String email;

        public List<Contatos> contatos;

        public Contatos() {
            contatos = new List<Contatos>();
        }

        public void addContato(Contatos c) {
            c = new Contatos();
            Console.WriteLine("\n -- Cadastrar Contato --  ");
            Console.Write("\n Nome :  ");
            c.nome = Console.ReadLine();
            Console.Write("\n Numero :  ");
            c.numero = Console.ReadLine();
            Console.Write("\n E-mail :  ");
            c.email = Console.ReadLine();
            contatos.Add(c);
            Console.WriteLine("\n Contato salvo ! \n");
        }

        public void rmvContato() {
            if (contatos.Any()) {
                int aux = 0;
                Console.WriteLine("\n -- Remover Contato -- !\n");
                Console.Write("\n Nome :  ");
                String nome = Console.ReadLine();
                for (int i = 0; i < contatos.Count(); i++) {
                    if (contatos.ElementAt(i).nome.Equals(nome)) {
                        Console.WriteLine("\n\n -- Contato " + (i + 1) + "--");
                        Console.WriteLine(" Nome:" + contatos.ElementAt(i).nome);
                        Console.WriteLine(" Email:" + contatos.ElementAt(i).email);
                        Console.WriteLine(" Numero:" + contatos.ElementAt(i).numero);
                        Console.WriteLine(" -- -- -- --\n");
                        contatos.Remove(contatos.ElementAt(i));
                        aux = 1;
                    }
                }
                if (aux == 1) {
                    Console.WriteLine("\n Removido com Sucesso !\n");
                }
                else {
                    Console.WriteLine("\n Não existe Contato com esse Nome !\n");
                }
            }
            else {
                Console.WriteLine("\n Não existe Contato para ser Removido !\n");
            }
        }

        public void altContato() {
            if (contatos.Any()) {
                int aux1 = 0, aux2 = 0;
                int numContato = -1;
                Console.WriteLine("\n -- Alterar Contato -- !\n");
                Console.Write("\n 1- Nome do Contato: ");
                String nomeContato = Console.ReadLine();
                for (int i = 0; i < contatos.Count(); i++) {
                    if (contatos.ElementAt(i).nome.Equals(nomeContato)) {
                        numContato = i;
                        aux2 = 1;
                        Console.Clear();
                    }
                }
                if (aux2 != 1 && numContato == -1) {
                    Console.WriteLine("\n Não existe Contato para ser Alterado !\n");
                }
                else {
                    do {
                        Console.WriteLine("\n O que deseja Alterar ? ");
                        Console.WriteLine("\n 1- Alterar Nome ");
                        Console.WriteLine(" 2- Alterar Numero");
                        Console.WriteLine(" 3- Alterar E-mail");
                        Console.WriteLine(" 4- Sair");
                        Console.WriteLine(" -- -- -- -- --");
                        Console.Write(" Opção:  ");
                        int opcao = Convert.ToInt32(Console.ReadLine());
                        switch (opcao) {
                            case 1:
                                Console.Write("\n Novo Nome :  ");
                                contatos.ElementAt(numContato).nome = Console.ReadLine();
                                Console.WriteLine("\n Alteração Realizada ! \n");
                                break;
                            case 2:
                                Console.Write("\n Novo Numero :  ");
                                contatos.ElementAt(numContato).numero = Console.ReadLine();
                                Console.WriteLine("\n Alteração Realizada ! \n");
                                break;
                            case 3:
                                Console.Write("\n Novo E-mail :  ");
                                contatos.ElementAt(numContato).email = Console.ReadLine();
                                Console.WriteLine("\n Alteração Realizada ! \n");
                                break;
                            case 4:
                                Console.WriteLine("\n Alteração Finalizada ! \n");
                                aux1 = 1;
                                break;
                            default:
                                Console.WriteLine("\n Entrada Invalida ! \n");
                                break;
                        }
                    } while (aux1 != 1);
                }
            }
            else {
                Console.WriteLine("\n Não existe Contato para ser Alterado !\n");
            }
        }
        public void bscContato() {
            if (contatos.Any()) {
                int aux = 0, numContato = 0;
                Console.WriteLine("\n -- Buscar Contato -- !\n");
                Console.Write("\n Nome :  ");
                String nome = Console.ReadLine();
                for (int i = 0; i < contatos.Count(); i++) {
                    if (contatos.ElementAt(i).nome.Equals(nome)) {
                        numContato = i;
                        aux = 1;
                    }
                }
                if (aux == 1) {
                    Console.WriteLine("\n\n -- Contato " + (numContato + 1) + "--");
                    Console.WriteLine(" Nome:" + contatos.ElementAt(numContato).getNome());
                    Console.WriteLine(" Email:" + contatos.ElementAt(numContato).getEmail());
                    Console.WriteLine(" Numero:" + contatos.ElementAt(numContato).getNumero());
                    Console.WriteLine(" -- -- -- --\n");
                }
                else {
                    Console.WriteLine("\n Não existe Contato com esse Nome !\n");
                }

            }
            else {
                Console.WriteLine("\n Não existe Contatos a ser Exibidos !\n");
            }
        }

        public void listarContatos() {
            if (contatos.Any()) {
                for (int i = 0; i < contatos.Count(); i++) {
                    Console.WriteLine("\n\n -- Contato " + (i + 1) + "--");
                    Console.WriteLine(" Nome:" + contatos.ElementAt(i).getNome());
                    Console.WriteLine(" Email:" + contatos.ElementAt(i).getEmail());
                    Console.WriteLine(" Numero:" + contatos.ElementAt(i).getNumero());
                    Console.WriteLine(" -- -- -- --\n");
                }
            }
            else {
                Console.WriteLine("\n Não existe Contatos a ser Exibidos !\n");
            }
        }

        public void modoNavegacao() {
            if (contatos.Any()) {
                int i = 0, aux = 0;
                ConsoleKeyInfo tecla;
                Console.Clear();
                do {
                    Console.WriteLine("\n             -- Modo Navegação -- \n");
                    Console.WriteLine("\n\n         -- -- --  Contato " + (i + 1) + " -- -- -- -- --");
                    Console.WriteLine("            Nome:   " + contatos.ElementAt(i).getNome());
                    Console.WriteLine("            Email:  " + contatos.ElementAt(i).getEmail());
                    Console.WriteLine("            Numero: " + contatos.ElementAt(i).getNumero());
                    Console.WriteLine("         -- -- -- --  -- -- --  -- -- -- -- \n");
                    Console.WriteLine("\n                  - Legenda - \n");
                    Console.WriteLine("\n Esquerda:  <- ou A      Direita:  -> ou D      Sair:  X");
                    Console.WriteLine("\n               -- -- -- -- -- -- -- --\n");
                    Console.Write("                Opcao : ");
                    tecla = Console.ReadKey();
                    if (tecla.Key == ConsoleKey.LeftArrow || tecla.Key == ConsoleKey.A) {
                        if (i != 0) {
                            Console.Clear();
                            i--;
                        }
                        else {
                            Console.Clear();
                            Console.WriteLine("\n\n     * Não Existe Mais Contatos Para Esquerda ! *\n\n");
                        }
                    }
                    if (tecla.Key == ConsoleKey.RightArrow || tecla.Key == ConsoleKey.D) {
                        if (i < (contatos.Count() - 1)) {
                            Console.Clear();
                            i++;
                        }
                        else {
                            Console.Clear();
                            Console.WriteLine("\n\n     * Não Existe Mais Contatos Para Direita ! * \n");
                        }
                    }
                    if (tecla.Key == ConsoleKey.X) {
                        Console.Clear();
                        aux = 1;
                    }
                } while (aux != 1);
            }
            else {
                Console.WriteLine("\n Não existe Contatos a ser Exibidos !\n");
            }
        }

        public void ordenarPorNome() {
            if (contatos.Any()) {
                int tamanho = contatos.Count();
                for (int ii = 0; ii < tamanho - 1; ii++) {
                    for (int j = 0; j < tamanho - 1 - ii; j++) {
                        if (contatos.ElementAt(j).nome.CompareTo(contatos.ElementAt(j + 1).nome) > 0) {
                            Contatos aux = contatos[j];
                            contatos[j] = contatos[j + 1];
                            contatos[j + 1] = aux;
                        }
                    }
                }
                Console.WriteLine("\n Ordenação Finalizada !\n");
            }
            else {
                Console.WriteLine("\n Não existe Contatos a ser Ordenados !\n");
            }
        }

        public void ordenarPorEmail() {
            if (contatos.Any()) {
                int tamanho = contatos.Count();
                for (int ii = 0; ii < tamanho - 1; ii++) {
                    for (int j = 0; j < tamanho - 1 - ii; j++) {
                        if (contatos.ElementAt(j).email.CompareTo(contatos.ElementAt(j + 1).email) > 0) {
                            Contatos aux = contatos[j];
                            contatos[j] = contatos[j + 1];
                            contatos[j + 1] = aux;
                        }
                    }
                }
                Console.WriteLine("\n Ordenação Finalizada !\n");
            }
            else {
                Console.WriteLine("\n Não existe Contatos a ser Ordenados !\n");
            }
        }

        public String getNome() {
            return this.nome;
        }

        public void setNome(String nome) {
            this.nome = nome;
        }

        public String getNumero() {
            return this.numero;
        }

        public void setNumero(String numero) {
            this.numero = numero;
        }

        public String getEmail() {
            return this.email;
        }

        public void setEmail(String email) {
            this.email = email;
        }

        public List<Contatos> getLista() {
            return contatos;
        }

    }
}
