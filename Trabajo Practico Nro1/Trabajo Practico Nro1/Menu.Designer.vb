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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_c = New System.Windows.Forms.Button()
        Me.btn_b = New System.Windows.Forms.Button()
        Me.btn_a = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "                     Alumnos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de la Orden ,Erazo,Fassino,Persico"
        '
        'btn_c
        '
        Me.btn_c.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_c.Location = New System.Drawing.Point(47, 163)
        Me.btn_c.Name = "btn_c"
        Me.btn_c.Size = New System.Drawing.Size(122, 36)
        Me.btn_c.TabIndex = 6
        Me.btn_c.Text = "PUNTO C"
        Me.btn_c.UseVisualStyleBackColor = False
        '
        'btn_b
        '
        Me.btn_b.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_b.Location = New System.Drawing.Point(47, 99)
        Me.btn_b.Name = "btn_b"
        Me.btn_b.Size = New System.Drawing.Size(122, 36)
        Me.btn_b.TabIndex = 5
        Me.btn_b.Text = "PUNTO B"
        Me.btn_b.UseVisualStyleBackColor = False
        '
        'btn_a
        '
        Me.btn_a.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_a.Location = New System.Drawing.Point(47, 36)
        Me.btn_a.Name = "btn_a"
        Me.btn_a.Size = New System.Drawing.Size(122, 36)
        Me.btn_a.TabIndex = 4
        Me.btn_a.Text = "PUNTO A"
        Me.btn_a.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(221, 281)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_c)
        Me.Controls.Add(Me.btn_b)
        Me.Controls.Add(Me.btn_a)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_c As System.Windows.Forms.Button
    Friend WithEvents btn_b As System.Windows.Forms.Button
    Friend WithEvents btn_a As System.Windows.Forms.Button

End Class
