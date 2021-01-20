Public Class Form1
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        'Declaracion de variables
        Dim nombre As String
        'Entrada de datos
        nombre = InputBox("Ingrese Nombre", "Registro de Datos", "Nombre", 100, 0)
        MessageBox.Show("Bienvenido Usuario: " & nombre, "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)





    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea Salir de la App?", "Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Me.Close()

        End If
    End Sub
End Class
