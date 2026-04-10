Public Class Form1
    Dim formato As Boolean = True
    Dim start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")

        Dim time_o = ""
        'formato de 24 horas
        If formato = True Then
            time_o = DateTime.Now.ToString("HH:mm:ss")

        ElseIf formato = False Then
            time_o = DateTime.Now.ToString("hh:mm:ss")

        End If

        Dim time_mod = time_o.split(":")
        Fecha.Text = date_o.ToString()
        Dia.Text = day_o.ToString()
        Horas.Text = time_mod(0)
        Minutos.Text = time_mod(1)
        segundos.Text = time_mod(2)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString
        If color_texto = "Verde" Then
            Fecha.ForeColor = Color.GreenYellow
            Dia.ForeColor = Color.GreenYellow
            Horas.ForeColor = Color.GreenYellow
            Minutos.ForeColor = Color.GreenYellow
            Label1.ForeColor = Color.GreenYellow
            Label2.ForeColor = Color.GreenYellow
            segundos.ForeColor = Color.GreenYellow
            Label3.ForeColor = Color.GreenYellow
            Label4.ForeColor = Color.GreenYellow
        ElseIf color_texto = "Blanco" Then
            Fecha.ForeColor = Color.White
            Dia.ForeColor = Color.White
            Horas.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            segundos.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
        ElseIf color_texto = "Turqueza" Then
            Fecha.ForeColor = Color.Turquoise
            Dia.ForeColor = Color.Turquoise
            Horas.ForeColor = Color.Turquoise
            Minutos.ForeColor = Color.Turquoise
            Label1.ForeColor = Color.Turquoise
            Label2.ForeColor = Color.Turquoise
            segundos.ForeColor = Color.Turquoise
            Label4.ForeColor = Color.Turquoise
            Label3.ForeColor = Color.Turquoise
        ElseIf color_texto = "Amarillo" Then
            Fecha.ForeColor = Color.Gold
            Dia.ForeColor = Color.Gold
            Horas.ForeColor = Color.Gold
            Minutos.ForeColor = Color.Gold
            Label1.ForeColor = Color.Gold
            Label2.ForeColor = Color.Gold
            segundos.ForeColor = Color.Gold
            Label4.ForeColor = Color.Gold
            Label3.ForeColor = Color.Gold

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False

        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If start = False Then
            Timer3.Enabled = True
            start = True
            Button2.Text = "Stop"
            startTime = DateTime.Now

        ElseIf start = True Then
            Timer3.Enabled = False
            start = False
            Button2.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub

    Private Sub Resetb_Click(sender As Object, e As EventArgs) Handles Resetb.Click
        elapsed = TimeSpan.Zero
        Button2.Text = "Start"
        Timer3.Enabled = False
        Label4.Text = "00:00:00:00"
        start = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim curremt = elapsed + (DateTime.Now - startTime)
        Label4.Text = curremt.ToString("hh\:mm\:ss\.ff")


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True
        End If
    End Sub
End Class
