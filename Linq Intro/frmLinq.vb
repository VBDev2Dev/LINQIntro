Imports System.Text

Public Class frmLinq

    Private Sub btnLinq_Click(sender As Object, e As EventArgs) Handles btnLinq.Click

        Select Case True
            Case optXElement.Checked
                Dim result As XElement = LinqData.XLinq

                Console.WriteLine(result.ToString)

                lstResults.DataSource = result.Nodes.ToList
            Case optRandom.Checked

                Dim result = LinqData.GetRandomNumbers.ToList
                lstResults.DataSource = result

                Console.WriteLine("Random")
                Console.WriteLine(GetCounts(result))

            Case optDistinctRandom.Checked

                Dim result = LinqData.GetDistintRandom.ToList
                lstResults.DataSource = result

                Console.WriteLine("Distinct Random")
                Console.WriteLine(GetCounts(result))
        End Select
    End Sub
    Function GetCounts(nums As IEnumerable(Of Integer)) As String

        Dim counts = From n In nums.ToList
                     Group By n Into tmp = Group
                     Order By tmp.Count Descending
                     Select New With {Key .Number = n, .Count = tmp.Count}

        Dim sb As New StringBuilder

        For Each n In counts
            sb.AppendLine($"Number:{n.Number} Count:{n.Count}")
        Next
        Return sb.ToString
    End Function
End Class
