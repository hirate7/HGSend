<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdFTPSTest = New System.Windows.Forms.Button()
        Me.ToFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdFTPSTest
        '
        Me.cmdFTPSTest.Location = New System.Drawing.Point(47, 38)
        Me.cmdFTPSTest.Name = "cmdFTPSTest"
        Me.cmdFTPSTest.Size = New System.Drawing.Size(171, 53)
        Me.cmdFTPSTest.TabIndex = 7
        Me.cmdFTPSTest.Text = "FTPSTest"
        Me.cmdFTPSTest.UseVisualStyleBackColor = True
        '
        'ToFile
        '
        Me.ToFile.Location = New System.Drawing.Point(47, 108)
        Me.ToFile.Name = "ToFile"
        Me.ToFile.Size = New System.Drawing.Size(171, 53)
        Me.ToFile.TabIndex = 8
        Me.ToFile.Text = "ToFile"
        Me.ToFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToFile)
        Me.Controls.Add(Me.cmdFTPSTest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFTPSTest As Button
    Friend WithEvents ToFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
