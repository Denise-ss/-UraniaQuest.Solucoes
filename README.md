# UraniaQuest
**Challenge FIAP 2026 | AMAZUL | 2TDSPA**

### 🌎 Nossa ideia

Quando ouvimos falar em energia nuclear, muitas vezes pensamos em acidentes, radiação e tragédias. Esses riscos são reais e não devem ser ignorados.

Mas será que conhecemos tudo o que a ciência nuclear pode oferecer?

Ela também está presente na medicina, na conservação de alimentos, na indústria, nas pesquisas científicas e na geração de energia.

Foi dessa reflexão que surgiu o **UraniaQuest**, nossa proposta de jogo educativo.

Imagine um mundo em crise, com regiões destruídas e problemas que precisam ser resolvidos. O jogador terá a missão de ajudar a recuperar esses lugares, mas sua principal ferramenta será o **conhecimento**.

Por meio de missões, baús com informações científicas e quizzes, ele descobrirá aplicações da tecnologia nuclear. A cada desafio, aprenderá algo novo e ajudará a transformar o cenário.

As informações serão baseadas em fontes científicas confiáveis, como a CNEN e a AIEA.

**Nossa ideia é simples: mostrar os riscos sem esconder os benefícios, porque a informação pode transformar a forma como enxergamos o mundo.**

### 💻 O que desenvolvemos na Sprint 1 de .NET?

Para colocar em prática o que aprendemos nas aulas, desenvolvemos o **UraniaQuest.Solucoes**, uma aplicação de console em **C# com .NET 8**.

Como nosso jogo envolve problemas e soluções científicas, começamos criando um sistema para organizar essas informações.

O programa permite:

- **Cadastrar** soluções científicas, informando código, nome, categoria, problema, aplicação, instituição, referência e link.
- **Listar** as soluções cadastradas.
- **Buscar** soluções por categoria.
- **Validar** campos obrigatórios, códigos repetidos, categorias e links.
- **Salvar e recuperar** os registros em um arquivo JSON.
- **Tratar erros** relacionados à leitura e ao salvamento dos dados.

Organizamos o código utilizando a classe `SolucaoCientifica`, o `Program.cs` e a classe `RepositorioSolucoes`.

As soluções estão divididas nas cinco áreas do UraniaQuest: Alimentação, Saúde, Energia, Indústria e Amazônia Azul.

### ▶️ Como executar?

Para executar a aplicação, é necessário ter o **Visual Studio** com suporte ao desenvolvimento em C# e o **.NET 8** instalado.

1. Baixe ou clone o repositório do projeto.
2. Abra o projeto `UraniaQuest.Solucoes` no Visual Studio.
3. Utilize **`Ctrl + Shift + B`** para compilar o projeto e verificar possíveis erros.
4. Após a compilação, pressione **`Ctrl + F5`** para executar a aplicação sem depuração.
5. No menu, escolha a opção desejada para cadastrar, listar ou pesquisar soluções científicas.
6. Para encerrar o programa, digite `0`.

### 🔍 Como o .NET contribui para o UraniaQuest?

O .NET nos permitiu desenvolver uma das primeiras funcionalidades do projeto: organizar e consultar informações sobre soluções científicas.

Nesta Sprint, trabalhamos com classes, objetos, listas, métodos, validações, tratamento de erros e persistência em JSON.

O sistema ainda funciona pelo terminal e não está integrado ao jogo. Nossa intenção é aproveitar esse conhecimento nas próximas etapas, quando começarmos a desenvolver as missões e os conteúdos educativos.

### 🛠️ Tecnologias utilizadas

C# · .NET 8 · Visual Studio · JSON · Git · GitHub

### 👥 Nossa equipe

**Turma: 2TDSPA**

| Integrante | RM |
|---|---|
| Pedro Begali | 567478 |
| Lucas Dudena | 567600 |
| Karen Cardoso | 566870 |
| Denise Santos | 567559 |

### 💙 Nosso propósito

Estamos apenas começando, mas já conseguimos transformar parte da nossa ideia em uma aplicação funcional.

Queremos que o UraniaQuest seja mais do que um jogo de perguntas e respostas. Queremos despertar a curiosidade e mostrar que aprender também pode ser uma aventura.

**UraniaQuest — explorar, aprender e transformar! 🌎🚀**