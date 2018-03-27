Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports System.Threading
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Dim localDir = SpecialDirectories.ProgramFiles
    Dim serverDir = "\\\\JMADC1\\Comparte\"
    Dim localFiles As New List(Of String)()
    Dim serverFiles As New List(Of String)()
    Dim fileCounter = 1
    Dim uf As UpdateForm = New UpdateForm()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnUpdate.Enabled = False
        btnCancel.Enabled = False
        If (UpdateHelper.ExecutionForm(Environment.GetCommandLineArgs())) Then
            Dim rb As frmRollback = New frmRollback()
            rb.Show()
            rb.BringToFront()
            Me.Close()
        Else
            MessageBox.Show(UpdateHelper.LastVerifiedDirectory + " - " + My.Settings.LastDirAvailable)
            If (UpdateHelper.isNewVersionAvailable()) Then
                Process.Start("C:\\Users\\ad.flores\\Documents\\Visual Studio 2008\\Projects\\MasterProcess\\MasterProcess\\obj\\Debug\\MasterProcess.exe")
                Me.Close()
            Else
                btnUpdate.Enabled = True
                btnCancel.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Me.Hide()
        uf.serverDir = My.Settings.LastDirAvailable
        uf.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Process.Start("C:\\Users\\ad.flores\\Documents\\Visual Studio 2008\\Projects\\MasterProcess\\MasterProcess\\obj\\Debug\\MasterProcess.exe")
        Me.Close()
    End Sub
End Class
