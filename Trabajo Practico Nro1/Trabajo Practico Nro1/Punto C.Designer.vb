<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Punto_C
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnEjemplo = New System.Windows.Forms.Button()
        Me.dtgvChiCuadrado = New System.Windows.Forms.DataGridView()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaObservada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaEsperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaDeFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaAlCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCuadradoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lbl_K = New System.Windows.Forms.Label()
        Me.txt_intervalos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.K = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.generarBTN = New System.Windows.Forms.Button()
        Me.txt_M = New System.Windows.Forms.TextBox()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.txt_muestras = New System.Windows.Forms.TextBox()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEjemplo
        '
        Me.btnEjemplo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEjemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjemplo.Location = New System.Drawing.Point(79, 22)
        Me.btnEjemplo.Name = "btnEjemplo"
        Me.btnEjemplo.Size = New System.Drawing.Size(156, 23)
        Me.btnEjemplo.TabIndex = 67
        Me.btnEjemplo.Text = "Cargar Ejemplo"
        Me.btnEjemplo.UseVisualStyleBackColor = False
        '
        'dtgvChiCuadrado
        '
        Me.dtgvChiCuadrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiCuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.intervalo, Me.frecuenciaObservada, Me.frecuenciaEsperada, Me.diferenciaDeFrecuencia, Me.diferenciaAlCuadrado, Me.xCuadradoI})
        Me.dtgvChiCuadrado.Location = New System.Drawing.Point(754, 22)
        Me.dtgvChiCuadrado.Name = "dtgvChiCuadrado"
        Me.dtgvChiCuadrado.Size = New System.Drawing.Size(518, 340)
        Me.dtgvChiCuadrado.TabIndex = 66
        '
        'intervalo
        '
        Me.intervalo.HeaderText = "K"
        Me.intervalo.Name = "intervalo"
        Me.intervalo.ReadOnly = True
        '
        'frecuenciaObservada
        '
        Me.frecuenciaObservada.HeaderText = "Fo"
        Me.frecuenciaObservada.Name = "frecuenciaObservada"
        Me.frecuenciaObservada.ReadOnly = True
        '
        'frecuenciaEsperada
        '
        Me.frecuenciaEsperada.HeaderText = "Fe"
        Me.frecuenciaEsperada.Name = "frecuenciaEsperada"
        Me.frecuenciaEsperada.ReadOnly = True
        '
        'diferenciaDeFrecuencia
        '
        Me.diferenciaDeFrecuencia.HeaderText = "(Fo-Fe)"
        Me.diferenciaDeFrecuencia.Name = "diferenciaDeFrecuencia"
        Me.diferenciaDeFrecuencia.ReadOnly = True
        '
        'diferenciaAlCuadrado
        '
        Me.diferenciaAlCuadrado.HeaderText = "(Fo-Fe)^2"
        Me.diferenciaAlCuadrado.Name = "diferenciaAlCuadrado"
        Me.diferenciaAlCuadrado.ReadOnly = True
        '
        'xCuadradoI
        '
        Me.xCuadradoI.HeaderText = "((Fo-Fe)^2)/Fe"
        Me.xCuadradoI.Name = "xCuadradoI"
        Me.xCuadradoI.ReadOnly = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(591, 385)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(157, 35)
        Me.btnLimpiar.TabIndex = 57
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(249, 23)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Observado"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Esperado"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(499, 340)
        Me.Chart1.TabIndex = 65
        Me.Chart1.Text = "Chart1"
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.Location = New System.Drawing.Point(76, 396)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(111, 13)
        Me.lblV.TabIndex = 64
        Me.lblV.Text = "Grados de libertad"
        '
        'lbl_K
        '
        Me.lbl_K.AutoSize = True
        Me.lbl_K.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_K.Location = New System.Drawing.Point(24, 264)
        Me.lbl_K.Name = "lbl_K"
        Me.lbl_K.Size = New System.Drawing.Size(67, 13)
        Me.lbl_K.TabIndex = 63
        Me.lbl_K.Text = "Intervalos "
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intervalos.Location = New System.Drawing.Point(97, 257)
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(50, 20)
        Me.txt_intervalos.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "m"
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(76, 188)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(15, 13)
        Me.C.TabIndex = 61
        Me.C.Text = "C"
        '
        'K
        '
        Me.K.AutoSize = True
        Me.K.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(76, 141)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(14, 13)
        Me.K.TabIndex = 60
        Me.K.Text = "a"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(76, 94)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(15, 13)
        Me.label.TabIndex = 59
        Me.label.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "N de muestras"
        '
        'generarBTN
        '
        Me.generarBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.generarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generarBTN.Location = New System.Drawing.Point(78, 328)
        Me.generarBTN.Name = "generarBTN"
        Me.generarBTN.Size = New System.Drawing.Size(157, 35)
        Me.generarBTN.TabIndex = 56
        Me.generarBTN.Text = "Generar"
        Me.generarBTN.UseVisualStyleBackColor = False
        '
        'txt_M
        '
        Me.txt_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M.Location = New System.Drawing.Point(97, 220)
        Me.txt_M.Name = "txt_M"
        Me.txt_M.Size = New System.Drawing.Size(50, 20)
        Me.txt_M.TabIndex = 54
        '
        'txt_C
        '
        Me.txt_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_C.Location = New System.Drawing.Point(97, 181)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(50, 20)
        Me.txt_C.TabIndex = 53
        '
        'txt_A
        '
        Me.txt_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_A.Location = New System.Drawing.Point(97, 138)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(50, 20)
        Me.txt_A.TabIndex = 52
        '
        'txt_semilla
        '
        Me.txt_semilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_semilla.Location = New System.Drawing.Point(97, 94)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(50, 20)
        Me.txt_semilla.TabIndex = 51
        '
        'txt_muestras
        '
        Me.txt_muestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_muestras.Location = New System.Drawing.Point(97, 51)
        Me.txt_muestras.Name = "txt_muestras"
        Me.txt_muestras.Size = New System.Drawing.Size(50, 20)
        Me.txt_muestras.TabIndex = 50
        '
        'Punto_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 492)
        Me.Controls.Add(Me.btnEjemplo)
        Me.Controls.Add(Me.dtgvChiCuadrado)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.lbl_K)
        Me.Controls.Add(Me.txt_intervalos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.K)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.generarBTN)
        Me.Controls.Add(Me.txt_M)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.txt_semilla)
        Me.Controls.Add(Me.txt_muestras)
        Me.Name = "Punto_C"
        Me.Text = "Punto_C"
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEjemplo As System.Windows.Forms.Button
    Friend WithEvents dtgvChiCuadrado As System.Windows.Forms.DataGridView
    Friend WithEvents intervalo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaObservada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaEsperada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferenciaDeFrecuencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferenciaAlCuadrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCuadradoI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents lbl_K As System.Windows.Forms.Label
    Friend WithEvents txt_intervalos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C As System.Windows.Forms.Label
    Friend WithEvents K As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents generarBTN As System.Windows.Forms.Button
    Friend WithEvents txt_M As System.Windows.Forms.TextBox
    Friend WithEvents txt_C As System.Windows.Forms.TextBox
    Friend WithEvents txt_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_semilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_muestras As System.Windows.Forms.TextBox
End Class
