
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Reflection
Imports System.Reflection.Emit

Public Class Form1
    Private Shared iClique As Integer = 0
    Private Shared iTempo As Integer = 0
    Private Shared iPontuacao As Integer = 0
    Private Sub btnClique_Click(sender As Object, e As EventArgs) Handles btnClique.Click
        iClique += 1
        lblClique.Text = $"Total de cliques: {iClique}"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tempo.Tick
        iTempo += 1
        lblTempo.Text = $"Tempo passado: {iTempo}"
        If iTempo = 5 Then
            tempo.Enabled = False
            MessageBox.Show($"{vbNewLine}O Tempo acabou {vbNewLine}", "Tempo acabou")
            btnReiniciar.Visible = True
            btnClique.Visible = False
            If iPontuacao < iClique Then
                iPontuacao = iClique
                lblPontuacao.Text = $"Parabéns, Você bateu seu recorde! {vbNewLine}
Sua nova pontuação é de: {iPontuacao}"
            Else
                lblPontuacao.Text = $"High Score: {iPontuacao}"
            End If
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        iClique = 0
        iTempo = 0
        lblClique.Text = $"Total de cliques: {iClique}"
        lblTempo.Text = $"Tempo passado: {iTempo}"
        lblPontuacao.Text = $"High Score: {iPontuacao}"
        tempo.Enabled = True
        btnReiniciar.Visible = False
        btnIniciar.Visible = False
        btnClique.Visible = True
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        tempo.Enabled = True
        btnReiniciar.Visible = False
        btnIniciar.Visible = False
        btnClique.Visible = True
        iTempo = 0
        iClique = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempo.Enabled = False
        btnClique.Visible = False
        btnReiniciar.Visible = False
        Try
            Dim myAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim resourceName As String = "clickJogo.sem.png"
            Using myStream As Stream = myAssembly.GetManifestResourceStream(resourceName)
                Dim bmp As New Bitmap(myStream)
                Dim resizedImage As New Bitmap(btnClique.Width, btnClique.Height)
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(bmp, New Rectangle(0, 0, resizedImage.Width, resizedImage.Height))
                End Using
                btnClique.Image = resizedImage
            End Using
        Catch ex As Exception
            MsgBox("Erro ao ler a imagem: " & ex.Message)
        End Try
    End Sub
End Class
