Imports System.Runtime.CompilerServices

Public Class LinqData
    'For you to understand LINQ you NEED to understand IEnumerable and IEnumerable(of T)
    'IEnumerable:https://msdn.microsoft.com/en-us/library/system.collections.ienumerable(v=vs.110).aspx
    'IEnumerable(of T):https://msdn.microsoft.com/en-us/library/9eekhta0(v=vs.110).aspx

    'Notice MSDN uses c# syntax:IEnumerable<T> is IEnumerable(of T) and you pronounce it that way
    'Basic LINQ query actions:https://msdn.microsoft.com/en-us/library/bb384504.aspx

    Private Shared nums As IEnumerable(Of Integer) = Enumerable.Range(1, 50)

    Public Class EvenData
        'Simple class that defines the structure of a projection
        Property IsEven As Boolean
        Property Number As Integer
    End Class
    Shared Function BeforeLinqIsEven() As List(Of EvenData)
        'Generate list of 50 numbers from 1 through 50
        '1*********
        Dim tmp As New List(Of Integer)
        For x As Integer = 1 To 50
            tmp.Add(x)
        Next
        '/1*********
        'Same result as 1
        'Dim tmp2 = Enumerable.Range(1, 50).ToList

        'Create the result projection from the list of numbers
        '2*********
        Dim result As New List(Of EvenData)
        For Each n In tmp
            result.Add(New EvenData With {.IsEven = n Mod 2 = 0, .Number = n})
        Next
        '/2*********
        Return result

    End Function
    Shared Function IsEven() As IEnumerable(Of EvenData)
        Static count As Integer = 0
        count += 1

        'Query vs lambda:https://msdn.microsoft.com/en-us/library/mt692789.aspx

        If count Mod 2 = 0 Then
            'Lambda syntax
            'https://msdn.microsoft.com/en-us/library/bb531253.aspx

            Return nums.Select(Function(n) New EvenData With {
                               .IsEven = n Mod 2 = 0,
                               .Number = n})
        Else
            'query syntax

            Return From n In nums
                   Select New EvenData With {
                       .IsEven = n Mod 2 = 0,
                       .Number = n}
        End If

    End Function

    Shared Function XLinq() As XElement

        'Generates a linq to xml object.
        '<numbers>
        '    <number IsEven="?">number from nums</number>
        '    ...
        '</numbers>
        'Notice that I am composing LINQ ienumerables.
        'IsEven returns a projection on nums then this function projects the xelement.
        'LINQ is lazy.  As in it won't process until needed.
        'I defined nums it goes 1, 2,...50
        'IsEven goes through those numbers and returns instances of EvenData.
        'This function goes through those EvenData objects and creates an xelement object.
        'All this processing is done when requested and not when it is defined.
        Return <numbers>
                   <%= IsEven.Select(Function(n) <number IsEven=<%= n.IsEven %>>
                                                     <%= n.Number %>
                                                 </number>)
                   %>
               </numbers>
    End Function

    Shared Function GetRandomNumbers() As IEnumerable(Of Integer)
        'will more than likely contain duplicates and will not contain all numbers
        Dim rand As New Random

        Return From n In nums Select rand.Next(nums.Min, nums.Max + 1)

    End Function

    Shared Function GetDistintRandom() As IEnumerable(Of Integer)
        Return nums.GetRandomOrder
    End Function

End Class
Module Extensions
    <Extension>
    Iterator Function GetRandomOrder(Of t)(items As IEnumerable(Of t)) As IEnumerable(Of t)
        'iterator functions will return an ienumerable that lets you write a custom linq function
        'https://msdn.microsoft.com/en-us/library/hh156569.aspx
        Dim rand As New Random
        Dim tmp = items.ToList

        For x As Integer = 0 To items.Count - 1
            Dim index As Integer = rand.Next(tmp.Count)
            Yield tmp(index)
            tmp.RemoveAt(index)

        Next
    End Function
End Module
