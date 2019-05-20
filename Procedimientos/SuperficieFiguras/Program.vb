Imports System

'Crear un proyecto y un módulo llamado 
'“SuperficieFiguras” para calcular la superficie 
'de una figura. Los valores se ingresan por consola 
'Usar una función sobrecargada para resolver el 
'área y según el número de parámetros será:

Module SuperficieFiguras

    Sub Main(args As String())

        Console.WriteLine("Area de un cuadrado de {0}m de lado = {1}", 4, AreaCuadrado(4))

        Console.WriteLine("Area de un rectangulo de {0}m * {1}m = {2}", 4, 2, AreaRectangulo(4, 2))

        Console.WriteLine("Area de un trapecio de {0} de base mayor, {1} de base menor y {2} de altura es = {3}", 8, 4, 6, AreaTrapecio(8, 4, 6))

    End Sub

    Function AreaCuadrado(valor As String)

        Return (valor * valor)

    End Function

    Function AreaRectangulo(valor1 As Integer, valor2 As Integer) As String

        Return (valor1 * valor2)

    End Function

    Function AreaTrapecio(Bmayor As Integer, Bmenor As Integer, H As Integer)

        Return (((Bmayor + Bmenor) / 2) * H)

    End Function
End Module
