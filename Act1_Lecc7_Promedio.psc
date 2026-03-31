Algoritmo Act1_Lecc7_Inciso1_Promedio
	Definir num1, num2, num3, num4, num5, prom Como Real
	
	Escribir "Ingrese 5 notas"
	Leer num1, num2, num3, num4, num5
	
	prom = (num1 + num2 + num3 + num4 +num5)/5
	
	si Prom >= 70 Entonces
		Escribir "Aprobado"
	SiNo
		Escribir "Reprobado"
	FinSi
	
FinAlgoritmo
