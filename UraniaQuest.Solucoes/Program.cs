
int opcao = -1; //	Cria uma variável para guardar a opção do usuário

while (opcao != 0) //Mantém o menu funcionando enquanto a pessoa não escolher sair
{
    Console.WriteLine(); //Exibe informações no console
    Console.WriteLine("====================================");
    Console.WriteLine("            URANIAQUEST");
    Console.WriteLine("  Gerenciamento de Solucoes Cientificas");
    Console.WriteLine("====================================");
    Console.WriteLine("1 - Cadastrar solucao cientifica");
    Console.WriteLine("2 - Listar solucoes cadastradas");
    Console.WriteLine("3 - Buscar solucoes por categoria");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("====================================");

    Console.Write("Escolha uma opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao)) //	Lê a informação digitada e 	Verifica se a pessoa digitou um número válido
    {
        Console.WriteLine("Digite um numero valido!");
        opcao = -1;
        continue; //Retorna ao início do laço para mostrar o menu novamente
    }

    switch (opcao) //Executa uma ação conforme a opção escolhida
    {
        case 1: //Representa cada opção do menu
            Console.WriteLine("Cadastro em desenvolvimento.");
            break; //Encerra aquele caso do switch

        case 2:
            Console.WriteLine("Listagem em desenvolvimento.");
            break;

        case 3:
            Console.WriteLine("Busca em desenvolvimento.");
            break;

        case 0:
            Console.WriteLine("Encerrando o UraniaQuest...");
            break;

        default:
            Console.WriteLine("Opcao invalida! Tente novamente.");
            break;
    }
}
