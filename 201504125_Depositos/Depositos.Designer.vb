<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depositos
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
        Me.Check_Monetario = New System.Windows.Forms.RadioButton()
        Me.Check_premium = New System.Windows.Forms.RadioButton()
        Me.Check_Ahorro = New System.Windows.Forms.RadioButton()
        Me.Saldo_Anterior = New System.Windows.Forms.Label()
        Me.button_calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Nuevo_Saldo = New System.Windows.Forms.Label()
        Me.Text_Saldo_Anterior = New System.Windows.Forms.TextBox()
        Me.Text_Nuevo_Saldo = New System.Windows.Forms.TextBox()
        Me.Text_Total = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.Button_refresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transacciones"
        '
        'Check_Monetario
        '
        Me.Check_Monetario.AutoSize = True
        Me.Check_Monetario.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Monetario.Location = New System.Drawing.Point(82, 79)
        Me.Check_Monetario.Name = "Check_Monetario"
        Me.Check_Monetario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check_Monetario.Size = New System.Drawing.Size(142, 31)
        Me.Check_Monetario.TabIndex = 1
        Me.Check_Monetario.Text = "Monetario "
        Me.Check_Monetario.UseMnemonic = False
        Me.Check_Monetario.UseVisualStyleBackColor = True
        '
        'Check_premium
        '
        Me.Check_premium.AutoSize = True
        Me.Check_premium.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_premium.Location = New System.Drawing.Point(284, 79)
        Me.Check_premium.Name = "Check_premium"
        Me.Check_premium.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check_premium.Size = New System.Drawing.Size(238, 31)
        Me.Check_premium.TabIndex = 2
        Me.Check_premium.Text = "Monetario Premium"
        Me.Check_premium.UseMnemonic = False
        Me.Check_premium.UseVisualStyleBackColor = True
        '
        'Check_Ahorro
        '
        Me.Check_Ahorro.AutoSize = True
        Me.Check_Ahorro.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Ahorro.Location = New System.Drawing.Point(582, 79)
        Me.Check_Ahorro.Name = "Check_Ahorro"
        Me.Check_Ahorro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check_Ahorro.Size = New System.Drawing.Size(101, 31)
        Me.Check_Ahorro.TabIndex = 3
        Me.Check_Ahorro.Text = "Ahorro"
        Me.Check_Ahorro.UseMnemonic = False
        Me.Check_Ahorro.UseVisualStyleBackColor = True
        '
        'Saldo_Anterior
        '
        Me.Saldo_Anterior.AutoSize = True
        Me.Saldo_Anterior.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldo_Anterior.Location = New System.Drawing.Point(193, 153)
        Me.Saldo_Anterior.Name = "Saldo_Anterior"
        Me.Saldo_Anterior.Size = New System.Drawing.Size(141, 24)
        Me.Saldo_Anterior.TabIndex = 9
        Me.Saldo_Anterior.Text = "Saldo Anterior"
        '
        'button_calcular
        '
        Me.button_calcular.BackColor = System.Drawing.Color.LimeGreen
        Me.button_calcular.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_calcular.Location = New System.Drawing.Point(371, 372)
        Me.button_calcular.Name = "button_calcular"
        Me.button_calcular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_calcular.Size = New System.Drawing.Size(101, 34)
        Me.button_calcular.TabIndex = 7
        Me.button_calcular.Text = "Calcular"
        Me.button_calcular.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Red
        Me.Salir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(160, 372)
        Me.Salir.Name = "Salir"
        Me.Salir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Salir.Size = New System.Drawing.Size(101, 34)
        Me.Salir.TabIndex = 8
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Nuevo_Saldo
        '
        Me.Nuevo_Saldo.AutoSize = True
        Me.Nuevo_Saldo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo_Saldo.Location = New System.Drawing.Point(199, 224)
        Me.Nuevo_Saldo.Name = "Nuevo_Saldo"
        Me.Nuevo_Saldo.Size = New System.Drawing.Size(129, 24)
        Me.Nuevo_Saldo.TabIndex = 10
        Me.Nuevo_Saldo.Text = "Nuevo Saldo"
        '
        'Text_Saldo_Anterior
        '
        Me.Text_Saldo_Anterior.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Saldo_Anterior.Location = New System.Drawing.Point(371, 150)
        Me.Text_Saldo_Anterior.Name = "Text_Saldo_Anterior"
        Me.Text_Saldo_Anterior.Size = New System.Drawing.Size(151, 32)
        Me.Text_Saldo_Anterior.TabIndex = 4
        '
        'Text_Nuevo_Saldo
        '
        Me.Text_Nuevo_Saldo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Nuevo_Saldo.Location = New System.Drawing.Point(371, 221)
        Me.Text_Nuevo_Saldo.Name = "Text_Nuevo_Saldo"
        Me.Text_Nuevo_Saldo.Size = New System.Drawing.Size(151, 32)
        Me.Text_Nuevo_Saldo.TabIndex = 5
        '
        'Text_Total
        '
        Me.Text_Total.Enabled = False
        Me.Text_Total.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Total.Location = New System.Drawing.Point(378, 286)
        Me.Text_Total.Name = "Text_Total"
        Me.Text_Total.Size = New System.Drawing.Size(137, 32)
        Me.Text_Total.TabIndex = 6
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(236, 289)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(54, 24)
        Me.Total.TabIndex = 11
        Me.Total.Text = "Total"
        '
        'Button_refresh
        '
        Me.Button_refresh.BackColor = System.Drawing.Color.Gold
        Me.Button_refresh.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_refresh.Location = New System.Drawing.Point(582, 372)
        Me.Button_refresh.Name = "Button_refresh"
        Me.Button_refresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_refresh.Size = New System.Drawing.Size(101, 34)
        Me.Button_refresh.TabIndex = 12
        Me.Button_refresh.Text = "Refrescar"
        Me.Button_refresh.UseVisualStyleBackColor = False
        '
        'Depositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(786, 450)
        Me.Controls.Add(Me.Button_refresh)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Text_Total)
        Me.Controls.Add(Me.Text_Nuevo_Saldo)
        Me.Controls.Add(Me.Text_Saldo_Anterior)
        Me.Controls.Add(Me.Nuevo_Saldo)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.button_calcular)
        Me.Controls.Add(Me.Saldo_Anterior)
        Me.Controls.Add(Me.Check_Ahorro)
        Me.Controls.Add(Me.Check_premium)
        Me.Controls.Add(Me.Check_Monetario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Depositos"
        Me.Text = "Depositos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Check_Monetario As RadioButton
    Friend WithEvents Check_premium As RadioButton
    Friend WithEvents Check_Ahorro As RadioButton
    Friend WithEvents Saldo_Anterior As Label
    Friend WithEvents button_calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Nuevo_Saldo As Label
    Friend WithEvents Text_Saldo_Anterior As TextBox
    Friend WithEvents Text_Nuevo_Saldo As TextBox
    Friend WithEvents Text_Total As TextBox
    Friend WithEvents Total As Label
    Friend WithEvents Button_refresh As Button
End Class
