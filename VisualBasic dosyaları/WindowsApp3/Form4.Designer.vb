<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.s = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        's
        '
        Me.s.Dock = System.Windows.Forms.DockStyle.Fill
        Me.s.Location = New System.Drawing.Point(0, 0)
        Me.s.MinimumSize = New System.Drawing.Size(20, 20)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(942, 543)
        Me.s.TabIndex = 0
        Me.s.Url = New System.Uri("https://twitter.com/oguzsasi", System.UriKind.Absolute)
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 543)
        Me.Controls.Add(Me.s)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form4"
        Me.Text = "Twitter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents s As WebBrowser
End Class
