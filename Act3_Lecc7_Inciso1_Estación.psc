Algoritmo Act3_Lecc7_Inciso1_Estacion
	Definir dia, mes Como Entero
	Escribir 'Ingrese el día:'
	Leer dia
	Escribir 'Ingrese el mes:'
	Leer mes
	Si (mes=12 Y dia>=21) O (mes=1) O (mes=2) O (mes=3 Y dia<21) Entonces
		Escribir 'Invierno'
	SiNo
		Si (mes=3 Y dia>=21) O (mes=4) O (mes=5) O (mes=6 Y dia<21) Entonces
			Escribir 'Primavera'
		SiNo
			Si (mes=6 Y dia>=21) O (mes=7) O (mes=8) O (mes=9 Y dia<21) Entonces
				Escribir 'Verano'
			SiNo
				Escribir 'Otoño'
			FinSi
		FinSi
	FinSi
FinAlgoritmo
