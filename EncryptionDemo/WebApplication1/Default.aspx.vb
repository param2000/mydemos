Imports System

Public Class _Default
    Inherits System.Web.UI.Page
    Private Const _myKey As String = "!#$Z54?@"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      

    End Sub

 
    Public Function encryptString(ByVal strToEncrypt As String) As String
        Dim oES As New Encryption64()
        Return oES.Encrypt(strToEncrypt, _myKey)
    End Function

    Public Function decryptString(ByVal strToDecrypt As String) As String
        Dim oES As New Encryption64
        Return oES.Decrypt(strToDecrypt, _myKey)
    End Function




    Protected Sub encrypt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles encrypt.Click
        Dim encryptedText = encryptString(txtInput.Text.Trim)
        lblOutput.Text = encryptedText
    End Sub

    Protected Sub decrypt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles decrypt.Click
        Dim decryptedText = decryptString(lblOutput.Text.Trim)
        lblInput.Text = decryptedText
    End Sub
End Class