<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCDecrypt
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
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDecrypt = New System.Windows.Forms.Button()
        Me.cmdChangeFolder = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEnd
        '
        Me.cmdEnd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdEnd.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(411, 156)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(128, 40)
        Me.cmdEnd.TabIndex = 20
        Me.cmdEnd.Text = "終了"
        Me.cmdEnd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(806, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "療養費請求データの複合"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdDecrypt
        '
        Me.cmdDecrypt.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdDecrypt.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdDecrypt.Location = New System.Drawing.Point(259, 156)
        Me.cmdDecrypt.Name = "cmdDecrypt"
        Me.cmdDecrypt.Size = New System.Drawing.Size(128, 40)
        Me.cmdDecrypt.TabIndex = 18
        Me.cmdDecrypt.Text = "復号"
        Me.cmdDecrypt.UseVisualStyleBackColor = False
        '
        'cmdChangeFolder
        '
        Me.cmdChangeFolder.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdChangeFolder.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdChangeFolder.Location = New System.Drawing.Point(692, 81)
        Me.cmdChangeFolder.Name = "cmdChangeFolder"
        Me.cmdChangeFolder.Size = New System.Drawing.Size(33, 47)
        Me.cmdChangeFolder.TabIndex = 17
        Me.cmdChangeFolder.Text = "▼"
        Me.cmdChangeFolder.UseVisualStyleBackColor = False
        '
        'lblFilePath
        '
        Me.lblFilePath.BackColor = System.Drawing.Color.White
        Me.lblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFilePath.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(62, 81)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(629, 47)
        Me.lblFilePath.TabIndex = 16
        '
        'frmCDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 219)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDecrypt)
        Me.Controls.Add(Me.cmdChangeFolder)
        Me.Controls.Add(Me.lblFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCDecrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "復号"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEnd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDecrypt As Button
    Friend WithEvents cmdChangeFolder As Button
    Friend WithEvents lblFilePath As Label
End Class
