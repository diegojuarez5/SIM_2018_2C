Public Class Punto_A
    Dim n As Integer
    Dim count As Integer
    Dim x As Double
    Dim c1 As Double
    Dim a As Double
    Dim ri As Double
    Dim m As Double
    Dim x1 As Double 'Representa el ultimo nro generado'
    Dim var As Boolean

    Private Sub PUNTO_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'txt_muestras.Text = 20
        'txt_muestras.Enabled = False
        txt_C.Enabled = False
        rdb_MIXTO.Checked = True
    End Sub
    Private Function ValidarVacio() As Boolean

        If (txt_M.Text = "" Or txt_A.Text = "" Or txt_semilla.Text = "" Or txt_muestras.Text = "") Then
            var = False
        Else
            var = True
        End If
        Return var
    End Function

    Private Sub btn_Generar_Click(sender As Object, e As EventArgs) Handles btn_Generar.Click
        ValidarVacio()
        If var = False Then
            MsgBox("Por favor ingrese las variables")
            txt_muestras.Focus()
        Else : lbx_general.Items.Clear() 'vacia la lista general'
            n = txt_muestras.Text
            Dim lista(0 To (n - 1)) As Double
            count = 0
            x = txt_semilla.Text
            a = txt_A.Text

            m = txt_M.Text


            If rdb_MIXTO.Checked Then
                For count = 0 To (n - 1)
                    c1 = txt_C.Text

                    x = (a * x)
                    x = x + c1
                    x = x Mod m

                    ri = x / m
                    lista(count) = Math.Round(ri, 4)
                    'lista(count) = x

                Next count
                x1 = x 'aca se guarda el ultimo nro generado'

                For count = 0 To (n - 1)
                    lbx_general.Items.Add(lista(count))
                Next count
            Else
                If rdb_multiplicativo.Checked Then
                    For count = 0 To (n - 1)


                        x = (a * x) Mod m
                        ri = x / m
                        lista(count) = Math.Round(ri, 4)
                        'lista(count) = x


                    Next count
                    x1 = x 'aca se guarda el ultimo nro generado'
                    For count = 0 To (n - 1)
                        lbx_general.Items.Add(lista(count))
                    Next count

                End If
            End If

            x1 = x

        End If
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        ValidarVacio()
        If var = False Then
            MsgBox("Por favor ingrese todos los valores requeridos")
        Else
            'Dim ri As Double
            If rdb_MIXTO.Checked Then
                x1 = (a * x1)
                x1 = x1 + c1
                x1 = x1 Mod m
                ri = x1 / m

            Else
                x1 = (a * x1) Mod m
                ri = x1 / m
            End If
            'ri = x1
            'lbx_general.Items.Add(x1)
            lbx_general.Items.Add(Math.Round(ri, 4))
            lbx_general.SelectedIndex = lbx_general.Items.Count - 1
        End If
    End Sub
    Private Sub rdb_MIXTO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_MIXTO.CheckedChanged
        txt_C.Enabled = True

    End Sub

    Private Sub rdb_multiplicativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_multiplicativo.CheckedChanged
        txt_C.Enabled = False
    End Sub

    Private Sub txt_A_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_A.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_semilla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_semilla.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_C_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_C.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txt_M_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_M.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        lbx_general.Items.Clear()
        txt_C.Clear()
        txt_A.Clear()
        txt_M.Clear()
        txt_semilla.Clear()
        txt_muestras.Clear()
    End Sub

    Private Sub txt_muestras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_muestras.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub
End Class