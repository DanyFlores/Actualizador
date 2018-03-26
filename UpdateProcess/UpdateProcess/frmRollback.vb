Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports System.Threading
Imports System.Media

Public Class frmRollback

    Dim AvailableRollbackFiles As String() 'Array encargado de listar los directorios de versiones disponibles
    'Strings usados para especificar las rutas donde se encuentran ubicados los archivos a consultar y reemplazar
    Dim localDir As String = "C:\\Users\\ad.flores\\Documents\\localDir" 'Directorio local de instalación
    Dim serverDir As String = "C:\\Users\\ad.flores\\Documents\\Container" 'Directorio de actualizaciones/versiones

    Private Sub frmRollback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgVersions.AllowUserToAddRows = False 'Evita mostrar un Row más al finalizar de enlistar las versiones disponibles
        AvailableRollbackFiles = Directory.GetDirectories(serverDir) 'Almacena los directorios de cada versión disponible en el Array
        Dim row As String() 'String utilizado para añadir rows al DataGridView
        'Ciclo para añadir las versiones al DataGridView
        For Each ver In AvailableRollbackFiles
            Dim di As DirectoryInfo = New DirectoryInfo(ver)
            row = New String() {di.Name, di.Name.Replace(".", "/").Substring(1, di.Name.Length - 1), "Regresar a esta versión"}
            dgVersions.Rows.Add(row)
        Next
    End Sub

    'Método encargado de realizar la acción de rollback de versión al clickear un botón dentro del DataGridView
    Private Sub dgVersions_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVersions.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then 'Comprobación para saber que el objeto al que se le hizo click es un botón
            Dim rollbackDir As String = AvailableRollbackFiles.ElementAt(e.RowIndex) 'String que almacena la ruta al directorio del cuál se tomará la versión para reemplazar
            Dim di As DirectoryInfo = New DirectoryInfo(rollbackDir)
            Dim uf As UpdateForm = New UpdateForm
            uf.serverDir = di.FullName
            uf.Show()
            Me.Close()
        End If
    End Sub
End Class