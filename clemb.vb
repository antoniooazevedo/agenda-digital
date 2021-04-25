Public Class clemb
    Public doc As XDocument = XDocument.Parse("<?xml version=""1.0"" encoding=""utf-8"" ?><root></root>")
    Public root As XElement = doc.Root
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        notslemb.Show()
    End Sub
    Private Sub clemb_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        index.Show()
    End Sub

    Private Sub clemb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class