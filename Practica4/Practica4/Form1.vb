Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
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
End Class
