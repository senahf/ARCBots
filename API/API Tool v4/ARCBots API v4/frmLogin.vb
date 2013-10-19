Imports System.Net
Imports System.Web.Script.Serialization


Public Class frmLogin
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ' <ARCBots Quick Tools v4 - API Example>
    'Copyright (C) 2013  Matthieu Tran
    '
    'This program is free software: you can redistribute it and/or modify
    'it under the terms of the GNU General Public License as published by
    'the Free Software Foundation, either version 3 of the License, or
    '(at your option) any later version.

    'This program is distributed in the hope that it will be useful,
    'but WITHOUT ANY WARRANTY; without even the implied warranty of
    'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    'GNU General Public License for more details.

    'You should have received a copy of the GNU General Public License
    'along with this program.  If not, see <http://www.gnu.org/licenses/>.
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




    '---------[_]---------
    '-------[TO DO]-------
    '-----[Lazy todo]-----
    '1. Clean up Codes

    Public BotID As String
    Public APIKey As String
    Public Username As String
    Public code As String
    Public botids() As Integer
    Public Shared API As String
    Public Shared User As String
    'Rectangle Color Chooser - Messy af. Planning on making it 1 line coding soon.
    'Pretty much just puts data into settings and change color of current form.
#Region "Colors"
    Private Sub DrawinRectangle6_Click(sender As Object, e As EventArgs) Handles DrawinRectangle6.Click
        Dim BaseColor = Color.FromArgb(241, 196, 15) 'yellow
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Yellow")
    End Sub

    Private Sub DrawinRectangle7_Click(sender As Object, e As EventArgs) Handles DrawinRectangle7.Click
        Dim BaseColor = Color.FromArgb(46, 204, 113) 'bluegreen
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Blue Green")
    End Sub

    Private Sub DrawinRectangle8_Click(sender As Object, e As EventArgs) Handles DrawinRectangle8.Click
        Dim BaseColor = Color.FromArgb(230, 126, 34) 'orange
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Orange")
    End Sub

    Private Sub DrawinRectangle9_Click(sender As Object, e As EventArgs) Handles DrawinRectangle9.Click
        Dim BaseColor = Color.FromArgb(52, 152, 219) 'blue
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Blue")
    End Sub

    Private Sub DrawinRectangle10_Click(sender As Object, e As EventArgs) Handles DrawinRectangle10.Click
        Dim BaseColor = Color.FromArgb(26, 188, 156) 'green
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Green")
    End Sub

    Private Sub DrawinRectangle11_Click(sender As Object, e As EventArgs) Handles DrawinRectangle11.Click
        Dim BaseColor = Color.FromArgb(155, 89, 182) 'purple
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Purple")
    End Sub

    Private Sub DrawinRectangle12_Click(sender As Object, e As EventArgs) Handles DrawinRectangle12.Click
        Dim BaseColor = Color.FromArgb(231, 76, 60) 'red
        FlatButton1.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        FormSkin1.FlatColor = BaseColor
        My.Settings.BaseColor = BaseColor
        Alert(Style.Success, "Base Color Changed to Red")
    End Sub
#End Region
    'too lazy to make hover responsive '#Region "Colors_hover"
    '    Private Sub DrawinRectangle6_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle6.MouseHover
    '        DrawinRectangle6.Selection = Color.FromArgb(243, 156, 18)
    '    End Sub

    '    Private Sub DrawinRectangle7_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle7.MouseHover
    '        DrawinRectangle7.Selection = Color.FromArgb(39, 174, 96)
    '    End Sub

    '    Private Sub DrawinRectangle8_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle8.MouseHover
    '        DrawinRectangle8.Selection = Color.FromArgb(211, 84, 0)
    '    End Sub

    '    Private Sub DrawinRectangle9_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle9.MouseHover
    '        DrawinRectangle9.Selection = Color.FromArgb(41, 128, 185)
    '    End Sub

    '    Private Sub DrawinRectangle10_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle10.MouseHover
    '        DrawinRectangle10.Selection = Color.FromArgb(22, 160, 133)
    '    End Sub

    '    Private Sub DrawinRectangle11_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle11.MouseHover
    '        DrawinRectangle11.Selection = Color.FromArgb(142, 68, 173)
    '    End Sub

    '    Private Sub DrawinRectangle12_MouseHover(sender As Object, e As EventArgs) Handles DrawinRectangle12.MouseHover
    '        DrawinRectangle12.Selection = Color.FromArgb(192, 57, 43)
    '    End Sub

    '#End Region

    'Control box, not that bad. Includes Minimize/Exit/Minimize to Tray // too lazy to make the hover stuff reactive
