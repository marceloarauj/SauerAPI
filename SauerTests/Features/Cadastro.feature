Feature: Cadastro
	Permite o cadastro de usuário médico
	e retorna valores relativos ao perfil.
	O tipos de médico são:
	0- Médico
	1- Residente
	2- Professor

@mytag
Scenario: Criar um novo usuário no sistema 

	Given nome <nome>
	And tipo <tipo>
	And email <email>
	And login <login>
	And senha <senha>
	And crm <crm>
	When realizo o cadastro das informações no banco
	Then O retorno deve ser um perfil do tipo <nome_perfil>

Examples: 
	| nome         | tipo | email                   | login       | senha         | crm    | nome_perfil |
	| João marcos  | 0    | teste-teste@gotmail.com | medico123   | minhasenha123 | 123456 | Medico      |
	| Carla teste  | 1    | email2@test.com         | medico1234  | senha123      | 321654 | Residente   |
	| Usuario novo | 2    | teste-abc@teste.com     | medico12345 | senha1234     | 222333 | Professor   |