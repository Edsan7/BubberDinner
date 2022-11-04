# Comandos usados

## Nova classlib
dotnet new classlib --framework net5.0 -n NomeDaClasslib

## Nova Api
dotnet new webapi --framework net5.0 -n NomeDaApi

## Nova solution
dotnet new sln -o BubberDinner

## Informações sobre a solution
more .\BubberDinner.sln

## Adicionar um projeto à uma solution
dotnet sln add nomeDaSolution.csproj

## Adicionar refêrencia a um projeto
dotnet add .\ProjetoQueRecebera  .\ProjetoDaReferência

## Compilar a solução (estar no diretório do arquivo .sln)
dotnet build

## Rodar um projeto da solução
dotnet run -- project ./projeto

## Adicionar um gitignore
dotnet new gitignore
