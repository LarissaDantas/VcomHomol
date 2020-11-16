#language: pt-BR
#Larissa

@Chrome
Funcionalidade: VcomCob

Cenario: Acessar VcomCob
	Dado que eu acesso o VcomCob
	E informo usuario e senha
	Entao e realizado o login com sucesso

Esquema do Cenario: Pesquisar cliente por Nome na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por nome <Nome>
	Então encontro o nome com sucesso na ficha de cliente <Nome>

	Exemplos: 
		|  Nome						 |
		| "MARIA DA SILVA MIRANDA"   |

Esquema do Cenario: Pesquisar cliente CPF na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por CPF <CPF>
	Então encontro o CPF com sucesso na ficha de cliente <CPF>

	Exemplos: 
		|  CPF		      |
		| "94707570763"   |

Esquema do Cenario: Pesquisar cliente por Contrato na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por contrato <Contrato>
	Então encontro o contrato com sucesso na ficha de cliente <Contrato>

	Exemplos: 
		|  Contrato		      |
		| "001010106646001"   |	
		
Esquema do Cenario: Pesquisar cliente por Complemento do Contrato na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por complemento do contrato <CompContrato>
	Então encontro o complemento do contrato com sucesso na ficha de cliente <CompContrato>

	Exemplos: 
		|  CompContrato		 |
		| "01020201985000"   |

Esquema do Cenario: Pesquisar cliente por Nosso Numero
	Dado que esteja logado
	E realizo uma busca de cliente por Nosso Numero <NossoNumero>
	Então encontro o Nosso Numero com sucesso na ficha de cliente <NossoNumero>

	Exemplos: 
		|  NossoNumero		 |
		| "01020201985000"   |

Cenario: Acesso a tela Ficha do Cliente
	Dado que esteja logado
	E realizo uma busca com sucesso por um cliente
	Então e apresentado a tela de Ficha do Cliente

Cenario: Inserção de Serviço
	Dado que esteja logado
	E realizo uma busca com sucesso por um cliente
	Quando seleciono inserção de serviços
	E confirmo a inserção com todos os campos preenchidos
	Entao a insersão é criada com sucesso
	
Cenario: Aplicação de filtros
	Dado que esteja logado
	E seleciono a Opção de Aplicação de filtros
	E confirmo a Aplicação de filtros com todos os campos preenchidos
	Entao é criado o filtro com sucesso

Cenario: Aplicação de sequência
	Dado que esteja logado
	E seleciono a Opção de Aplicação de sequência
	E confirmo a Aplicação de sequência com todos os campos preenchidos
	Entao é criado a Aplicação de sequência com sucesso