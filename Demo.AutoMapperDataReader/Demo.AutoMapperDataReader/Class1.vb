Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports AutoMapper
Imports System.Collections.Generic

Public Class TestTheDrMapping

    Public Sub Bob()
        Mapper.CreateMap(Of IDataReader, jobmst)()
        Mapper.AssertConfigurationIsValid()


        Dim csb As New SqlConnectionStringBuilder
        csb.DataSource = "."
        csb.InitialCatalog = "Admiral"
        csb.IntegratedSecurity = True
        Using conn = New SqlConnection(csb.ConnectionString)
            conn.Open()

            Using cmd = conn.CreateCommand
                cmd.CommandText = "SELECT jobmst_id FROM jobmst"
                cmd.CommandType = CommandType.Text

                Using dr = cmd.ExecuteReader

                    '                    While dr.Read()
                    '                        Console.WriteLine(dr(0))
                    '                    End While

                    Dim x = Mapper.Map(Of IDataReader, IEnumerable(Of jobmst))(dr)


                    For Each author As jobmst In x
                        Console.WriteLine(author.jobmst_id)
                    Next

                End Using
            End Using
        End Using
    End Sub

    Public Sub Matt()
        Dim o As New One
        o.Name = "matt"
        o.Address = New Address
        o.Address.Number = "1"

        Mapper.CreateMap(Of One, Two)()
        Dim t = Mapper.Map(Of One, Two)(o)

        Console.WriteLine(t.Name)
        Console.WriteLine(t.AddressNumber)
    End Sub
End Class

Public Class jobmst
    Private _jobmstId As Integer

    Public Property jobmst_id() As Integer
        Get
            Return _jobmstId
        End Get
        Set(ByVal value As Integer)
            _jobmstId = value
        End Set
    End Property
End Class

Public Class One
    Public Name As String
    Public Address As Address
End Class
Public Class Two
    Public Name As String
    Public AddressNumber As String
End Class
Public Class Address
    Public Number As String
End Class
Public Interface Three
    Property Name() As String
End Interface