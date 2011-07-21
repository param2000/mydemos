Imports System.IO
Imports System.Text

Public Class Form1
    Private _lines As String()
    'Private _delimiter As Char = "|"c
    Private _delimiter As Char = ","c

    Private Sub btnFindCsv_Click (ByVal sender As Object, ByVal e As EventArgs) Handles btnFindCsv.Click
        'Dim filePath As String = txtDir.Text
        txtDisplayStatements.Text = String.Empty

        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        txtFilePath.Text = OpenFileDialog1.FileName
    End Sub


    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreate.Click

        txtDisplayStatements.Text = String.Empty

        _lines = File.ReadAllLines(txtFilePath.Text)

        Dim tableName As String = txtTable.Text
        If String.IsNullOrEmpty(txtTable.Text) Then
            tableName = Path.GetFileNameWithoutExtension(txtFilePath.Text)
        End If

        Dim statements As StringBuilder = New StringBuilder

        Dim fields() As String = Split(_lines(0), _delimiter)

        For i As Integer = 1 To _lines.Length - 1
            'Dim statement As String = buildDataPortion(tableName, fields, Split(_lines(i), _delimiter))
            Dim statement As String = buildDataPortionEntirelyFromFile(tableName, fields, Split(_lines(i), _delimiter))
            statements.AppendFormat("{0} {1}", statement, Environment.NewLine)
        Next

        txtDisplayStatements.Text = statements.ToString

    End Sub

    Private Function buildDataPortion(ByVal tableName As String, ByVal fields() As String, ByVal data() As String) _
        As String
        Dim sb As StringBuilder = New StringBuilder
        sb.AppendFormat("INSERT INTO {0}", tableName)
        sb.Append("   ([CreatedBy]")
        sb.Append("   ,[CreatedOn]")
        sb.Append("   ,[UpdatedBy]")
        sb.Append("   ,[UpdatedOn]")
        sb.Append("   ,[UpdatedReason]")

        For Each field As String In fields
            If Not String.IsNullOrEmpty(field) Then
                sb.AppendFormat("   ,[{0}]", field)

            End If
        Next

        sb.Append(")  VALUES (")
        sb.Append("   'Intitial Load'")
        sb.Append("   ,getDate()")
        sb.Append("   ,''")
        sb.Append("   ,null")
        sb.Append("   ,''")

        For Each info As String In data
            If Not String.IsNullOrEmpty(info) Then
                sb.AppendFormat("    ,'{0}' ", info.Replace("'", "''"))
            End If
        Next

        sb.Append("   );")


        Return sb.ToString
    End Function

    Private Sub btnClipBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClipBoard.Click
        Clipboard.SetText(txtDisplayStatements.Text)
        MessageBox.Show("Saved to Clipboard", "Clipboard", MessageBoxButtons.OK)
    End Sub

    Private Sub lblTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTable.Click

    End Sub

    Private Function buildDataPortionEntirelyFromFile(ByVal tableName As String, ByVal fields() As String, ByVal data() As String) As String
        Dim sb As StringBuilder = New StringBuilder
        sb.AppendFormat("INSERT INTO {0}", tableName)
        sb.Append("(")
        'INSERT STATEMENT [Column Part]
        Dim firstCol As Boolean = True
        For Each field As String In fields
            If Not String.IsNullOrEmpty(field) Then
                If firstCol Then
                    firstCol = False
                    sb.AppendFormat("   [{0}]", field)
                Else
                    sb.AppendFormat("   ,[{0}]", field)
                End If
            End If
        Next

        sb = sb.Replace("""", "")


        'Values Part
        sb.Append(")  VALUES (")
        firstCol = True
        For Each info As String In data
            If Not String.IsNullOrEmpty(info) Then
                If firstCol Then
                    firstCol = False
                    sb.AppendFormat("  '{0}' ", info.Replace("'", "''"))
                Else
                    sb.AppendFormat("    ,'{0}' ", info.Replace("'", "''"))
                End If
            Else
                'Insert Null if empty Field 
                If firstCol Then
                    firstCol = False
                    sb.AppendFormat(" null ")
                Else
                    sb.AppendFormat(" ,null ")
                End If
            End If
        Next

        sb.Append("   );")


        Return sb.ToString
    End Function
End Class
