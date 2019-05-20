Imports System
Imports System.Math

'Crear un proyecto y un módulo llamado
'“Potencias” que implemente una función 
'que retornará la primera vez que es invocada 
'el valor al cuadrado, la siguiente vez el valor 
'al cubo y así sucesivamente. Ingresar por teclado 
'un valor numérico y mostrar ese valor elevado a 
'la 2°, 3° y 5° potencias. Por ejemplo, ingresando 3 mostrar:  9, 27 y 243

Module Potencias

    Sub Main(args As String())

        Dim numero As Integer
        Dim potencia As Byte

        Console.WriteLine("Ingrese un numero: ")
        numero = Console.ReadLine()

        'primera invocacion
        potencia = 2
        Console.WriteLine("{0} elevado al cuadrado: {1}", numero, CalculoPotencia(numero, potencia))

        'segunda invocacion
        potencia += 1
        Console.WriteLine("{0} elevado al cubo: {1}", numero, CalculoPotencia(numero, potencia))

        'tercera invocacion
        potencia += 2
        Console.WriteLine("{0} elevado a la quinta potencia: {1}", numero, CalculoPotencia(numero, potencia))


    End Sub

    Function CalculoPotencia(numero, potencia)

        numero = Pow(numero, potencia)

        Return (numero)

    End Function

End Module
