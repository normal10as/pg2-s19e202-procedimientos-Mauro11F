Imports System

'Crear un proyecto y un módulo llamado “Sumas” 
'que implementa una función sobrecargada capaz de 
'sumar dos, tres y cuatro valores de acuerdo al 
'número de argumentos que recibe. Invocarla desde 
'el módulo main probando las diferentes alternativas y 
'mostrando los resultados por consola. Ej.: sumar(5, 8)
'Minimizar la repetición de código

Module Sumas

    Public total As Integer

    Sub Main(args As String())

        Dim A, B, C, D As Integer

        A = 12
        B = 23
        C = 40
        D = 8

        Console.WriteLine("Dos valores sumados: {0} + {1} igual a {2} ", A, B, SobreCarga1(A, B))

        Console.WriteLine("Tres valores sumados: {0} + {1} + {2} igual a {3} ", A, B, C, SobreCarga2(A, B, C))

        Console.WriteLine("Cuatro valores sumados: {0} + {1} + {2} + {3} igual a {4} ", A, B, C, D, SobreCarga3(A, B, C, D))


    End Sub

    Function SobreCarga1(A As Integer, B As Integer) As String

        total = A + B

        Return (total)

    End Function

    Function SobreCarga2(A As Integer, B As Integer, C As Integer) As String

        total = A + B + C

        Return (total)

    End Function

    Function SobreCarga3(A As Integer, B As Integer, C As Integer, D As Integer) As String

        total = A + B + C + D

        Return (total)

    End Function

End Module
