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
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.lblUpdatesNotifier = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(180, 51)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Instalar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblUpdatesNotifier
        '
        Me.lblUpdatesNotifier.AutoSize = True
        Me.lblUpdatesNotifier.Location = New System.Drawing.Point(12, 18)
        Me.lblUpdatesNotifier.Name = "lblUpdatesNotifier"
        Me.lblUpdatesNotifier.Size = New System.Drawing.Size(390, 13)
        Me.lblUpdatesNotifier.TabIndex = 3
        Me.lblUpdatesNotifier.Text = "Se encontraron actualizaciones para los archivos del sistema, ¿desea instalarlas?" & _
            ""
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(261, 51)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Continuar sin actualizar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 86)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUpdatesNotifier)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "Form1"
        Me.Text = "Actualización disponible"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblUpdatesNotifier As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
