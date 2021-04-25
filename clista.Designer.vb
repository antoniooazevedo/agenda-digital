<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clista))
        Me.list1 = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'list1
        '
        Me.list1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.list1.FormattingEnabled = True
        Me.list1.Location = New System.Drawing.Point(12, 12)
        Me.list1.Name = "list1"
        Me.list1.Size = New System.Drawing.Size(398, 344)
        Me.list1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(141, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Remover"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(12, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(279, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 70)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Configurar Notificações e Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(12, 362)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(398, 22)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Escreva aqui um item a adicionar!"
        '
        'clista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Agenda_Digital.My.Resources.Resources.istockphoto_1252705970_170667a
        Me.ClientSize = New System.Drawing.Size(422, 472)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.list1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clista"
        Me.Text = "Criar uma Lista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents list1 As CheckedListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
