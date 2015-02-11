Public Class Form1


    Public SID As String
    Public Squawk As Integer
    Public callsign As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        callsign = TextBox1.Text
        SID = TextBox2.Text
        Squawk = TextBox3.Text
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
