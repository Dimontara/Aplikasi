Public Class form2
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then
            ListBox1.Visible = False
            ListBox1.Items.Clear()
        Else
            ListBox1.Visible = True
            For i As Integer = 0 To ComboBox1.Items.Count - 1
                If ComboBox1.Items(i).ToString.ToLower.Contains(ComboBox1.Text.ToLower) Then
                    If Not ListBox1.Items.Contains(ComboBox1.Items(i)) Then
                        ListBox1.Items.Add(ComboBox1.Items(i))
                    End If
                ElseIf ListBox1.Items.Contains(ComboBox1.Items(i)) Then
                    ListBox1.Items.Remove(ComboBox1.Items(i))
                End If
            Next
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyData = Keys.Escape Then
            ComboBox1.SelectionStart = 1
            ComboBox1.SelectionLength = 1
        End If
    End Sub

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class