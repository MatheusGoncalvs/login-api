Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Calcular Idade
	Given que a pessoa nasceu no ano 2000-01-01
	And o ano atual é 2021-01-01
	When o ano atual é subtraído pelo ano de nascimento
	Then o resultado deve ser igual a 21