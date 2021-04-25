<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notslemb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notslemb))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datas = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.horas = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.NumericUpDown()
        CType(Me.horas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecione a Data de Conclusão"
        '
        'datas
        '
        Me.datas.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.datas.Location = New System.Drawing.Point(12, 29)
        Me.datas.Name = "datas"
        Me.datas.Size = New System.Drawing.Size(218, 22)
        Me.datas.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Selecionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'horas
        '
        Me.horas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.horas.Location = New System.Drawing.Point(12, 74)
        Me.horas.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(50, 22)
        Me.horas.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Selecione a Hora de Conclusão"
        '
        'minutos
        '
        Me.minutos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.minutos.Location = New System.Drawing.Point(68, 74)
        Me.minutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(55, 22)
        Me.minutos.TabIndex = 7
        '
        'notslemb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Agenda_Digital.My.Resources.Resources.istockphoto_1252705970_170667a
        Me.ClientSize = New System.Drawing.Size(242, 137)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.datas)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "notslemb"
        Me.Text = "Notificações"
        CType(Me.horas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents datas As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents horas As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents minutos As NumericUpDown
End Class
