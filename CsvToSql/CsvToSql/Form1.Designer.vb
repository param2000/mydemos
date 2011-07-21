<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCreate = New System.Windows.Forms.Button
        Me.txtFilePath = New System.Windows.Forms.TextBox
        Me.btnFindCsv = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtDisplayStatements = New System.Windows.Forms.TextBox
        Me.btnClipBoard = New System.Windows.Forms.Button
        Me.txtTable = New System.Windows.Forms.TextBox
        Me.lblTable = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTable)
        Me.Panel1.Controls.Add(Me.txtTable)
        Me.Panel1.Controls.Add(Me.btnClipBoard)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.txtFilePath)
        Me.Panel1.Controls.Add(Me.btnFindCsv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1242, 100)
        Me.Panel1.TabIndex = 0
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(13, 43)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(137, 23)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create Insert Statements"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(67, 15)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(821, 20)
        Me.txtFilePath.TabIndex = 1
        '
        'btnFindCsv
        '
        Me.btnFindCsv.Location = New System.Drawing.Point(13, 13)
        Me.btnFindCsv.Name = "btnFindCsv"
        Me.btnFindCsv.Size = New System.Drawing.Size(38, 23)
        Me.btnFindCsv.TabIndex = 0
        Me.btnFindCsv.Text = " ... "
        Me.btnFindCsv.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtDisplayStatements
        '
        Me.txtDisplayStatements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDisplayStatements.Location = New System.Drawing.Point(0, 100)
        Me.txtDisplayStatements.Multiline = True
        Me.txtDisplayStatements.Name = "txtDisplayStatements"
        Me.txtDisplayStatements.Size = New System.Drawing.Size(1242, 421)
        Me.txtDisplayStatements.TabIndex = 1
        '
        'btnClipBoard
        '
        Me.btnClipBoard.Location = New System.Drawing.Point(13, 73)
        Me.btnClipBoard.Name = "btnClipBoard"
        Me.btnClipBoard.Size = New System.Drawing.Size(137, 23)
        Me.btnClipBoard.TabIndex = 3
        Me.btnClipBoard.Text = "Save To Clipboard"
        Me.btnClipBoard.UseVisualStyleBackColor = True
        '
        'txtTable
        '
        Me.txtTable.Location = New System.Drawing.Point(301, 45)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(342, 20)
        Me.txtTable.TabIndex = 4
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(230, 45)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(65, 13)
        Me.lblTable.TabIndex = 5
        Me.lblTable.Text = "Table Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 521)
        Me.Controls.Add(Me.txtDisplayStatements)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Excel To Insert Statements"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFindCsv As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtDisplayStatements As System.Windows.Forms.TextBox
    Friend WithEvents btnClipBoard As System.Windows.Forms.Button
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents txtTable As System.Windows.Forms.TextBox

End Class
