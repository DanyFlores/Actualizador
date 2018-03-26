Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports System.Threading

Public Class Form1

    Dim localDir = "C:\\Users\\ad.flores\\Documents\\localDir"
    Dim serverDir = "C:\\Users\\ad.flores\\Documents\\serverDir"
    Dim localFiles As New List(Of String)()
    Dim serverFiles As New List(Of String)()
    Dim fileCounter = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try ' Control de excepciones
            ' Funciones recursivas encargadas de realizar el llenado de la lista de archivos locales con el fin de utilizarlos para la comparación más adelante en la ejecución
            If (File.Exists(localDir)) Then ' Consulta si existe algún archivo dentro del directorio
                checkFile(localDir, localFiles) ' Llamada a la función para agregar la información de los archivos a la lista
            ElseIf (Directory.Exists(localDir)) Then ' Consulta si existe algún directorio hijo dentro del directorio principal
                checkDirectory(localDir, localFiles) ' Llamada a la función para explorar el directorio internamente en busca de archivos
            End If
            'Las siguientes 5 líneas se encargan de realizar lo mismo que se realizó en el proceso anterior, pero aplicado ahora a buscar archivos dentro del servidor
            If (File.Exists(serverDir)) Then
                checkFile(serverDir, serverFiles)
            ElseIf (Directory.Exists(serverDir)) Then
                checkDirectory(serverDir, serverFiles)
            End If
            'Debug.Write("Archivos encontrados en el directorio local: " + localFiles.Count) ' Línea de depuración, encargada de contar los archivos encontrados en el directorio local
            'Debug.Write("Archivos encontrados en el directorio de actualización: " + serverFiles.Count) ' Línea de depuración, encargada de contar los archivos encontrados en el directorio de actualización
            ' Ciclo encargado de realizar las comparaciones entre los archivos, para así determinar si tienen actualizaciones disponibles o no.
            Dim State As Boolean = False
            For Each fileName As String In localFiles
                Dim localFile As FileInfo = New FileInfo(fileName) ' Crea una instancia del objeto FileInfo para obtener la información necesaria del archivo local actual
                Debug.WriteLine("Comprobando actualizaciones para el archivo " + localFile.Name)
                For Each uFile As String In serverFiles
                    Dim serverFile As FileInfo = New FileInfo(uFile) ' Crea una instancia del objeto FileInfo para obtener la información necesaria de cada archivo del servidor, para así compararlos con el archivo local actual
                    Debug.Write("Local: " + localFile.Name + "\t" + localFile.LastWriteTime + "\nServidor: " + serverFile.Name + "\t" + serverFile.LastWriteTime)
                    Console.Write(Date.Compare(localFile.LastWriteTime, serverFile.LastWriteTime))
                    If (localFile.Name = serverFile.Name And Date.Compare(localFile.LastWriteTime, serverFile.LastWriteTime) < 0 And localFile.Directory.Name = serverFile.Directory.Name) Then ' Prueba lógica para determinar si existe una nueva versión del archivo o no
                        ' Proceso resultado en caso de encontrar una nueva versión del archivo en el servidor
                        If (MessageBox.Show("Se encontraron actualizaciones para uno o varios archivos necesarios para la ejecución del programa. ¿Desea actualizarlos?", "Actualizaciones encontradas", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)) Then
                            Process.Start("C:\\Users\\ad.flores\\Documents\\Visual Studio 2008\\Projects\\UpdateProcess\\UpdateProcess\\obj\\Release\\UpdateProcess.exe")
                            State = True
                            System.Environment.Exit(0) ' Llamada a la salida del proceso actual                            
                        End If
                    End If
                    If (State) Then
                        Exit For
                    End If
                Next
                If (State) Then
                    Exit For
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub checkDirectory(ByVal directoryPath As String, ByRef listToAppend As List(Of String))
        Dim filesList() As String = Directory.GetFiles(directoryPath)
        For Each fileName As String In filesList
            checkFile(fileName, listToAppend)
        Next

        Dim subdirectories() As String = Directory.GetDirectories(directoryPath)
        For Each subDir As String In subdirectories
            checkDirectory(subDir, listToAppend)
        Next
    End Sub

    Public Sub checkFile(ByVal filePath As String, ByRef listToAppend As List(Of String))
        listToAppend.Add(filePath)
    End Sub

    Private Sub btnInvokeRollback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvokeRollback.Click
        Process.Start("C:\\Users\\ad.flores\\Documents\\Visual Studio 2008\\Projects\\UpdateProcess\\UpdateProcess\\bin\\Debug\\UpdateProcess.exe", "rollback")
        System.Environment.Exit(0)
    End Sub
End Class
