#language: pt-BR
#Larissa

@Chrome
Funcionalidade: Zaap

Cenario: Acessar o Zaap
	Dado que eu acesso o Zaap
	E esteja logado com perfil Operador
	E conecto em uma equipe
	Então estarei na pagina inicial do Operador

Esquema do Cenario: Pesquisar cliente por Nome
	Quando que esteja com perfil de operador
	E realizo uma busca por nome <nome>
	Então encontro o <nome> com sucesso

	Exemplos: 
		| nome						|
		| "LARISSA A DO NASCIMENTO" |


Esquema do Cenario: Pesquisar cliente por Código de Identificação
	Quando que esteja com perfil de operador
	E realizo uma busca por <Código de Identificação>
	Então encontro o <nome> com sucesso

	Exemplos: 
		| Código de Identificação | nome                                |
		| "22109"                 | "ALDENEIDE APARECIDA AMARANTE LIRA" |

Esquema do Cenario: Pesquisar cliente por Cpf/CNPJ
	Quando que esteja com perfil de operador
	E realizo uma busca por cpf <CPF>
	Então a pesquisa é realizada com sucesso
	

	Exemplos: 
		| CPF		     |
		| "2567929762"   |
		

Esquema do Cenario: Pesquisar cliente por Contrato
	Quando que esteja com perfil de operador
	E realizo uma busca por Contrato <Contrato>
	Então a pesquisa é realizada com sucesso

	Exemplos: 
		| Contrato		       |
		| "01PRE000886904 PRE" |

Esquema do Cenario: pesquisar cliente por complemento do contrato
	Quando que esteja com perfil de operador
	E realizo uma busca por ComplementoDoContrato <ComplementoDoContrato>
	Então a pesquisa é realizada com sucesso

	Exemplos: 
		| ComplementoDoContrato |
		| "15436906"            |

Esquema do Cenario: Pesquisar cliente por E-mail
Quando que esteja com perfil de operador
	E realizo uma busca por Email <Email>
	Então a pesquisa é realizada com sucesso

	Exemplos: 
		| Email						 |
		| "adriana.braga@teste.com"  |

Esquema do Cenario: Pesquisar cliente por Telefone
	Quando que esteja com perfil de operador
	E realizo uma busca por Telefone <Telefone>
	Então a pesquisa é realizada com sucesso

	Exemplos: 
		| Telefone	  |
		| "37541156"  |

Cenario: Inativar e-mail
	Dado que realizo uma busca por cliente
	Quando seleciono a opção de email inativo
	Então o email é inativado com sucesso


Cenário: Alterar Telefone
	Dado que realizo uma busca por cliente
	E seleciono a opção editar Telefone
	Quando incluo as informações que desejo alterar
	Então o Telefone é alterado com sucesso
	
Cenário: Acessar a tela de negociação
	Dado que realizo uma busca por cliente
	E seleciono cliente por Nome
	Então acesso a tela de negociação com sucesso

Cenário: listar boletos
	Dado que realizo uma busca por cliente que tenha feito negociacao
	Quando seleciono a opção boletos
	Então acesso a lista de boletos com sucesso

Cenário: Reimpressão de boleto
	Dado que realizo uma busca por cliente que tenha feito negociacao
	Quando seleciono a opção boletos
	Então a reimpressão é realizada com sucesso

Cenário: Inserção de ocorrência Nulo
	Dado que realizo uma busca por cliente que tenha feito negociacao
	Quando incluo uma nova ocorrência em Nulo
	Então a ocorrência é realizada com sucesso

Cenário: Inserção de ocorrência em Andamento
	Dado que realizo uma busca por cliente que tenha feito negociacao
	Quando incluo uma nova ocorrência em andamento
	Então a ocorrência é realizada com sucesso

Cenário: Inserção de ocorrência Agendado
	Dado que realizo uma busca por cliente que tenha feito negociacao
	Quando incluo uma nova ocorrência em agendamento
	Então a ocorrência é realizada com sucesso

Cenário: Inserção de serviço
	Dado que realizo uma busca por cliente que tenha feito negociacao
	Quando incluo um novo serviço
	Então a ocorrência é realizada com sucesso
