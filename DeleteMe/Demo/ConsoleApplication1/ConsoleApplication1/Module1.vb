


Module Module1
    Dim temp As Integer = 0


    Sub Main()

        'Dim myPerson As Person = New Person


        'For Each member In myPerson.GetType.GetMethods()
        '    'Console.WriteLine("Info : {0}", member.ToString())
        '    'Console.WriteLine("Number of parameters : {0}", member.GetParameters.Length)

        '    If member.GetParameters.Length = 0 Then
        '        Dim parameters(member.GetParameters.Length - 1) As Object
        '        Console.WriteLine("Calling {0}, {1}", member.Name, member.Invoke(myPerson, Nothing))
        '    End If
        'Next


        'For Each temp As PropertyInfo In myPerson.GetType.GetProperties()
        '    'Console.WriteLine("Property : {0}", temp.Name)
        'Next


        'Dim T As Type
        'T = GetType(Person)
        'Dim field As FieldInfo = T.GetField("Phone")
        'Dim newValue As Integer = 20

        'If field IsNot Nothing Then
        '    Console.WriteLine("Value " + field.GetValue(myPerson).ToString())

        '    field.SetValue(myPerson, 456)

        '    Console.WriteLine("Value " + field.GetValue(myPerson).ToString())
        'Else
        '    Console.WriteLine("nothing  ")
        'End If
        ''Dim person2 As Person = BuildInstance(Of Person)()


        ''Console.WriteLine(person2.NameInCapitalLetters())

        'Console.ReadLine()


        Dim steelflask As Flask(Of Steel) = New Flask(Of Steel)
        Dim clayflask As Flask(Of Clay) = New Flask(Of Clay)

        Console.WriteLine ("Steel Flask is made of of :{0}", steelflask.material._material)
        Console.WriteLine("Clay Flask is made of of :{0}", clayflask.material._material)

        Dim roundShapeR As RoundShape(Of Steel) = New RoundShape(Of Steel)

        steelflask.material = CType(roundShapeR.Mould, Steel)
        Console.WriteLine("Steel Flask is made of of :{0}", steelflask.material._material)

        Console.ReadLine()
        Console.WriteLine ("Something ")


    End Sub

    'public T BuildINstance <T>() 
    Public Function BuildInstance (Of T As IBob)() As T

        Dim type As Type = GetType (T)
        Dim someObj As T = CType (Activator.CreateInstance (type), T)


        'someObj.

        Return someObj
    End Function
End Module

Public Interface IBob
    Property Name() As String
End Interface
