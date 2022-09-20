Algoritmo ConversaoHorasEmMinutos //Gabriel Sanches - RA: 5929052190
Inicio
	Inteiro Horas, Minutos;
	Real HorasConvertidaMinutos;
	
	Escreva("Digite a quantidade de horas: ");
	Leia(Horas);
	
	Escreva("Digite a quantidade de minutos: ");
	Leia(Minutos);
	
	HorasConvertidaMinutos = (Horas * 60) + Minutos;
	
	Escreva("O total de minutos é " + HorasConvertidaMinutos);
	
Fim