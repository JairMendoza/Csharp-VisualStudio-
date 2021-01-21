<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpromedio
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnotac = New System.Windows.Forms.TextBox()
        Me.txtnotab = New System.Windows.Forms.TextBox()
        Me.txtnotaa = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpromedio = New System.Windows.Forms.TextBox()
        Me.txtsituacion = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btncalc)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnotac)
        Me.GroupBox1.Controls.Add(Me.txtnotab)
        Me.GroupBox1.Controls.Add(Me.txtnotaa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Ingresados"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(410, 205)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(317, 205)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(75, 23)
        Me.btncalc.TabIndex = 9
        Me.btncalc.Text = "Calcular"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(225, 205)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 8
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nota C (2 Creditos)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nota B (4 Creditos)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nota A (3 Creditos)"
        '
        'txtnotac
        '
        Me.txtnotac.Location = New System.Drawing.Point(225, 166)
        Me.txtnotac.Name = "txtnotac"
        Me.txtnotac.Size = New System.Drawing.Size(353, 22)
        Me.txtnotac.TabIndex = 4
        '
        'txtnotab
        '
        Me.txtnotab.Location = New System.Drawing.Point(225, 108)
        Me.txtnotab.Name = "txtnotab"
        Me.txtnotab.Size = New System.Drawing.Size(353, 22)
        Me.txtnotab.TabIndex = 1
        '
        'txtnotaa
        '
        Me.txtnotaa.Location = New System.Drawing.Point(225, 39)
        Me.txtnotaa.Name = "txtnotaa"
        Me.txtnotaa.Size = New System.Drawing.Size(353, 22)
        Me.txtnotaa.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtpromedio)
        Me.GroupBox2.Controls.Add(Me.txtsituacion)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Promedio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Situacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Promedio:"
        '
        'txtpromedio
        '
        Me.txtpromedio.Location = New System.Drawing.Point(223, 58)
        Me.txtpromedio.Name = "txtpromedio"
        Me.txtpromedio.Size = New System.Drawing.Size(353, 22)
        Me.txtpromedio.TabIndex = 2
        '
        'txtsituacion
        '
        Me.txtsituacion.Location = New System.Drawing.Point(223, 104)
        Me.txtsituacion.Name = "txtsituacion"
        Me.txtsituacion.Size = New System.Drawing.Size(353, 22)
        Me.txtsituacion.TabIndex = 3
        '
        'frmpromedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 534)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmpromedio"
        Me.Text = ".:.Promedio.:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncalc As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnotac As TextBox
    Friend WithEvents txtnotab As TextBox
    Friend WithEvents txtnotaa As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpromedio As TextBox
    Friend WithEvents txtsituacion As TextBox
End Class
