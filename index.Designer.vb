<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.relogio = New System.Windows.Forms.Timer(Me.components)
        Me.Notificações = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FecharAAplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirAAplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Criar uma Lista"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(129, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 57)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Abrir uma Lista"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(12, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 57)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Criar um Lembrete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(129, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 57)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Abrir um Lembrete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Location = New System.Drawing.Point(12, 138)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 57)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salvar Configurações"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Location = New System.Drawing.Point(129, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 57)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Carregar Configurações"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.Font = New System.Drawing.Font("Noto Sans", 8.999999!)
        Me.TextBox1.Location = New System.Drawing.Point(248, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(234, 183)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(333, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 8
        '
        'relogio
        '
        Me.relogio.Interval = 1000
        '
        'Notificações
        '
        Me.Notificações.Icon = CType(resources.GetObject("Notificações.Icon"), System.Drawing.Icon)
        Me.Notificações.Visible = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FecharAAplicaçãoToolStripMenuItem, Me.AbrirAAplicaçãoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 52)
        '
        'FecharAAplicaçãoToolStripMenuItem
        '
        Me.FecharAAplicaçãoToolStripMenuItem.Name = "FecharAAplicaçãoToolStripMenuItem"
        Me.FecharAAplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.FecharAAplicaçãoToolStripMenuItem.Text = "Fechar a aplicação"
        '
        'AbrirAAplicaçãoToolStripMenuItem
        '
        Me.AbrirAAplicaçãoToolStripMenuItem.Name = "AbrirAAplicaçãoToolStripMenuItem"
        Me.AbrirAAplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.AbrirAAplicaçãoToolStripMenuItem.Text = "Abrir a aplicação"
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Agenda_Digital.My.Resources.Resources.istockphoto_1252705970_170667a
        Me.ClientSize = New System.Drawing.Size(494, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "index"
        Me.Text = "Agenda Digital"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents relogio As Timer
    Friend WithEvents Notificações As NotifyIcon
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FecharAAplicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirAAplicaçãoToolStripMenuItem As ToolStripMenuItem
End Class
