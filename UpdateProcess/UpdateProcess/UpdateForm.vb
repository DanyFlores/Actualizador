Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports System.Threading
Imports System.Media
Public Class UpdateForm

    Dim lastRequestedDir As String
    Dim localDir As String = "C:\\Users\\ad.flores\\Documents\\localDir"
    Public serverDir As String
    Dim restartCounter As Integer

    Private Sub UpdateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateProgress.Value = 0 'Inicio de la barra de progreso
        Dim di As DirectoryInfo = New DirectoryInfo(serverDir)
        Dim updateFiles() As String = Directory.GetFiles(serverDir) 'Array para obtener el listado de archivos del directorio de actualizacíón
        Dim localFiles() As String = Directory.GetFiles(localDir) 'Array para almacenar el listado de archivos disponibles en el directorio local
        'Intervalo de avance de la barra de progreso 
        updateProgress.Minimum = 0 'Inicio
        updateProgress.Maximum = updateFiles.Length 'Fin
        'Ciclo encargado de reemplazar los archivos del directorio local con los del directorio de actualización
        For Each f As String In updateFiles
            Dim fi As FileInfo = New FileInfo(f)
            txtInfoContainer.Text += "Moviendo el archivo " + fi.Name + " (" + fi.FullName + ") -> " + localDir + "\" + fi.Name & vbNewLine
            Try
                For Each fileName As String In localFiles
                    Dim localFile As FileInfo = New FileInfo(fileName)
                    If (localFile.Name = fi.Name) Then
                        File.Delete(localFile.FullName)
                        Dim path As String = localDir + "\\" + fi.Name
                        File.Copy(fi.FullName, path)
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            updateProgress.Value += 1 'Avanza la barra de progreso por cada archivo sobreescrito
        Next
        SystemSounds.Asterisk.Play() 'Alerta sonora (feedback para el usuario)
        restartCounter = 3
        txtInfoContainer.Text += "Actualización completada, reiniciando el sistema en 3 segundos..." & vbNewLine
        timer.Start()
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        restartCounter -= 1
        If (restartCounter = 0) Then
            timer.Stop()
            Process.Start("C:\\Users\\ad.flores\\Documents\\Visual Studio 2008\\Projects\\MasterProcess\\MasterProcess\\obj\\Debug\\MasterProcess.exe")
            System.Environment.Exit(0)
        End If
    End Sub
End Class