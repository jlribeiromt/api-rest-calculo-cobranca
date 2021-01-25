# Desafio Técnico - Softplan
> Implementar duas API's, uma com dois endpoints e outra com um endpoint, sendo: 
> 1. Retorna taxa de juros: A API deve retornar a informação da taxa de juros, sendo ela no formato 1% ou 0,01 e a partir do endpoint "/taxaJuros".
> 2. Calcula Juros: A API deverá conter dois endpoints, um que cálcula juros (pelo endpoint "/calculajuros") e outro que retorna a url do projeto no github 
> (pelo endpoint "/showmethecode"). 

## Tecnologias usadas no projeto:
* ASP.NET Core 3.1
* .NET Core Native DI
* FluentValidator
* Versionamento de APIs
* Testes de unidade
* Swagger UI 

## Arquitetura:

* Arquitetura aplicada nos projetos, tem como preocupação na separação de responsabilidades e código limpo.
* Validação de entidades
* TDD 

------------

## Como instalar
**Antes de qualquer coisa, prepare o ambiente de desenvolvimento** 
* Instale o [Git](https://git-scm.com/downloads "git")
* Instale o [Docker](https://app.dbdesigner.net/signup "docker")
* Certifique-se também que as portas `5555`, `64978` e `1433` estão liberadas.
 
------------

## Executando o Projeto
* Faça um clone do projeto
* Acesse o mesmo
* Rode o comando docker.
 ```sh
git clone https://github.com/pablomorigi/ewave-livraria-senior.git
cd ewave-livraria-senior
docker-compose up --build
 ```

**Após a finalização do build, o link poderá ser acessado para front-end clicando [aqui](http://localhost:5555/ "front") e para o swagger clicando [aqui](http://localhost:64978/swagger/ "swagger")**


