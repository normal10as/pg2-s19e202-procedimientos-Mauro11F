Imports System

Imports System.Math


Module VolumenCilindro

    Sub Main(args As String())

        Dim Pi As Double = 3.14159265
        Dim R, H As Double

        Console.WriteLine("Calculo del Volumen de un cilindro" & vbCrLf)

        Console.WriteLine("Ingrese el Radio de la Base: ")
        R = Console.ReadLine()
        Console.WriteLine("A ver que pasa: " & R)
        Console.WriteLine("Ingrese la Altura del Cilindro (Metros): ")
        H = Console.ReadLine()
        Console.WriteLine("A ver que pasa: " & H)

        'Console.WriteLine("Elevado al cuadrado " & Pow(R, 2))

        Console.WriteLine("El Volumen calculado es: " & CalculoVolumen(Pi, R, H) & " Metros Cubicos")

    End Sub

    Function CalculoVolumen(Pi, R, H) As String

        Dim V As Double

        'Formula: calculo de volumen de un cilindro

        V = Pi * (Pow(R, 2)) * H

        Return (V)

    End Function

End Module
