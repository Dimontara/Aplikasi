Public Class form3
    Public list As New List(Of String)(New String() {"teuku ridho abdullah", "fitrah akbar"})
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            ListBox1.Visible = False
            ListBox1.Items.Clear()
        Else
            ListBox1.Visible = True
            For i As Integer = 0 To list.Count - 1
                If list.Item(i).ToLower.Contains(TextBox1.Text.ToLower) Then
                    If Not ListBox1.Items.Contains(list.Item(i)) Then
                        ListBox1.Items.Add(list.Item(i))
                    End If
                ElseIf ListBox1.Items.Contains(list.Item(i)) Then
                    ListBox1.Items.Remove(list.Item(i))
                End If
            Next
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If Not ListBox1.Visible Then
            Exit Sub
        End If
        If e.KeyData = Keys.Down Then
            If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Else
                ListBox1.SelectedIndex = 0
            End If
        ElseIf e.KeyData = Keys.Up Then
            If ListBox1.SelectedIndex > 0 Then
                ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            Else
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        ListBox1.Visible = False
        If TextBox1.Text <> "" And Not list.[Select](Function(x) x.ToLower()).ToList().Contains(TextBox1.Text) Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyData = Keys.Tab And ListBox1.SelectedIndex >= 0 Then
            TextBox1.Text = ListBox1.SelectedItem()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        If ListBox1.Visible = False Then
            ListBox1.Visible = True
            For i As Integer = 0 To list.Count - 1
                ListBox1.Items.Add(list.Item(i))
            Next
        Else
            ListBox1.Visible = False
        End If
    End Sub

    Private Sub testt(sender As Object, e As EventArgs)
        MsgBox("boi")

    End Sub

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler TextBox1.Leave, AddressOf testt
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

    End Sub
End Class