Imports System.Data
Imports System.Data.SqlClient

Public Class form_regis

    Private Sub form_regis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Me.Close()
        form_sesion.Show()
    End Sub
End Class