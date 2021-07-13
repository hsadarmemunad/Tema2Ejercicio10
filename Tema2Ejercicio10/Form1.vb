Public Class Form1
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        Dim frm As New Quiz()
        frm.Show()
        frm = Nothing

        Me.Hide()
    End Sub

End Class
