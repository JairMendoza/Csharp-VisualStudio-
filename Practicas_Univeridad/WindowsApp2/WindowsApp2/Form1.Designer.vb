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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpunitario = New System.Windows.Forms.TextBox()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.shkdesc = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpparcial = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtpneto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.shkdesc)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btncalcular)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtcant)
        Me.GroupBox1.Controls.Add(Me.txtpunitario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Ingresados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpneto)
        Me.GroupBox2.Controls.Add(Me.txtdescuento)
        Me.GroupBox2.Controls.Add(Me.txtpparcial)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 204)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio Unitario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad:"
        '
        'txtpunitario
        '
        Me.txtpunitario.Location = New System.Drawing.Point(151, 48)
        Me.txtpunitario.Name = "txtpunitario"
        Me.txtpunitario.Size = New System.Drawing.Size(272, 22)
        Me.txtpunitario.TabIndex = 2
        '
        'txtcant
        '
        Me.txtcant.Location = New System.Drawing.Point(151, 112)
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(272, 22)
        Me.txtcant.TabIndex = 3
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(59, 177)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(202, 177)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(348, 177)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 6
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'shkdesc
        '
        Me.shkdesc.AutoSize = True
        Me.shkdesc.Location = New System.Drawing.Point(336, 150)
        Me.shkdesc.Name = "shkdesc"
        Me.shkdesc.Size = New System.Drawing.Size(145, 21)
        Me.shkdesc.TabIndex = 7
        Me.shkdesc.Text = "Aplicar Descuento"
        Me.shkdesc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Precio Parcial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Descuento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio Neto:"
        '
        'txtpparcial
        '
        Me.txtpparcial.Location = New System.Drawing.Point(143, 66)
        Me.txtpparcial.Name = "txtpparcial"
        Me.txtpparcial.Size = New System.Drawing.Size(100, 22)
        Me.txtpparcial.TabIndex = 11
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(143, 117)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 22)
        Me.txtdescuento.TabIndex = 12
        '
        'txtpneto
        '
        Me.txtpneto.Location = New System.Drawing.Point(143, 169)
        Me.txtpneto.Name = "txtpneto"
        Me.txtpneto.Size = New System.Drawing.Size(100, 22)
        Me.txtpneto.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = ".:.Estructuras Condicionales.:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents shkdesc As CheckBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtcant As TextBox
    Friend WithEvents txtpunitario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtpneto As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtpparcial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
