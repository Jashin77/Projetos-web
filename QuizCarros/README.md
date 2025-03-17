# QuizCarros 🚗❓  

**QuizCarros** é um aplicativo web desenvolvido com **ASP.NET** que testa seus conhecimentos sobre o mundo dos carros. O quiz apresenta perguntas de múltipla escolha e exibe a pontuação ao final.  

## 📌 Funcionalidades  

- **Perguntas de múltipla escolha**: Cada questão tem quatro alternativas, com apenas uma correta.  
- **Pontuação automática**: O sistema calcula e exibe o resultado final.  
- **Interface responsiva**: Compatível com desktops e dispositivos móveis.  
- **Back-end em ASP.NET**: Gerenciamento das perguntas e lógica do quiz.  

## 🛠 Tecnologias Utilizadas  

- **ASP.NET Core**: Back-end e roteamento da aplicação.  
- **C#**: Lógica do servidor.  
- **Entity Framework**: Gerenciamento dos dados das perguntas.  
- **HTML, CSS, JavaScript**: Interface e interatividade do quiz.  

## 📂 Estrutura do Projeto  

- `Controllers/HomeController.cs` → Lógica do quiz e gerenciamento das perguntas.  
- `Models/Perguntas.cs` → Estrutura dos dados das perguntas.  
- `Views/Home/Index.cshtml` → Página principal do quiz.  
- `wwwroot/` → Arquivos estáticos (CSS, JS, imagens).  

## 🚀 Como Executar  

1. **Clone o repositório**:  
   ```bash
   git clone https://github.com/Jashin77/Projetos-web.git
2.Acesse o diretório do projeto:
   cd Projetos-web/QuizCarros

3.instale as dependências no cmd:
   dotnet restore

4. Execute o projeto no cmd:
   dotnet run
   
5.Acesse no navegador:
  O terminal mostrará algo como:
  Now listening on: http://localhost:5145
  Now listening on: https://localhost:7237
  
6. Acesse a URL exibida no terminal (por padrão, http://localhost:5145).

##📜 Licença

Este projeto está sob a licença MIT.
