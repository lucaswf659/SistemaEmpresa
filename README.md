# SistemaEmpresa

O sistema é baseado em cadastros de empresas, fornecedores e a listagem com alguns filtros destes fornecedores de acordo com a empresa vinculada.

### Pré-requisitos

* VisualStudio
* SQL Server 

### Instalação

Executar o script ScriptsSistemaEmpresa.sql no SQL Server. 
Abrir o arquivo SistemaEmpresa.sln no VisualStudio. 
Na opção da Solution, ir na opção "Definir projeto de inicialização" e selecionar os projetos "SistemaAPI" e "SistemaFront" marcando-os como "Iniciar".
Clicar em "Iniciar" ou F5 para inicializar o projeto.
No projeto "SistemaDados", alterar a string de conexão de todos os métodos (o ideal é deixar essa configuração em Settings.Properties do projeto, será alterado futuramente). A string de conexão é obtida no SQL Server. 

### Implementações Futuras

* Criar um layout mais agradável
* Validações/máscaras em todos os campos
* Exclusão de empresas e fornecedores
* Paginação para mais registros
* Vínculo entre empresa/fornecedor de forma mais intuitiva

### Tecnologias

* AngularJS
* WebApi .Net Framework
* Bootstrap 4
* SQL Server

### Autoria

* Lucas Weber Figueiró - https://www.linkedin.com/in/lucas-weber-92252211b/
