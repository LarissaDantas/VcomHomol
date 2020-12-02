#language: pt-BR

@Chrome
Funcionalidade: VComCalc


Esquema do Cenario: Acessar o VcomCalc
	Dado que eu acesso o VComCalc Sistemas
	Então é apresentada as versões dos sistemas <Versao>

	Exemplos: 
	  | Versao           |
	  | "1.00.201023.01" |

Esquema do Cenario: Emissão de boleto à vista (com impressão)
	Dado que eu acesso o VcomCalc com cliente negociavel
	E realizo uma negociação a vista <Data>
	Então e apresentado com sucesso o boleto para impressao

	Exemplos: 
	  | Data         |
	  | "02/12/2020" |

#Cenario: Emissão de boleto parcelado (com impressão)
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  escolho o modo de pagamento parcelado
#	E seleciono se haverá ou não entrada, a quantidade de parcelas e periodicidade
#	Quando clico no botão "Pronto, finalize esta negociação"
#	Então  clico em visualizar 
#	E  assim imprimo o boleto
#
#	
#Cenario: Envio de boleto por e-mail
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  escolho o modo de pagamento
#	Quando clico no botão "Pronto, finalize esta negociação"
#	Então  clico no botão "e-mail"
#	E seleciono o e-mail já cadastrado ou insiro outro
#	Então clico em enviar e recebo a mensagem de sucesso
#
#	
#Cenario: Envio de boleto por SMS
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  escolho o modo de pagamento
#	Quando clico no botão "Pronto, finalize esta negociação"
#	Então clico no botão "SMS"
#	E seleciono o número cadastrado ou insiro outro
#	E escolho o tipo de serviço e o tipo de mensagem
#	Então clico em "enviar agora" e recebo a mensagem de sucesso
#
#Cenario: Listar últimas negociações
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  clico em "+detalhes" no canto inferior direito da tela
#	E encontro a listagem de negociações
#
#
#Cenario: Reimpressão de boleto
#    Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  clico em "+detalhes" no canto inferior direito da tela
#	E clico no ícone de expansão do lado esquerdo do número do contrato
#	Então clico em "opções"
#	E assim clico em reimprimir e reimprimo com sucesso
#
#
#Cenario: Cancelamento de boleto
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  clico em "+detalhes" no canto inferior direito da tela
#	E clico no ícone de expansão do lado esquerdo do número do contrato
#	Então clico em "opções"
#	E assim clico em "cancelar" e cancelo com sucesso o boleto
#	
#
#Cenario: Estorno de parcelamento
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  clico no ícone de expansão do lado superior direito
#	E clico em "cancelar negociação"
#	Então insiro o motivo e confirmo
#
#
#Cenario: Gravação de cálculo
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  escolho o modo de pagamento
#	E clico no botão expansivo ao lado direito de "Pronto, finalize esta negociação"
#	Então clico em "Apenas grave essa negociação"
#	Então  gravo com sucesso e posso conferir em "+detalhes"
#
#Esquema do Cenario: Emissão de boleto de cálculo gravado
#	Dado que gravei um cálculo
#	Quando clico "+detalhes"
#	E clico em "opções"
#	Então clico em emitir
#	E então emiti com sucesso o boleto
#	
#
#Esquema do Cenário:  Abertura de cálculo gravado
#	Dado que gravei um cálculo
#	Quando clico "+detalhes"
#	E clico em "opções"
#	Então clico em "abrir"
#	E assim abro com sucesso o cálculo
#
#
#Esquema do Cenário: Cancelamento de cálculo gravado
#	Dado que gravei um cálculo
#	Quando clico "+detalhes"
#	E clico em "opções"
#	Então clico em "cancelar" e confirmo
#	E assim cancelo com sucesso
#
#Cenário: Recebimento
#	Dado que esteja com perfil logado com cliente pesquisado via <CPF>, <Contrato> ou <Nome>
#	E com o contrato devido selecionado
#	Então  escolho o modo de pagamento
#	E clico no botão expansivo ao lado direito de "Pronto, finalize esta negociação"
#	Então clico em "receba o pagamento por esta negociação"
#	E escolho a forma de pagamento
#	E insiro os dados do pagamento
#	Então confirmo o pagamento
#	E o pagamento é confirmado com sucesso
