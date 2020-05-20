<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar
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
        Me.lvmeds = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBLabs = New System.Windows.Forms.ComboBox()
        Me.BTNBuscar = New System.Windows.Forms.Button()
        Me.BTNExportar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvmeds
        '
        Me.lvmeds.HideSelection = False
        Me.lvmeds.Location = New System.Drawing.Point(34, 84)
        Me.lvmeds.Name = "lvmeds"
        Me.lvmeds.Size = New System.Drawing.Size(687, 252)
        Me.lvmeds.TabIndex = 0
        Me.lvmeds.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Laboratorio"
        '
        'CMBLabs
        '
        Me.CMBLabs.FormattingEnabled = True
        Me.CMBLabs.Location = New System.Drawing.Point(97, 36)
        Me.CMBLabs.Name = "CMBLabs"
        Me.CMBLabs.Size = New System.Drawing.Size(121, 21)
        Me.CMBLabs.TabIndex = 2
        '
        'BTNBuscar
        '
        Me.BTNBuscar.Location = New System.Drawing.Point(224, 36)
        Me.BTNBuscar.Name = "BTNBuscar"
        Me.BTNBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BTNBuscar.TabIndex = 3
        Me.BTNBuscar.Text = "Buscar"
        Me.BTNBuscar.UseVisualStyleBackColor = True
        '
        'BTNExportar
        '
        Me.BTNExportar.Location = New System.Drawing.Point(646, 39)
        Me.BTNExportar.Name = "BTNExportar"
        Me.BTNExportar.Size = New System.Drawing.Size(75, 23)
        Me.BTNExportar.TabIndex = 4
        Me.BTNExportar.Text = "Exportar"
        Me.BTNExportar.UseVisualStyleBackColor = True
        '
        'Listar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNExportar)
        Me.Controls.Add(Me.BTNBuscar)
        Me.Controls.Add(Me.CMBLabs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvmeds)
        Me.Name = "Listar"
        Me.Text = "Listar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvmeds As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBLabs As ComboBox
    Friend WithEvents BTNBuscar As Button
    Friend WithEvents BTNExportar As Button
End Class
