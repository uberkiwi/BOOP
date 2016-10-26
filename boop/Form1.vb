Public Class BOOP
    Private Sub Form1()
        Dim Form2 As New BOOP1
    End Sub
    Private Sub BOOP_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BOOPbutton.Click
        My.Computer.Audio.Play("boop.wav", AudioPlayMode.BackgroundLoop)
        Me.Hide()
        BOOP1.Show()
    End Sub

    Private Sub BOOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class