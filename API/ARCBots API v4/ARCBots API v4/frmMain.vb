Imports System.Net
Imports System.Web.Script.Serialization

Public Class frmMain
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ' <ARCBots Quick Tools v4 - API Example>
    'Copyright (C) 2013  Matthieu Tran

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


    Private User As String = frmLogin.Username
    Private Api As String = frmLogin.APIKey
    Public stuff As String
    Public BotID As Integer = frmLogin.BotID
#Region "Functions"
    'Basically a snipper for VB.net
    Public Function GetBetween(ByVal InputText As String, _
        ByVal starttext As String, _
        ByVal endtext As String)
        Dim lnTextStart As Long
        Dim lnTextEnd As Long
        lnTextStart = InStr(StartPosition, InputText, starttext, vbTextCompare) + Len(starttext)
        lnTextEnd = InStr(lnTextStart, InputText, endtext, vbTextCompare)
        If lnTextStart >= (StartPosition + Len(starttext)) And lnTextEnd > lnTextStart Then
            GetBetween = Mid$(InputText, lnTextStart, lnTextEnd - lnTextStart)
        Else
            GetBetween = "I didn't get a response from the server!"
        End If
    End Function

    Public Shared Function file_get_contents(fileName As String) As String
        Dim sContents As String = String.Empty
        If fileName.ToLower().IndexOf("http:") > -1 Then
            ' URL 
            Dim wc As New System.Net.WebClient()
            Dim response As Byte() = wc.DownloadData(fileName)
            sContents = System.Text.Encoding.ASCII.GetString(response)
        Else
            ' Regular Filename 
            Dim sr As New System.IO.StreamReader(fileName)
            sContents = sr.ReadToEnd()
            sr.Close()
        End If
        Return sContents
    End Function
    Public Shared Function GetStringInBetween(strBegin As String, strEnd As String, strSource As String, includeBegin As Boolean, includeEnd As Boolean) As String()
        Dim result As String() = {"", ""}
        Dim iIndexOfBegin As Integer = strSource.IndexOf(strBegin)
        If iIndexOfBegin <> -1 Then
            ' include the Begin string if desired
            If includeBegin Then
                iIndexOfBegin -= strBegin.Length
            End If
            strSource = strSource.Substring(iIndexOfBegin + strBegin.Length)
            Dim iEnd As Integer = strSource.IndexOf(strEnd)
            If iEnd <> -1 Then
                ' include the End string if desired
                If includeEnd Then
                    iEnd += strEnd.Length
                End If
                result(0) = strSource.Substring(0, iEnd)
                ' advance beyond this segment
                If iEnd + strEnd.Length < strSource.Length Then
                    result(1) = strSource.Substring(iEnd + strEnd.Length)
                End If
            End If
        Else
            ' stay where we are
            result(1) = strSource
        End If
        Return result
    End Function

