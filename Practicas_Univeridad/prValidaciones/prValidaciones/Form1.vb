Imports System.ComponentModel

Public Class Form1
    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        Try
            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Val(txtedad.Text) - Int(Val(txtedad.Text) = 0 And txtsalario.Text <> String.Empty) Then
                MessageBox.Show("Datos registrados correctamente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese correctamente los datos remarcados.", "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtsalario_TextChanged(sender As Object, e As EventArgs) Handles txtsalario.TextChanged

    End Sub

    Private Sub txtsalario_Validating(sender As Object, e As CancelEventArgs) Handles txtsalario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Salario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged

    End Sub

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating
        If (Val(txtedad.Text) - Int(Val(txtedad.Text)) = 0) Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese una edad valida, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtedad.Clear()
        txtdescripcion.Clear()
        txtnombre.Clear()
        txtsalario.Clear()
    End Sub

    Private Sub lblsalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblsalir.LinkClicked
        End

    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        ttmensaje.SetToolTip(txtnombre, "Ingrese aqui el Nombre del Usuario.")
        ttmensaje.ToolTipTitle = "Nombre del Usuario"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info


    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        ttmensaje.SetToolTip(txtedad, "Ingrese aqui la Edad del Usuario.")
        ttmensaje.ToolTipTitle = "Edad del Usuario"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtsalario_MouseHover(sender As Object, e As EventArgs) Handles txtsalario.MouseHover
        ttmensaje.SetToolTip(txtsalario, "Ingrese aqui el Salario del Usuario.")
        ttmensaje.ToolTipTitle = "Salario del Usuario"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
