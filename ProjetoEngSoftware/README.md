# instalar o cli do dotnet ef
dotnet tool install --global dotnet-ef

# Criar arquivo de migrations
dotnet ef migrations add Migrations --context Context

# Atualizar banco com as tabelas
dotnet ef database update --context Context

# Diretorios
-   Contexts possui uma classe que cria o contexto para acessar o banco de dados
-   Configurations possui arquivos gerais de configura��o como invers�o de controle,criptografia,token,etc 
-   Controllers possui as urls de acesso � api
-   DTO possui os objetos que transitam pela api , entrada do usu�rio e sa�das para o usuario
-   Entity � o mapeamento dos objetos da pasta Models para tabelas e relacionamentos do banco
-   Service � chamado pelos controllers, possui as regras de neg�cio e valida��es
-   Repositories � chamado pelas services, utiliza o contexts para acessar o banco e retornar dados   

# Trabalhando com asp net core fluent api
https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/fluent/relationships

