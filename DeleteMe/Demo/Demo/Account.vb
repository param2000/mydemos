Imports System
Imports log4net
Public Class Account
    Private _accountNumber As String
    Private _balance As Integer
    Private Shared _logger As ILog = LogManager.GetLogger(GetType(Account))



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="accountNumber"></param>
    ''' <remarks></remarks>

    Public Sub New(ByVal accountNumber As String)
        _accountNumber = accountNumber
    End Sub

    Public ReadOnly Property AccountNumber() As String
        Get
            Return _accountNumber
        End Get
    End Property

    Public Property Balance() As Integer
        Get
            Return _balance
        End Get

        Set(ByVal amount As Integer)
            If amount <= 0 Then
                Throw New Exception("Invalid Amount")
            Else
                _balance = amount
            End If
        End Set
    End Property

    Public Sub Deposit(ByVal amountToDeposit As Integer)

        Balance += amountToDeposit

    End Sub

    Public Sub Withdraw(ByVal amountToWithdraw As Integer)

        If (IsValidWithdrawal(amountToWithdraw)) Then
            Balance -= amountToWithdraw
            _logger.Debug("Valid Transaction, amount added")
        Else
            _logger.Debug("Invalid Transaction nothing added")
        End If

    End Sub

    Private Function IsValidWithdrawal(ByVal amountToWithdraw As Integer) As Boolean

        Dim isValidTransaction As Boolean = False

        If (Balance - amountToWithdraw < 0) Then
            isValidTransaction = False
        Else
            isValidTransaction = True
        End If
        Return isValidTransaction
    End Function
End Class
