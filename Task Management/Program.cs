using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management
{
    class TaskManager
    {
        // Lista para armazenar as tarefas
        List<string> tasks = new List<string>();

        // Método principal que inicia a execução do programa
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager(); // Cria uma instância da classe TaskManager
            taskManager.Run(); // Inicia o programa chamando o método Run()
        }

        // Método para exibir o menu e gerenciar as opções do usuário
        void Run()
        {
            while (true)
            {
                // Exibe o menu de opções
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Ver Tarefas");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string choice = Console.ReadLine();

                // Verifica a escolha do usuário e chama o método correspondente
                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        Environment.Exit(0); // Sai do programa
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        // Método para adicionar uma nova tarefa à lista de tarefas
        void AddTask()
        {
            Console.Write("Digite a tarefa: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Tarefa adicionada com sucesso.");
        }

        // Método para exibir todas as tarefas presentes na lista
        void ViewTasks()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }

}
