# API de Dispositivos IoT

Esta é uma API para gerenciar dispositivos IoT e suas medições de chuva.

## Configuração do Banco de Dados

A API utiliza um banco de dados SQL Server para armazenar os dados dos dispositivos. Certifique-se de configurar corretamente a conexão com o banco de dados no arquivo `appsettings.json` antes de iniciar a API. 

```json
{
  "ConnectionStrings": {
    "PredictWeatherConnection": "Data Source=SQLEXPRESS;Initial Catalog=PredictWeather;User ID=usuario;password=senha;Encrypt=True;Trust Server Certificate=True"
  }
}
```

Substitua os valores em `"Data Source"`, `"Initial Catalog"`, `"User ID"` e `"password"` pelos detalhes de conexão do seu banco de dados SQL Server.

## Endpoints

### Dispositivos

#### Listagem de Dispositivos

- **Descrição**: Retorna uma lista contendo os identificadores dos dispositivos cadastrados na plataforma.
- **Verbo HTTP**: GET
- **Endpoint**: `/device`

#### Cadastro de Dispositivo

- **Descrição**: Cadastra um novo dispositivo na plataforma.
- **Verbo HTTP**: POST
- **Endpoint**: `/device`
- **Corpo da Requisição**: 
```json
{
  "Nome": "Nome do Dispositivo",
  "Fabricante": "Fabricante do Dispositivo",
  "Comando": "Comando do Dispositivo",
  "EnderecoIP": "Endereço IP do Dispositivo",
  "Porta": 1234
}
```

#### Detalhes do Dispositivo

- **Descrição**: Retorna os detalhes de um dispositivo específico.
- **Verbo HTTP**: GET
- **Endpoint**: `/device/{id}` (onde {id} é o identificador do dispositivo)

#### Atualização de Dispositivo

- **Descrição**: Atualiza os dados de um dispositivo existente.
- **Verbo HTTP**: PUT
- **Endpoint**: `/device/{id}` (onde {id} é o identificador do dispositivo)
- **Corpo da Requisição**: 
```json
{
  "Id": 1,
  "Nome": "Novo Nome do Dispositivo",
  "Fabricante": "Novo Fabricante do Dispositivo",
  "Comando": "Novo Comando do Dispositivo"
}
```

#### Remoção de Dispositivo

- **Descrição**: Remove os detalhes de um dispositivo.
- **Verbo HTTP**: DELETE
- **Endpoint**: `/device/{id}` (onde {id} é o identificador do dispositivo)

#### Listar Medições do Dispositivo

- **Descrição**: Lista medições de chuva dos dispositivos.
- **Verbo HTTP**: GET
- **Endpoint**: `/device/medicoes`

### Autenticação

#### Login

- **Descrição**: Faz login e recebe um token JWT de retorno.
- **Verbo HTTP**: POST
- **Endpoint**: `/Autenticacao/login`
- **Corpo da Requisição**: 
```json
{
  "Usuario": "nome_usuario",
  "Senha": "senha_usuario"
}
```

### Usuários

#### Criar Usuário

- **Descrição**: Cria um novo usuário.
- **Verbo HTTP**: POST
- **Endpoint**: `/usuario`
- **Corpo da Requisição**: 
```json
{
  "Nome": "Nome do Novo Usuário",
  "Senha": "Senha do Novo Usuário"
}
```

## Autenticação

Para acessar os endpoints que requerem autenticação, envie o token JWT recebido após o login no header `Authorization` da requisição, no formato `Bearer token_jwt`.

## Explicação de Decisões de Design e Implementação

### Padrão de Arquitetura MVC

Este projeto segue o padrão de arquitetura MVC (Model-View-Controller) para organizar os componentes da aplicação em camadas separadas de responsabilidade, facilitando a manutenção e escalabilidade do projeto.

### Padrão de Arquitetura DDD

Os componentes da aplicação são organizados de acordo com os princípios do Domain-Driven Design (DDD), proporcionando uma melhor modelagem do domínio do problema e uma arquitetura mais flexível e orientada ao negócio.

### Injeção de Dependência

Utilizamos a injeção de dependência para injetar as dependências necessárias nos controladores e serviços, tornando o código mais modular, testável e de fácil manutenção.

### Utilização do AutoMapper

Foi utilizado o AutoMapper para mapear os objetos de request e response para as entidades do domínio.

## Sugestões de Melhorias e Avanços Futuros

1. Implementar testes automatizados para garantir a qualidade e robustez do código.
2. Adicionar tratamento de erros mais robusto e consistente em toda a aplicação.
3. Implementar logging para registrar eventos e informações importantes da aplicação.

## Contribuindo

Sinta-se à vontade para contribuir com melhorias ou correções neste projeto. Basta enviar um pull request com suas alterações.