#End Region
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
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load up Theme Settings from Login Form.
        Dim BaseColor = My.Settings.BaseColor
        FormSkin1.FlatColor = BaseColor
        FlatButton1.BaseColor = BaseColor
        FlatTabControl1.ActiveColor = BaseColor
        FlatButton4.BaseColor = BaseColor
        FormSkin1.BaseColor = BaseColor
        FlatStatusBar1.Text = "Welcome Back, " & User & "!"
        FlatStatusBar1.RectColor = BaseColor
        FlatButton7.BaseColor = BaseColor
        FlatRadioButton1.BorderColor = BaseColor
        FlatRadioButton2.BorderColor = BaseColor
        FlatListBox2.SelectedColor = BaseColor
        'Me.FlatComboBox1.Items.Add(BotID)
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        'http://arcbots.com/api-v2.html&user=username&apiToken=apikey&cmd=sendCmd&xatBotCommand=!say%20test&botid=number
        If FlatListBox2.SelectedItem = "" Then
            Alert(Style.Critical, "Please select a Bot ID From the List!")
        Else
            Dim client As New WebClient()
            Dim jsonResponse As String = client.DownloadString(New Uri("http://arcbots.com/api-v2.html&user=" & frmLogin.User & "&apiToken=" & frmLogin.API & "&cmd=sendCmd&xatBotCommand=" & FlatTextBox1.Text & "&botid=" & FlatListBox2.SelectedItem))
            Dim serializer As New JavaScriptSerializer()
            Dim response As ARCBotsCMDSendJSON = serializer.Deserialize(Of ARCBotsCMDSendJSON)(jsonResponse)
            If response.error = "0" Then
                Alert(Style.Success, response.message)
            Else
                Alert(Style.Critical, response.message & response.errorMessage)
            End If
        End If
    End Sub

    Private Sub FlatTextBox1_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox1.TextChanged

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        'http://arcbots.com/api-v2.html&user=username&apiToken=apikey&cmd=stop&botid=id
        If FlatListBox2.SelectedItem = "" Then
            Alert(Style.Critical, "Please select a Bot ID From the List!")
        Else
            Dim client As New WebClient()
            Dim jsonResponse As String = client.DownloadString(New Uri("http://arcbots.com/api-v2.html&user=" & frmLogin.User & "&apiToken=" & frmLogin.API & "&cmd=stop&botid=" & FlatListBox2.SelectedItem))
            Dim serializer As New JavaScriptSerializer()
            Dim response As ARCBotsCMDJSON = serializer.Deserialize(Of ARCBotsCMDJSON)(jsonResponse)
            If response.error = "0" Then
                Alert(Style.Success, response.message)
            Else
                Alert(Style.Critical, response.message)
            End If
        End If
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        'http://arcbots.com/api-v2.html&user=username&apiToken=apikey&cmd=restart&botid=id
        If FlatListBox2.SelectedItem = "" Then
            Alert(Style.Critical, "Please select a Bot ID From the List!")
        Else
            Dim client As New WebClient()
            Dim jsonResponse As String = client.DownloadString(New Uri("http://arcbots.com/api-v2.html&user=" & frmLogin.User & "&apiToken=" & frmLogin.API & "&cmd=restart&botid=" & FlatListBox2.SelectedItem))
            Dim serializer As New JavaScriptSerializer()
            Dim response As ARCBotsCMDJSON = serializer.Deserialize(Of ARCBotsCMDJSON)(jsonResponse)
            If response.error = "0" Then
                Alert(Style.Success, response.message)
            Else
                Alert(Style.Critical, response.message)
            End If
        End If
    End Sub

    Private Sub FlatComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click

        If FlatRadioButton1.Checked = True Then
            Dim rawr = file_get_contents("http://arcbots.com/userinfo.php?displayname=" + FlatTextBox3.Text)
            If rawr = "Xat user opted out from this feature!" Then
                Alert(Style.Critical, "Xat user has opted out from this feature!")
            Else
                FlatTextBox5.Text = file_get_contents("http://arcbots.com/userinfo.php?reg=" + FlatTextBox3.Text) 'Flat textbox 4/5 orders count

                FlatTextBox7.Text = file_get_contents("http://arcbots.com/userinfo.php?lastseen=" + FlatTextBox3.Text)
                FlatTextBox6.Text = file_get_contents("http://arcbots.com/userinfo.php?displayname=" + FlatTextBox3.Text)
                FlatTextBox8.Text = file_get_contents("http://arcbots.com/userinfo.php?homepage=" + FlatTextBox3.Text)
                FlatTextBox9.Text = file_get_contents("http://arcbots.com/userinfo.php?avatar=" + FlatTextBox3.Text)
                FlatTextBox4.Text = FlatTextBox3.Text
            End If

        ElseIf FlatRadioButton2.Checked = True Then
            Dim rawr = file_get_contents("http://arcbots.com/userinfo.php?displayname=" + FlatTextBox3.Text)
            If rawr = "Xat user opted out from this feature!" Then
                Alert(Style.Critical, "Xat user has opted out from this feature!")
            Else
                FlatTextBox4.Text = file_get_contents("http://arcbots.com/userinfo.php?id=" + FlatTextBox3.Text) 'Flat textbox 4/5 orders count

                FlatTextBox7.Text = file_get_contents("http://arcbots.com/userinfo.php?lastseen=" + FlatTextBox3.Text)
                FlatTextBox6.Text = file_get_contents("http://arcbots.com/userinfo.php?displayname=" + FlatTextBox3.Text)
                FlatTextBox8.Text = file_get_contents("http://arcbots.com/userinfo.php?homepage=" + FlatTextBox3.Text)
                FlatTextBox9.Text = file_get_contents("http://arcbots.com/userinfo.php?avatar=" + FlatTextBox3.Text)
                FlatTextBox5.Text = file_get_contents("http://arcbots.com/userinfo.php?reg=" + FlatTextBox4.Text)
            End If
        End If
    End Sub

    Private Sub FlatRadioButton1_CheckedChanged(sender As Object) Handles FlatRadioButton1.CheckedChanged
        If FlatRadioButton1.Checked = True Then
            FlatRadioButton2.Checked = False
        End If
    End Sub

    Private Sub FlatRadioButton2_CheckedChanged(sender As Object) Handles FlatRadioButton2.CheckedChanged
        If FlatRadioButton2.Checked = True Then
            FlatRadioButton1.Checked = False
        End If
    End Sub

    Private Sub FlatStatusBar1_Click(sender As Object, e As EventArgs) Handles FlatStatusBar1.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
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
End Class