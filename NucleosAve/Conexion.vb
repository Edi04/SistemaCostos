Imports System.Data.SqlClient

Module Conexion
    Public Conexion As New SqlConnection(My.Settings.Conexxx)
    Public Enunciado As SqlCommand
    Public Respuesta As SqlDataReader

    Sub Abrir()
        Try
            Conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("Error en la Conexión" + ex.ToString)
        End Try
    End Sub

    Function UsuarioRegistrado(ByVal NombreUsuario As String) As Boolean
        Dim Resultado As Boolean = False

        Try
            Enunciado = New SqlCommand("SELECT * 
                                        FROM TB_Usuarios
                                        WHERE Usuario = '" & NombreUsuario & "'
                                            AND Estado = 'Activo'", Conexion)
            Respuesta = Enunciado.ExecuteReader

            If Respuesta.Read Then
                Resultado = True
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Resultado
    End Function

    Function Contrasena(ByVal NombreUsuario As String) As String
        Dim Resultado As String = ""
        Try
            Enunciado = New SqlCommand("SELECT Contrasena 
                                        FROM TB_Usuarios 
                                        WHERE Usuario = '" & NombreUsuario & "'", Conexion)
            Respuesta = Enunciado.ExecuteReader

            If Respuesta.Read Then
                resultado = Respuesta.Item("Contrasena")
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Proceso(ByVal NombreUsuario As String) As Integer
        Dim Resultado As Integer
        Try
            Enunciado = New SqlCommand("SELECT Id_Proceso 
                                        FROM TB_Usuarios 
                                        WHERE Usuario = '" & NombreUsuario & "'", Conexion)
            Respuesta = Enunciado.ExecuteReader

            If Respuesta.Read Then
                Resultado = CInt(Respuesta.Item("Id_Proceso"))
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Resultado
    End Function
End Module
