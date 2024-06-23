Imports System.Net
Imports FluentFTP

Public Class Form1

    Private Sub cmdFTPSTest_Click(sender As Object, e As EventArgs) Handles cmdFTPSTest.Click

        Dim ResMsg As String

        If SendData("C:\DDD\", "20240601_012345.CRP", ResMsg) Then
            MessageBox.Show("送信完了" + vbCrLf + ResMsg)
        Else
            MessageBox.Show("送信失敗" + vbCrLf + ResMsg)
        End If

    End Sub

End Class
