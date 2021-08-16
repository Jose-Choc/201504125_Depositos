Public Class Depositos
    Dim result_Transaccion As Decimal
    Private Sub text_nuevosaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Nuevo_Saldo.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub text_saldoanterior_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Saldo_Anterior.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub button_calcular_Click(sender As Object, e As EventArgs) Handles button_calcular.Click
        If Check_Ahorro.Checked Or Check_Monetario.Checked Or Check_premium.Checked Then
            If Check_Ahorro.Checked Then
                result_Transaccion = 0
                result_Transaccion = val_Ahorro(Decimal.Parse(Text_Saldo_Anterior.Text), Decimal.Parse(Text_Nuevo_Saldo.Text))
                Text_Total.Text = result_Transaccion
            ElseIf Check_premium.Checked Then
                result_Transaccion = 0
                result_Transaccion = val_Premier(Decimal.Parse(Text_Saldo_Anterior.Text), Decimal.Parse(Text_Nuevo_Saldo.Text))
                Text_Total.Text = result_Transaccion
            ElseIf Check_Monetario.Checked Then

            End If
        Else
            MessageBox.Show("Debe seleccionar un tipo de transacción")
        End If
    End Sub
    Function val_Ahorro(Saldo_Anterior As Decimal, Nuevo_Saldo As Decimal) As Decimal
        Dim resultado As Decimal
        If Nuevo_Saldo > 0 And Nuevo_Saldo <= 1001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.015
        ElseIf Nuevo_Saldo > 1001 And Nuevo_Saldo <= 5001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.025
        ElseIf Nuevo_Saldo > 5001 And Nuevo_Saldo <= 15001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.075
        ElseIf Nuevo_Saldo > 15001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.1
        End If
        Return resultado
    End Function
    Function val_Premier(Saldo_Anterior As Decimal, Nuevo_Saldo As Decimal) As Decimal
        Dim resultado As Decimal
        If Nuevo_Saldo > 0 And Nuevo_Saldo <= 10001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.025
        ElseIf Nuevo_Saldo > 10001 And Nuevo_Saldo <= 15001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.03
        ElseIf Nuevo_Saldo > 15001 Then
            resultado = Saldo_Anterior + Nuevo_Saldo + Nuevo_Saldo * 0.045
        End If
        Return resultado
    End Function

    Private Sub Button_refresh_Click(sender As Object, e As EventArgs) Handles Button_refresh.Click
        Text_Nuevo_Saldo.Text = ""
        Text_Saldo_Anterior.Text = ""
        Text_Total.Text = ""
        result_Transaccion = 0
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If MessageBox.Show("Esta seguro de salir", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
