Public Class Form1
    Dim harga As Double
    Dim TotalHarga As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNoOrder.Text = DateAndTime.Now.ToString("yyMMdd-hhmmss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbJenisCuci.Text = "CUCI KERING" And cbServis.Text = "BIASA" Then
            harga = 3000
        ElseIf cbJenisCuci.Text = "CUCI KERING" And cbServis.Text = "KILAT" Then
            harga = 5000
        ElseIf cbJenisCuci.Text = "CUCI+SETRIKA" And cbServis.Text = "BIASA" Then
            harga = 6000
        ElseIf cbJenisCuci.Text = "CUCI+SETRIKA" And cbServis.Text = "KILAT" Then
            harga = 7000
        End If

        If txtNama.Text = "" Or txtBerat.Text = "" Or cbJenisCuci.Text = "" Or cbServis.Text = "" Then
            MsgBox("ISI FORMULIR DULULAH!")
        Else
            TotalHarga = txtBerat.Text * harga
            MessageBox.Show("NO ORDER : " + txtNoOrder.Text & Environment.NewLine &
                            "NAMA PELANGGAN : " + txtNama.Text & Environment.NewLine &
                            "JUMLAH BERAT : " + txtBerat.Text & Environment.NewLine &
                            "JENIS & LAYANAN : " + cbJenisCuci.Text + " " + cbServis.Text & Environment.NewLine &
                            "TOTAL HARGA : " + TotalHarga.ToString)
        End If

        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = txtNoOrder.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = txtNama.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = txtBerat.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = cbJenisCuci.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = cbServis.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = TotalHarga
        DataGridView1.Update()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNoOrder.Text = DateAndTime.Now.ToString("yyMMdd-hhmmss")
        txtNama.Text = ""
        txtBerat.Text = ""
        cbJenisCuci.Text = ""
        cbServis.Text = ""
    End Sub
End Class
