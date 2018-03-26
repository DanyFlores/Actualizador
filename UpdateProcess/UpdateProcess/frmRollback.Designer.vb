<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRollback
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
        Me.dgVersions = New System.Windows.Forms.DataGridView
        Me.SoftwareVersion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SoftwareDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SoftwareRollback = New System.Windows.Forms.DataGridViewButtonColumn
        CType(Me.dgVersions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVersions
        '
        Me.dgVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVersions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SoftwareVersion, Me.SoftwareDate, Me.SoftwareRollback})
        Me.dgVersions.Location = New System.Drawing.Point(13, 13)
        Me.dgVersions.Name = "dgVersions"
        Me.dgVersions.Size = New System.Drawing.Size(711, 181)
        Me.dgVersions.TabIndex = 0
        '
        'SoftwareVersion
        '
        Me.SoftwareVersion.HeaderText = "Versión"
        Me.SoftwareVersion.Name = "SoftwareVersion"
        Me.SoftwareVersion.ReadOnly = True
        Me.SoftwareVersion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SoftwareVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SoftwareVersion.Width = 300
        '
        'SoftwareDate
        '
        Me.SoftwareDate.HeaderText = "Fecha"
        Me.SoftwareDate.Name = "SoftwareDate"
        Me.SoftwareDate.Width = 200
        '
        'SoftwareRollback
        '
        Me.SoftwareRollback.HeaderText = ""
        Me.SoftwareRollback.Name = "SoftwareRollback"
        Me.SoftwareRollback.Width = 150
        '
        'frmRollback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 204)
        Me.Controls.Add(Me.dgVersions)
        Me.Name = "frmRollback"
        Me.Text = "Historial de actualizaciones"
        CType(Me.dgVersions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgVersions As System.Windows.Forms.DataGridView
    Friend WithEvents SoftwareVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoftwareDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoftwareRollback As System.Windows.Forms.DataGridViewButtonColumn
End Class
