


Public Module Sample1



    ''' <summary>
    ''' Este exemplo usa Aggregate para multiplicar os números em execução na matriz.
    ''' 
    ''' Saída:
    '''     Multiplicação de todos os números 88.33081
    ''' </summary>
    Public Sub MethodSyntaxExample()
        Dim doubles = {1.7, 2.3, 1.9, 4.1, 2.9}

        'Dim product = doubles.Aggregate(Function(runningProduct, nextFactor) runningProduct * nextFactor)
        Dim product = doubles.Aggregate(Function(runningProduct, nextFactor) Agregar(runningProduct, nextFactor))

        Console.WriteLine($"Multiplicação de todos os números: {product}")
    End Sub


    Public Function Agregar(runningProduct, nextFactor) As Double

        Console.WriteLine("runningProduct = " & runningProduct.ToString())
        Console.WriteLine("nextFactor = " & nextFactor.ToString())
        Console.WriteLine("runningProduct * nextFactor = " & (runningProduct * nextFactor).ToString)
        Console.WriteLine("")

        Return runningProduct * nextFactor

    End Function

End Module
