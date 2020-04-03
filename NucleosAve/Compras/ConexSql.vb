Imports System.Data.SqlClient
Module ConexSql
    Public con As New SqlConnection 'se crea el metodo para la coneccion de BD
    Sub conectarBD()
        Try
            Dim conexion As String
            conexion = "Data Source=ANTUA-PC\SQLEXPRESS;Initial Catalog=NucleosA;Integrated Security=True"
            con = New SqlConnection
            con.Open()


        Catch ex As Exception

        End Try
    End Sub
End Module
