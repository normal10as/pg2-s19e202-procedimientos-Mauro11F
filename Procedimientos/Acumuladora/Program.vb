Imports System

'Crear un proyecto y un módulo llamado “Acumuladora” 
'que implemente una subrutina que recibe un valor Decimal 
'y lo va acumulando. Invocar por lo menos tres veces la 
'subrutina desde el main y mostrar luego de cada llamada 
'mostrar el valor acumulado

Module Acululadora

    Public numero As Decimal

    Sub Main(args As String())

        Dim valor As Decimal

        Console.WriteLine("Ingrese eun valor: ")
        valor = Console.ReadLine()

        'primera invocacion
        ValorAcumulado(valor)

        'segunda invocacion
        ValorAcumulado(numero)

        'tercera invocacion
        ValorAcumulado(numero)

    End Sub

    Sub ValorAcumulado(valor As Decimal)

        numero = valor + valor
        Console.WriteLine("Valor acumulado: " & numero)

    End Sub

End Module
