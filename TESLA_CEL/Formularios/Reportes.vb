﻿Public Class Reportes


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        dgvProducto.DataSource = consultas.getReportsAll
    End Sub

    Private Sub bntDiario_Click(sender As Object, e As EventArgs) Handles bntDiario.Click

        dgvProducto.DataSource = consultas.getDayliReport(Date.Today.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        If cbTipo.Text = "TIPO PAGO" Then
            dgvProducto.DataSource = consultas.getDateReport(dtpInicio.Value.Date.ToString("yyyy-MM-dd"), dtpFin.Value.Date.ToString("yyyy-MM-dd"))
        Else
            dgvProducto.DataSource = consultas.getDateTypeReport(dtpInicio.Value.Date.ToString("yyyy-MM-dd"), dtpFin.Value.Date.ToString("yyyy-MM-dd"), cbTipo.Text)
        End If


    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        txtNombre.Clear()
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If txtNombre.Text = "" Then
            txtNombre.Text = "NOMBRE PRODUCTO"
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgvProducto.DataSource = consultas.getProductReport(txtNombre.Text)
    End Sub

    Private Sub Reportes_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        dgvProducto.DataSource = ""
    End Sub
End Class