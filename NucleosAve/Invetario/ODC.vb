Imports System.Data.SqlClient

Public Class ODC
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    'ComboBoxs
    Dim OrdenC As New SqlCommand
    Dim DTOrdenC As DataTable
    Dim DAOrdenC As New SqlDataAdapter

    Private Sub ODC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrdenCompra()
        Nombres()
    End Sub


    'Botones
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
        Inventario.Show()
    End Sub

    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
        Inventario.Show()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If CEnt1.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID1.Text
                Datos.GCEnt = CEnt1.Text
                Datos.GProducto = Producto1.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt1.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt2.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID2.Text
                Datos.GCEnt = CEnt2.Text
                Datos.GProducto = Producto2.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt2.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt3.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID3.Text
                Datos.GCEnt = CEnt3.Text
                Datos.GProducto = Producto3.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt3.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt4.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID4.Text
                Datos.GCEnt = CEnt4.Text
                Datos.GProducto = Producto4.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt4.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt5.Text = "0" Then
        Else
            Try

                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID5.Text
                Datos.GCEnt = CEnt5.Text
                Datos.GProducto = Producto5.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt5.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt6.Text = "0" Then
        Else
            Try

                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID6.Text
                Datos.GCEnt = CEnt6.Text
                Datos.GProducto = Producto6.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt6.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt7.Text = "0" Then
        Else
            Try

                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID7.Text
                Datos.GCEnt = CEnt7.Text
                Datos.GProducto = Producto7.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt7.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt8.Text = "0" Then
        Else
            Try

                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID8.Text
                Datos.GCEnt = CEnt8.Text
                Datos.GProducto = Producto8.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt8.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt9.Text = "0" Then
        Else
            Try

                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID9.Text
                Datos.GCEnt = CEnt9.Text
                Datos.GProducto = Producto9.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt9.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt10.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID10.Text
                Datos.GCEnt = CEnt10.Text
                Datos.GProducto = Producto10.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt10.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt11.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID11.Text
                Datos.GCEnt = CEnt11.Text
                Datos.GProducto = Producto11.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt11.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt12.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID12.Text
                Datos.GCEnt = CEnt12.Text
                Datos.GProducto = Producto12.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt12.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt13.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID13.Text
                Datos.GCEnt = CEnt13.Text
                Datos.GProducto = Producto13.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt13.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt14.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID14.Text
                Datos.GCEnt = CEnt14.Text
                Datos.GProducto = Producto14.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt14.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt15.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID15.Text
                Datos.GCEnt = CEnt15.Text
                Datos.GProducto = Producto15.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt15.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt16.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID16.Text
                Datos.GCEnt = CEnt16.Text
                Datos.GProducto = Producto16.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt16.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt17.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID17.Text
                Datos.GCEnt = CEnt17.Text
                Datos.GProducto = Producto17.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt17.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt18.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID18.Text
                Datos.GCEnt = CEnt18.Text
                Datos.GProducto = Producto18.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt18.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt19.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID19.Text
                Datos.GCEnt = CEnt19.Text
                Datos.GProducto = Producto19.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt19.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If CEnt20.Text = "0" Then
        Else

            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = ID20.Text
                Datos.GCEnt = CEnt20.Text
                Datos.GProducto = Producto20.Text
                Datos.GCOrdenC = COrdenC.SelectedValue
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COrdenC.Text

                If Funcion.R(Datos) Then
                    CEnt20.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        MR()
        Productos()
    End Sub

    Private Sub BTerminar_Click(sender As Object, e As EventArgs) Handles BTerminar.Click
        Dim CodS As String = COrdenC.Text

        Conex.Open()
        Dim CONSULTA As String = "UPDATE TB_Ordenes_Compra 
                                    SET estado = 'Finalizado'
                                    WHERE codigo = '" & CodS & "'"

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        B1()
        B2()
        B3()
        B4()
        B5()
        B6()
        B7()
        B8()
        B9()
        B10()
        B11()
        B12()
        B13()
        B14()
        B15()
        B16()
        B17()
        B18()
        B19()
        B20()
        Conex.Close()

        OrdenCompra()
    End Sub


    Private Sub COrdenC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COrdenC.SelectionChangeCommitted
        Productos()
    End Sub


    '//////////////////
    Private Sub CEnt1_TextChanged(sender As Object, e As EventArgs) Handles CEnt1.TextChanged
        If CEnt1.Text <> "0" Then
            Dim Prod As String = Producto1.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS1.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt2_TextChanged(sender As Object, e As EventArgs) Handles CEnt2.TextChanged
        If CEnt2.Text <> "0" Then
            Dim Prod As String = Producto2.Text
            Dim CodS As String = COrdenC.SelectedValue

            Dim CanS As Double = CDec(CantidadS2.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt3_TextChanged(sender As Object, e As EventArgs) Handles CEnt3.TextChanged
        If CEnt3.Text <> "0" Then
            Dim Prod As String = Producto3.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS3.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt4_TextChanged(sender As Object, e As EventArgs) Handles CEnt4.TextChanged
        If CEnt4.Text <> "0" Then
            Dim Prod As String = Producto4.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS4.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt5_TextChanged(sender As Object, e As EventArgs) Handles CEnt5.TextChanged
        If CEnt5.Text <> "0" Then
            Dim Prod As String = Producto5.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS5.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt6_TextChanged(sender As Object, e As EventArgs) Handles CEnt6.TextChanged
        If CEnt6.Text <> "0" Then
            Dim Prod As String = Producto6.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS6.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt7_TextChanged(sender As Object, e As EventArgs) Handles CEnt7.TextChanged
        If CEnt7.Text <> "0" Then
            Dim Prod As String = Producto7.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS7.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt8_TextChanged(sender As Object, e As EventArgs) Handles CEnt8.TextChanged
        If CEnt8.Text <> "0" Then
            Dim Prod As String = Producto8.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS8.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt9_TextChanged(sender As Object, e As EventArgs) Handles CEnt9.TextChanged
        If CEnt9.Text <> "0" Then
            Dim Prod As String = Producto9.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS9.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt10_TextChanged(sender As Object, e As EventArgs) Handles CEnt10.TextChanged
        If CEnt10.Text <> "0" Then
            Dim Prod As String = Producto10.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS10.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt11_TextChanged(sender As Object, e As EventArgs) Handles CEnt11.TextChanged
        If CEnt11.Text <> "0" Then
            Dim Prod As String = Producto11.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS11.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt12_TextChanged(sender As Object, e As EventArgs) Handles CEnt12.TextChanged
        If CEnt12.Text <> "0" Then
            Dim Prod As String = Producto12.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS12.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt13_TextChanged(sender As Object, e As EventArgs) Handles CEnt13.TextChanged
        If CEnt13.Text <> "0" Then
            Dim Prod As String = Producto13.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS13.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt14_TextChanged(sender As Object, e As EventArgs) Handles CEnt14.TextChanged
        If CEnt14.Text <> "0" Then
            Dim Prod As String = Producto14.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS14.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt15_TextChanged(sender As Object, e As EventArgs) Handles CEnt15.TextChanged
        If CEnt15.Text <> "0" Then
            Dim Prod As String = Producto15.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS15.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt16_TextChanged(sender As Object, e As EventArgs) Handles CEnt16.TextChanged
        If CEnt16.Text <> "0" Then
            Dim Prod As String = Producto16.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS16.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt17_TextChanged(sender As Object, e As EventArgs) Handles CEnt17.TextChanged
        If CEnt17.Text <> "0" Then
            Dim Prod As String = Producto17.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS17.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt18_TextChanged(sender As Object, e As EventArgs) Handles CEnt18.TextChanged
        If CEnt18.Text <> "0" Then
            Dim Prod As String = Producto18.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS18.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt19_TextChanged(sender As Object, e As EventArgs) Handles CEnt19.TextChanged
        If CEnt19.Text <> "0" Then
            Dim Prod As String = Producto19.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS19.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt20_TextChanged(sender As Object, e As EventArgs) Handles CEnt20.TextChanged
        If CEnt20.Text <> "0" Then
            Dim Prod As String = Producto20.Text
            Dim CodS As String = COrdenC.SelectedValue
            Dim CanS As Double = CDec(CantidadS20.Text)

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                        INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                       VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub


    'Consultas
    Private Sub MR()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodS As String = COrdenC.SelectedValue
        Dim Emple As String = LUsuario.Text
        Dim OrdenCompr As String = COrdenC.Text

        Conex.Open()
        Dim CONSULTA As String = "INSERT INTO TB_MovimientoRastreo (Codigo, Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ('" & OrdenCompr & "', 'Entrada', 'Entrada', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub

    Private Sub OrdenCompra()
        'Combos
        With OrdenC
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Ordenes_Compra
                            WHERE Estado = 'Activo' AND
                                  CodiS <> ''
                            ORDER BY codigo ASC"
            .Connection = Conex
        End With

        DAOrdenC.SelectCommand = OrdenC
        DTOrdenC = New DataTable
        DAOrdenC.Fill(DTOrdenC)
        With COrdenC
            .DataSource = DTOrdenC
            .DisplayMember = "purchase_order"
            .ValueMember = "CodiS"
        End With
    End Sub

    Private Sub Nombres()
        Dim Consulta As String = "SELECT ( E.Nombre_Empleado+ ' ' + E.Ape_Paterno+' ' +  E.Ape_Materno) AS Nombre
                                  FROM TB_Usuarios AS U
                                    INNER JOIN TB_Empleados AS E ON U.Id_Empleado = E.Id_Empleado
                                  WHERE  U.Id_Usuario = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(Index.L_ID.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            LUsuario.Text = Da.Item("Nombre").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub Productos()
        Dim Tabla As New DataTable
        Dim Busqueda As String = COrdenC.Text
        Dim Da As New SqlDataAdapter

        Dim Consulta As New SqlCommand("SELECT  P.Id_Producto, P.Nombre_Producto, OD.cantidad, OD.estatus
                                        FROM TB_Ordenes_Detalle AS OD
                                        INNER JOIN TB_Productos AS P ON OD.descripcion = P.Nombre_Producto
                                        WHERE OD.codigo = '" + Busqueda + "' ", Conex)
        Da.SelectCommand = Consulta
        Da.Fill(Tabla)

        Try
            Conex.Open()

            If (Tabla.Rows.Count > 0) Then
                ID1.Visible = True
                Producto1.Visible = True
                CantidadS1.Visible = True
                CEnt1.Visible = True
                CEntra1.Visible = True

                ID1.Text = Tabla.Rows(0)(0).ToString
                Producto1.Text = Tabla.Rows(0)(1).ToString
                CantidadS1.Text = Tabla.Rows(0)(2).ToString
                CEntra1.Text = Tabla.Rows(0)(3).ToString

                B2()
                B3()
                B4()
                B5()
                B6()
                B7()
                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 1) Then
                ID2.Visible = True
                Producto2.Visible = True
                CantidadS2.Visible = True
                CEnt2.Visible = True
                CEntra2.Visible = True

                ID2.Text = Tabla.Rows(1)(0).ToString
                Producto2.Text = Tabla.Rows(1)(1).ToString
                CantidadS2.Text = Tabla.Rows(1)(2).ToString
                CEntra2.Text = Tabla.Rows(1)(3).ToString

                B3()
                B4()
                B5()
                B6()
                B7()
                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 2) Then
                ID3.Visible = True
                Producto3.Visible = True
                CantidadS3.Visible = True
                CEnt3.Visible = True
                CEntra3.Visible = True

                ID3.Text = Tabla.Rows(2)(0).ToString
                Producto3.Text = Tabla.Rows(2)(1).ToString
                CantidadS3.Text = Tabla.Rows(2)(2).ToString
                CEntra3.Text = Tabla.Rows(2)(3).ToString

                B4()
                B5()
                B6()
                B7()
                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 3) Then
                ID4.Visible = True
                Producto4.Visible = True
                CantidadS4.Visible = True

                ID4.Text = Tabla.Rows(3)(0).ToString
                Producto4.Text = Tabla.Rows(3)(1).ToString
                CantidadS4.Text = Tabla.Rows(3)(2).ToString
                CEntra4.Text = Tabla.Rows(3)(3).ToString

                B5()
                B6()
                B7()
                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 4) Then
                ID5.Visible = True
                Producto5.Visible = True
                CantidadS5.Visible = True

                ID5.Text = Tabla.Rows(4)(0).ToString
                Producto5.Text = Tabla.Rows(4)(1).ToString
                CantidadS5.Text = Tabla.Rows(4)(2).ToString
                CEntra5.Text = Tabla.Rows(4)(3).ToString

                B6()
                B7()
                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 5) Then
                ID6.Visible = True
                Producto6.Visible = True
                CantidadS6.Visible = True

                ID6.Text = Tabla.Rows(5)(0).ToString
                Producto6.Text = Tabla.Rows(5)(1).ToString
                CantidadS6.Text = Tabla.Rows(5)(2).ToString
                CEntra6.Text = Tabla.Rows(5)(3).ToString

                B7()
                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 6) Then
                ID7.Visible = True
                Producto7.Visible = True
                CantidadS7.Visible = True

                ID7.Text = Tabla.Rows(6)(0).ToString
                Producto7.Text = Tabla.Rows(6)(1).ToString
                CantidadS7.Text = Tabla.Rows(6)(2).ToString
                CEntra7.Text = Tabla.Rows(6)(3).ToString

                B8()
                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 7) Then
                ID8.Visible = True
                Producto8.Visible = True
                CantidadS8.Visible = True

                ID8.Text = Tabla.Rows(7)(0).ToString
                Producto8.Text = Tabla.Rows(7)(1).ToString
                CantidadS8.Text = Tabla.Rows(7)(2).ToString
                CEntra8.Text = Tabla.Rows(7)(3).ToString

                B9()
                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 8) Then
                ID9.Visible = True
                Producto9.Visible = True
                CantidadS9.Visible = True

                ID9.Text = Tabla.Rows(8)(0).ToString
                Producto9.Text = Tabla.Rows(8)(1).ToString
                CantidadS9.Text = Tabla.Rows(8)(2).ToString
                CEntra9.Text = Tabla.Rows(8)(3).ToString

                B10()
                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 9) Then
                ID10.Visible = True
                Producto10.Visible = True
                CantidadS10.Visible = True

                ID10.Text = Tabla.Rows(9)(0).ToString
                Producto10.Text = Tabla.Rows(9)(1).ToString
                CantidadS10.Text = Tabla.Rows(9)(2).ToString
                CEntra10.Text = Tabla.Rows(9)(3).ToString

                B11()
                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 10) Then
                ID11.Visible = True
                Producto11.Visible = True
                CantidadS11.Visible = True

                ID11.Text = Tabla.Rows(10)(0).ToString
                Producto11.Text = Tabla.Rows(10)(1).ToString
                CantidadS11.Text = Tabla.Rows(10)(2).ToString
                CEntra11.Text = Tabla.Rows(10)(3).ToString

                B12()
                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 11) Then
                ID12.Visible = True
                Producto12.Visible = True
                CantidadS12.Visible = True

                ID12.Text = Tabla.Rows(11)(0).ToString
                Producto12.Text = Tabla.Rows(11)(1).ToString
                CantidadS12.Text = Tabla.Rows(11)(2).ToString
                CEntra12.Text = Tabla.Rows(11)(3).ToString

                B13()
                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 12) Then
                ID13.Visible = True
                Producto13.Visible = True
                CantidadS13.Visible = True

                ID13.Text = Tabla.Rows(12)(0).ToString
                Producto13.Text = Tabla.Rows(12)(1).ToString
                CantidadS13.Text = Tabla.Rows(12)(2).ToString
                CEntra13.Text = Tabla.Rows(12)(3).ToString

                B14()
                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 13) Then
                ID14.Visible = True
                Producto14.Visible = True
                CantidadS14.Visible = True

                ID14.Text = Tabla.Rows(13)(0).ToString
                Producto14.Text = Tabla.Rows(13)(1).ToString
                CantidadS14.Text = Tabla.Rows(13)(2).ToString
                CEntra14.Text = Tabla.Rows(13)(3).ToString

                B15()
                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 14) Then
                ID15.Visible = True
                Producto15.Visible = True
                CantidadS15.Visible = True

                ID15.Text = Tabla.Rows(14)(0).ToString
                Producto15.Text = Tabla.Rows(14)(1).ToString
                CantidadS15.Text = Tabla.Rows(14)(2).ToString
                CEntra15.Text = Tabla.Rows(14)(3).ToString

                B16()
                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 15) Then
                ID16.Visible = True
                Producto16.Visible = True
                CantidadS16.Visible = True

                ID16.Text = Tabla.Rows(15)(0).ToString
                Producto16.Text = Tabla.Rows(15)(1).ToString
                CantidadS16.Text = Tabla.Rows(15)(2).ToString
                CEntra16.Text = Tabla.Rows(15)(3).ToString

                B17()
                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 16) Then
                ID17.Visible = True
                Producto17.Visible = True
                CantidadS17.Visible = True

                ID17.Text = Tabla.Rows(16)(0).ToString
                Producto17.Text = Tabla.Rows(16)(1).ToString
                CantidadS17.Text = Tabla.Rows(16)(2).ToString
                CEntra17.Text = Tabla.Rows(16)(3).ToString

                B18()
                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 17) Then
                ID18.Visible = True
                Producto18.Visible = True
                CantidadS18.Visible = True

                ID18.Text = Tabla.Rows(17)(0).ToString
                Producto18.Text = Tabla.Rows(17)(1).ToString
                CantidadS18.Text = Tabla.Rows(17)(2).ToString
                CEntra18.Text = Tabla.Rows(17)(3).ToString

                B19()
                B20()
            End If

            If (Tabla.Rows.Count > 18) Then
                ID19.Visible = True
                Producto19.Visible = True
                CantidadS19.Visible = True

                ID19.Text = Tabla.Rows(18)(0).ToString
                Producto19.Text = Tabla.Rows(18)(1).ToString
                CantidadS19.Text = Tabla.Rows(18)(2).ToString
                CEntra19.Text = Tabla.Rows(18)(3).ToString

                B20()
            End If

            If (Tabla.Rows.Count > 19) Then
                ID20.Visible = True
                Producto20.Visible = True
                CantidadS20.Visible = True

                ID20.Text = Tabla.Rows(19)(0).ToString
                Producto20.Text = Tabla.Rows(19)(1).ToString
                CantidadS20.Text = Tabla.Rows(19)(2).ToString
                CEntra20.Text = Tabla.Rows(19)(3).ToString
            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub


    'Blanco
    Private Sub B1()
        ID1.Visible = False
        Producto1.Visible = False
        CantidadS1.Visible = False
        CEnt1.Visible = False
        CEntra1.Visible = False
        ID1.Text = ""
        Producto1.Text = ""
        CantidadS1.Text = ""
        CEnt1.Text = "0"
        CEntra1.Text = ""
    End Sub

    Private Sub B2()
        ID2.Visible = False
        Producto2.Visible = False
        CantidadS2.Visible = False
        CEnt2.Visible = False
        CEntra2.Visible = False
        ID2.Text = ""
        Producto2.Text = ""
        CantidadS2.Text = ""
        CEnt2.Text = "0"
        CEntra2.Text = ""
    End Sub

    Private Sub B3()
        ID3.Visible = False
        Producto3.Visible = False
        CantidadS3.Visible = False
        CEnt3.Visible = False
        CEntra3.Visible = False
        ID3.Text = ""
        Producto3.Text = ""
        CantidadS3.Text = ""
        CEnt3.Text = "0"
        CEntra3.Text = ""
    End Sub

    Private Sub B4()
        ID4.Visible = False
        Producto4.Visible = False
        CantidadS4.Visible = False
        CEnt4.Visible = False
        CEntra4.Visible = False
        ID4.Text = ""
        Producto4.Text = ""
        CantidadS4.Text = ""
        CEnt4.Text = "0"
        CEntra4.Text = ""
    End Sub

    Private Sub B5()
        ID5.Visible = False
        Producto5.Visible = False
        CantidadS5.Visible = False
        CEnt5.Visible = False
        CEntra5.Visible = False
        ID5.Text = ""
        Producto5.Text = ""
        CantidadS5.Text = ""
        CEnt5.Text = "0"
        CEntra5.Text = ""
    End Sub

    Private Sub B6()
        ID6.Visible = False
        Producto6.Visible = False
        CantidadS6.Visible = False
        CEnt6.Visible = False
        CEntra6.Visible = False
        ID6.Text = ""
        Producto6.Text = ""
        CantidadS6.Text = ""
        CEnt6.Text = "0"
        CEntra6.Text = ""
    End Sub

    Private Sub B7()
        ID7.Visible = False
        Producto7.Visible = False
        CantidadS7.Visible = False
        CEnt7.Visible = False
        CEntra7.Visible = False
        ID7.Text = ""
        Producto7.Text = ""
        CantidadS7.Text = ""
        CEnt7.Text = "0"
        CEntra7.Text = ""
    End Sub

    Private Sub B8()
        ID8.Visible = False
        Producto8.Visible = False
        CantidadS8.Visible = False
        CEnt8.Visible = False
        CEntra8.Visible = False
        ID8.Text = ""
        Producto8.Text = ""
        CantidadS8.Text = ""
        CEnt8.Text = "0"
        CEntra8.Text = ""
    End Sub

    Private Sub B9()
        ID9.Visible = False
        Producto9.Visible = False
        CantidadS9.Visible = False
        CEnt9.Visible = False
        CEntra9.Visible = False
        ID9.Text = ""
        Producto9.Text = ""
        CantidadS9.Text = ""
        CEnt9.Text = "0"
        CEntra9.Text = ""
    End Sub

    Private Sub B10()
        ID10.Visible = False
        Producto10.Visible = False
        CantidadS10.Visible = False
        CEnt10.Visible = False
        CEntra10.Visible = False
        ID10.Text = ""
        Producto10.Text = ""
        CantidadS10.Text = ""
        CEnt10.Text = "0"
        CEntra10.Text = ""
    End Sub

    Private Sub B11()
        ID11.Visible = False
        Producto11.Visible = False
        CantidadS11.Visible = False
        CEnt11.Visible = False
        CEntra11.Visible = False
        ID11.Text = ""
        Producto11.Text = ""
        CantidadS11.Text = ""
        CEnt11.Text = "0"
        CEntra11.Text = ""
    End Sub

    Private Sub B12()
        ID12.Visible = False
        Producto12.Visible = False
        CantidadS12.Visible = False
        CEnt12.Visible = False
        CEntra12.Visible = False
        ID12.Text = ""
        Producto12.Text = ""
        CantidadS12.Text = ""
        CEnt12.Text = "0"
        CEntra12.Text = ""
    End Sub

    Private Sub B13()
        ID13.Visible = False
        Producto13.Visible = False
        CantidadS13.Visible = False
        CEnt13.Visible = False
        CEntra13.Visible = False
        ID13.Text = ""
        Producto13.Text = ""
        CantidadS13.Text = ""
        CEnt13.Text = "0"
        CEntra13.Text = ""
    End Sub

    Private Sub B14()
        ID14.Visible = False
        Producto14.Visible = False
        CantidadS14.Visible = False
        CEnt14.Visible = False
        CEntra14.Visible = False
        ID14.Text = ""
        Producto14.Text = ""
        CantidadS14.Text = ""
        CEnt14.Text = "0"
        CEntra14.Text = ""
    End Sub

    Private Sub B15()
        ID15.Visible = False
        Producto15.Visible = False
        CantidadS15.Visible = False
        CEnt15.Visible = False
        CEntra15.Visible = False
        ID15.Text = ""
        Producto15.Text = ""
        CantidadS15.Text = ""
        CEnt15.Text = "0"
        CEntra15.Text = ""
    End Sub

    Private Sub B16()
        ID16.Visible = False
        Producto16.Visible = False
        CantidadS16.Visible = False
        CEnt16.Visible = False
        CEntra16.Visible = False
        ID16.Text = ""
        Producto16.Text = ""
        CantidadS16.Text = ""
        CEnt16.Text = "0"
        CEntra16.Text = ""
    End Sub

    Private Sub B17()
        ID17.Visible = False
        Producto17.Visible = False
        CantidadS17.Visible = False
        CEnt17.Visible = False
        CEntra17.Visible = False
        ID17.Text = ""
        Producto17.Text = ""
        CantidadS17.Text = ""
        CEnt17.Text = "0"
        CEntra17.Text = ""
    End Sub

    Private Sub B18()
        ID18.Visible = False
        Producto18.Visible = False
        CantidadS18.Visible = False
        CEnt18.Visible = False
        CEntra18.Visible = False
        ID18.Text = ""
        Producto18.Text = ""
        CantidadS18.Text = ""
        CEnt18.Text = "0"
        CEntra18.Text = ""
    End Sub

    Private Sub B19()
        ID19.Visible = False
        Producto19.Visible = False
        CantidadS19.Visible = False
        CEnt19.Visible = False
        CEntra19.Visible = False
        ID19.Text = ""
        Producto19.Text = ""
        CantidadS19.Text = ""
        CEnt19.Text = "0"
        CEntra19.Text = ""
    End Sub

    Private Sub B20()
        ID20.Visible = False
        Producto20.Visible = False
        CantidadS20.Visible = False
        CEnt20.Visible = False
        CEntra20.Visible = False
        ID20.Text = ""
        Producto20.Text = ""
        CantidadS20.Text = ""
        CEnt20.Text = "0"
        CEntra20.Text = ""
    End Sub


    'Validaciones
    Private Sub CE(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CEnt1.KeyPress, CEnt2.KeyPress, CEnt3.KeyPress, CEnt4.KeyPress, CEnt5.KeyPress
        NumerosyDecimal(CEnt1, e)
        NumerosyDecimal(CEnt2, e)
        NumerosyDecimal(CEnt3, e)
        NumerosyDecimal(CEnt4, e)
        NumerosyDecimal(CEnt5, e)
    End Sub

    Private Sub CEn2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CEnt6.KeyPress, CEnt7.KeyPress, CEnt8.KeyPress, CEnt9.KeyPress, CEnt10.KeyPress
        NumerosyDecimal(CEnt6, e)
        NumerosyDecimal(CEnt7, e)
        NumerosyDecimal(CEnt8, e)
        NumerosyDecimal(CEnt9, e)
        NumerosyDecimal(CEnt10, e)
    End Sub

    Private Sub CEn3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CEnt11.KeyPress, CEnt12.KeyPress, CEnt13.KeyPress, CEnt14.KeyPress, CEnt15.KeyPress
        NumerosyDecimal(CEnt11, e)
        NumerosyDecimal(CEnt12, e)
        NumerosyDecimal(CEnt13, e)
        NumerosyDecimal(CEnt14, e)
        NumerosyDecimal(CEnt15, e)
    End Sub

    Private Sub CEn4(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CEnt16.KeyPress, CEnt17.KeyPress, CEnt18.KeyPress, CEnt19.KeyPress, CEnt20.KeyPress
        NumerosyDecimal(CEnt16, e)
        NumerosyDecimal(CEnt17, e)
        NumerosyDecimal(CEnt18, e)
        NumerosyDecimal(CEnt19, e)
        NumerosyDecimal(CEnt20, e)
    End Sub

    '   Numeros y Punto Decimal
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'Movimiento
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class