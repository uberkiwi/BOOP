Public Class BOOP1
    Private Sub Form2()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.boop, AudioPlayMode.BackgroundLoop)
        Dim BOOP As New BOOP
        BOOP.Show()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim BOOP1 As New BOOP1
        Me.Hide()
        BOOP1.Show()
    End Sub
End Class
