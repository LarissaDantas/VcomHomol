#language: pt-BR
#Larissa

@Chrome
Funcionalidade: VcomCob

Cenario: Acessar VcomCob
	Dado que eu acesso o VcomCob
	E informo usuario e senha
	Entao e realizado o login com sucesso

Cenario: Pesquisar cliente por Nome na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por nome
	Então encontro o nome com sucesso na ficha de cliente

Cenario: Pesquisar cliente CPF na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por CPF
	Então encontro o CPF com sucesso na ficha de cliente

Cenario: Pesquisar cliente por Contrato na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por contrato
	Então encontro o contrato com sucesso na ficha de cliente
		
Cenario: Pesquisar cliente por Complemento do Contrato na Ficha de Cliente
	Dado que esteja logado
	E realizo uma busca de cliente por complemento do contrato
	Então encontro o complemento do contrato com sucesso na ficha de cliente

Cenario: Pesquisar cliente por Nosso Numero
	Dado que esteja logado
	E realizo uma busca de cliente por Nosso Numero
	Então encontro o Nosso Numero com sucesso na ficha de cliente

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