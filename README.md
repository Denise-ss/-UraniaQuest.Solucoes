# UraniaQuest — Challenge FIAP 2026 - 2TDSPA

## Sobre o nosso projeto

O **UraniaQuest** é um projeto que estamos desenvolvendo para o Challenge 2026 da FIAP, em parceria com a **AMAZUL**.

Nossa ideia é criar uma plataforma educativa em formato de jogo, para ensinar de maneira mais leve e interativa como a ciência e a tecnologia nuclear estão presentes em diferentes áreas da nossa vida.

Quando ouvimos falar sobre energia nuclear, muitas vezes pensamos apenas em usinas ou em situações de risco. Porém, existem diversas aplicações dessa tecnologia na medicina, na alimentação, na indústria, na pesquisa científica e em outras áreas importantes.

Foi pensando nisso que surgiu o UraniaQuest: queremos transformar esse conhecimento em uma aventura, na qual o jogador aprende enquanto ajuda a resolver problemas.

## Como imaginamos o UraniaQuest

Nossa proposta é desenvolver um jogo educativo com uma identidade visual jovem, inspirada em animações e jogos de aventura.

Nesse universo, diferentes regiões estão enfrentando problemas que precisam ser resolvidos com a ajuda da ciência.

O jogador poderá escolher um personagem e participar de missões para ajudar a recuperar essas regiões.

Ao longo da aventura, a ideia é que ele encontre baús com informações científicas, descubra soluções e responda perguntas relacionadas aos temas apresentados.

Quando uma resposta estiver correta, o jogador poderá avançar na missão. Quando estiver incorreta, queremos apresentar uma explicação para que ele entenda o assunto e tenha a oportunidade de aprender.

Nosso objetivo não é apenas criar perguntas e respostas, mas fazer com que o jogador compreenda por que aquela solução científica é importante.

## As cinco áreas do jogo

Organizamos o UraniaQuest em cinco áreas principais:

| Área | O que queremos apresentar |
|---|---|
| Alimentação e Agricultura | Aplicações da tecnologia nuclear na conservação de alimentos e na agricultura |
| Saúde e Medicina Nuclear | Utilização de tecnologias nucleares em exames, diagnósticos e tratamentos |
| Energia e Meio Ambiente | Produção de energia, pesquisas e aplicações relacionadas ao meio ambiente |
| Indústria, Pesquisa e Inovação | Uso da ciência nuclear em processos industriais e no desenvolvimento de tecnologias |
| Amazônia Azul e Defesa | Pesquisas e tecnologias relacionadas ao ambiente marítimo e à área de defesa |

Cada área terá seus próprios desafios e conteúdos educativos.

A proposta é que, conforme o jogador complete as missões, os cenários sejam recuperados aos poucos, mostrando visualmente o resultado das soluções encontradas.

## Qual é o objetivo do projeto?

Nosso principal objetivo é aproximar a ciência das pessoas, principalmente dos jovens.

Queremos mostrar que assuntos que parecem difíceis podem ser apresentados de uma forma mais simples, sem perder a importância das informações científicas.

Também queremos incentivar a curiosidade, a pesquisa e o aprendizado sobre aplicações pacíficas da tecnologia nuclear.

Para ajudar na confiabilidade do conteúdo, pretendemos utilizar referências de instituições científicas, como a CNEN e a AIEA, verificando as informações antes de utilizá-las no jogo.

## Nossa parte desenvolvida em .NET

Para a Sprint 1 de .NET, desenvolvemos uma aplicação de console em **C# utilizando .NET 8**, chamada `UraniaQuest.Solucoes`.

Escolhemos criar um sistema para gerenciar soluções científicas porque elas fazem parte da proposta principal do nosso jogo.

Por exemplo, quando o jogador encontrar uma solução durante uma missão, queremos que essa informação tenha relação com um problema, uma aplicação científica e uma fonte de referência.

Por isso, criamos um cadastro que organiza essas informações.

### O que o programa já faz?

Nesta primeira versão, conseguimos implementar:

1. Cadastro de soluções científicas.
2. Listagem das soluções cadastradas.
3. Pesquisa de soluções por categoria.
4. Validação dos campos obrigatórios.
5. Verificação de códigos repetidos.
6. Validação das cinco categorias do projeto.
7. Validação do formato dos links de referência.
8. Salvamento das informações em arquivo JSON.
9. Recuperação dos registros quando o programa é aberto novamente.
10. Tratamento de erros relacionados ao arquivo JSON.

O sistema funciona pelo console. Portanto, essa aplicação ainda não é a interface visual do jogo e não está integrada aos outros módulos.

Ela é uma parte do desenvolvimento que poderá apoiar o UraniaQuest nas próximas etapas.

## Como organizamos o código?

Utilizamos três arquivos principais:

### Program.cs

É onde desenvolvemos o menu e as funcionalidades utilizadas pelo usuário.

Nele também estão as validações e os métodos responsáveis pelo cadastro, listagem e pesquisa.

### Models/SolucaoCientifica.cs

Criamos essa classe para representar uma solução científica.

Cada solução possui as seguintes informações:

