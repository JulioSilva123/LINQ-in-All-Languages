Imports System.Linq
Imports System


Public Module Sample2

    ''' <summary>
    ''' 
    ''' Este exemplo usa Aggregate para criar um saldo de conta corrente 
    ''' que subtrai cada retirada do saldo inicial de 100, desde que o 
    ''' saldo nunca caia abaixo de 0.
    ''' 
    ''' Saída:
    ''' 
    ''' Balanço final: 20
    ''' </summary>
    Public Sub MethodSyntaxExample()

        Dim startBalance = 100.0

        Dim attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30}

        Dim endBalance = attemptedWithdrawals.Aggregate(startBalance, Function(balance, nextWithdrawal) If(nextWithdrawal <= balance, balance - nextWithdrawal, balance))
        'Dim endBalance = attemptedWithdrawals.Aggregate(startBalance, Agregar(balance, nextWithdrawal) ))



        Console.WriteLine($"Este exemplo usa Aggregate para criar um saldo 
de conta corrente que subtrai cada retirada do 
saldo inicial de 100, desde que o saldo nunca 
caia abaixo de 0.")
        Console.WriteLine("")
        Console.WriteLine($"Balanço final: {endBalance}")


    End Sub



    'Public Function Agregar(balance, nextWithdrawal) As Double


    '    Console.WriteLine("balance = " & balance.ToString())
    '    Console.WriteLine("nextWithdrawal = " & nextWithdrawal.ToString())
    '    If (nextWithdrawal <= balance) Then
    '        balance -= nextWithdrawal
    '        Console.WriteLine("balance * nextWithdrawal = " & (balance - nextWithdrawal).ToString)
    '    Else
    '        Console.WriteLine("balance = " & balance.ToString())
    '    End If

    '    Console.WriteLine("")

    '    Return balance

    'End Function


End Module

