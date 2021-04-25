Imports System.Windows.Forms
Public Class notslista
    Public doc As XDocument = XDocument.Parse("<?xml version=""1.0"" encoding=""utf-8"" ?><root></root>")
    Public root As XElement = doc.Root
    Public listas As New XElement("Listas")
    Public nots As New XElement("Notificacoes")
    Public lembretes As New XElement("Lembretes")
    Private Sub notslista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function save_process(nome As String, intervalo As Integer)
        Dim checkeditems As List(Of String) = clista.list1.CheckedItems.Cast(Of String).ToList()
        Dim uncheckeditems As IEnumerable(Of String) = clista.list1.Items.Cast(Of String).ToList().Except(checkeditems)
        uncheckeditems.ToList()
        Dim listas1 As New XElement("Lista")
        Dim nomelista As New XElement("Nome", nome)
        Dim tipo As New XElement("Lista")
        Dim notslista As New XElement("Nome", nome)
        tipo.Add(notslista)
        tipo.Add(New XElement("Periodo", intervalo))
        Dim n As Integer = 1

        If String.IsNullOrEmpty(index.odoc.ToString) = True Then
            If listas.HasElements = False Then
                For Each citem As String In checkeditems
                    listas1.Add(New XElement("Item", citem, New XAttribute("Checked", True)))
                Next
                For Each uitem As String In uncheckeditems
                    listas1.Add(New XElement("Item", uitem, New XAttribute("Checked", False)))
                Next

                listas1.Add(nomelista)
                If root.Elements("Listas").Any() = False Then
                    root.Add(listas)
                    listas.Add(listas1)
                Else
                    listas.Add(listas1)
                End If
                If root.Elements("Notificacoes").Any() = False Then
                    root.Add(nots)
                    nots.Add(tipo)
                Else
                    nots.Add(tipo)
                End If

                Hide()
                index.Show()
                MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
            Else
                For Each el As XElement In listas.Elements
                    Dim name As String = el.Element("Nome").Value()
                    If nome = name And n = 1 Then
                        confirm.Label1.Text = "Já existe uma lista com o mesmo nome. Quer substituir essa lista?"
                        confirm.ShowDialog()
                        If confirm.result = DialogResult.OK Then
                            el.RemoveAll()
                            For Each nl As XElement In root.Element("Notificacoes").Elements("Lista")
                                If nl.Element("Nome").Value() = name Then
                                    nl.RemoveAll()
                                End If
                            Next

                            For Each citem As String In checkeditems
                                listas1.Add(New XElement("Item", citem, New XAttribute("Checked", True)))
                            Next
                            For Each uitem As String In uncheckeditems
                                listas1.Add(New XElement("Item", uitem, New XAttribute("Checked", False)))
                            Next
                            listas1.Add(nomelista)
                            If root.Elements("Listas").Any() = False Then
                                root.Add(listas)
                                listas.Add(listas1)
                            Else
                                listas.Add(listas1)
                            End If
                            If root.Elements("Notificacoes").Any() = False Then
                                root.Add(nots)
                                nots.Add(tipo)
                            Else
                                nots.Add(tipo)
                            End If

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
                    For Each citem As String In checkeditems
                        listas1.Add(New XElement("Item", citem, New XAttribute("Checked", True)))
                    Next
                    For Each uitem As String In uncheckeditems
                        listas1.Add(New XElement("Item", uitem, New XAttribute("Checked", False)))
                    Next
                    listas1.Add(nomelista)
                    If root.Elements("Listas").Any() = False Then
                        root.Add(listas)
                        listas.Add(listas1)
                    Else
                        listas.Add(listas1)
                    End If
                    If root.Elements("Notificacoes").Any() = False Then
                        root.Add(nots)
                        nots.Add(tipo)
                    Else
                        nots.Add(tipo)
                    End If

                    Hide()
                    index.Show()
                    MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
                End If
            End If
        Else
            If index.odoc.Element("root").Element("Listas").HasElements() = False Then
                For Each citem As String In checkeditems
                    listas1.Add(New XElement("Item", citem, New XAttribute("Checked", True)))
                Next
                For Each uitem As String In uncheckeditems
                    listas1.Add(New XElement("Item", uitem, New XAttribute("Checked", False)))
                Next

                listas1.Add(nomelista)
                index.odoc.Element("root").Element("Listas").Add(listas1)
                nots.Add(tipo)
                index.odoc.Element("root").Element("Notificacoes").Add(nots)
                Hide()
                index.Show()
                MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
            Else
                For Each el As XElement In index.odoc.Element("root").Element("Listas").Elements("Lista")
                    Dim name As String = el.Element("Nome").Value()
                    If nome = name And n = 1 Then
                        confirm.Label1.Text = "Já existe uma lista com o mesmo nome. Quer substituir essa lista?"
                        confirm.ShowDialog()
                        If confirm.result = DialogResult.OK Then
                            el.RemoveAll()
                            For Each nl As XElement In index.odoc.Element("root").Element("Notificacoes").Elements
                                If nl.Element("Nome").Value() = name Then
                                    nl.RemoveAll()
                                End If
                            Next
                            For Each citem As String In checkeditems
                                listas1.Add(New XElement("Item", citem, New XAttribute("Checked", True)))
                            Next
                            For Each uitem As String In uncheckeditems
                                listas1.Add(New XElement("Item", uitem, New XAttribute("Checked", False)))
                            Next
                            listas1.Add(nomelista)
                            index.odoc.Element("root").Element("Listas").Add(listas1)
                            nots.Add(tipo)
                            index.odoc.Element("root").Element("Notificacoes").Add(nots)

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
                    For Each citem As String In checkeditems
                        listas1.Add(New XElement("Item", citem, New XAttribute("Checked", True)))
                    Next
                    For Each uitem As String In uncheckeditems
                        listas1.Add(New XElement("Item", uitem, New XAttribute("Checked", False)))
                    Next
                    listas1.Add(nomelista)
                    index.odoc.Element("root").Element("Listas").Add(listas1)
                    nots.Add(tipo)
                    index.odoc.Element("root").Element("Notificacoes").Add(nots)

                    Hide()
                    index.Show()
                    MessageBox.Show("Não se esqueça de clicar em 'Guardar Configurações' quando acabar, senão as definições, lembretes e listas NÃO SÃO guardadas")
                End If
            End If
        End If
        Hide()
        index.Show()
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nome1 As String = InputBox("Introduza um nome para a lista criada: (não pode conter espaços nem números)")
        If nome1 = "" Then
            MessageBox.Show("Nome inválido")
            Return
        End If
        Try
            save_process(nome1, 3600 * 1000)
        Catch ex As Exception
            MessageBox.Show("Nome inválido")
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nome1 As String = InputBox("Introduza um nome para a lista criada: (não pode conter espaços nem números)")
        If nome1 = "" Then
            MessageBox.Show("Nome inválido")
            Return
        End If
        Try
            save_process(nome1, 3600 * 1000 * 4)
        Catch ex As Exception
            MessageBox.Show("Nome inválido")
            Return
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nome1 As String = InputBox("Introduza um nome para a lista criada: (não pode conter espaços nem números)")
        If nome1 = "" Then
            MessageBox.Show("Nome inválido")
            Return
        End If
        Try
            save_process(nome1, 3600 * 1000 * 8)
        Catch ex As Exception
            MessageBox.Show("Nome inválido")
            Return
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Integer.Parse(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("O tempo introduzido é inválido.")
            Return
        End Try

        If (Integer.Parse(TextBox1.Text) > 0) = False Then
            MessageBox.Show("O tempo introduzido tem de ser maior que zero.")
        End If

        Dim nome1 As String = InputBox("Introduza um nome para a lista criada: (não pode conter espaços nem números)")
        If nome1 = "" Then
            MessageBox.Show("Nome inválido")
            Return
        End If
        Try
            save_process(nome1, Integer.Parse(TextBox1.Text))
        Catch ex As Exception
            MessageBox.Show("Nome inválido")
            Return
        End Try
    End Sub
    Private Sub no_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles no.LinkClicked
        MessageBox.Show("Não será notificado desta lista!")
        Dim nome1 As String = InputBox("Introduza um nome para a lista criada: (não pode conter espaços nem números)")
        If nome1 = "" Then
            MessageBox.Show("Nome inválido")
            Return
        End If
        Try
            save_process(nome1, 0)
        Catch ex As Exception
            MessageBox.Show("Nome inválido")
            Return
        End Try
    End Sub
    Private Sub notslista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clista.Show()
    End Sub
End Class