<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigurasiServer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigurasiServer))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbSecurity = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.Btn_test = New System.Windows.Forms.Button()
        Me.GbSecurity = New System.Windows.Forms.GroupBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_databse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_server = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcopyright = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GbSecurity.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(354, 300)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.CbSecurity)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Btn_save)
        Me.TabPage1.Controls.Add(Me.Btn_test)
        Me.TabPage1.Controls.Add(Me.GbSecurity)
        Me.TabPage1.Controls.Add(Me.txt_databse)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Txt_server)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtcopyright)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(346, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Server Configuration"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(115, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = ":"
        '
        'CbSecurity
        '
        Me.CbSecurity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSecurity.FormattingEnabled = True
        Me.CbSecurity.Items.AddRange(New Object() {"SQL Server Authentication", "Windows Authentication"})
        Me.CbSecurity.Location = New System.Drawing.Point(129, 75)
        Me.CbSecurity.Name = "CbSecurity"
        Me.CbSecurity.Size = New System.Drawing.Size(196, 25)
        Me.CbSecurity.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.CbSecurity, "Authentication")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Authentication"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = ":"
        '
        'Btn_save
        '
        Me.Btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_save.Image = CType(resources.GetObject("Btn_save.Image"), System.Drawing.Image)
        Me.Btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_save.Location = New System.Drawing.Point(32, 195)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(126, 34)
        Me.Btn_save.TabIndex = 12
        Me.Btn_save.Text = "      &Save Setting"
        Me.ToolTip1.SetToolTip(Me.Btn_save, "Press this button to save configuration")
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'Btn_test
        '
        Me.Btn_test.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_test.Image = CType(resources.GetObject("Btn_test.Image"), System.Drawing.Image)
        Me.Btn_test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_test.Location = New System.Drawing.Point(162, 194)
        Me.Btn_test.Name = "Btn_test"
        Me.Btn_test.Size = New System.Drawing.Size(143, 34)
        Me.Btn_test.TabIndex = 11
        Me.Btn_test.Text = "       &Connection Test"
        Me.ToolTip1.SetToolTip(Me.Btn_test, "Press this button to connection test")
        Me.Btn_test.UseVisualStyleBackColor = True
        '
        'GbSecurity
        '
        Me.GbSecurity.Controls.Add(Me.txt_password)
        Me.GbSecurity.Controls.Add(Me.Label4)
        Me.GbSecurity.Controls.Add(Me.Txt_username)
        Me.GbSecurity.Controls.Add(Me.Label3)
        Me.GbSecurity.Controls.Add(Me.Label8)
        Me.GbSecurity.Controls.Add(Me.Label7)
        Me.GbSecurity.Location = New System.Drawing.Point(21, 104)
        Me.GbSecurity.Name = "GbSecurity"
        Me.GbSecurity.Size = New System.Drawing.Size(302, 136)
        Me.GbSecurity.TabIndex = 10
        Me.GbSecurity.TabStop = False
        Me.GbSecurity.Text = "Security"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(108, 56)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.Size = New System.Drawing.Size(178, 23)
        Me.txt_password.TabIndex = 5
        Me.txt_password.Text = "im2q92oz"
        Me.ToolTip1.SetToolTip(Me.txt_password, "Password")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password"
        '
        'Txt_username
        '
        Me.Txt_username.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_username.Location = New System.Drawing.Point(108, 26)
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.Size = New System.Drawing.Size(178, 23)
        Me.Txt_username.TabIndex = 3
        Me.Txt_username.Text = "hamdan"
        Me.ToolTip1.SetToolTip(Me.Txt_username, "Username")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = ":"
        '
        'txt_databse
        '
        Me.txt_databse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_databse.Location = New System.Drawing.Point(129, 46)
        Me.txt_databse.Name = "txt_databse"
        Me.txt_databse.Size = New System.Drawing.Size(196, 23)
        Me.txt_databse.TabIndex = 9
        Me.txt_databse.Text = "DbHamdan"
        Me.ToolTip1.SetToolTip(Me.txt_databse, "Database")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Database"
        '
        'Txt_server
        '
        Me.Txt_server.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_server.Location = New System.Drawing.Point(129, 17)
        Me.Txt_server.Name = "Txt_server"
        Me.Txt_server.Size = New System.Drawing.Size(196, 23)
        Me.Txt_server.TabIndex = 7
        Me.Txt_server.Text = "8.8.8.8\HAMDAN"
        Me.ToolTip1.SetToolTip(Me.Txt_server, "Server name")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Server Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = ":"
        '
        'txtcopyright
        '
        Me.txtcopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcopyright.Location = New System.Drawing.Point(1, 241)
        Me.txtcopyright.Name = "txtcopyright"
        Me.txtcopyright.Size = New System.Drawing.Size(339, 23)
        Me.txtcopyright.TabIndex = 15
        Me.txtcopyright.Text = "Copyright ©  2012 By Softmed Consultindo"
        Me.txtcopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmConfigurasiServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(373, 319)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfigurasiServer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Setting"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GbSecurity.ResumeLayout(False)
        Me.GbSecurity.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_test As System.Windows.Forms.Button
    Friend WithEvents txtcopyright As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GbSecurity As System.Windows.Forms.GroupBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_databse As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_server As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
