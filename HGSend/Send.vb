Public Class frmCSend

    Private Sub cmdChangeFolder_Click(sender As Object, e As EventArgs) Handles cmdChangeFolder.Click

        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = ""
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = "E:"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "RYOYOHI.DAT|RYOYOHI.DAT|すべてのファイル(*.*)|*.*"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        ofd.FilterIndex = 1
        'タイトルを設定する
        ofd.Title = "開くファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckPathExists = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            lblFilePath.Text = ofd.FileName
        End If

    End Sub

    Private Test_Mode As Boolean = False

    Private Sub cmdFTPS_Click(sender As Object, e As EventArgs) Handles cmdFTPS.Click

        Dim fi As New System.IO.FileInfo(lblFilePath.Text)
        If (fi.Length Mod 9000) <> 0 Then
            MsgBox("RYOYOHI.DATのファイルサイズが異常です。", MsgBoxStyle.OkOnly, cmdFTPS.Text)
            Return
        End If

        '自分自身の実行ファイルのパスを取得する
        Dim appPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location

        Dim CRPFNa As String = GetCRPFileName(lblFilePath.Text)

        EncryptForHG(lblFilePath.Text, System.IO.Path.GetDirectoryName(lblFilePath.Text) + "\" + CRPFNa)

        Dim ResMsg As String = ""

        If SendData(System.IO.Path.GetDirectoryName(lblFilePath.Text) + "\", CRPFNa, ResMsg, True) Then
            MessageBox.Show("送信完了" + vbCrLf + ResMsg)
        Else
            MessageBox.Show("送信失敗" + vbCrLf + ResMsg)
        End If

    End Sub

    Private Sub lblFilePath_DragEnter(sender As Object, e As DragEventArgs) Handles lblFilePath.DragEnter

        'コントロール内にドラッグされたとき実行される
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            e.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受け付けない
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub lblFilePath_DragDrop(sender As Object, e As DragEventArgs) Handles lblFilePath.DragDrop

        'コントロール内にドロップされたとき実行される
        'ドロップされたすべてのファイル名を取得する
        Dim fileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        'ListBoxに追加する
        lblFilePath.Text = fileName(0)

    End Sub

    Private Sub lblFilePath_TextChanged(sender As Object, e As EventArgs) Handles lblFilePath.TextChanged

        If System.IO.Path.GetFileName(lblFilePath.Text) = "RYOYOHI.DAT" Then

            lblFileNa2.Text = GetCRPFileName(lblFilePath.Text)
            cmdFTPS.Enabled = True

        Else

            lblFileNa2.Text = ""
            cmdFTPS.Enabled = False

        End If

    End Sub

    Private Sub frmCSend_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmdFTPS.Enabled = False

    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click

        Me.Close()

    End Sub

    Private Sub frmCSend_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        '/// TEST MODE shift + "M" ///
        If e.Shift And e.KeyCode = Keys.M Then
            Test_Mode = True
            lblTest_Mode.Visible = True
        End If

    End Sub
End Class