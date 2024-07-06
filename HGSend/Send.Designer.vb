<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCSend
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCSend))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdChangeFolder = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.cmdFTPS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFileNa2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.lblTest_Mode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(694, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "↓ここに送信したい療養費請求データファイル（RYOYOHI.DAT）をドラッグ＆ドロップしてください。"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdChangeFolder
        '
        Me.cmdChangeFolder.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdChangeFolder.Location = New System.Drawing.Point(696, 127)
        Me.cmdChangeFolder.Name = "cmdChangeFolder"
        Me.cmdChangeFolder.Size = New System.Drawing.Size(33, 47)
        Me.cmdChangeFolder.TabIndex = 8
        Me.cmdChangeFolder.Text = "▼"
        Me.cmdChangeFolder.UseVisualStyleBackColor = True
        '
        'lblFilePath
        '
        Me.lblFilePath.AllowDrop = True
        Me.lblFilePath.BackColor = System.Drawing.Color.White
        Me.lblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFilePath.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(66, 127)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(629, 47)
        Me.lblFilePath.TabIndex = 7
        '
        'cmdFTPS
        '
        Me.cmdFTPS.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdFTPS.Location = New System.Drawing.Point(586, 225)
        Me.cmdFTPS.Name = "cmdFTPS"
        Me.cmdFTPS.Size = New System.Drawing.Size(90, 40)
        Me.cmdFTPS.TabIndex = 10
        Me.cmdFTPS.Text = "送信"
        Me.cmdFTPS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(792, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "療養費請求データファイル（RYOYOHI.DAT)を兵庫県柔道整復師会に送信できます。"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ここから選択することもできます。↑"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFileNa2
        '
        Me.lblFileNa2.AllowDrop = True
        Me.lblFileNa2.BackColor = System.Drawing.Color.White
        Me.lblFileNa2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFileNa2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFileNa2.Location = New System.Drawing.Point(371, 235)
        Me.lblFileNa2.Name = "lblFileNa2"
        Me.lblFileNa2.Size = New System.Drawing.Size(191, 20)
        Me.lblFileNa2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "実際に送信される暗号化されたファイル："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdEnd
        '
        Me.cmdEnd.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(350, 315)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(128, 40)
        Me.cmdEnd.TabIndex = 15
        Me.cmdEnd.Text = "終了"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'lblTest_Mode
        '
        Me.lblTest_Mode.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTest_Mode.ForeColor = System.Drawing.Color.Red
        Me.lblTest_Mode.Location = New System.Drawing.Point(577, 282)
        Me.lblTest_Mode.Name = "lblTest_Mode"
        Me.lblTest_Mode.Size = New System.Drawing.Size(152, 31)
        Me.lblTest_Mode.TabIndex = 16
        Me.lblTest_Mode.Text = "TEST MODE"
        Me.lblTest_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTest_Mode.Visible = False
        '
        'frmCSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(817, 380)
        Me.Controls.Add(Me.lblTest_Mode)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFileNa2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdFTPS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdChangeFolder)
        Me.Controls.Add(Me.lblFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCSend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "療養費請求データファイル（RYOYOHI.DAT)送信アプリ"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmdChangeFolder As Button
    Friend WithEvents lblFilePath As Label
    Friend WithEvents cmdFTPS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFileNa2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdEnd As Button
    Friend WithEvents lblTest_Mode As Label
End Class
