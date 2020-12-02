#language: pt-BR
#Larissa

@Chrome
Funcionalidade: CobWeb

Cenário: Login CobWeb
    Dado que eu acesso o CobWeb
    E preencho usuario e senha
    Entao e realizado o logon com sucesso

Cenário: Pesquisar cliente por Nome
    Dado que eu esteja logado
    E realizo uma busca de cliente por nome
    Então encontro o nome do cliente com sucesso

#Cenário: Pesquisar cliente por ID
#    Dado que eu esteja logado
#    E realizo uma busca de cliente por ID <ID>
#    Então encontro o ID do cliente com sucesso <ID>
#
#Cenário: Pesquisar cliente por CPF/CNPJ
#    Dado que eu esteja logado
#    E realizo uma busca de cliente por CPF/CNPJ <CPFCNPJ>
#    Então encontro o CPF/CNPJ do cliente com sucesso <CPFCNPJ>
#
#Cenário: Pesquisar cliente por Contrato
#    Dado que eu esteja logado
#    E realizo uma busca de cliente por Contrato <Contrato>
#    Então encontro o Contrato do cliente com sucesso <Contrato>
#
#Cenário: Botão Próximo
#    Dado que esteja com perfil logado
#    E realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então  mudará o credor no menu
#
#Cenario: Cálculo à vista
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então clico no botão <próximo>
#    E seleciono um título à pagar
#    Então o cálculo à vista simulado aparece
#
#Cenário: Cálculo parcelado
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato> 
#    E seleciono um título à pagar
#    Então clico no combo de <opção>
#    E escolho o total de parcelas
#    Então o cálculo parcelado simulado aparece
#
#Cenário: Aplicação de descontos
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    E seleciono um título à pagar
#    Então  o sistema aponta o desconto disponível
#
#Cenário: Gravação de cálculo
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    E seleciono um título à pagar
#    E aplico algum tipo de cálculo (à vista/parcelado)
#    Então  clico no combo <operações>
#    E  seleciono <gravar cálculo - quitação>
#    Então  o sistema manda a mensagem de <Cálculo Registrado Com Sucesso>
#
#Cenário: Abertura de cálculo gravado
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então  clico no combo <operações>
#    E  seleciono <abrir cálculo>
#    Então acesso o cálculo gravado com sucesso
#
#Cenário: Geração de boleto (com impressão)
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    E seleciono um título à pagar
#    Entao e apresentado com sucesso
#
#Cenário: Listar boletos (Tela de Boletos)
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então a lista de boletos aparecerá
#
#Cenário: Inserção de ocorrência andamento
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então clico no botão <ocorrência>
#    E  insiro o credor na parte inferior do sistema
#    E  clico em <teste andamento>
#    Então  a inserção será feita com sucesso
#
#Cenário: Inserção de ocorrência Agendado
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então clico no botão <ocorrência>
#    E  insiro o credor na parte inferior do sistema
#    E  clico em <teste agendamento>
#    E insiro a data para simular
#    Então a inserção foi feita com sucesso
#
#Cenário: Inserção de ocorrências Nulo
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então clico no botão <ocorrência>
#    E  insiro o credor na parte inferior do sistema
#    E  clico em <teste nulo>
#    Então a inserção foi feita com sucesso
#
#Cenário: Inserção de serviço
#    Dado que realizo uma busca por cliente que tenha feito negociacao
#    Quando incluo um novo serviço
#    Então a ocorrência é realizada com sucesso
#
#Cenário: Aplicação de filtros
#    Dado que esteja com perfil logado
#    Quando realizo uma busca por <nome> , <id> , <CPF> ou <Contrato>
#    Então clico no combo <unidade de cobrança>
#    E insiro os filtros
#    Então  escolho uma aplicação e executo com sucesso
