Imports NHibernate.Tool.hbm2ddl
Imports NHibernate.Criterion
Imports FluentNHibernate.Cfg
Imports FluentNHibernate.Cfg.Db
Imports FluentNHibernate.Mapping
Imports NHibernate
Imports NHibernate.Cfg

Module Module1
    Sub Main()


        'Dim sessionFactory = Fluently.Configure() _  
        '        .Mappings (AddressOf MapIt) _        [   
        '        .Database (Function() MsSqlConfiguration.MsSql2005.ConnectionString (AddressOf ConnectionProperties)) _
        '        .ExposeConfiguration (AddressOf BuildOurDatabase) _
        '        .BuildSessionFactory()


        Dim sessionFactory = Fluently.Configure() _
                .Mappings (AddressOf MapIt) _
                .Database (Function() MsSqlConfiguration.MsSql2005.ConnectionString (AddressOf ConnectionProperties)) _
                .ExposeConfiguration (AddressOf BuildOurDatabase) _
                .BuildSessionFactory()


        'Database Usage

        Using sessionObj As ISession = sessionFactory.OpenSession
            Using trx As ITransaction = sessionObj.BeginTransaction
                '

                'For index As Integer = 1 To 10
                '    Dim b As New Bab
                '    b.Name = "Param" + index.ToString()
                '    sessionObj.Save (b)
                'Next


                Dim criteria = sessionObj.CreateCriteria (Of Bab)
                'Querying 
                'crit.Add (Expression.Like ("Name", "P%"))
                
                criteria.Add(Expression.Ge("Id",5))

                

                Dim bb = criteria.List (Of Bab).First()

                'bb.Name = "Paramjit Raloowall"


                Console.WriteLine (bb.Name)
                Console.ReadLine()

                trx.Commit()

            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Build a Database for Us if Create is Called 
    ''' </summary>
    ''' <param name="config">NHibernate Configuration</param>
    ''' <remarks></remarks>
    Private Sub BuildOurDatabase (config As Configuration)
        Dim s As New SchemaExport (config)
        's.Create(False,True)
    End Sub

    ''' <summary>
    ''' Database Name, Server and Atleast trusted connection
    ''' </summary>
    ''' <param name="csb"></param>
    ''' <remarks></remarks>
    Private Sub ConnectionProperties (csb As MsSqlConnectionStringBuilder)
        csb.Database ("test")
        
        csb.Server (".")
        csb.TrustedConnection()
    End Sub

    ''' <summary>
    ''' Telling the fluent to
    ''' Find mapping in the same assembly as BabMap
    ''' 
    ''' </summary>
    ''' <param name="cfg"></param>
    ''' <remarks></remarks>
    Private Sub MapIt (ByVal cfg As MappingConfiguration)
        cfg.FluentMappings().AddFromAssemblyOf (Of BabMap)
    End Sub
End Module

Public Class Bab
    Private _name As String
    Private _id As Integer


    Public Property Name() As String
        Get
            Return _name
        End Get
        Set (ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set (ByVal value As Integer)
            _id = value
        End Set
    End Property
End Class

''' <summary>
''' Mapping Class for fluent To Use
''' 
''' </summary>
''' <remarks>Still needs more clarificatin of what happened here ?</remarks>
    Public Class BabMap
    Inherits ClassMap(Of Bab)

    Public Sub New
        Id (Function(o)o.Id) 'default is generator only for integers 
        Map(Function(o)o.Name) 'just property 
        [Not].LazyLoad

    End Sub
End Class