#Region "AlertBox"
    Enum Style
        Success = 1
        Critical = 2
        Information = 3
    End Enum

    Sub Alert(ByVal Style As Style, ByVal Text As String)
        Dim AlertBox As New FlatAlertBox With {.Dock = DockStyle.Bottom}
        Me.Controls.Add(AlertBox)
        AddHandler AlertBox.Click, AddressOf CloseAlert
        Dim CurrentHeight As Integer = Me.Size.Height
        Do Until Me.Size.Height >= CurrentHeight + 42
            Me.Size = New Drawing.Size(Me.Size.Width, Me.Size.Height + 2)
        Loop
        Select Case Style
            Case 1
                AlertBox.kind = FlatAlertBox._Kind.Success
            Case 2
                AlertBox.kind = FlatAlertBox._Kind.Error
            Case 3
                AlertBox.kind = FlatAlertBox._Kind.Info
        End Select
        AlertBox.Text = Text
        AlertBox.Visible = True
    End Sub

    Sub CloseAlert()
        Dim CurrentHeight As Integer = Me.Size.Height
        Do Until Me.Size.Height <= CurrentHeight - 42
            Me.Size = New Drawing.Size(Me.Size.Width, Me.Size.Height - 2)
        Loop
    End Sub
#End Region
#Region "ControlBox"
    Private Sub FlatClose2_Click(sender As Object, e As EventArgs) Handles FlatClose2.Click
        End
    End Sub

    Private Sub FlatMini2_Click(sender As Object, e As EventArgs) Handles FlatMini2.Click
        Me.WindowState = FormWindowState.Minimized ' Minimize
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        'Minimize to Tray and display a notification
        NotifyIcon1.Visible = True
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(100, "ARCBots Quick Tools v4", "The ARCBots Quick Tools Software has been minimized to Tray!", ToolTipIcon.Info) '100 miliseconds
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        'Make form "Visible" when clicking icon x2.
        NotifyIcon1.Visible = False
        Me.Show()
        NotifyIcon1.ShowBalloonTip(100, "ARCBots Quick Tools v4", "The ARCBots Quick Tools Software is now visible!", ToolTipIcon.Info)
    End Sub
#End Region
#Region "Functions"
    Public Function cString(ByVal int As Integer) As String
        Return int.ToString
    End Function
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load up settings from before if user has already used the application.
        Dim BaseColor = My.Settings.BaseColor
        FlatButton4.BaseColor = BaseColor
        FlatButton3.BaseColor = BaseColor
        ' FormSkin1.FlatColor = BaseColor
        FlatTextBox4.Text = My.Settings.API
        FlatToggle2.Checked = My.Settings.Check
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim LoginSt As Boolean
        'Saves the Remember Me Option
        'Reason why I don't save the username would be for verification.
        If FlatToggle1.Checked = True Then
            My.Settings.Check = True
            My.Settings.API = FlatTextBox4.Text
        Else
            My.Settings.API = Nothing
            My.Settings.Check = False
        End If
        If FlatTextBox3.Text = "" Or FlatTextBox4.Text = "" Then 'thjpstation qjaxxfwmgiij
            Alert(Style.Critical, "All Fields are required!")
            Return
        Else
            Dim client As New WebClient()
            Dim jsonResponse As String = client.DownloadString(New Uri("http://arcbots.com/api-v2.html&user=" & FlatTextBox3.Text & "&apiToken=" & FlatTextBox4.Text))
            Dim serializer As New JavaScriptSerializer()
            Dim response As ARCBotsJSON = serializer.Deserialize(Of ARCBotsJSON)(jsonResponse)
            code = response.error

            If code = 1 Then
                Alert(Style.Critical, response.message)
            ElseIf code = 0 Then
                LoginSt = True
                botids = response.botids
            Else
                Alert(Style.Critical, response.message)
            End If
        End If

        If LoginSt = True Then
            User = FlatTextBox3.Text
            API = FlatTextBox4.Text
            FlatStatusBar1.Text = "Login Successful, Redirecting to Main Form!"
            FlatStatusBar1.RectColor = Color.FromArgb(0, 128, 255)
            Username = FlatTextBox3.Text
            APIKey = FlatTextBox4.Text
            Me.Hide()
            frmMain.Show()

            frmMain.FlatListBox2.AddRange(Array.ConvertAll(botids, New Converter(Of Integer, String)(AddressOf cString)))

        End If
    End Sub


    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class



