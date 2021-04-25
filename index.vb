Public Class index
    Public odoc As New XDocument
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relogio.Start()
    End Sub
    Private Sub relogio_Tick(sender As Object, e As EventArgs) Handles relogio.Tick
        Label1.Text = DateTime.Now
        If String.IsNullOrEmpty(odoc.ToString) = False Then
            If odoc.Element("root").Element("Lembretes").Elements("Lembrete").Any() = True Then
                For Each lembrete In odoc.Element("root").Element("Lembretes").Elements("Lembrete")
                    Dim data1 = Convert.ToDateTime(lembrete.Element("Data").Value)
                    Dim data As New DateTime(data1.Year, data1.Month, data1.Day, lembrete.Element("Hora").Value, lembrete.Element("Minuto").Value, 0)
                    Dim calc = Math.Truncate((data - DateTime.Now).TotalSeconds)

                    If calc = 7200 Then
                        Notificações.ShowBalloonTip(5000, "Agenda Digital", "Duas horas até ao seu lembrete!", ToolTipIcon.None)
                    ElseIf calc = 3600 Then
                        Notificações.ShowBalloonTip(5000, "Agenda Digital", "Uma hora até ao seu lembrete!", ToolTipIcon.None)
                    ElseIf calc = 600 Then
                        Notificações.ShowBalloonTip(5000, "Agenda Digital", "Dez minutos até ao seu lembrete!", ToolTipIcon.None)
                    ElseIf calc = 0 Then
                        Notificações.ShowBalloonTip(5000, "Agenda Digital", "Notificação do seu lembrete!", ToolTipIcon.None)
                    End If
                Next
            End If
        End If
    End Sub
    'Hover effects'
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        TextBox1.Text = "Abre o menu de criação de uma lista de afazeres, podendo marcar as coisas já feitas e configurar um horário de notificação."
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        TextBox1.Text = "Abre uma lista préviamente criada noutro sistema ou noutra altura."
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        TextBox1.Text = "Abre o menu de criação de um lembrete, podendo escolher data e hora de conclusão e sendo lembrado 2 horas, 1 hora, 10 minutos e na hora de conclusão do mesmo."
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        TextBox1.Text = "Abre um lembrete préviamente criado noutro sistema ou noutra altura."
    End Sub
    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        TextBox1.Text = "Permite guardar as listas, os lembretes e as definições da aplicação num ficheiro que pode transportar de sistema a sistema, para nunca perder os seus dados."
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        TextBox1.Text = "Permite carregar um ficheiro da aplicação préviamente criado noutro sistema ou noutra altura."
    End Sub
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs)
        TextBox1.Text = "Abre o menu das definições da aplicação."
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        TextBox1.Text = ""
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        TextBox1.Text = ""
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        TextBox1.Text = ""
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        TextBox1.Text = ""
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        TextBox1.Text = ""
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        TextBox1.Text = ""
    End Sub
    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs)
        TextBox1.Text = ""
    End Sub
    'Hover Effects''
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        clista.list1.Items.Clear()
        clista.Show()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim openfile As New OpenFileDialog()
        openfile.Filter = "XML files (*.xml)|*.xml"
        If openfile.ShowDialog = DialogResult.OK Then
            odoc = XDocument.Load(openfile.FileName)
        End If

        Dim periodo As XDocument

        Try
            periodo = XDocument.Parse(odoc.ToString)
        Catch ex As Exception
            Return
        End Try


        For Each lista In periodo.Element("root").Element("Notificacoes").Elements("Lista")
            Dim t = New Timer()
            If lista.Element("Periodo").Value() = "0" Then
                Return
            Else
                t.Interval = Integer.Parse(lista.Elements("Periodo").Value())
                t.Enabled = True
                t.Start()
            End If

            AddHandler t.Tick, AddressOf TimerTick
        Next
    End Sub
    Sub TimerTick(ByVal sender As Object, e As EventArgs)
        Notificações.ShowBalloonTip(5000, "Agenda Digital", "Notificação periódica dos seus afazeres!", ToolTipIcon.None)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listasstr As XDocument
        Try
            listasstr = System.Xml.Linq.XDocument.Parse(odoc.ToString())
        Catch ex As Exception
            MessageBox.Show("Não foi encontrado nenhum ficheiro de configuração")
            Return
        End Try
        Hide()
        alista.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim savefile As New SaveFileDialog()
        savefile.Filter = "XML files (*.xml)|*.xml"
        If savefile.ShowDialog() = DialogResult.OK Then
            If String.IsNullOrEmpty(odoc.ToString) = True Then
                If notslista.root.Elements("Lembretes").Any = False Then
                    notslista.root.Add(notslista.lembretes)
                End If
                If notslista.root.Elements("Listas").Any = False Then
                    notslista.root.Add(notslista.listas)
                End If
                If notslista.root.Elements("Notificacoes").Any = False Then
                    notslista.root.Add(notslista.nots)
                End If
                notslista.doc.Save(savefile.FileName)
            Else
                odoc.Save(savefile.FileName)
            End If

        End If
    End Sub

    Private Sub index_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Visible = False
        Notificações.Visible = True
    End Sub
    Private Sub Notificações_MouseClick(sender As Object, e As MouseEventArgs) Handles Notificações.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position)
        Else
            Visible = True
            Notificações.Visible = False
        End If
    End Sub

    Private Sub FecharAAplicaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharAAplicaçãoToolStripMenuItem.Click
        Notificações.Visible = False
        End
    End Sub

    Private Sub AbrirAAplicaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirAAplicaçãoToolStripMenuItem.Click
        Visible = True
        Notificações.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        clemb.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            XDocument.Parse(odoc.ToString)
        Catch ex As Exception
            MessageBox.Show("Não foi encontrado nenhum ficheiro de configuração")
            Return
        End Try
        Hide()
        alemb.Show()
    End Sub
End Class
