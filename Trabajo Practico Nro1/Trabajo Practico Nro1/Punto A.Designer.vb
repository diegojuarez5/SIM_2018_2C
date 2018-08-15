<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Punto_A
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
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.lbx_general = New System.Windows.Forms.ListBox()
        Me.btn_Generar = New System.Windows.Forms.Button()
        Me.rdb_multiplicativo = New System.Windows.Forms.RadioButton()
        Me.rdb_MIXTO = New System.Windows.Forms.RadioButton()
        Me.txt_M = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.Label()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.K = New System.Windows.Forms.Label()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txt_muestras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(245, 468)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 34
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(245, 234)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(75, 23)
        Me.btn_Next.TabIndex = 33
        Me.btn_Next.Text = "Siguiente"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'lbx_general
        '
        Me.lbx_general.FormattingEnabled = True
        Me.lbx_general.Location = New System.Drawing.Point(20, 276)
        Me.lbx_general.Name = "lbx_general"
        Me.lbx_general.Size = New System.Drawing.Size(305, 186)
        Me.lbx_general.TabIndex = 32
        '
        'btn_Generar
        '
        Me.btn_Generar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Generar.Location = New System.Drawing.Point(164, 234)
        Me.btn_Generar.Name = "btn_Generar"
        Me.btn_Generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Generar.TabIndex = 31
        Me.btn_Generar.Text = "Generar"
        Me.btn_Generar.UseVisualStyleBackColor = False
        '
        'rdb_multiplicativo
        '
        Me.rdb_multiplicativo.AutoSize = True
        Me.rdb_multiplicativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_multiplicativo.Location = New System.Drawing.Point(225, 50)
        Me.rdb_multiplicativo.Name = "rdb_multiplicativo"
        Me.rdb_multiplicativo.Size = New System.Drawing.Size(100, 17)
        Me.rdb_multiplicativo.TabIndex = 30
        Me.rdb_multiplicativo.TabStop = True
        Me.rdb_multiplicativo.Text = "Multiplicativo"
        Me.rdb_multiplicativo.UseVisualStyleBackColor = True
        '
        'rdb_MIXTO
        '
        Me.rdb_MIXTO.AutoSize = True
        Me.rdb_MIXTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_MIXTO.Location = New System.Drawing.Point(225, 14)
        Me.rdb_MIXTO.Name = "rdb_MIXTO"
        Me.rdb_MIXTO.Size = New System.Drawing.Size(55, 17)
        Me.rdb_MIXTO.TabIndex = 29
        Me.rdb_MIXTO.TabStop = True
        Me.rdb_MIXTO.Text = "Mixto"
        Me.rdb_MIXTO.UseVisualStyleBackColor = True
        '
        'txt_M
        '
        Me.txt_M.Location = New System.Drawing.Point(111, 179)
        Me.txt_M.Name = "txt_M"
        Me.txt_M.Size = New System.Drawing.Size(42, 20)
        Me.txt_M.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "m"
        '
        'txt_C
        '
        Me.txt_C.Location = New System.Drawing.Point(111, 138)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(42, 20)
        Me.txt_C.TabIndex = 26
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(70, 145)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(15, 13)
        Me.C.TabIndex = 25
        Me.C.Text = "C"
        '
        'txt_A
        '
        Me.txt_A.Location = New System.Drawing.Point(111, 101)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(42, 20)
        Me.txt_A.TabIndex = 24
        '
        'K
        '
        Me.K.AutoSize = True
        Me.K.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(71, 108)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(14, 13)
        Me.K.TabIndex = 23
        Me.K.Text = "a"
        '
        'txt_semilla
        '
        Me.txt_semilla.Location = New System.Drawing.Point(111, 65)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(42, 20)
        Me.txt_semilla.TabIndex = 22
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(71, 68)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(15, 13)
        Me.label.TabIndex = 21
        Me.label.Text = "X"
        '
        'txt_muestras
        '
        Me.txt_muestras.Location = New System.Drawing.Point(111, 17)
        Me.txt_muestras.Name = "txt_muestras"
        Me.txt_muestras.Size = New System.Drawing.Size(42, 20)
        Me.txt_muestras.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "N de muestras"
        '
        'Punto_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 512)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.lbx_general)
        Me.Controls.Add(Me.btn_Generar)
        Me.Controls.Add(Me.rdb_multiplicativo)
        Me.Controls.Add(Me.rdb_MIXTO)
        Me.Controls.Add(Me.txt_M)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.K)
        Me.Controls.Add(Me.txt_semilla)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txt_muestras)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Punto_A"
        Me.Text = "Punto_A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_Next As System.Windows.Forms.Button
    Friend WithEvents lbx_general As System.Windows.Forms.ListBox
    Friend WithEvents btn_Generar As System.Windows.Forms.Button
    Friend WithEvents rdb_multiplicativo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_MIXTO As System.Windows.Forms.RadioButton
    Friend WithEvents txt_M As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_C As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.Label
    Friend WithEvents txt_A As System.Windows.Forms.TextBox
    Friend WithEvents K As System.Windows.Forms.Label
    Friend WithEvents txt_semilla As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txt_muestras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
