Module MdlAutoComplete
    Private TextBox1 As TextBox
    Private ListBoxResult As ListBox
    Private list As List(Of String)

    Public Function autoComplete(TextBox_ As TextBox, isi As List(Of List(Of String)), control As Windows.Forms.Control.ControlCollection, index As Int16, Optional x As Int16 = 0, Optional y As Int16 = 0) As ListBox
        If x = 0 And y = 0 Then
            x = TextBox_.Location.X
            y = TextBox_.Location.Y
        End If
        ListBoxResult = New ListBox
        list = isi.Item(index)
        ListBoxResult.ItemHeight = 15
        ListBoxResult.Location = New System.Drawing.Point(x + 10, y + 20)
        ListBoxResult.Name = "ListBoxResult_" + TextBox_.Name
        ListBoxResult.Size = New System.Drawing.Size(152, 50)
        ListBoxResult.Visible = False
        ListBoxResult.TabIndex = 300
        ListBoxResult.TabStop = False
        TextBox1 = TextBox_
        AddHandler TextBox1.TextChanged, AddressOf TextBox1_TextChanged
        AddHandler TextBox1.KeyDown, AddressOf TextBox1_KeyDown
        AddHandler TextBox1.Leave, AddressOf TextBox1_Leave
        AddHandler TextBox1.PreviewKeyDown, AddressOf TextBox1_PreviewKeyDown
        AddHandler ListBoxResult.Leave, AddressOf ListBoxResult_Leave
        AddHandler ListBoxResult.Click, AddressOf ListBoxResult_Click
        control.Add(ListBoxResult)
        Return ListBoxResult
    End Function

    Public Sub removeAutoComplete(TextBox_ As TextBox, control As Windows.Forms.Control.ControlCollection)
        control.Remove(ListBoxResult)
        ListBoxResult = Nothing
        RemoveHandler TextBox_.TextChanged, AddressOf TextBox1_TextChanged
        RemoveHandler TextBox_.KeyDown, AddressOf TextBox1_KeyDown
        RemoveHandler TextBox_.Leave, AddressOf TextBox1_Leave
        RemoveHandler TextBox_.PreviewKeyDown, AddressOf TextBox1_PreviewKeyDown
    End Sub

    Public Function isAutoComplete(TextBox_ As TextBox, control As Windows.Forms.Control.ControlCollection) As Boolean
        If ListBoxResult Is Nothing Then
            'MsgBox("1")
            Return False
        ElseIf control.Contains(ListBoxResult) And ListBoxResult.Name.Equals("ListBoxResult_" + TextBox_.Name) Then
            'MsgBox("2")
            Return True
        End If
        'MsgBox("3")
        Return False
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Then
            ListBoxResult.Visible = False
            ListBoxResult.Items.Clear()
        Else
            ListBoxResult.Visible = True
            For i As Integer = 0 To list.Count - 1
                If list.Item(i).ToLower.Contains(TextBox1.Text.ToLower) Then
                    If Not ListBoxResult.Items.Contains(list.Item(i)) Then
                        ListBoxResult.Items.Add(list.Item(i))
                    End If
                ElseIf ListBoxResult.Items.Contains(list.Item(i)) Then
                    ListBoxResult.Items.Remove(list.Item(i))
                End If
            Next
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If ListBoxResult.Visible And ListBoxResult.Items.Count > 0 Then
            If e.KeyData = Keys.Down Then
                If ListBoxResult.SelectedIndex < ListBoxResult.Items.Count - 1 Then
                    ListBoxResult.SelectedIndex = ListBoxResult.SelectedIndex + 1
                Else
                    ListBoxResult.SelectedIndex = 0
                End If
            ElseIf e.KeyData = Keys.Up Then
                If ListBoxResult.SelectedIndex > 0 Then
                    ListBoxResult.SelectedIndex = ListBoxResult.SelectedIndex - 1
                Else
                    ListBoxResult.SelectedIndex = ListBoxResult.Items.Count - 1
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs)
        ListBoxResult.Visible = False
        If TextBox1.Text <> "" And Not list.[Select](Function(x) x.ToLower()).ToList().Contains(TextBox1.Text.ToLower) Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub ListBoxResult_Leave(sender As Object, e As EventArgs)
        ListBoxResult.Visible = False
    End Sub

    Private Sub ListBoxResult_Click(sender As Object, e As EventArgs)        
        If ListBoxResult.SelectedItem <> Nothing Then
            MsgBox("xd")
            ListBoxResult.Text = ListBoxResult.SelectedItem
        End If
    End Sub

    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        If ListBoxResult.SelectedIndex >= 0 Then
            If e.KeyData = Keys.Tab Or e.KeyData = Keys.Enter Then
                TextBox1.Text = ListBoxResult.SelectedItem()
                e.IsInputKey = True
                ListBoxResult.Items.Clear()
                ListBoxResult.Visible = False
            End If
        End If
    End Sub
End Module
