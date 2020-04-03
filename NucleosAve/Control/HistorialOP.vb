Imports System.Data.SqlClient
Public Class HistorialOP
    Dim Conex As New SqlConnection(My.Settings.Conexxx)
    Private Sub OC()
        Dim Consulta As String = "Select OC.codigo, OC.fecha2_nota, OC.estado
FROM TB_Ordenes_Compra As OC
 where oc.estado <> ''
ORDER BY fecha2_nota ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)

        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DVOC.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVOC.CellContentClick

    End Sub

    Private Sub HistorialOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OC()
        Op()
    End Sub

    Private Sub Op()
        Dim Consulta As String = "Select Id_Pedido, Fecha, Estado
FROM Tb_Pedido
Where Estado <> '' 
ORDER BY Fecha ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)

        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DVOP.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub
End Class