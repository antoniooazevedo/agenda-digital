<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alista))
        Me.alist = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'alist
        '
        Me.alist.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.alist.Font = New System.Drawing.Font("DejaVu Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alist.FormattingEnabled = True
        Me.alist.ItemHeight = 24
        Me.alist.Location = New System.Drawing.Point(12, 14)
        Me.alist.Name = "alist"
        Me.alist.Size = New System.Drawing.Size(286, 268)
        Me.alist.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(176, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Selecionar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(12, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Remover"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'alista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Agenda_Digital.My.Resources.Resources.istockphoto_1252705970_170667a
        Me.ClientSize = New System.Drawing.Size(308, 347)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.alist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alista"
        Me.Text = "Abrir uma Lista"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents alist As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
