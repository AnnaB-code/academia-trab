# Sistema de Login - Academia

## 📋 Descrição

Sistema de gerenciamento para academias desenvolvido com Xamarin Forms. Permite o cadastro, consulta, edição e exclusão de alunos, armazenando informações como nome, CPF, telefone, idade, modalidade e peso.

## ✨ Funcionalidades

- **Cadastro de Alunos**: Registre novos alunos com informações completas
- **Listagem de Alunos**: Visualize todos os alunos cadastrados
- **Pesquisa**: Busque alunos por nome
- **Edição**: Atualize informações dos alunos cadastrados
- **Exclusão**: Remova alunos do sistema
- **Gestão de Modalidades**: Categorize alunos por modalidade de treino

## 🚀 Tecnologias Utilizadas

- **Xamarin.Forms 5.0.0**: Framework multiplataforma para desenvolvimento mobile
- **SQLite**: Banco de dados local para armazenamento de informações
- **MySQL.Data 9.0.0**: Suporte para banco de dados MySQL
- **.NET Standard 2.0**: Compatibilidade entre plataformas

## 📱 Plataformas Suportadas

- Android
- UWP (Universal Windows Platform)

## 🏗️ Estrutura do Projeto

```
academia/
├── academia/               # Projeto principal (Xamarin.Forms)
│   ├── paginas/           # Páginas da aplicação
│   │   ├── Abertura.xaml
│   │   ├── inicial.xaml   # Cadastro de alunos
│   │   ├── lista.xaml     # Listagem de alunos
│   │   ├── pesquisar.xaml # Pesquisa de alunos
│   │   ├── editar.xaml    # Edição de alunos
│   │   ├── exclusao.xaml  # Exclusão de alunos
│   │   └── modalidade.xaml # Gerenciamento de modalidades
│   └── banco/             # Camada de dados
│       ├── Alunos.cs      # Modelo de dados
│       └── Banco_funcoes.cs # Funções do banco de dados
├── academia.Android/      # Projeto Android
└── academia.UWP/          # Projeto UWP (Windows)
```

## 💾 Modelo de Dados

### Aluno
- **Id**: Identificador único (chave primária)
- **Nome**: Nome completo do aluno
- **CPF**: Cadastro de Pessoa Física
- **Fone**: Telefone de contato
- **Idade**: Idade do aluno
- **Modalidade**: Tipo de atividade física
- **Peso**: Peso do aluno

## 🔧 Requisitos

- Visual Studio 2019 ou superior
- Xamarin instalado
- SDK do Android (para desenvolvimento Android)
- Windows 10 SDK (para desenvolvimento UWP)

## 📦 Pacotes NuGet

- `Xamarin.Forms` (v5.0.0.2196)
- `Xamarin.Essentials` (v1.7.0)
- `sqlite-net-pcl` (v1.9.172)
- `MySql.Data` (v9.0.0)

## 🛠️ Como Executar

1. Clone o repositório:
```bash
git clone https://github.com/AnnaBeatrizdc/Sistema-Login-Academia.git
```

2. Abra a solução no Visual Studio:
```bash
cd Sistema-Login-Academia
start academia.sln
```

3. Restaure os pacotes NuGet:
   - No Visual Studio, clique com o botão direito na solução
   - Selecione "Restaurar Pacotes NuGet"

4. Selecione o projeto de plataforma desejado (Android ou UWP) como projeto de inicialização

5. Execute o projeto (F5 ou Ctrl+F5)

## 📝 Uso

1. **Tela Inicial**: Cadastre um novo aluno preenchendo todos os campos
2. **Lista de Alunos**: Visualize todos os alunos cadastrados
3. **Pesquisar**: Use a busca para encontrar alunos específicos
4. **Editar**: Selecione um aluno para editar suas informações
5. **Excluir**: Remova alunos que não estão mais ativos

## 🗄️ Banco de Dados

O sistema utiliza SQLite como banco de dados local, armazenando os dados no dispositivo do usuário. O arquivo do banco de dados (`Alunos.db3`) é criado automaticamente na pasta de dados pessoais do aplicativo.

## 👥 Autor

Anna Beatriz

## 📄 Licença

Este projeto é de código aberto e está disponível para uso educacional e desenvolvimento.
