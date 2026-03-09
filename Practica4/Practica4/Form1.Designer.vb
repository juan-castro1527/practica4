<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Horas = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.BackColor = System.Drawing.Color.Transparent
        Me.Horas.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Horas.Location = New System.Drawing.Point(43, 17)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(137, 115)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "00"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.Color.Transparent
        Me.Minutos.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Minutos.Location = New System.Drawing.Point(196, 17)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(137, 115)
        Me.Minutos.TabIndex = 1
        Me.Minutos.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(157, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 115)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Dia.Location = New System.Drawing.Point(109, 132)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(163, 77)
        Me.Dia.TabIndex = 3
        Me.Dia.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Fecha.Location = New System.Drawing.Point(12, 220)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(375, 59)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de marzo del 2026"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(398, 288)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Reloj digital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Horas As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
End Class
