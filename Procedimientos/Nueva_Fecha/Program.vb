Imports System

'Crear un proyecto y un m�dulo 
'llamado �Nueva_fecha� con una funci�n que 
'reciba un valor fecha y un valor entero 
'que representa una cantidad de d�as y retorne a 
'la fecha sumada la cantidad de d�as. En el m�dulo 
'principal ingresar una fecha y la cantidad de d�as, 
'invocar a la funci�n creada y mostrar el valor obtenido

Module Nueva_Fecha

    Sub Main(args As String())

        Dim fecha As Date
        Dim dias As Byte


        Console.WriteLine("Ingrese una fecha (dd/mm/aa): ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese una fecha (dd/mm/aa): ")
        dias = Console.ReadLine()

        Console.WriteLine("Nueva fecha: " & OperacionFecha(fecha, dias))

    End Sub

    Function OperacionFecha(fecha As Date, dias As Byte) As String

        fecha = fecha.AddDays(dias)

        Return (fecha)

    End Function

End Module
