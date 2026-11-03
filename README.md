<h1 align="center">UraniaQuest</h1>
<p align="center">
  <b>Challenge FIAP 2026 | AMAZUL | 2TDSPA</b>
</p>

---

### 🌎 Nossa ideia

Quando ouvimos falar em energia nuclear, muitas vezes pensamos em acidentes, radiação e tragédias. Esses riscos são reais e não devem ser ignorados.

Mas será que conhecemos tudo o que a ciência nuclear pode oferecer?

Ela também está presente na medicina, na conservação de alimentos, na indústria, nas pesquisas científicas e na geração de energia.

Foi dessa reflexão que surgiu o **UraniaQuest**, nossa proposta de jogo educativo.

Imagine um mundo em crise, com regiões destruídas e problemas que precisam ser resolvidos. O jogador terá a missão de ajudar a recuperar esses lugares, mas sua principal ferramenta será o **conhecimento**.

Por meio de missões, baús com informações científicas e quizzes, ele descobrirá aplicações da tecnologia nuclear. A cada desafio, aprenderá algo novo e ajudará a transformar o cenário.

As informações serão baseadas em fontes científicas confiáveis, como a CNEN e a AIEA.

> **Nossa ideia é simples: mostrar os riscos sem esconder os benefícios, porque a informação pode transformar a forma como enxergamos o mundo.**

---

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

---

### ▶️ Como executar?

Para executar a aplicação, é necessário ter o **Visual Studio** com suporte ao desenvolvimento em C# e o **.NET 8** instalado.

1. Baixe ou clone o repositório do projeto.
2. Abra o projeto `UraniaQuest.Solucoes` no Visual Studio.
3. Utilize **`Ctrl + Shift + B`** para compilar o projeto e verificar possíveis erros.
4. Após a compilação, pressione **`Ctrl + F5`** para executar a aplicação sem depuração.
5. No menu, escolha a opção desejada para cadastrar, listar ou pesquisar soluções científicas.
6. Para encerrar o programa, digite `0`.

---

### 🔍 Como o .NET contribui para o UraniaQuest?

O .NET nos permitiu desenvolver uma das primeiras funcionalidades do projeto: organizar e consultar informações sobre soluções científicas.

Nesta Sprint, trabalhamos com classes, objetos, listas, métodos, validações, tratamento de erros e persistência em JSON.

O sistema ainda funciona pelo terminal e não está integrado ao jogo. Nossa intenção é aproveitar esse conhecimento nas próximas etapas, quando começarmos a desenvolver as missões e os conteúdos educativos.

---

### 🛠️ Tecnologias utilizadas

<p align="left">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt
