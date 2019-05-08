Public Class Stoppuhr
    Public Zeit As String
    Public Zähler As Integer
    Private Runde As Integer
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://computergott.eu")
    End Sub

    Private Sub Stoppuhr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        runden.Items.Clear()
        Runde = 1
        Timer1.Interval = 1000
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim AktRunde As String
        AktRunde = Runde.ToString + ". - " + Zeit
        runden.Items.Add(AktRunde)
        Runde = Runde + 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        runden.Items.Remove(runden.SelectedItem)
        runden.SelectedItem = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Zähler = Zähler + 1
        rechnen.gettime()
        Time.Text = Zeit
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Timer1.Enabled Then
            Timer1.Stop()
        Else
            Timer1.Start()

        End If
    End Sub

    Private Sub CheckClose(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Timer1.Enabled Then
            MsgBox("Um die Anwendung zu beenden musst Du vorher den Timer anhalten", MsgBoxStyle.Critical, Title:="Beenden nicht möglich")
            e.Cancel = True
        End If
    End Sub

End Class
