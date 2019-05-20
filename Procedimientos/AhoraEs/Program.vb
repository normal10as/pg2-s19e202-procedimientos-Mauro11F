Imports System

Imports System.DateTime

'Crear un proyecto y un módulo 
'llamado “AhoraEs” que imprima la fecha y 
'hora actual con sus respectivas leyendas 
'según los siguientes requerimientos  
'• Utilizar una sub para imprimir la fecha actual. 
'• Utilizar una function para obtener la hora actual. 
'• Llamar a los procedimientos desde el Main.

Module AhoraEs

    Sub Main(args As String())

        Fecha()
        Console.WriteLine("La Hora actual es: " & Hora())


    End Sub

    Sub Fecha()

        Console.WriteLine("Fecha actual: " & Now.Date)

    End Sub

    Function Hora() As String

        Return (Now.Hour & ":" & Now.Minute & ":" & Now.Second)

    End Function
End Module
