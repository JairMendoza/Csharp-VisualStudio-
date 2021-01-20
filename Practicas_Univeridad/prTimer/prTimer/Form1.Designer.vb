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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnplay = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IncanatoIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IncanatoIT"
        '
        'btnplay
        '
        Me.btnplay.ForeColor = System.Drawing.Color.Red
        Me.btnplay.Location = New System.Drawing.Point(332, 32)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(102, 39)
        Me.btnplay.TabIndex = 2
        Me.btnplay.Text = "Play"
        Me.btnplay.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.ForeColor = System.Drawing.Color.Red
        Me.btnstop.Location = New System.Drawing.Point(332, 95)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(102, 45)
        Me.btnstop.TabIndex = 3
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.ForeColor = System.Drawing.Color.Red
        Me.lblfecha.Location = New System.Drawing.Point(12, 9)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(51, 17)
        Me.lblfecha.TabIndex = 4
        Me.lblfecha.Text = "Label3"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 219)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = ".:.Control Timer.:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnplay As Button
    Friend WithEvents btnstop As Button
    Friend WithEvents lblfecha As Label
    Protected Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
