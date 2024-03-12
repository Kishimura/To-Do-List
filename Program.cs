using System;
using System.Globalization;

namespace todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de Lista de Tarefas!");
            List<string> listaTarefas = new List<string>();
            string opcao = "";

            while (opcao != "e")
            {
                Console.WriteLine("\nO que você gostaria de fazer?");
                Console.WriteLine("Digite 1 para adicionar uma tarefa");
                Console.WriteLine("Digite 2 para remover uma tarefa");
                Console.WriteLine("Digite 3 para ver a lista");
                Console.WriteLine("Digite 'e' para sair\n");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Insira uma tarefa: ");
                    string tarefa = Console.ReadLine();
                    listaTarefas.Add(tarefa);
                    Console.WriteLine("a tarefa foi adicionada com sucesso à lista");

                } else if (opcao == "2") {
                    for (int i = 0; i < listaTarefas.Count; i++) {
                        Console.WriteLine(i + " : " + listaTarefas[i]);

                    }
                    Console.WriteLine("Entre com o número da tarefa que vocÊ deseja remover: ");
                    int numeroEntrada = Convert.ToInt32(Console.ReadLine());
                    listaTarefas.RemoveAt(numeroEntrada);

                } else if (opcao == "3") {
                    Console.WriteLine("Estas são as tarefas da lista. ");

                } else if (opcao == "e"){
                    Console.WriteLine("Você saiu!");
                    break;
                }
                else
                {

                }
                


            };
        }
    }
}