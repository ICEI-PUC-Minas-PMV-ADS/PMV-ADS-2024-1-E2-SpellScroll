# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

- O site deve ser publicado em um ambiente acessível publicamente na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

|     Caso de teste     | CT-01 – Acessar Informações                                                                                                                                                    |
| :-------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-01 - O site terá uma página apresentando uma lista interativa, disposta em cards informativos com todas as magias de D&D.                                                   |
|   Objetivo do Teste   | Verificar se a página está apresentando de forma correta e ordenada os cards informativos.                                                                                     |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar a URL INSERIRURL <br> 3) Visualizar a página principal <br> 4) Clicar em um dos cards informativos para ler os detalhes de cada magia  |
|  Critérios de Êxito   | Ao clicar no link o usuário deve poder visualizar a listagem e interagir com a mesma.                                                                                          |

|     Caso de teste     | CT-02 – Utilizar o filtro de pesquisa                                                                                                                                                                                                                                                                                                  |
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-02, RF-03, RF-05 - O site terá uma opção de filtragem na pesquisa das magias, definindo parâmetros como classe do personagem, nível da magia, dentre outros.                                                                                                                                                                           |
|   Objetivo do Teste   | Verificar se o filtro de pesquisa funciona de modo adequado.                                                                                                                                                                                                                                                                              |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar a URL INSERIRURL, clicar no campo "Pesquisar" e na opção "Filtro" <br> 3) Visualizar as opções de filtragem de pesquisa <br> 4) Selecionar as opções presentes de filtragem, e, após a seleção das opções, clicar no botão para aplicar os filtros com a seguinte descrição: "APLICAR FILTRO(S)". |
|  Critérios de Êxito   | Após o preenchimento das opções de filtragem, ao clicar no botão de aplicar, as opções de pesquisa retornadas devem ser correspondenes aos parâmetros selecionados no filtro.                                                                                                                                                             |

|     Caso de teste     | CT-03 – Realizar cadastro                                                                                                                                            |
| :-------------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-06 - O site deverá permitir o cadastro de usuários.                                                                                                               |  
|   Objetivo do Teste   | Verificar se o usuário consegue fazer cadastro no site                                                                                                               |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar a URL INSERIRURL <br> 3) Clicar em "Criar conta". <br> 4) Preencher os campos disponíveis <br> Clicar em "Criar minha conta" |
|  Critérios de Êxito   | Após os passos descritos, a conta é criada.                                                                                                                          |

|     Caso de teste     | CT-04 – Realizar loguin de usuários cadastrados                                                                                                               |
| :-------------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Requisitos Associados | RF-07 - O site deverá permitir o loguin de usuários cadastrados.                                                                                              |  
|   Objetivo do Teste   | Verificar se o usuário consegue fazer loguin no site                                                                                                          |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar a URL INSERIRURL <br> 3) Clicar em "Acessar conta". <br> 4) Preencher os campos disponíveis <br> Clicar em "Conectar" |
|  Critérios de Êxito   | Após os passos descritos, o usuário acessa sua conta cadastrada.                                                                                              |

|     Caso de teste     | CT-05 – Adicionar Lista de Favoritos                                                                                                                                                                                                                                    |
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-04 - O site deverá permitir a criação de uma lista de Favoritos.                                                                                                                                                                                                     |  
|   Objetivo do Teste   | Verificar se o usuário consegue criar e adicionar magiias em uma Lista de Favoritos                                                                                                                                                                                     |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar a URL INSERIRURL <br> 3) Visualizar a página principal <br> 4) Clicar em um dos cards informativos para ler os detalhes de cada magia <br> 5) Clicar no ícone de favoritos <br> 6) Selecionar a opção "ADICIONAR AOS FAVORITOS" |
|  Critérios de Êxito   | Após os passos descritos, a magia selecionada é adicionada a lista de favoritos.                                                                                                                                                                                        |

|     Caso de teste     | CT-06 – Acessar, Editar e Compartilhar Lista de Favoritos                                                                                                                                                                                                                   |
| :-------------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-08 - O site deverá permitir a compartilhação da Lista de Favoritos.                                                                                                                                                                                                      |  
|   Objetivo do Teste   | Verificar se o usuário consegue acessar e compartilhar a Lista de Favoritos                                                                                                                                                                                                 |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar a URL INSERIRURL <br> 3) Clicar em "Acessar conta". <br> 4) Preencher os campos disponíveis <br> Clicar em "Conectar" <br> 5) Clicar em "Favoritos" <br> 6) Clicar em "COMPARTILHAR" <br> 7) Selecionar a opção de compartilhamento |
|  Critérios de Êxito   | Após os passos descritos, a lista de favoritos selecionada é compartilhada.                                                                                                                                                                                                 |
