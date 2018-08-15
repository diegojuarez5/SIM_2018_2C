<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Punto_B
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dtgvChiCuadrado = New System.Windows.Forms.DataGridView()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaObservada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuenciaEsperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaDeFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferenciaAlCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCuadradoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblV = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lst_numeros = New System.Windows.Forms.ListBox()
        Me.graficarBTN = New System.Windows.Forms.Button()
        Me.Ktxt = New System.Windows.Forms.TextBox()
        Me.Ntxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvChiCuadrado
        '
        Me.dtgvChiCuadrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiCuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.intervalo, Me.frecuenciaObservada, Me.frecuenciaEsperada, Me.diferenciaDeFrecuencia, Me.diferenciaAlCuadrado, Me.xCuadradoI})
        Me.dtgvChiCuadrado.Location = New System.Drawing.Point(594, 100)
        Me.dtgvChiCuadrado.Name = "dtgvChiCuadrado"
        Me.dtgvChiCuadrado.ReadOnly = True
        Me.dtgvChiCuadrado.Size = New System.Drawing.Size(631, 312)
        Me.dtgvChiCuadrado.TabIndex = 58
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
        Me.btnLimpiar.Location = New System.Drawing.Point(446, 27)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(134, 36)
        Me.btnLimpiar.TabIndex = 57
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Location = New System.Drawing.Point(602, 30)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(93, 13)
        Me.lblV.TabIndex = 56
        Me.lblV.Text = "Grados de libertad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst_numeros)
        Me.GroupBox1.Location = New System.Drawing.Point(322, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 283)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SERIE DE NUMEROS"
        '
        'lst_numeros
        '
        Me.lst_numeros.FormattingEnabled = True
        Me.lst_numeros.Location = New System.Drawing.Point(8, 19)
        Me.lst_numeros.Name = "lst_numeros"
        Me.lst_numeros.Size = New System.Drawing.Size(238, 238)
        Me.lst_numeros.TabIndex = 0
        '
        'graficarBTN
        '
        Me.graficarBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.graficarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graficarBTN.Location = New System.Drawing.Point(258, 27)
        Me.graficarBTN.Name = "graficarBTN"
        Me.graficarBTN.Size = New System.Drawing.Size(157, 36)
        Me.graficarBTN.TabIndex = 54
        Me.graficarBTN.Text = "Graficar"
        Me.graficarBTN.UseVisualStyleBackColor = False
        '
        'Ktxt
        '
        Me.Ktxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ktxt.Location = New System.Drawing.Point(103, 47)
        Me.Ktxt.Name = "Ktxt"
        Me.Ktxt.Size = New System.Drawing.Size(100, 20)
        Me.Ktxt.TabIndex = 53
        '
        'Ntxt
        '
        Me.Ntxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ntxt.Location = New System.Drawing.Point(103, 14)
        Me.Ntxt.Name = "Ntxt"
        Me.Ntxt.Size = New System.Drawing.Size(100, 20)
        Me.Ntxt.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "K(intervalos)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "N de muestras"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(39, 100)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Observado"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Esperado"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(529, 312)
        Me.Chart1.TabIndex = 60
        Me.Chart1.Text = "Chart1"
        '
        'Punto_B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 750)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.dtgvChiCuadrado)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.graficarBTN)
        Me.Controls.Add(Me.Ktxt)
        Me.Controls.Add(Me.Ntxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Punto_B"
        Me.Text = "Punto_B"
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgvChiCuadrado As System.Windows.Forms.DataGridView
    Friend WithEvents intervalo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaObservada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuenciaEsperada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferenciaDeFrecuencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferenciaAlCuadrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xCuadradoI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lst_numeros As System.Windows.Forms.ListBox
    Friend WithEvents graficarBTN As System.Windows.Forms.Button
    Friend WithEvents Ktxt As System.Windows.Forms.TextBox
    Friend WithEvents Ntxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
