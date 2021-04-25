Public Class notslemb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim horacomprida As New DateTime(1, 1, 1, horas.Value, minutos.Value, 0)
        If datas.Value.Date < DateTime.Today Then
            MessageBox.Show("Data Inválida")
            Return
        ElseIf datas.Value.Date = DateTime.Today And horacomprida < TimeOfDay Then
            MessageBox.Show("Hora Inválida")
            Return
        End If

        save(InputBox("Introduza um nome para o lembrete criado"))

    End Sub
    Private Sub notslemb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clemb.Show()
    End Sub
    Private Function save(nome As String)
        Dim lembrete As New XElement("Lembrete")
        Dim nomelembrete As New XElement("Nome", nome)
        Dim conteudo As New XElement("Conteudo", clemb.TextBox1.Text)
        Dim hora As New XElement("Hora", horas.Value)
        Dim minuto As New XElement("Minuto", minutos.Value)
        Dim data As New XElement("Data", CStr(datas.Value.Date))
        Dim n As Integer = 1

        If String.IsNullOrEmpty(index.odoc.ToString) = True Then
            If notslista.lembretes.HasElements = False Then
                lembrete.Add(nomelembrete, conteudo, data, hora, minuto)
                If notslista.root.Elements("Lembretes").Any() = False Then
                    notslista.root.Add(notslista.lembretes)
                    notslista.lembretes.Add(lembrete)
                Else
                    notslista.lembretes.Add(lembrete)
                End If
                MessageBox.Show("O lembrete foi introduzido com sucesso")
                Hide()
                index.Show()
                MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
            Else
                For Each el As XElement In notslista.lembretes.Elements
                    If nome = el.Element("Nome").Value Then
                        confirm.Label1.Text = "Já existe um lembrete com esse nome. Quer substituir esse lembrete?"
                        confirm.ShowDialog()
                        If confirm.result = DialogResult.OK Then
                            el.RemoveAll()
                            el.Remove()
                            lembrete.Add(nomelembrete, conteudo, data, hora, minuto)
                            If notslista.root.Elements("Lembretes").Any() = False Then
                                notslista.lembretes.Add(lembrete)
                                notslista.root.Add(notslista.lembretes)
                            Else
                                notslista.lembretes.Add(lembrete)
                            End If
                            MessageBox.Show("O lembrete foi introduzido com sucesso")
                            n = n + 1
                            Hide()
                            index.Show()
                            MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
                        Else
                            Return False
                        End If
                    End If
                Next
                If n = 1 Then
                    lembrete.Add(nomelembrete, conteudo, data, hora, minuto)
                    If notslista.root.Elements("Lembretes").Any() = False Then
                        notslista.root.Add(notslista.lembretes)
                        notslista.lembretes.Add(lembrete)
                    Else
                        notslista.lembretes.Add(lembrete)
                    End If
                    MessageBox.Show("O lembrete foi introduzido com sucesso")
                    Hide()
                    index.Show()
                    MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
                End If
            End If
        Else
            If index.odoc.Element("root").Element("Lembretes").HasElements() = False Then
                lembrete.Add(nomelembrete, conteudo, data, hora, minuto)
                index.odoc.Element("root").Element("Lembretes").Add(lembrete)
                MessageBox.Show("O lembrete foi introduzido com sucesso")
                Hide()
                index.Show()
                MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
            Else
                For Each el As XElement In index.odoc.Element("root").Element("Lembretes").Elements("Lembrete")
                    If nome = el.Element("Nome").Value Then
                        confirm.Label1.Text = "Já existe um lembrete com esse nome. Quer substituir esse lembrete?"
                        confirm.ShowDialog()
                        If confirm.result = DialogResult.OK Then
                            el.RemoveAll()
                            el.Remove()
                            lembrete.Add(nomelembrete, conteudo, data, hora, minuto)
                            index.odoc.Element("root").Element("Lembretes").Add(lembrete)
                            MessageBox.Show("O lembrete foi introduzido com sucesso")
                            n += 1
                            Hide()
                            index.Show()
                            MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
                        Else
                            Return False
                        End If
                    End If
                Next
                If n = 1 Then
                    lembrete.Add(nomelembrete, conteudo, data, hora, minuto)
                    index.odoc.Element("root").Element("Lembretes").Add(lembrete)
                    MessageBox.Show("O lembrete foi introduzido com sucesso")
                    Hide()
                    index.Show()
                    MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
                End If
            End If
        End If
        Hide()
        index.Show()
    End Function

    Private Sub notslemb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class