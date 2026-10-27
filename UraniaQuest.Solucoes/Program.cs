
using UraniaQuest.Solucoes.Models;

List<SolucaoCientifica> solucoes = new List<SolucaoCientifica>(); //Lista que guarda nossas soluções

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
            CadastrarSolucao();
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

    void CadastrarSolucao() //	Método responsável pelo cadastro
    {
        Console.WriteLine();
        Console.WriteLine("=== CADASTRO DE SOLUCAO CIENTIFICA ===");

        Console.Write("Codigo: ");

        if (!int.TryParse(Console.ReadLine(), out int codigo) || codigo <= 0)
        {
            Console.WriteLine("Codigo invalido!");
            return; //	Encerra o método quando encontra uma informação inválida
        }

        foreach (SolucaoCientifica item in solucoes) //	Percorre os registros para procurar um código repetido
        {
            if (item.Codigo == codigo)
            {
                Console.WriteLine("Ja existe uma solucao com esse codigo!");
                return;
            }
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine() ?? "";

        Console.Write("Problema: ");
        string problema = Console.ReadLine() ?? "";

        Console.Write("Aplicacao: ");
        string aplicacao = Console.ReadLine() ?? "";

        Console.Write("Instituicao: ");
        string instituicao = Console.ReadLine() ?? "";

        Console.Write("Referencia: ");
        string referencia = Console.ReadLine() ?? "";

        Console.Write("Link: ");
        string link = Console.ReadLine() ?? "";

        SolucaoCientifica novaSolucao = new SolucaoCientifica //Cria uma nova solução usando a classe
        {
            Codigo = codigo,
            Nome = nome,
            Categoria = categoria,
            Problema = problema,
            Aplicacao = aplicacao,
            Instituicao = instituicao,
            Referencia = referencia,
            Link = link
        };

        solucoes.Add(novaSolucao); //Adiciona o objeto à lista

        Console.WriteLine();
        Console.WriteLine("Solucao cadastrada com sucesso!");
    }

}
