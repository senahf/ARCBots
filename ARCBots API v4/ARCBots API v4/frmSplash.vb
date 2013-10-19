Public Class frmSplash
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


    'Honestly, this code is really bad, suggest you don't even look at it.
#Region "gay ass coding"
    Private prgvalue As Integer
    Dim Val As Integer
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatStatusBar2_Click(sender As Object, e As EventArgs) Handles FlatStatusBar2.Click

    End Sub
#End Region

    Private Sub FlatProgressBar2_Click(sender As Object, e As EventArgs) Handles FlatProgressBar2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Threading.Thread.Sleep(3000)
        FlatProgressBar2.Value = 20
        FlatStatusBar2.Text = "Loading . ."
        Threading.Thread.Sleep(3000)
        FlatProgressBar2.Value = 50
        FlatStatusBar2.Text = "Loading . . ."
        Threading.Thread.Sleep(2000)
        FlatProgressBar2.Value = 70
        FlatStatusBar2.Text = "Loading . "
        Threading.Thread.Sleep(1000)
        FlatProgressBar2.Value = 100
        FlatStatusBar2.Text = "Finish!"
        Threading.Thread.Sleep(1000)
        frmLogin.Show()
        Me.Close()
    End Sub
End Class