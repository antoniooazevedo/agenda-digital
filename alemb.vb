Public Class alemb
    Public rdoc = index.odoc
    Private Sub alemb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each el As XElement In index.odoc.Element("root").Element("Lembretes").Elements
            arem.Items.Add(el.Element("Nome").Value())
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim abc = arem.SelectedItem()
        Catch ex As Exception
            MessageBox.Show("Não foi selecionada nenhuma lista")
            Return
        End Try

        For Each el As XElement In index.odoc.Element("root").Element("Lembretes").Elements
            If el.Element("Nome").Value() = arem.SelectedItem() Then
                clemb.TextBox1.Text = el.Element("Conteudo").Value
                notslemb.datas.Value = el.Element("Data").Value
                notslemb.horas.Value = el.Element("Hora").Value
                notslemb.minutos.Value = el.Element("Minuto").Value
            End If
        Next
        Hide()
        clemb.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim abc = arem.SelectedItem()
        Catch ex As Exception
            MessageBox.Show("Não foi selecionada nenhuma lista")
            Return
        End Try

        For Each el As XElement In index.odoc.Element("root").Element("Lembretes").Elements
            If el.Element("Nome").Value = arem.SelectedItem() Then
                el.RemoveAll()
                el.Remove()
                arem.Items.Remove(arem.SelectedItem)
            End If
        Next
    End Sub

    Private Sub alemb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        index.Show()
    End Sub
End Class