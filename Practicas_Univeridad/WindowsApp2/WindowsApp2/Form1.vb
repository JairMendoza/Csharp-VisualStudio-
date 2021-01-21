Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles shkdesc.CheckedChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Declaracion de variables 
        Dim cant As Integer
        Dim punitario, desc, pparcial, pneto As Single
        Dim marcadesc As Boolean
        'Entrada de datos
        cant = Val(txtcant.Text)
        punitario = Val(txtpunitario.Text)
        marcadesc = shkdesc.Checked
        'Inicializar Variable descuento
        desc = 0
        'Proceso
        pparcial = cant * punitario
        'Evaluar si aplicamos descuento o no 
        If (marcadesc = True) Then
            desc = pparcial * 7 / 100
        End If
        pneto = pparcial - desc
        'Salida de informacion
        txtpparcial.Text = pparcial
        txtdescuento.Text = desc
        txtpneto.Text = pneto





    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcant.Clear()
        txtdescuento.Clear()
        txtpneto.Clear()
        txtpparcial.Clear()
        txtpunitario.Clear()
        shkdesc.Checked = False


    End Sub
End Class
