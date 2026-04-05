Algoritmo Act3_Lecc7_Inciso2_TipoDeTriangulo
	Definir a, b, c Como Real
    
    Escribir "Ingrese los tres ángulos:"
    Leer a, b, c
    
    Si a = b Y b = c Entonces
        Escribir "Equilátero"
    Sino
        Si a = b O a = c O b = c Entonces
            Escribir "Isósceles"
        Sino
            Escribir "Escaleno"
        FinSi
    FinSi
	
	
FinAlgoritmo
