﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'INVENTORYDataSet.SHOP' table. You can move, or remove it, as needed.
        Me.SHOPTableAdapter.Fill(Me.INVENTORYDataSet.SHOP)

    End Sub
End Class