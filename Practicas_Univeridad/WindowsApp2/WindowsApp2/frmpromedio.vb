Public Class frmpromedio
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        'Declaracion de Variables 
        Dim notaa, notac, notab As Byte
        Dim promedio As Single
        Dim situacion As String
        'Entrada de datos
        notaa = Val(txtnotaa.Text)
        notab = Val(txtnotab.Text)
        notac = Val(txtnotab.Text)
        'Proceso
        promedio = (notaa * 3 + notab * 4 + notac * 2) / 9
        'Evaluar su situacion 
        If (promedio >= 10.5) Then
            situacion = "Aprobado"
        Else
            situacion = "Desaprobado"

        End If
        'Salida de informacon
        txtpromedio.Text = promedio
        txtsituacion.Text = situacion

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtsituacion.Clear()
        txtpromedio.Clear()
        txtnotac.Clear()
        txtnotaa.Clear()
        txtnotab.Clear()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End

    End Sub

    Private Sub frmpromedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class