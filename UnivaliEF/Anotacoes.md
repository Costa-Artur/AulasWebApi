# AULA ENTITY FRAMEWORK

## Instalando o Entity

dotnet tool install --global dotnet-ef

instala

dotnet ef --version
 
verifica a versão

## EntityFrameworkCore.Tools

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.4

Habilita as migrations que precisa para o Banco de Dados

## NoWarn

<NoWarn> 

Desativa alguns avisos que podem aparecer

## Migrações

dotnet ef migrations add {"Nome da Migração"}

Adiciona uma migração, cria um arquivo snapshot na pasta migrations que é criado uma vez e atualiza conforme vai dando migrations novas

dotnet ef database update

Atualiza o banco de dados depois de fazer uma migração

## Deletar o banco e criar novamente

_context.Database.EnsureDeleted();
_context.Database.Migrate();

## AddRange

Adiciona uma lista inteira de uma vez

Não aumenta performance no postgres, porém no sqlserver melhora performance
Por isso SqlServer é melhor
