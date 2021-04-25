Imports System.Xml
Imports System.Xml.Linq
Public Class alista
    Private Sub alista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listasstr = XDocument.Parse(index.odoc.ToString)
        Dim listas = listasstr.Element("root").Element("Listas")

        For Each lista In listas.Elements
            alist.Items.Add(lista.Element("Nome").Value())
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clista.list1.Items.Clear()
        Dim listasstr = XDocument.Parse(index.odoc.ToString)

        Try
            Dim lista As String = alist.SelectedItem()
        Catch ex As Exception
            MessageBox.Show("Não foi selecionada nenhuma lista")
            Return
        End Try

        For Each lista In listasstr.Element("root").Element("Listas").Elements("Lista")
            If lista.Element("Nome").Value() = alist.SelectedItem() Then
                For Each item In lista.Elements("Item")
                    If item.Attribute("Checked") = "true" Then
                        clista.list1.Items.Add(item.Value(), True)
                    Else
                        clista.list1.Items.Add(item.Value(), False)
                    End If
                Next
            End If
        Next

        Hide()
        clista.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listasstr As XDocument
        Try
            listasstr = System.Xml.Linq.XDocument.Parse(index.odoc.ToString())
        Catch ex As Exception
            MessageBox.Show("Não foi encontrado nenhum ficheiro de configuração")
            Hide()
            index.Show()
            Return
        End Try
        Try
            Dim lista As String = alist.SelectedItem()
        Catch ex As Exception
            MessageBox.Show("Não foi selecionada nenhuma lista")
            Return
        End Try

        For Each lista As XElement In index.odoc.Element("root").Element("Listas").Elements
            If alist.SelectedItem() = lista.Element("Nome").Value() Then
                lista.RemoveAll()
                lista.Remove()
                For Each el As XElement In index.odoc.Element("root").Element("Notificacoes").Elements
                    If alist.SelectedItem = el.Element("Nome").Value() Then
                        el.RemoveAll()
                        el.Remove()
                    End If
                Next
                alist.Items.Remove(alist.SelectedItem())
            End If
        Next
    End Sub
    Private Sub alista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        index.Show()
    End Sub
End Class