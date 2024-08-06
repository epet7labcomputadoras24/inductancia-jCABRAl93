Module Program
    Sub Main()
        Console.WriteLine("ingrese el valor de su inductor")
        Dim inductor As Double
        inductor = Console.ReadLine
        Console.WriteLine("ingrese el valo de la frecuencia")
        Dim frecuencia As Double
        frecuencia = Console.ReadLine
        Dim igual As Double
        igual = inductor * frecuencia * (2 * 3.1415)
        Console.WriteLine("el valor es igual a: " & igual)
    End Sub
End Module