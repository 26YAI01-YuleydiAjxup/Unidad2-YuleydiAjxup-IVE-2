Algoritmo Act2_Lecc7_Inciso1_BuzónDeVoz
	Definir op Como Entero
    
    Escribir "BUZÓN DE VOZ"
    Escribir "1. Ventas"
    Escribir "2. Soporte técnico"
    Escribir "3. Atención al cliente"
    Escribir "4. Salir"
    Leer op
    
    Si op = 1 Entonces
        Escribir "Has seleccionado Ventas"
    Sino
        Si op = 2 Entonces
            Escribir "Has seleccionado Soporte técnico"
        Sino
            Si op = 3 Entonces
                Escribir "Has seleccionado Atención al cliente"
            Sino
                Si op = 4 Entonces
                    Escribir "Gracias por llamar"
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo
