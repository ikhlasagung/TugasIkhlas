Imports System.Data.SqlClient

Public Class Form1
    Dim bentuk As string

    Private Sub ListView()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVpengajuan.View = View.Details
        LVpengajuan.Columns.Add("No", 50)
        LVpengajuan.Columns.Add("Nama Pelaksana", 150)
        LVpengajuan.Columns.Add("Bidang", 100)
        LVpengajuan.Columns.Add("Jml Permintaan", 150)
        LVpengajuan.Columns.Add("Bentuk Dana", 100)
        LVpengajuan.Columns.Add("Keperluan", 200)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from tbpengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                LVpengajuan.Items.Add(dr("id"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("nama_pelaksana"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("bidang"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("jml_permintaan"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("bentuk_dana"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("keperluan"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Bersih()
        TbNama.Text = ""
        CBbidang.Text = ""
        TBpermintaan.Text = ""
        TBkeperluan.Text = ""
        RBcekbank.Checked = False
        RBgiro.Checked = False
        RBtunai.Checked = False
        TBID.Text = ""
        BTsave.Text = "save"

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
        Call ListView()
        TBID.Visible = False
    End Sub

    Private Sub BTsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsave.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim tanggal As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim query As String = ""
        If BTsave.Text = "save" Then
            Try
                Call OpenKoneksi()
                Dim query_id As String = "select MAX(id)+1 AS MXID from tbpengajuan"
                cmd = New SqlCommand(query_id, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                uid = dr("MXID")
                dr.Close()

                If RBcekbank.Checked = True Then
                    bentuk = RBcekbank.Text
                ElseIf RBtunai.Checked = True Then
                    bentuk = RBtunai.Text
                ElseIf RBgiro.Checked = True Then
                    bentuk = RBgiro.Text
                End If

                query = "Insert into tbpengajuan (id,nama_pelaksana,bidang,jml_permintaan,bentuk_dana,keperluan,tanggal) Values(" & uid & ",'" & TbNama.Text & "','" & CBbidang.Text & "','" & TBpermintaan.Text & "','" & bentuk & "','" & TBkeperluan.Text & "','" & tanggal & "')"
                MsgBox("Selamat '" + TbNama.Text + "' permintaan anda terACC")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf BTsave.Text = "Update" Then
            Call OpenKoneksi()
            If RBcekbank.Checked = True Then
                bentuk = RBcekbank.Text
            ElseIf RBtunai.Checked = True Then
                bentuk = RBtunai.Text
            ElseIf RBgiro.Checked = True Then
                bentuk = RBgiro.Text
            End If
            query = "Update tbpengajuan Set nama_pelaksana='" & TbNama.Text & "',bidang='" & CBbidang.Text & "',jml_permintaan='" & TBpermintaan.Text & "',bentuk_dana='" & bentuk & "',keperluan='" & TBkeperluan.Text & "'Where id='" & TBID.Text & "'"
            MsgBox("Selamat '" + TbNama.Text + "'Data Telah Berhasil Di Update")
        End If
        Try
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            Bersih()
            LVpengajuan.Clear()
            ListView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub BTEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEdit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        Try
            id = LVpengajuan.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "Select * from tbpengajuan Where id='" + id + "'"

            If bentuk = RBtunai.Text Then
                RBtunai.Checked = True
            ElseIf bentuk = RBcekbank.Text Then
                RBcekbank.Checked = True
            ElseIf bentuk = RBgiro.Text Then
                RBgiro.Checked = True
            End If
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            TbNama.Text = dr("nama_pelaksana")
            CBbidang.Text = dr("bidang")
            TBpermintaan.Text = dr("jml_permintaan")
            bentuk = dr("bentuk_dana")
            TBkeperluan.Text = dr("keperluan")
            TBID.Text = dr("id")
            BTsave.Text = "Update"
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub BTDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDelete.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Apakah Anda Yakin Ingin Menghapusnya?", vbYesNo) = MsgBoxResult.Yes Then
            Try
                id = LVpengajuan.SelectedItems(0).Text
                Call OpenKoneksi()
                Dim query As String = "Delete from tbpengajuan Where id='" + id + "'"

                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader
                Call CloseKoneksi()
                dr.Close()
                LVpengajuan.Clear()
                ListView()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BTcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcancel.Click
        Bersih()
    End Sub
End Class
