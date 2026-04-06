Algoritmo Act3_Lecc20_Inciso1_DíaDeLaSemana
	Definir dia Como Entero
	
	Escribir "Ingrese un número del 1 al 7:"
	Leer dia
    
    Si dia = 1 O dia = 7 Entonces
        Escribir "Fin de semana"
    Sino
        Si dia >= 2 Y dia <= 6 Entonces
            Escribir "Entre semana"
        Sino
            Escribir "Número inválido"
        FinSi
    FinSi
	
FinAlgoritmo
