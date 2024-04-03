# Análise da Solução

## Diagrama de classes

## Projeto da Base de Dados

Para a persistência dos dados da aplicação aqui desenvolvida, optou-se por utilizar a solução pay-as-you-go do banco de dados SQL da Azure Cloud. Desse modo, foi criado um Servidor Flexível do Banco de Dados do Azure para MySQL, hospedado na região East US e com capacidade total de armazenamento de 20 GB. Optou-se por utilizar o modelo de banco de dados relacional devido à solidez estrutural que o mesmo proporciona, permitindo uma modelagem de dados mais segura e didática; ademais, o modelo SQL é amplamente utilizado nos tempos atuais, o que ocasiona também em uma maior quantidade de materiais e documentações disponíveis para consulta e auxílio durante o processo do desenvolvimento.

### Diagrama entidade-relacionamento

Segue abaixo o diagrama entidade-relacionamento relativo à estrutura da base de dados utilizada.

![Diagrama Entidade Relacionamento](https://assets.digitalocean.com/articles/alligator/boo.svg "Diagrama ER")