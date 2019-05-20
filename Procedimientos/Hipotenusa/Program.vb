Imports System

Imports System.Math

'Crear un proyecto y un m�dulo llamado 
'�Hipotenusa� que implemente una funci�n 
'que reciba el tama�o de los lados A y B, 
'calcule y devuelva C (hipotenusa). Dados los 
'lados A y B de un tri�ngulo rect�ngulo, seg�n el 
'teorema de Pit�goras, el cuadrado de la hipotenusa 
'(C), es igual a la suma del cuadrado de los catetos 
'(lados) de lo que se da la siguiente f�rmula: c� = a� + b�. 
'Ingresar los valores por teclado y mostrar el resultado en consola

Module Hipotenusa

    Sub Main(args As String())

        Dim A, B As Single
        Console.WriteLine("Calculo de Hipotenusa" & vbCrLf)
        Console.WriteLine("Ingrese un Lado A: ")
        A = Console.ReadLine()
        Console.WriteLine("Ingre el lado B: ")
        B = Console.ReadLine()

        Console.WriteLine("Lado C (Hipotenusa) es: " & CalculoHipotenusa(A, B))

    End Sub

    Function CalculoHipotenusa(A, B)

        Dim C As Single

        ' C = sqrt((A^2) + (B^2))
        C = Sqrt(Pow(A, 2) + Pow(B, 2))

        Return (C)
    End Function

End Module
