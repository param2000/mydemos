'
Imports MbUnit.Framework

<TestFixture()> _
Public Class TestsForAccount
    <SetUp()> _
    Public Sub SetUp()
        Dim myAccount = New Account("1234")
    End Sub
    <Test()> _
    Public Sub CheckingEqualityBetweenAccounts()
        Dim accountNumber As String = "123"

        Dim loan As New Account(accountNumber)
        Assert.AreEqual(accountNumber, loan.AccountNumber)

    End Sub

    <Test()> _
    Public Sub TestingDepositReturnsTrueWhenSuccessfull()
        Dim accountNumber As String = "123"

        Dim loan As New Account(accountNumber)
        loan.Deposit(10)
        Assert.AreEqual(10, loan.Balance)
    End Sub

    <Test()> _
    Public Sub ValidatingICantWithdrawMoneyThanIHave()

        Dim accountNumber As String = "123"
        Dim loan As New Account(accountNumber)
        loan.Withdraw(10000)
        Assert.GreaterEqualThan(0, loan.Balance)

    End Sub

   
End Class
