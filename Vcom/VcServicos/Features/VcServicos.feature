#language: pt-BR

@Chrome
Funcionalidade: VcServicos


Esquema do Cenario: 01 - Acessar o VcServicos
	Dado que eu acesso o VComCalc Sistemas
	Então é apresentada as versões dos sistemas <Versao>

	Exemplos: 
	  | Versao           |
	  | "1.00.201202.01" |

Esquema do Cenario: 02 - Emissão de boleto à vista (com impressão)
	Dado que eu acesso o VcomCalc com cliente negociavel
	E realizo uma negociação a vista <Data>
	Então e apresentado com sucesso o boleto para impressao

	Exemplos: 
	  | Data         |
	  | "07/12/2020" |

Esquema do Cenario: 03 - Emissão de boleto parcelado (com impressão)
	Dado que eu acesso o VcomCalc com cliente negociavel
	E realizo uma negociação parcelado <Data>
	Então e apresentado com sucesso o boleto para impressao

	Exemplos: 
	  | Data         |
	  | "07/12/2020" |
	
Esquema do Cenario: 04 - Envio de boleto por e-mail
	Dado que eu acesso o VcomCalc com cliente negociavel
	E realizo uma negociação a vista <Data>
	Então e apresentado com sucesso o boleto para email

	Exemplos: 
	  | Data         |
	  | "07/12/2020" |
	
Esquema do Cenario: 05 - Envio de boleto por SMS
	Dado que eu acesso o VcomCalc com cliente negociavel
	E realizo uma negociação a vista <Data>
	Então e apresentado com sucesso o boleto para o sms

	Exemplos: 
	  | Data         |
	  | "07/12/2020" |

Cenario: 06 - Listar últimas negociações
	Dado que eu acesso o VcomCalc com cliente negociavel
	E clico em detalhes
	Então visualiso as ultimas negociaçoes

Cenario: 07 - Reimpressão de boleto
    Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono a opção de reimprimir
	Entao visualizo a reimpressão com sucesso

Cenario: 08 - Cancelamento de boleto
	Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono a opção de cancelar boletos
	Entao o boleto é cancelado com sucesso

Cenario: 09 - Gravação de cálculo
	Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono a opção de gravar negociação
	Então é gravado com sucesso

Cenario: 10 - Emissão de boleto de cálculo gravado
	Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono a opção de emitir boleto
	Entao visualizo a reimpressão com sucesso

Cenário: 11 - Abertura de cálculo gravado
	Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono abrir calculo gravado
	Entao visualizo a negociação em aberto

Cenário: 12 - Cancelamento de cálculo gravado
	Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono cancelamento de cálculo gravado
	Entao visualizo o cancelamento com sucesso

Cenário: 13 - Recebimento
	Dado que eu acesso o VcomCalc com cliente negociavel
	E seleciono a opção de recebimento
	Então e confirmado o recebimento
