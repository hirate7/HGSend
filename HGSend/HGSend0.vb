Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports FluentFTP
Imports System.Text

Module HGSend0

    Private Test_Mode As Boolean
    Private TmpDir As String
    Private FNaCRP As String

    ''' <summary>
    ''' 兵庫県柔道整復師会
    ''' 療養費請求データの暗号化とFTPS送信
    ''' .NET Framework4.5に対応しておりWindows8以降で動作する
    ''' WindowsVista、Windows7でも.NET Framework4.5以降をインストールすれば使える
    ''' 
    ''' コマンドライン
    ''' 無し
    '''  送信用フォームを表示する
    ''' パラメータ2つ
    '''  1: 0=本番モードで送信 1= TestModeで送信
    '''  2: 作業フォルダのパス C:\MapleH\Work\"
    '''  3: 暗号化後のファイル名 20240601_012345.CRP
    ''' </summary>
    Sub Main()

        If Environment.GetCommandLineArgs.Count = 1 Then

            Dim frmSend As New frmCSend
            frmSend.ShowDialog()
            Exit Sub

        End If
        If Environment.GetCommandLineArgs.Count <> 4 Then
            MessageBox.Show("パラメータの数が異常です")
            Return
        End If

        Test_Mode = (Environment.GetCommandLineArgs(1) = "1")
        TmpDir = Environment.GetCommandLineArgs(2)
        FNaCRP = Environment.GetCommandLineArgs(3)

        EncryptForHG(TmpDir + "RYOYOHI.DAT", TmpDir + FNaCRP)

        Dim ResMsg As String = ""

        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")

        If SendData(TmpDir, FNaCRP, ResMsg, Test_Mode) Then
            '成功
            Using outStream = New StreamWriter(TmpDir + "HGSendResS.txt", False, enc)
                'MessageBox.Show(TmpDir + "HGSendResS.txt")
                outStream.Write("Success")
            End Using
        Else
            '失敗
            Using outStream = New StreamWriter(TmpDir + "HGSendResF.txt", False, enc)
                outStream.Write(ResMsg)
            End Using
        End If

    End Sub

    Function GetKey() As Byte()

        Dim byteData = System.Text.Encoding.UTF8.GetBytes("HYG兵庫県柔道整復師会")
        Dim DeriveBytes As New System.Security.Cryptography.Rfc2898DeriveBytes("svy03qwu!9c67z2k", byteData, 1000)
        Dim Key As Byte() = DeriveBytes.GetBytes(256 \ 8)

        Return Key

    End Function

    Sub EncryptForHG(inFNa As String, outFNa As String)
        '兵庫県柔道整復師会のRYOYOHI.DATの暗号化
        ' Encryptor（暗号化器）を用意する
        Using am = New AesManaged()
            am.KeySize = 256
            am.BlockSize = 128
            am.FeedbackSize = 128
            am.Mode = CipherMode.CBC
            am.Padding = PaddingMode.PKCS7
            am.Key = GetKey()
            'am.IVは自動で初期化されてるのでそのまま使う
            Using encryptor = am.CreateEncryptor()
                '入力ストリームを用意する
                Using inStream = New FileStream(inFNa, FileMode.Open, FileAccess.Read)
                    ' 出力ストリームを用意する
                    Using outStream = New FileStream(outFNa, FileMode.Create, FileAccess.Write)
                        'am.IVを頭に付ける
                        outStream.Write(am.IV, 0, 16)
                        ' 暗号化して書き出す
                        Using cs = New CryptoStream(outStream, encryptor, CryptoStreamMode.Write)
                            Dim buffer(4095) As Byte
                            Dim len As Integer
                            Do
                                len = inStream.Read(buffer, 0, buffer.Length)
                                If len = 0 Then
                                    Exit Do
                                Else
                                    cs.Write(buffer, 0, len)
                                End If
                            Loop
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Sub DecryptForHG(inFNa As String, outFNa As String)
        '兵庫県柔道整復師会のRYOYOHI.DATの復号
        ' Decryptor（復号器）を用意する
        Using am = New AesManaged()
            am.KeySize = 256
            am.BlockSize = 128
            am.FeedbackSize = 128
            am.Mode = CipherMode.CBC
            am.Padding = PaddingMode.PKCS7
            am.Key = GetKey()
            ' 入力ストリームを開く
            Using inStream = New FileStream(inFNa, FileMode.Open, FileAccess.Read)
                '先頭のIVを読み込む
                Dim IV(15) As Byte
                inStream.Read(IV, 0, 16)
                am.IV = IV
                Using decryptor = am.CreateDecryptor()
                    ' 出力ストリームを用意する
                    Using outStream = New FileStream(outFNa, FileMode.Create, FileAccess.Write)
                        ' 復号して一定量ずつ読み出し、それを出力ストリームに書き出す
                        Using cs = New CryptoStream(inStream, decryptor, CryptoStreamMode.Read)
                            Dim buffer(4095) As Byte
                            Dim len As Integer
                            Do
                                len = cs.Read(buffer, 0, buffer.Length)
                                If len = 0 Then
                                    Exit Do
                                Else
                                    outStream.Write(buffer, 0, len)
                                End If
                            Loop
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Function SendData(ByVal Path As String, ByVal FNa As String, ByRef ResMsg As String, Optional ByVal Test As Boolean = True) As Boolean

        Dim Res As Boolean

        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() = False Then
            ResMsg = "ネットワークに接続されていません。"
            Return Res
        End If

        Dim client As FtpClient = New FtpClient()

        'ホスト名設定
        client.Host = "hyogo.jyuseishi.com"

        'ポート
        client.Port = 21

        '// 資格情報の設定
        Dim User As String
        If Test Then
            User = "ftp6441-test@hyogo.jyuseishi.com"
        Else
            User = "ftp6441@hyogo.jyuseishi.com"
        End If
        client.Credentials = New NetworkCredential(User, "x0jE!7C68$")

        '// 要求の完了後に接続を閉じる
        client.SocketKeepAlive = False

        '// Explicit設定
        client.EncryptionMode = FtpEncryptionMode.Explicit

        '// プロトコルはTls12
        client.SslProtocols = System.Security.Authentication.SslProtocols.Tls12

        '// 接続タイムアウトを3秒に設定
        client.ConnectTimeout = 3000

        '// 証明書の内容を確認しない
        AddHandler client.ValidateCertificate, New FtpSslValidation(AddressOf OnValidateCertificate)

        'データ転送モード
        client.DataConnectionType = FtpDataConnectionType.AutoPassive

        'データ転送形式
        client.UploadDataType = FtpDataType.Binary

        Try

            '// 接続
            client.Connect()
            '// ファイルのアップロード
            client.RetryAttempts = 3
            ResMsg = client.UploadFile(Path + FNa, FNa, FtpRemoteExists.Overwrite, False, FtpVerify.Retry).ToString

            Res = True

        Catch ex As Exception

            ResMsg = ex.Message
            Res = False

        Finally

            '// 切断
            client.Disconnect()
            '// 解放
            client.Dispose()

        End Try

        Return Res

    End Function

    Private Sub OnValidateCertificate(control As FtpClient, e As FtpSslValidationEventArgs)

        '// 証明書の内容を確認しない
        e.Accept = True

    End Sub

    ''' <summary>
    ''' 暗号化後ファイル名取得
    ''' </summary>
    ''' <param name="Src"></param>
    ''' <returns></returns>
    Function GetCRPFileName(Src As String) As String

        Using inStream = New StreamReader(Src, Encoding.GetEncoding("Shift_JIS"))

            Dim S As String = inStream.ReadLine()

            Return Mid(S, 5, 6) + "01_" + Mid(S, 18, 6) + ".CRP"

        End Using

    End Function

    Public Function Left_(ByVal S As String, ByVal I As Integer) As String
        'Microsoft.VisualBasic.Left()と同じ
        'Inports Microsoft.VisualBasicを書いてもMicrosoft.VisualBasicの
        '名前空間を指定しなければならない場合に名前が長くならないようにするため

        Return Left(S, I)

    End Function

    Public Function Right_(ByVal S As String, ByVal I As Integer) As String
        'Microsoft.VisualBasic.Left()と同じ
        'Inports Microsoft.VisualBasicを書いてもMicrosoft.VisualBasicの
        '名前空間を指定しなければならない場合に名前が長くならないようにするため

        Return Right(S, I)

    End Function
End Module
