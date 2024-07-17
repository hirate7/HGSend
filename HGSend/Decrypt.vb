Public Class frmCDecrypt
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
        ofd.Filter = "暗号化ファイル|*.CRP|すべてのファイル(*.*)|*.*"
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

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click

        Me.Close()

    End Sub

    Private Sub cmdDecrypt_Click(sender As Object, e As EventArgs) Handles cmdDecrypt.Click

        Dim inFNa As String = lblFilePath.Text
        Dim outFNa As String = System.IO.Path.GetDirectoryName(lblFilePath.Text) + "\" + "RYOYOHI.DAT"

        DecryptForHG(inFNa, outFNa)

        MessageBox.Show("復号しました。")

    End Sub
End Class