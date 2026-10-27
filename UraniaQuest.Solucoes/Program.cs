
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
            ListarSolucoes();
            break;

        case 3:
            BuscarSolucoesPorCategoria();
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

        string nome = LerCampoObrigatorio("Nome");

        string categoria = LerCampoObrigatorio("Categoria");

        string problema = LerCampoObrigatorio("Problema");

        string aplicacao = LerCampoObrigatorio("Aplicacao");

        string instituicao = LerCampoObrigatorio("Instituicao");

        string referencia = LerCampoObrigatorio("Referencia");

        string link = LerCampoObrigatorio("Link");


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

    void ListarSolucoes()  //Cria o método responsável pela listagem
    {
        Console.WriteLine();
        Console.WriteLine("=== SOLUCOES CIENTIFICAS CADASTRADAS ===");

        if (solucoes.Count == 0) //Conta quantas soluções existem na lista e Verifica se a lista está vazia
        {
            Console.WriteLine("Nenhuma solucao cadastrada.");
            return;
        }

        foreach (SolucaoCientifica item in solucoes) //	Percorre cada solução cadastrada
        {
            Console.WriteLine();
            Console.WriteLine($"Codigo: {item.Codigo}");
            Console.WriteLine($"Nome: {item.Nome}"); //Acessa o nome da solução atual
            Console.WriteLine($"Categoria: {item.Categoria}");
            Console.WriteLine($"Problema: {item.Problema}");
            Console.WriteLine($"Aplicacao: {item.Aplicacao}");
            Console.WriteLine($"Instituicao: {item.Instituicao}");
            Console.WriteLine($"Referencia: {item.Referencia}");
            Console.WriteLine($"Link: {item.Link}");
            Console.WriteLine("------------------------------------");
        }
    }

    void BuscarSolucoesPorCategoria()
    {
        Console.WriteLine();
        Console.WriteLine("=== BUSCAR SOLUCOES POR CATEGORIA ===");

        if (solucoes.Count == 0) //Verifica se existe alguma solução cadastrada
        {
            Console.WriteLine("Nenhuma solucao cadastrada.");
            return;
        }

        Console.Write("Digite a categoria: ");
        string categoriaBusca = (Console.ReadLine() ?? "").Trim(); //Lê a categoria digitada e trim. Remove espaços extras no início e no fim

        if (categoriaBusca == "")
        {
            Console.WriteLine("A categoria nao pode ficar vazia!");
            return;
        }

        bool encontrou = false; //Controla se alguma solução foi encontrada

        foreach (SolucaoCientifica item in solucoes)
        {
            if (item.Categoria.Trim().ToUpper() == categoriaBusca.ToUpper()) //Converte o texto para maiúsculas durante a comparação
            {
                Console.WriteLine();
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Categoria: {item.Categoria}");
                Console.WriteLine($"Problema: {item.Problema}");
                Console.WriteLine($"Aplicacao: {item.Aplicacao}");
                Console.WriteLine($"Instituicao: {item.Instituicao}");
                Console.WriteLine($"Referencia: {item.Referencia}");
                Console.WriteLine($"Link: {item.Link}");
                Console.WriteLine("------------------------------------");

                encontrou = true;
            }
        }

        if (!encontrou) //Mostra uma mensagem caso não encontre resultados
        {
            Console.WriteLine("Nenhuma solucao encontrada nessa categoria.");
        }
    }

    //Ele solicita uma informação e verifica se o usuário digitou algum conteúdo. Caso o campo esteja vazio, repete a pergunta até receber um valor.
    string LerCampoObrigatorio(string campo)
    {
        string valor = "";

        while (valor == "")
        {
            Console.Write($"{campo}: ");
            valor = (Console.ReadLine() ?? "").Trim();

            if (valor == "")
            {
                Console.WriteLine("Este campo nao pode ficar vazio!");
            }
        }

        return valor;
    }




}
