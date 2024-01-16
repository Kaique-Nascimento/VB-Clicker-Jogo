<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClique = New System.Windows.Forms.Button()
        Me.lblClique = New System.Windows.Forms.Label()
        Me.tempo = New System.Windows.Forms.Timer(Me.components)
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.lblPontuacao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClique
        '
        Me.btnClique.BackgroundImage = CType(resources.GetObject("btnClique.BackgroundImage"), System.Drawing.Image)
        Me.btnClique.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClique.FlatAppearance.BorderSize = 0
        Me.btnClique.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClique.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClique.Location = New System.Drawing.Point(87, 142)
        Me.btnClique.Name = "btnClique"
        Me.btnClique.Size = New System.Drawing.Size(106, 130)
        Me.btnClique.TabIndex = 0
        Me.btnClique.UseVisualStyleBackColor = True
        '
        'lblClique
        '
        Me.lblClique.AutoSize = True
        Me.lblClique.Location = New System.Drawing.Point(93, 37)
        Me.lblClique.Name = "lblClique"
        Me.lblClique.Size = New System.Drawing.Size(94, 13)
        Me.lblClique.TabIndex = 1
        Me.lblClique.Text = "Total de cliques: 0"
        '
        'tempo
        '
        Me.tempo.Enabled = True
        Me.tempo.Interval = 1000
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Location = New System.Drawing.Point(93, 80)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(95, 13)
        Me.lblTempo.TabIndex = 2
        Me.lblTempo.Text = "Tempo passado: 0"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReiniciar.Location = New System.Drawing.Point(95, 186)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(90, 42)
        Me.btnReiniciar.TabIndex = 3
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Location = New System.Drawing.Point(98, 186)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(84, 42)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'lblPontuacao
        '
        Me.lblPontuacao.AutoSize = True
        Me.lblPontuacao.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblPontuacao.Location = New System.Drawing.Point(106, 116)
        Me.lblPontuacao.Name = "lblPontuacao"
        Me.lblPontuacao.Size = New System.Drawing.Size(72, 13)
        Me.lblPontuacao.TabIndex = 5
        Me.lblPontuacao.Text = "High Score: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 298)
        Me.Controls.Add(Me.lblPontuacao)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.lblTempo)
        Me.Controls.Add(Me.lblClique)
        Me.Controls.Add(Me.btnClique)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClique As Button
    Friend WithEvents lblClique As Label
    Friend WithEvents tempo As Timer
    Friend WithEvents lblTempo As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents lblPontuacao As Label
End Class
