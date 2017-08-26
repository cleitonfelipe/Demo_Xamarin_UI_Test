#language: pt-BR
Funcionalidade: Funcionalidade
	Calcular(Somar) dois numero inteiros

@minhaTag
Cenário: Somar dois numeros
	Dado Que eu entro com o numero "10" na calculadora
	E Também entro com o numero "20" na calculadora
	Quando Eu dar um tap no botão Calcular
	Então O resultado deve ser "30"
