Algoritmo Act2_Lecc21_Inciso2_BuzónDeVoz
	Definir op Como Entero
	
	Escribir "*Buzón de Voz*"
	Escribir "1. Ventas"
	Escribir "2. Recepción"
    Escribir "3. Dirección"
    Escribir "4. Compras"
    Leer op
	
	Si op = 1 Entonces
        Escribir "Bienvenido a Ventas"
        Escribir "Encargado: José - ventas@empresa.com"
    Sino
        Si op = 2 Entonces
            Escribir "Bienvenido a Recepción"
            Escribir "Encargado: María - recepcion@empresa.com"
        Sino
            Si op = 3 Entonces
                Escribir "Bienvenido a Dirección"
                Escribir "Encargado: Luis - direccion@empresa.com"
            Sino
                Si op = 4 Entonces
                    Escribir "Bienvenido a Compras"
                    Escribir "Encargado: Miguel - compras@empresa.com"
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo
