Imports System.Windows.Forms.DataVisualization.Charting
Public Class Punto_B
    Dim var As Boolean

    Private Sub Punto_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series(0).Points.Clear()
    End Sub

    Private Function ValidarVacio() As Boolean
        If (Ntxt.Text = "" Or Ktxt.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function


    Private Sub graficarBTN_Click(sender As Object, e As EventArgs) Handles graficarBTN.Click
        ValidarVacio()
        If var = False Then
            MsgBox("Por favor ingrese todos los valores solicitados")
        Else
            limpiarGraficoListaYtabla()
            Dim eje_y As Double
            Dim random As New Random()
            Dim intervalos As Double
            Dim n As Integer = Ntxt.Text
            Dim lista(0 To (n - 1)) As Double
            Dim count As Integer = 0
            Dim sum As Integer
            Dim k As Integer = Ktxt.Text ''numero de intervalos equiprobables entre 0 y 1
            Dim med As Double
            Dim xCuadradoTabulado As Double = 0 ''variable que asumira el rol de xi cuadrado tabulado
            Dim xCuadradoCalculado As Double = 0 ''variable que asumira el rol de xi cuadrado para ser comparado con la tabla


            For num As Decimal = 0 To (Ntxt.Text - 1) ''iteramos la cantidad de n-1 elegidas por el usuario
                eje_y = Rnd() ''asignamos numero random al eje y
                lst_numeros.Items.Add(Math.Round(eje_y, 5)) ''lo agregamos a la lista q se muestra en pantalla
                'Round(yvalue, 3)

                lista(num) = eje_y ''lo agregamos a la lista para el lbl

            Next

            intervalos = 1 / k ''probabilidad de cada intevalo
            med = n / k ''MEDIDA DE LOS INTERVALOS'' = frecuencia esperada

            Dim fila As Double = 0
            intervalos = Math.Round(intervalos, 3)
            ''ESTABLECE EL VALOR REDONDEADO DE LOS INTERVALOS EN 3 DIGITOS''

            For i As Double = 0 To (0.99) Step intervalos ''recorremos los intervalos saltando de forma entera, pero el intervalo es decimal.
                ''de esta forma buscamos los numeros en la lista que pertenecen a cada intervalo para sumarlos
                ''a la muestra
                sum = 0 ''contador de frecuencia , que sera al final el ciclo la frecuencia observada de dicho valor
                For count = 0 To (n - 1) ''iteramos desde 0 hasta la cantidad de muestras solicitadas
                    If i <= lista(count) Then ''si el numero pseudo-aleaotrio es mayor que el limite inferior del intervalo 
                        If lista(count) < (i + intervalos) Then ''y menor que el limite superior del intervalo
                            sum = sum + 1 ''incremento de la frecuencia de aparicion en dicho intervalo
                        End If
                    End If
                Next count
                Chart1.Series("Observado").Points.AddXY((i + intervalos), sum) ''graficamos el valor observado en el intervalo i
                Chart1.Series("Esperado").Points.AddXY((i + intervalos), med) '' y graficamos el valor del esperado en el intervalo i
                '' calculo de chi - cuadrado
                dtgvChiCuadrado.Rows.Add() ''agregamos una fila por cada ciclo
                dtgvChiCuadrado.Rows((fila)).Cells(0).Value = i.ToString() + " - " + (i + intervalos).ToString ''agregamos el rango del intervalo a la grilla
                dtgvChiCuadrado.Rows((fila)).Cells(1).Value = sum.ToString ''agregamos la frecuencia observada
                dtgvChiCuadrado.Rows((fila)).Cells(2).Value = med.ToString ''agregamos frecuencia esperada

                Dim fdif As Double = sum - med
                dtgvChiCuadrado.Rows((fila)).Cells(3).Value = fdif.ToString ''agregamos diferencia de frecuencias
                Dim difCuadrado As Double = fdif * fdif
                dtgvChiCuadrado.Rows((fila)).Cells(4).Value = difCuadrado.ToString ''agregamos diferencia al cuadrado
                Dim xCuadradoI As Double = difCuadrado / med ''calculo ((fo - fe)^2 )/ fe
                dtgvChiCuadrado.Rows((fila)).Cells(5).Value = xCuadradoI.ToString ''agreagamos xicuadrado

                xCuadradoCalculado += xCuadradoI ''voy realizando sumatoria de ((fo - fe)^2 )/ fe
                fila += 1
            Next
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila)).Cells(4).Value = "Xi Cuadrado calculado"
            dtgvChiCuadrado.Rows((fila)).Cells(5).Value = xCuadradoCalculado.ToString ''agregamos el xi cuadrado a la grilla

            Chart1.Series("Observado").ChartType = SeriesChartType.Column
            Chart1.Series("Observado").XValueType = ChartValueType.Double
            Chart1.Series("Observado").YValueType = ChartValueType.Int32
            Chart1.ChartAreas(0).AxisX.Interval = intervalos
            Chart1.Series("Observado").IsVisibleInLegend = True

            lblV.Text = "Los grados de libertad son: " + (k - 1).ToString
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila + 1)).Cells(4).Value = "Xi cuadrado Tabulado"
            Dim xiTabulado As String = Form1.listaChipcuadrada(k - 2).ToString()
            If xiTabulado Is "" Then ''si la posicion del vector no tiene valores, cambia el string xiTabulado
                xiTabulado = "No hay valores para esos grados de libertad"
                dtgvChiCuadrado.Rows((fila + 1)).Cells(5).Value = xiTabulado.ToString
            Else
                dtgvChiCuadrado.Rows((fila + 1)).Cells(5).Value = xiTabulado.ToString
                If Convert.ToDouble(xiTabulado.ToString) > xCuadradoCalculado Then
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Value = "Aceptado"
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Style.BackColor = Color.Green
                Else
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Value = "Rechazado"
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Style.BackColor = Color.Red
                End If
            End If



        End If
    End Sub

    Private Sub Ntxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ntxt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Ktxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ktxt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub
    Private Sub limpiarGraficoListaYtabla()
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        dtgvChiCuadrado.Rows.Clear()
        lst_numeros.Items.Clear()
        lst_numeros.Show()
    End Sub
    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Ntxt.Text = ""
        Ktxt.Text = ""
        lst_numeros.Items.Clear()
        lst_numeros.Show()
        dtgvChiCuadrado.Rows.Clear()
        lblV.Text = "Grados de Libertad"
    End Sub
End Class