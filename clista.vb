Imports System.Xml
Imports System.Xml.Linq
Imports System.Threading.Thread
Public Class clista
    Public doc As XDocument = XDocument.Parse("<?xml version=""1.0"" encoding=""utf-8"" ?><root></root>")
    Public root As XElement = doc.Root
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text IsNot "" Then
            list1.Items.Add(TextBox1.Text)
        End If
        TextBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        list1.Items.Remove(list1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        notslista.Show()
    End Sub

    Private Sub clista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        index.Show()
    End Sub

    Private Sub clista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class