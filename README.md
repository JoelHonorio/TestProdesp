<b><i>-Para clonar basta inserir o seguinte comando no CMD:<br/></i></b>
git clone -b master https://github.com/JoelHonorio/TestProdesp.git</i></b><br/><br/>

<b><i>-Configure a Connection string de acordo com seu usuário e senha na base de dados no arquivo "appsettings.Development.json" e "appsettings.json".</i></b><br/><br/>

<b><i>-Crie um banco chamado "Prodesp" na sua base de dados.</i></b><br/><br/>

<b><i>-Dentro da pasta Script-Migration, terá uma pasta dentro com o nome v1.0.0, contendo dentro dela os arquivos para preparar o banco de dados para a aplicação, executando-os de acordo com a seguencia ali representada pelos números a frente de cada arquivo.</i></b><br/><br/>

<b><i>-Feito estes passos a aplicação deverá já estar executando corretamente!.</i></b><br/><br/>

<b><i>Obs: Os Scripts foram criados a partir de Migrations executadas de acordo com os comando abaixo, e salvo na pasta "Script-Migration".</i></b><br/>
Add-Migration Initial -Verbose -Context ProdespDbContext, usando o projeto padrão "Prodesp.Dados"<br/>
Script-Migration -Context ProdespDbContext, também usando o projeto padrão "Prodesp.Dados"
