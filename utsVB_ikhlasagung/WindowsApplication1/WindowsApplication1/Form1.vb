Imports System.Data.SqlClient
Public Class Form1
    Dim transport As String
    Dim tanggal = DateTime.Now.ToString("yyyy-MM-dd")
    Dim cmd_gl As SqlCommand    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()


        CBtransport.Items.Add("Pick up")
        CBtransport.Items.Add("Box")
        CBtransport.Items.Add("Blind Van")
        CBtransport.Items.Add("Truck")
        CBtransport.Items.Add("BTT")
        CBtransport.Items.Add("Forklift")
        CBtransport.Items.Add("Other")

        Tbtransport.Visible = False
        show_request()
    End Sub

    Private Sub CBtransport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtransport.SelectedIndexChanged
        transport = CBtransport.Text
        If CBtransport.Text = "Other" Then
            Tbtransport.Visible = True
        End If
    End Sub

    Private Sub Btsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String



        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID FROM Trequest"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()



            query = "INSERT INTO Trequest (RequestId,Namerequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) " & _
                    "VALUES (" & uid & ",'" & Tbname.Text & "', '" & TbId.Text & "','" & TbUnit.Text & "','" & tanggal & "','" & tbUandD.Text & "','" & TbReg.Text & "', " & _
                    " '" & transport & "','" & Tbphone.Text & "','" & Tbinstruction.Text & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("Data pengajuan '" + Tbname.Text + "' Berhasil Terkirim")
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Tbtransport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbtransport.TextChanged
        transport = Tbtransport.Text
    End Sub

    Private Sub show_request()

        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVRequest.View = View.Details
        LVRequest.Columns.Add("NO", 50)
        LVRequest.Columns.Add("Name Of Request", 300)
        LVRequest.Columns.Add("UnitForm", 150)
        LVRequest.Columns.Add("UnitTo", 200)
        LVRequest.Columns.Add("RequestDate", 200)
        LVRequest.Columns.Add("Transportation", 200)


        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from Trequest"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader


            Do While dr.Read
                LVRequest.Items.Add(dr("RequestId"))
                LVRequest.Items(LVRequest.Items.Count - 1).SubItems.Add(dr("Namerequestor"))
                LVRequest.Items(LVRequest.Items.Count - 1).SubItems.Add(dr("Unit"))
                LVRequest.Items(LVRequest.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                LVRequest.Items(LVRequest.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                LVRequest.Items(LVRequest.Items.Count - 1).SubItems.Add(dr("Transportation"))
            Loop

            dr.Close()
            Call CloseKoneksi()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String
        Try
            RequestId = LVRequest.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from Trequest where RequestId='" + RequestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVRequest.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String
        Dim query As String
        Btsend.Visible = False




        Try
            RequestId = LVRequest.SelectedItems(0).Text

            Call OpenKoneksi()
            query = "SELECT Trequest WHERE RequestId='" + RequestId + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()


            Tbname.Text = dr("Namerequestor")
            TbId.Text = dr("RequestorId")
            TbUnit.Text = dr("Unit")
            DtpIssue.Value = dr("DateIssue")
            tbUandD.Text = dr("UnitDestination")
            TbReg.Text = dr("acRegis")
            Tbtransport.Text = dr("Transportation")
            Tbphone.Text = dr("Phone")
            Tbinstruction.Text = dr("Instruction")

            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
    End Sub

    Private Sub Btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btupdate.Click
        Btsend.Visible = True
        Btupdate.Visible = False
        Try

            Call OpenKoneksi()
            query_gl = "UPDATE Trequest SET " & _
                "NameRequestor = '" & Tbname.Text & "'," & _
                "Unit = '" & TbUnit.Text & "', " & _
                "DateIssue = '" & tanggal & "'," & _
                "UnitDestination = '" & tbUandD.Text & "', " & _
                "acRegis = '" & TbReg.Text & "', " & _
                "Transportation = '" & CBtransport.Text & "', " & _
                "Phone = '" & Tbphone.Text & "', " & _
                "Instruction = '" & Tbinstruction.Text & "' " & _
                "WHERE RequestId = '" & Id.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            bersih()
            LVRequest.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub bersih()
        TBName.Text = ""
        TbReg.Text = ""
        TBUnit.Text = ""
        tanggal = ""
        tbUandD.Text = ""
        TbUnit.Text = ""
        CBtransport.Text = ""
        TbPhone.Text = ""
        TbInstruction.Text = ""
        BtSend.Text = "save"
    End Sub

End Class