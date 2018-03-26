<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.components = New System.ComponentModel.Container
        Me.txtInfoContainer = New System.Windows.Forms.RichTextBox
        Me.updateProgress = New System.Windows.Forms.ProgressBar
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtInfoContainer
        '
        Me.txtInfoContainer.Location = New System.Drawing.Point(12, 42)
        Me.txtInfoContainer.Name = "txtInfoContainer"
        Me.txtInfoContainer.Size = New System.Drawing.Size(616, 218)
        Me.txtInfoContainer.TabIndex = 4
        Me.txtInfoContainer.Text = ""
        '
        'updateProgress
        '
        Me.updateProgress.Location = New System.Drawing.Point(12, 12)
        Me.updateProgress.Name = "updateProgress"
        Me.updateProgress.Size = New System.Drawing.Size(616, 23)
        Me.updateProgress.TabIndex = 3
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 267)
        Me.Controls.Add(Me.txtInfoContainer)
        Me.Controls.Add(Me.updateProgress)
        Me.Name = "UpdateForm"
        Me.Text = "Actualizando"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtInfoContainer As System.Windows.Forms.RichTextBox
    Friend WithEvents updateProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents timer As System.Windows.Forms.Timer
End Class