- Código
- Nome
- Categoria
- Problema
- Aplicação
- Instituição
- Referência
- Link

### Repositorios/RepositorioSolucoes.cs

Essa classe ficou responsável por salvar e carregar os dados em JSON.

Utilizamos o `System.Text.Json`, que já faz parte do .NET, sem precisar instalar bibliotecas adicionais.

## Como funciona o menu?

Quando executamos o projeto, aparecem as opções:

```text
====================================
            URANIAQUEST
  Gerenciamento de Solucoes Cientificas
====================================
1 - Cadastrar solucao cientifica
2 - Listar solucoes cadastradas
3 - Buscar solucoes por categoria
0 - Sair
====================================
```

Na opção **1**, podemos cadastrar uma nova solução.

Na opção **2**, conseguimos visualizar as soluções cadastradas.

Na opção **3**, pesquisamos as soluções por uma das categorias do UraniaQuest.

Na opção **0**, encerramos o programa.

## Regras e validações que implementamos

Durante o desenvolvimento, também trabalhamos com algumas regras para evitar informações incorretas.

O código de cada solução precisa ser um número positivo e não pode estar repetido.

Os campos de texto não podem ficar vazios.

As categorias precisam corresponder a uma das cinco áreas do UraniaQuest: `ALIMENTACAO`, `SAUDE`, `ENERGIA`, `INDUSTRIA` ou `AMAZONIA_AZUL`.

Também criamos uma validação para aceitar links que utilizem `http://` ou `https://`.

Essa última validação verifica o formato do endereço, mas não garante que o conteúdo do site seja verdadeiro. Por isso, a conferência das referências científicas continua sendo necessária.

## Como salvamos os dados?

No início, nosso programa armazenava as soluções apenas em uma lista, então perdíamos os registros sempre que fechávamos a aplicação.

Depois, implementamos o salvamento em JSON.

Agora, quando cadastramos uma solução, o programa salva as informações no arquivo `solucoes.json`.

Ao abrir novamente, ele tenta recuperar os registros anteriores.

O arquivo é criado na pasta de execução do programa, normalmente em:

```text
bin/Debug/net8.0/solucoes.json
```

Também implementamos tratamento de erros para situações em que o arquivo esteja vazio, corrompido ou não possa ser acessado.

## Testes que realizamos

Durante o desenvolvimento, testamos o funcionamento do menu, o cadastro, as validações, a listagem e a pesquisa por categoria.

Também fizemos testes específicos com o JSON.

Cadastramos uma solução, fechamos o programa e abrimos novamente para verificar se os dados continuavam salvos.

Em outro teste, alteramos propositalmente o conteúdo do JSON para simular um arquivo corrompido.

O programa identificou o problema, apresentou uma mensagem de erro e bloqueou novos cadastros para evitar a substituição dos dados.

Depois, restauramos a cópia original do arquivo e confirmamos que as informações podiam ser carregadas novamente.

Esses testes nos ajudaram a entender melhor a importância das validações, da persistência e do tratamento de exceções.

## Como executar o projeto .NET

Para executar esta parte do UraniaQuest, é necessário ter o Visual Studio com suporte ao desenvolvimento em C# e o .NET 8.

Passo a passo:

1. Baixar ou clonar o repositório do projeto.
2. Abrir a solução UraniaQuest no Visual Studio.
3. Selecionar o projeto `UraniaQuest.Solucoes`.
4. Compilar a aplicação.
5. Executar utilizando `Ctrl + F5`.
6. Utilizar as opções apresentadas no menu.

## Tecnologias utilizadas neste módulo

- C#
- .NET 8
- Visual Studio
- JSON
- Git
- GitHub

## O que pretendemos fazer nas próximas etapas?

Nossa intenção é continuar evoluindo o UraniaQuest e aproximar os diferentes módulos da proposta do jogo.

Queremos desenvolver a experiência visual das missões, trabalhar com os personagens, organizar as perguntas científicas e criar a dinâmica de recuperação das regiões.

Também pretendemos estudar como os sistemas desenvolvidos nas diferentes disciplinas poderão compartilhar informações.

A aplicação .NET que criamos nesta Sprint é uma das primeiras partes funcionais do projeto e poderá ser aprimorada conforme o UraniaQuest evoluir.

## Equipe

**FIAP — Challenge 2026 - 2TDSPA**

Projeto: **UraniaQuest**

- Pedro Begali - RM: 567478 
- Lucas Dudena - RM: 567600
- Karen Cardoso - RM: 566870
- Denise Santos - RM: 567559

## Considerações finais

Nesta primeira Sprint, conseguimos colocar em prática vários conteúdos que aprendemos durante as aulas de .NET, como classes, objetos, listas, métodos, validações, tratamento de exceções e persistência em JSON.

Mais do que criar um cadastro, procuramos desenvolver uma funcionalidade que tivesse sentido dentro da proposta do UraniaQuest.

Sabemos que ainda existem muitas etapas pela frente, principalmente na construção do jogo e na integração dos módulos, mas essa primeira entrega representa uma parte da base que estamos construindo para o projeto.