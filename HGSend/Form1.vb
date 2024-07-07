Imports System.Net
Imports FluentFTP

Public Class Form1

    Private Sub cmdFTPSTest_Click(sender As Object, e As EventArgs) Handles cmdFTPSTest.Click

        Dim ResMsg As String = ""

        If SendData("C:\DDD\", "20240601_012345.CRP", ResMsg) Then
            MessageBox.Show("送信完了" + vbCrLf + ResMsg)
        Else
            MessageBox.Show("送信失敗" + vbCrLf + ResMsg)
        End If

    End Sub

    Private Sub ToFile_Click(sender As Object, e As EventArgs) Handles ToFile.Click

        'Dim A() As Byte = System.Text.Encoding.UTF8.GetBytes("HYG兵庫県柔道整復師会,svy03qwu!9c67z2k,hyogo.jyuseishi.com,ftp6441@hyogo.jyuseishi.com,ftp6441-test@hyogo.jyuseishi.com,x0jE!7C68$")

        'Dim B() As Byte = ChangeData(A)
        'Dim I As Integer
        'Label1.Text = ""
        'For I = 0 To B.Length - 1
        '    Label1.Text = Label1.Text + Str(B(I))
        'Next

        'My.Computer.FileSystem.WriteAllBytes("C:\MapleH\FTPS.DLL", B, False)

        'Dim C() As Byte = My.Computer.FileSystem.ReadAllBytes("C:\MapleH\FTPS.DLL")

        'Label2.Text = System.Text.Encoding.UTF8.GetString(ChangeData(C))

    End Sub

End Class
