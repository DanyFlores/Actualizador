Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports System.Threading

Public Class Form1
    Dim localDir = "C:\\Users\\ad.flores\\Documents\\localDir"
    Dim serverDir = "C:\\Users\\ad.flores\\Documents\\Container"
    Dim localFiles As New List(Of String)()
    Dim serverFiles As New List(Of String)()
    Dim fileCounter = 1
    Dim uf As UpdateForm = New UpdateForm()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Dim args() As String = Environment.GetCommandLineArgs()
        If (args.Contains("rollback")) Then
            Dim rb As frmRollback = New frmRollback()
            rb.Show()
            rb.BringToFront()
            Me.Close()
        ElseIf Not (args.Contains("rollback")) Then
            btnUpdate.Enabled = False
            btnCancel.Enabled = False
            Dim lastRequestedDir = My.Settings.LastDirAvailable
            Dim Subdirectories() As String = Directory.GetDirectories(serverDir)
            My.Settings.LastDirAvailable = Subdirectories.Last()
            My.Settings.Save()
            If (lastRequestedDir.Equals(My.Settings.LastDirAvailable)) Then
                Process.Start("C:\\Users\\ad.flores\\Documents\\Visual Studio 2008\\Projects\\MasterProcess\\MasterProcess\\obj\\Debug\\MasterProcess.exe")
                Me.Close()
            Else
                Me.Visible = True
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
