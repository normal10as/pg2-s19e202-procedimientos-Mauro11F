Imports System

'Crear un proyecto y un módulo 
'llamado “Nueva_fecha” con una función que 
'reciba un valor fecha y un valor entero 
'que representa una cantidad de días y retorne a 
'la fecha sumada la cantidad de días. En el módulo 
'principal ingresar una fecha y la cantidad de días, 
'invocar a la función creada y mostrar el valor obtenido

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
