Imports System.Data.SqlClient

Public Class EntregasEPP
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Dim PProceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub EntregasEPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultas()
    End Sub


    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Consultas()
        With PProceso
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Procesos
                            WHERE Estado = 'Activo'
                            ORDER BY Nombre_Proceso ASC"
            .Connection = Conex
        End With

        DAProceso.SelectCommand = PProceso
        DTProceso = New DataTable
        DAProceso.Fill(DTProceso)
        With CProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub


End Class