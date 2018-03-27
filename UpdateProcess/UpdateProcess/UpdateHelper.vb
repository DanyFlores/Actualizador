Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class UpdateHelper

    Public Shared LocalInstallationDirectory As String = SpecialDirectories.ProgramFiles + "\\JMA\\SAC\\"
    Public Shared UpdateProviderDirectory As String = "\\\\JMADC1\\Comparte\\"
    Public Shared LastVerifiedDirectory As String = My.Settings.LastDirAvailable

    Public Shared Function isNewVersionAvailable() As Boolean
        Dim UpdateDirectories() As String = Directory.GetDirectories(UpdateProviderDirectory, "SetupSACU*")
        My.Settings.LastDirAvailable = UpdateDirectories.Last()
        My.Settings.Save()
        If (LastVerifiedDirectory.Equals(My.Settings.LastDirAvailable)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function ExecutionForm(ByRef CommandLineFlags() As String) As Boolean
        If (CommandLineFlags.Contains("rollback")) Then
            Return True
        End If
        Return False
    End Function

End Class
