# Especificação do Projeto

## Perfis de Usuários

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

1. Lucas Oliveira
   
Idade: 28 anos

Ocupação: Desenvolvedor de software

Aplicativos: Reddit, GitHub, Twitch, Spotify

Motivações: Lucas é um entusiasta de Dungeons and Dragons há anos e está sempre em busca de novas maneiras de aprimorar suas sessões de jogo.

Frustrações: Ele fica frustrado quando precisa interromper o jogo para procurar uma magia específica em um livro físico, o que quebra o ritmo e a imersão da experiência.

Hobbies, História: Participa ativamente de fóruns de discussão sobre RPG e segue streamers que jogam Dungeons and Dragons no Twitch para aprender novas estratégias e ideias para suas próprias sessões de jogo.

3. Mariana Santos
   
Idade: 22 anos

Ocupação: Estudante universitária de artes visuais

Aplicativos: Tumblr, Discord, YouTube, Instagram

Motivações: Mariana valoriza a praticidade e a acessibilidade em suas atividades de lazer, e busca uma maneira conveniente de acessar as informações necessárias durante suas sessões de jogo.

Frustrações: Como uma estudante ocupada, ela prefere soluções práticas e digitais que se integrem facilmente ao seu estilo de vida movimentado.

Hobbies, História: Ela costuma jogar Dungeons and Dragons com seus amigos como uma forma de estimular sua criatividade e imaginação.

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO... `QUEM`   | QUERO/PRECISO ... `O QUE` |PARA ... `PORQUE`                 |
|--------------------|---------------------------|----------------------------------|
| Lucas Oliveira | uma aplicação que me permita acessar rapidamente informações sobre magias de Dungeons and Dragons durante minhas sessões de jogo. | manter o ritmo e a imersão da experiência sem interrupções, garantindo que minhas aventuras sejam fluidas e envolventes. |
| Mariana Santos | poder salvar minhas magias favoritas ou mais utilizadas na aplicação. | criar uma biblioteca personalizada de magias que se alinham ao conceito dos meus personagens e facilitar o acesso durante as sessões de jogo, tornando minha experiência mais prática e personalizada. |
| Lucas Oliveira | uma funcionalidade de busca intuitiva que me permita encontrar magias específicas por nome ou classe. | experimentar novas estratégias e mecânicas de jogo sem perder tempo procurando em um livro físico, mantendo-me atualizado e engajado com o universo de D&D. |
| Mariana Santos | uma funcionalidade na aplicação que me permita filtrar as magias por tema ou efeito. | encontrar facilmente magias que se encaixem no clima ou enredo da minha campanha atual de Dungeons and Dragons, tornando minhas histórias mais coesas e imersivas. |

## Requisitos do Projeto

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição                | Prioridade |
|-------|---------------------------------|----|
| RF-01 | O site deverá apresentar uma lista interativa com todas as magias de D&D, previamente ordenadas, dispostas em cards informativos | Alta | 
| RF-02 | O site deverá permitir a filtragem das magias de acordo com a classe do personagem | Alta |
| RF-03 | O site deverá permitir a filtragem das magias de acordo com o nível da magia | Alta |
| RF-04 | O site deverá permitir a adição de magias favoritas do usuário | Alta |
| RF-05 | O site deverá permitir a filtragem de acordo com as magias favoritas de um usuário | Alta |
| RF-06 | O site deverá permitir o compartilhamento de uma lista de magias favoritas | Média |
| RF-07 | O site deverá permitir o cadastro de usuários | Média |
| RF-08 | O site deverá permitir o login de usuários cadastrados | Média |
| RF-09 | O site deverá permitir a exclusão de uma conta cadastrada | Baixa |
| RF-10 | O site deverá permitir a recuperação de senha | Baixa |

### Requisitos não funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID      | Descrição               |Prioridade |
|--------|-------------------------|----|
| RNF-01 | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | Alta | 
| RNF-02 | O site deverá ser responsivo permitindo a visualização em um celular de forma adequada | Alta | 
| RNF-03 | O site deve ter bom nível de contraste entre os elementos da tela em conformidade  | Média | 
| RNF-04 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) | Alta | 
| RNF-05 | O site deverá ter um back-end desenvolvido através do ecossistema  .NET | Média | 
| RNF-06 | O site deverá ter um front-end desenvolvido através do ecossistema Javascript | Baixa | 
| RNF-07 | O site deverá persistir as suas informações em um banco de dados provido em nuvem pela Azure | Alta | 

### Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID      | Descrição               |
|--------|-------------------------|
| RE-01 | O projeto deverá ser entregue no final do semestre letivo (eixo 2). |
| RE-02 | A equipe não pode subcontratar o desenvolvimento do trabalho. |
| RE-03 | O gerenciamento do desenvolvimento se dará através da metodologia SCRUM |
| RE-04 | O site não deverá ter anúncios ou ser monetizado |
