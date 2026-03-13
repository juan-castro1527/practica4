Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")
        Dim time_o = DateTime.Now.ToString("HH:mm")

        Dim time_mod = time_o.Split(":")
        Fecha.Text = date_o.ToString()
        Dia.Text = day_o.ToString()
        Horas.Text = time_mod(0)
        Minutos.Text = time_mod(1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub
End Class
