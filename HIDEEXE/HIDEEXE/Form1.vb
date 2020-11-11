Imports System.IO
Public Class Form1
    Dim exe, ico As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exe = TextBox1.Text
        ico = "inject.ico"
        Iconchanger.InjectIcon(exe, ico)
        My.Computer.FileSystem.RenameFile(exe, "⠀⠀.exe")
        MsgBox("Done!")
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "EXE | *.exe"
            .Title = "Browse"
            .ShowDialog()
            TextBox1.Text = .FileName
        End With
    End Sub
End Class
