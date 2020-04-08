Imports System.Data.SqlClient

Public Class ODC
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub ODC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        POC.Visible = True
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

    Private Sub BBOCompra_Click(sender As Object, e As EventArgs) Handles BBOCompra.Click
        If POC.Visible = False Then
            POC.Visible = True
        ElseIf POC.Visible = True Then
            POC.Visible = False
        End If
    End Sub

    Private Sub BBOC1_Click(sender As Object, e As EventArgs) Handles BBOC1.Click
        Dim Consulta As String = "SELECT OC.id_orden, OC.codigo, OC.purchase_order, OC.CodiS, PR.nombre, COUNT(OD.descripcion) AS 'Productos Solicitados'
                                          FROM TB_Ordenes_Compra AS OC
                                               INNER JOIN Tb_Proveedores AS Pr ON Pr.id_p = OC.id_pro
                                               INNER JOIN TB_Ordenes_Detalle AS OD ON OC.codigo = OD.codigo
                                          WHERE OC.estado ='Activo' AND
                                                OC.CodiS <> ''  AND
                                                OD.descripcion NOT LIKE '%SILICIO%' AND
                                                OD.descripcion NOT LIKE '%GRAIN ORIENTED%' AND
                                                OD.descripcion NOT LIKE '%STEEL%' AND
                                                OD.descripcion NOT LIKE '%GRADE%' AND
                                                OD.descripcion NOT LIKE '%HERST%' AND
                                                OD.um NOT LIKE '%Servicio%' AND
                                                OC.fecha2_nota BETWEEN @Fech1 and @Fech2
                                          GROUP BY OC.id_orden, OC.codigo, OC.purchase_order, OC.CodiS, Pr.nombre"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Fech1", DTF1.Value)
        cmd.Parameters.AddWithValue("@Fech2", DTF2.Value)

        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DGOCA.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub DGOCA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOCA.CellContentClick
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

        Dim IDO, Cod, PO, Codis As String
        Dim row As DataGridViewRow = DGOCA.CurrentRow()

        IDO = row.Cells(0).Value
        IDOC.Text = IDO

        Cod = row.Cells(1).Value
        COCS.Text = Cod

        PO = row.Cells(2).Value
        OCompra.Text = PO

        Codis = row.Cells(3).Value
        CodS.Text = Codis

        POC.Visible = False
        Productos1.Visible = True
        BGuardar.Visible = True
        BTerminar.Visible = True
        LFinalizar.Visible = True
        LProd.Visible = True
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If CEnt1.Text = "0" Then
        Else
            Try
                Dim Funcion As New RegistroOC
                Dim Datos As New CRegistroOC

                Datos.GID = IDP1.Text
                Datos.GCEnt = CEnt1.Text
                Datos.GProducto = TxtAP1.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP2.Text
                Datos.GCEnt = CEnt2.Text
                Datos.GProducto = TxtAP2.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP3.Text
                Datos.GCEnt = CEnt3.Text
                Datos.GProducto = TxtAP3.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP4.Text
                Datos.GCEnt = CEnt4.Text
                Datos.GProducto = TxtAP4.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP5.Text
                Datos.GCEnt = CEnt5.Text
                Datos.GProducto = TxtAP5.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP6.Text
                Datos.GCEnt = CEnt6.Text
                Datos.GProducto = TxtAP6.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text


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

                Datos.GID = IDP7.Text
                Datos.GCEnt = CEnt7.Text
                Datos.GProducto = TxtAP7.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP8.Text
                Datos.GCEnt = CEnt8.Text
                Datos.GProducto = TxtAP8.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP9.Text
                Datos.GCEnt = CEnt9.Text
                Datos.GProducto = TxtAP9.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP10.Text
                Datos.GCEnt = CEnt10.Text
                Datos.GProducto = TxtAP10.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP11.Text
                Datos.GCEnt = CEnt11.Text
                Datos.GProducto = TxtAP11.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP12.Text
                Datos.GCEnt = CEnt12.Text
                Datos.GProducto = TxtAP12.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP13.Text
                Datos.GCEnt = CEnt13.Text
                Datos.GProducto = TxtAP13.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP14.Text
                Datos.GCEnt = CEnt14.Text
                Datos.GProducto = TxtAP14.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP15.Text
                Datos.GCEnt = CEnt15.Text
                Datos.GProducto = TxtAP15.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP16.Text
                Datos.GCEnt = CEnt16.Text
                Datos.GProducto = TxtAP16.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP17.Text
                Datos.GCEnt = CEnt17.Text
                Datos.GProducto = TxtAP17.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP18.Text
                Datos.GCEnt = CEnt18.Text
                Datos.GProducto = TxtAP18.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP19.Text
                Datos.GCEnt = CEnt19.Text
                Datos.GProducto = TxtAP19.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

                Datos.GID = IDP20.Text
                Datos.GCEnt = CEnt20.Text
                Datos.GProducto = TxtAP20.Text
                Datos.GL_ID = Index.L_ID.Text
                Datos.GLUsuario = LUsuario.Text
                Datos.GCOrdenT = COCS.Text
                Datos.GCOrdenC = CodS.Text

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

    Private Sub BB1_Click(sender As Object, e As EventArgs) Handles BB1.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "1"
            TxtBMaterial.Text = Producto1.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto1.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "1"
            M()
        End If
    End Sub

    Private Sub BB2_Click(sender As Object, e As EventArgs) Handles BB2.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "2"
            TxtBMaterial.Text = Producto2.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto2.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "2"
            M()
        End If
    End Sub

    Private Sub BB3_Click(sender As Object, e As EventArgs) Handles BB3.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "3"
            TxtBMaterial.Text = Producto3.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto3.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "3"
            M()
        End If
    End Sub

    Private Sub BB4_Click(sender As Object, e As EventArgs) Handles BB4.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "4"
            TxtBMaterial.Text = Producto4.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto4.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "4"
            M()
        End If
    End Sub

    Private Sub BB5_Click(sender As Object, e As EventArgs) Handles BB5.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "5"
            TxtBMaterial.Text = Producto5.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto5.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "5"
            M()
        End If
    End Sub

    Private Sub BB6_Click(sender As Object, e As EventArgs) Handles BB6.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "6"
            TxtBMaterial.Text = Producto6.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto6.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "6"
            M()
        End If
    End Sub

    Private Sub BB7_Click(sender As Object, e As EventArgs) Handles BB7.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "7"
            TxtBMaterial.Text = Producto7.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto7.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "7"
            M()
        End If
    End Sub

    Private Sub BB8_Click(sender As Object, e As EventArgs) Handles BB8.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "8"
            TxtBMaterial.Text = Producto8.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto8.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "8"
            M()
        End If
    End Sub

    Private Sub BB9_Click(sender As Object, e As EventArgs) Handles BB9.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "9"
            TxtBMaterial.Text = Producto9.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto9.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "9"
            M()
        End If
    End Sub

    Private Sub BB10_Click(sender As Object, e As EventArgs) Handles BB10.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "10"
            TxtBMaterial.Text = Producto10.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto10.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "10"
            M()
        End If
    End Sub

    Private Sub BB11_Click(sender As Object, e As EventArgs) Handles BB11.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "11"
            TxtBMaterial.Text = Producto11.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto11.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "11"
            M()
        End If
    End Sub

    Private Sub BB12_Click(sender As Object, e As EventArgs) Handles BB12.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "12"
            TxtBMaterial.Text = Producto12.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto12.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "12"
            M()
        End If
    End Sub

    Private Sub BB13_Click(sender As Object, e As EventArgs) Handles BB13.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "13"
            TxtBMaterial.Text = Producto13.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto13.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "13"
            M()
        End If
    End Sub

    Private Sub BB14_Click(sender As Object, e As EventArgs) Handles BB14.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "14"
            TxtBMaterial.Text = Producto14.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto14.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "14"
            M()
        End If
    End Sub

    Private Sub BB15_Click(sender As Object, e As EventArgs) Handles BB15.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "15"
            TxtBMaterial.Text = Producto15.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto15.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "15"
            M()
        End If
    End Sub

    Private Sub BB16_Click(sender As Object, e As EventArgs) Handles BB16.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "16"
            TxtBMaterial.Text = Producto16.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto16.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "16"
            M()
        End If
    End Sub

    Private Sub BB17_Click(sender As Object, e As EventArgs) Handles BB17.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "17"
            TxtBMaterial.Text = Producto17.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto17.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "17"
            M()
        End If
    End Sub

    Private Sub BB18_Click(sender As Object, e As EventArgs) Handles BB18.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "18"
            TxtBMaterial.Text = Producto18.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto18.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "18"
            M()
        End If
    End Sub

    Private Sub BB19_Click(sender As Object, e As EventArgs) Handles BB19.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "19"
            TxtBMaterial.Text = Producto19.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto19.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "19"
            M()
        End If
    End Sub

    Private Sub BB20_Click(sender As Object, e As EventArgs) Handles BB20.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "20"
            TxtBMaterial.Text = Producto20.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = Producto20.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "20"
            M()
        End If
    End Sub

    Private Sub BCM_Click(sender As Object, e As EventArgs) Handles BCM.Click
        PMaterial.Visible = False
    End Sub

    Private Sub DGProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducto.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim row As DataGridViewRow = DGProducto.Rows(e.RowIndex)

        If LDGP.Text = "1" Then
            FilaID = row.Cells(0).Value
            IDP1.Text = FilaID

            FilaP = row.Cells(1).Value
            TxtAP1.Text = FilaP

            BP1()

            Dim Id As Integer = ID1.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE1.Visible = True
            PMaterial.Visible = False
            CEnt1.ReadOnly = False

        ElseIf LDGP.Text = "2" Then
                FilaID = row.Cells(0).Value
                IDP2.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP2.Text = FilaP

            BP2()

            Dim Id As Integer = ID2.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE2.Visible = True
            PMaterial.Visible = False
            CEnt2.ReadOnly = False

        ElseIf LDGP.Text = "3" Then
                FilaID = row.Cells(0).Value
                IDP3.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP3.Text = FilaP

            BP3()

            Dim Id As Integer = ID3.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE3.Visible = True
            PMaterial.Visible = False
            CEnt3.ReadOnly = False

        ElseIf LDGP.Text = "4" Then
                FilaID = row.Cells(0).Value
                IDP4.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP4.Text = FilaP

            BP4()

            Dim Id As Integer = ID4.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE4.Visible = True
            PMaterial.Visible = False
            CEnt4.ReadOnly = False

        ElseIf LDGP.Text = "5" Then
                FilaID = row.Cells(0).Value
                IDP5.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP5.Text = FilaP

            BP5()

            Dim Id As Integer = ID5.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE5.Visible = True
            PMaterial.Visible = False
            CEnt5.ReadOnly = False

        ElseIf LDGP.Text = "6" Then
                FilaID = row.Cells(0).Value
                IDP6.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP6.Text = FilaP

            BP6()

            Dim Id As Integer = ID6.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE6.Visible = True
            PMaterial.Visible = False
            CEnt6.ReadOnly = False

        ElseIf LDGP.Text = "7" Then
                FilaID = row.Cells(0).Value
                IDP7.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP7.Text = FilaP

            BP7()

            Dim Id As Integer = ID7.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE7.Visible = True
            PMaterial.Visible = False
            CEnt7.ReadOnly = False

        ElseIf LDGP.Text = "8" Then
                FilaID = row.Cells(0).Value
                IDP8.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP8.Text = FilaP

            BP8()

            Dim Id As Integer = ID8.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE8.Visible = True
            PMaterial.Visible = False
            CEnt8.ReadOnly = False

        ElseIf LDGP.Text = "9" Then
                FilaID = row.Cells(0).Value
                IDP9.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP9.Text = FilaP

            BP9()

            Dim Id As Integer = ID9.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE9.Visible = True
            PMaterial.Visible = False
            CEnt9.ReadOnly = False

        ElseIf LDGP.Text = "10" Then
                FilaID = row.Cells(0).Value
                IDP10.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP10.Text = FilaP

            BP10()

            Dim Id As Integer = ID10.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE10.Visible = True
            PMaterial.Visible = False
            CEnt10.ReadOnly = False

        ElseIf LDGP.Text = "11" Then
                FilaID = row.Cells(0).Value
                IDP11.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP11.Text = FilaP

            BP11()

            Dim Id As Integer = ID11.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE11.Visible = True
            PMaterial.Visible = False
            CEnt11.ReadOnly = False

        ElseIf LDGP.Text = "12" Then
                FilaID = row.Cells(0).Value
                IDP12.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP12.Text = FilaP

            BP12()

            Dim Id As Integer = ID12.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE12.Visible = True
            PMaterial.Visible = False
            CEnt12.ReadOnly = False

        ElseIf LDGP.Text = "13" Then
                FilaID = row.Cells(0).Value
                IDP13.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP13.Text = FilaP

            BP13()

            Dim Id As Integer = ID13.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE13.Visible = True
            PMaterial.Visible = False
            CEnt13.ReadOnly = False

        ElseIf LDGP.Text = "14" Then
                FilaID = row.Cells(0).Value
                IDP14.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP14.Text = FilaP

            BP14()

            Dim Id As Integer = ID14.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE14.Visible = True
            PMaterial.Visible = False
            CEnt14.ReadOnly = False

        ElseIf LDGP.Text = "15" Then
                FilaID = row.Cells(0).Value
                IDP15.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP15.Text = FilaP

            BP15()

            Dim Id As Integer = ID15.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE15.Visible = True
            PMaterial.Visible = False
            CEnt15.ReadOnly = False

        ElseIf LDGP.Text = "16" Then
                FilaID = row.Cells(0).Value
                IDP16.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP16.Text = FilaP

            BP16()

            Dim Id As Integer = ID16.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE16.Visible = True
            PMaterial.Visible = False
            CEnt16.ReadOnly = False

        ElseIf LDGP.Text = "17" Then
                FilaID = row.Cells(0).Value
                IDP17.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP17.Text = FilaP

            BP17()

            Dim Id As Integer = ID17.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE17.Visible = True
            PMaterial.Visible = False
            CEnt17.ReadOnly = False

        ElseIf LDGP.Text = "18" Then
                FilaID = row.Cells(0).Value
                IDP18.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP18.Text = FilaP

            BP18()

            Dim Id As Integer = ID18.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE18.Visible = True
            PMaterial.Visible = False
            CEnt18.ReadOnly = False

        ElseIf LDGP.Text = "19" Then
                FilaID = row.Cells(0).Value
                IDP19.Text = FilaID

                FilaP = row.Cells(1).Value
                TxtAP19.Text = FilaP

            BP19()

            Dim Id As Integer = ID19.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & Id & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE19.Visible = True
            PMaterial.Visible = False
            CEnt19.ReadOnly = False

        ElseIf LDGP.Text = "20" Then
                FilaID = row.Cells(0).Value
            IDP20.Text = FilaID

            FilaP = row.Cells(1).Value
            TxtAP20.Text = FilaP

            BP20()

            Dim Id As Integer = ID20.Text
            Conex.Open()
            Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = " & FilaID & "
                                                            WHERE id_pro = " & ID & ""

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()

            BE20.Visible = True
            PMaterial.Visible = False
            CEnt20.ReadOnly = False
        End If
    End Sub

    Private Sub BTerminar_Click(sender As Object, e As EventArgs) Handles BTerminar.Click
        Dim CodSs As String = OCompra.Text

        Conex.Open()
        Dim CONSULTA As String = "UPDATE TB_Ordenes_Compra 
                                        SET estado = 'Finalizado'
                                        WHERE purchase_order = '" & CodSs & "'"

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

        POC.Visible = True
        Dim Consultas As String = "SELECT OC.id_orden, OC.codigo, OC.purchase_order, OC.CodiS, PR.nombre, COUNT(OD.descripcion) AS 'Productos Solicitados'
                                                        FROM TB_Ordenes_Compra AS OC
                                                            INNER JOIN Tb_Proveedores AS Pr ON Pr.id_p = OC.id_pro
                                                            INNER JOIN TB_Ordenes_Detalle AS OD ON OC.codigo = OD.codigo
                                                        WHERE OC.estado ='Activo' AND
                                                            OC.CodiS <> ''  AND
                                                            OC.purchase_order like '%'+@Busqueda+'%' AND
                                                            OD.descripcion NOT LIKE '%SILICIO%' AND
                                                            OD.descripcion NOT LIKE '%GRAIN ORIENTED%' AND
                                                            OD.descripcion NOT LIKE '%STEEL%' AND
                                                            OD.descripcion NOT LIKE '%GRADE%' AND
                                                            OD.descripcion NOT LIKE '%HERST%' AND
                                                            OD.um NOT LIKE '%Servicio%'
                                                        GROUP BY OC.id_orden, OC.codigo, OC.purchase_order, OC.CodiS, Pr.nombre"

        Dim cmds As New SqlCommand(Consultas, Conex)
        cmds.Parameters.AddWithValue("@Busqueda", "-")

        Dim Das As New SqlDataAdapter(cmds)
        Dim Dss As New DataSet

        Try
            Conex.Open()
            Das.Fill(Dss)

            DGOCA.DataSource = Dss.Tables(0)
            Das.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub BE1_Click(sender As Object, e As EventArgs) Handles BE1.Click
        TxtAP1.Text = ""
        IDP1.Text = ""
        LA1.Visible = False

        Dim Id As Integer = ID1.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE1.Visible = False
    End Sub

    Private Sub BE2_Click(sender As Object, e As EventArgs) Handles BE2.Click
        TxtAP2.Text = ""
        IDP2.Text = ""
        LA2.Visible = False

        Dim Id As Integer = ID2.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE2.Visible = False
    End Sub

    Private Sub BE3_Click(sender As Object, e As EventArgs) Handles BE3.Click
        TxtAP3.Text = ""
        IDP3.Text = ""
        LA3.Visible = False

        Dim Id As Integer = ID3.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE3.Visible = False
    End Sub

    Private Sub BE4_Click(sender As Object, e As EventArgs) Handles BE4.Click
        TxtAP4.Text = ""
        IDP4.Text = ""
        LA4.Visible = False

        Dim Id As Integer = ID4.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE4.Visible = False
    End Sub

    Private Sub BE5_Click(sender As Object, e As EventArgs) Handles BE5.Click
        TxtAP5.Text = ""
        IDP5.Text = ""
        LA5.Visible = False

        Dim Id As Integer = ID5.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE5.Visible = False
    End Sub

    Private Sub BE6_Click(sender As Object, e As EventArgs) Handles BE6.Click
        TxtAP6.Text = ""
        IDP6.Text = ""
        LA6.Visible = False

        Dim Id As Integer = ID6.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE6.Visible = False
    End Sub

    Private Sub BE7_Click(sender As Object, e As EventArgs) Handles BE7.Click
        TxtAP7.Text = ""
        IDP7.Text = ""
        LA7.Visible = False

        Dim Id As Integer = ID7.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE7.Visible = False
    End Sub

    Private Sub BE8_Click(sender As Object, e As EventArgs) Handles BE8.Click
        TxtAP8.Text = ""
        IDP8.Text = ""
        LA8.Visible = False

        Dim Id As Integer = ID8.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE8.Visible = False
    End Sub

    Private Sub BE9_Click(sender As Object, e As EventArgs) Handles BE9.Click
        TxtAP9.Text = ""
        IDP9.Text = ""
        LA9.Visible = False

        Dim Id As Integer = ID9.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE9.Visible = False
    End Sub

    Private Sub BE10_Click(sender As Object, e As EventArgs) Handles BE10.Click
        TxtAP10.Text = ""
        IDP10.Text = ""
        LA10.Visible = False

        Dim Id As Integer = ID10.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE10.Visible = False
    End Sub

    Private Sub BE11_Click(sender As Object, e As EventArgs) Handles BE11.Click
        TxtAP11.Text = ""
        IDP11.Text = ""
        LA11.Visible = False

        Dim Id As Integer = ID11.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE11.Visible = False
    End Sub

    Private Sub BE12_Click(sender As Object, e As EventArgs) Handles BE12.Click
        TxtAP12.Text = ""
        IDP12.Text = ""
        LA12.Visible = False

        Dim Id As Integer = ID12.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE12.Visible = False
    End Sub

    Private Sub BE13_Click(sender As Object, e As EventArgs) Handles BE13.Click
        TxtAP13.Text = ""
        IDP13.Text = ""
        LA13.Visible = False

        Dim Id As Integer = ID13.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE13.Visible = False
    End Sub

    Private Sub BE14_Click(sender As Object, e As EventArgs) Handles BE14.Click
        TxtAP14.Text = ""
        IDP14.Text = ""
        LA14.Visible = False

        Dim Id As Integer = ID14.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE14.Visible = False
    End Sub

    Private Sub BE15_Click(sender As Object, e As EventArgs) Handles BE15.Click
        TxtAP15.Text = ""
        IDP15.Text = ""
        LA15.Visible = False

        Dim Id As Integer = ID15.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE15.Visible = False
    End Sub

    Private Sub BE16_Click(sender As Object, e As EventArgs) Handles BE16.Click
        TxtAP16.Text = ""
        IDP16.Text = ""
        LA16.Visible = False

        Dim Id As Integer = ID16.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE16.Visible = False
    End Sub

    Private Sub BE17_Click(sender As Object, e As EventArgs) Handles BE17.Click
        TxtAP17.Text = ""
        IDP17.Text = ""
        LA17.Visible = False

        Dim Id As Integer = ID17.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE17.Visible = False
    End Sub

    Private Sub BE18_Click(sender As Object, e As EventArgs) Handles BE18.Click
        TxtAP18.Text = ""
        IDP18.Text = ""
        LA18.Visible = False

        Dim Id As Integer = ID18.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE18.Visible = False
    End Sub

    Private Sub BE19_Click(sender As Object, e As EventArgs) Handles BE19.Click
        TxtAP19.Text = ""
        IDP19.Text = ""
        LA19.Visible = False

        Dim Id As Integer = ID19.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE19.Visible = False
    End Sub

    Private Sub BE20_Click(sender As Object, e As EventArgs) Handles BE20.Click
        TxtAP20.Text = ""
        IDP20.Text = ""
        LA20.Visible = False

        Dim Id As Integer = ID20.Text
        Conex.Open()
        Dim CONSULTA As String = "Update TB_Ordenes_Detalle SET
                                            estado = ''
                                                            WHERE id_pro = " & Id & ""

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        BE20.Visible = False
    End Sub


    'Text
    Private Sub TxtBOC_TextChanged(sender As Object, e As EventArgs) Handles TxtBOC.TextChanged
        If TxtBOC.Text = "" Then
        Else
            Dim Consulta As String = "SELECT OC.id_orden, OC.codigo, OC.purchase_order, OC.CodiS, PR.nombre, COUNT(OD.descripcion) AS 'Productos Solicitados'
                                                        FROM TB_Ordenes_Compra AS OC
                                                            INNER JOIN Tb_Proveedores AS Pr ON Pr.id_p = OC.id_pro
                                                            INNER JOIN TB_Ordenes_Detalle AS OD ON OC.codigo = OD.codigo
                                                        WHERE OC.estado ='Activo' AND
                                                            OC.CodiS <> ''  AND
                                                            OC.purchase_order like '%'+@Busqueda+'%' AND
                                                            OD.descripcion NOT LIKE '%SILICIO%' AND
                                                            OD.descripcion NOT LIKE '%GRAIN ORIENTED%' AND
                                                            OD.descripcion NOT LIKE '%STEEL%' AND
                                                            OD.descripcion NOT LIKE '%GRADE%' AND
                                                            OD.descripcion NOT LIKE '%HERST%' AND
                                                            OD.um NOT LIKE '%Servicio%'
                                                        GROUP BY OC.id_orden, OC.codigo, OC.purchase_order, OC.CodiS, Pr.nombre"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBOC.Text))

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()
                Da.Fill(Ds)

                DGOCA.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Private Sub COCS_TextChanged(sender As Object, e As EventArgs) Handles COCS.TextChanged
        Productos()
    End Sub

    Private Sub CEnt1_TextChanged(sender As Object, e As EventArgs) Handles CEnt1.TextChanged
        If CEnt1.Text <> "0" Then
            Dim Prod As String = TxtAP1.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS1.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt2_TextChanged(sender As Object, e As EventArgs) Handles CEnt2.TextChanged
        If CEnt2.Text <> "0" Then
            Dim Prod As String = TxtAP2.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS2.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt3_TextChanged(sender As Object, e As EventArgs) Handles CEnt3.TextChanged
        If CEnt3.Text <> "0" Then
            Dim Prod As String = TxtAP3.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS3.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt4_TextChanged(sender As Object, e As EventArgs) Handles CEnt4.TextChanged
        If CEnt4.Text <> "0" Then
            Dim Prod As String = TxtAP4.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS4.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt5_TextChanged(sender As Object, e As EventArgs) Handles CEnt5.TextChanged
        If CEnt5.Text <> "0" Then
            Dim Prod As String = TxtAP5.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS5.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt6_TextChanged(sender As Object, e As EventArgs) Handles CEnt6.TextChanged
        If CEnt6.Text <> "0" Then
            Dim Prod As String = TxtAP6.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS6.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt7_TextChanged(sender As Object, e As EventArgs) Handles CEnt7.TextChanged
        If CEnt7.Text <> "0" Then
            Dim Prod As String = TxtAP7.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS7.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt8_TextChanged(sender As Object, e As EventArgs) Handles CEnt8.TextChanged
        If CEnt8.Text <> "0" Then
            Dim Prod As String = TxtAP8.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS8.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt9_TextChanged(sender As Object, e As EventArgs) Handles CEnt9.TextChanged
        If CEnt9.Text <> "0" Then
            Dim Prod As String = TxtAP9.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS9.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt10_TextChanged(sender As Object, e As EventArgs) Handles CEnt10.TextChanged
        If CEnt10.Text <> "0" Then
            Dim Prod As String = TxtAP10.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS10.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt11_TextChanged(sender As Object, e As EventArgs) Handles CEnt11.TextChanged
        If CEnt11.Text <> "0" Then
            Dim Prod As String = TxtAP11.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS11.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt12_TextChanged(sender As Object, e As EventArgs) Handles CEnt12.TextChanged
        If CEnt12.Text <> "0" Then
            Dim Prod As String = TxtAP12.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS12.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt13_TextChanged(sender As Object, e As EventArgs) Handles CEnt13.TextChanged
        If CEnt13.Text <> "0" Then
            Dim Prod As String = TxtAP13.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS13.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt14_TextChanged(sender As Object, e As EventArgs) Handles CEnt14.TextChanged
        If CEnt14.Text <> "0" Then
            Dim Prod As String = TxtAP14.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS14.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt15_TextChanged(sender As Object, e As EventArgs) Handles CEnt15.TextChanged
        If CEnt15.Text <> "0" Then
            Dim Prod As String = TxtAP15.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS15.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt16_TextChanged(sender As Object, e As EventArgs) Handles CEnt16.TextChanged
        If CEnt16.Text <> "0" Then
            Dim Prod As String = TxtAP16.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS16.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt17_TextChanged(sender As Object, e As EventArgs) Handles CEnt17.TextChanged
        If CEnt17.Text <> "0" Then
            Dim Prod As String = TxtAP17.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS17.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt18_TextChanged(sender As Object, e As EventArgs) Handles CEnt18.TextChanged
        If CEnt18.Text <> "0" Then
            Dim Prod As String = TxtAP18.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS18.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt19_TextChanged(sender As Object, e As EventArgs) Handles CEnt19.TextChanged
        If CEnt19.Text <> "0" Then
            Dim Prod As String = TxtAP19.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS19.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub CEnt20_TextChanged(sender As Object, e As EventArgs) Handles CEnt20.TextChanged
        If CEnt20.Text <> "0" Then
            Dim Prod As String = TxtAP20.Text
            Dim CodSs As String = CodS.Text
            Dim Can As String = CantidadS20.Text
            Dim CanS As String() = Can.Split(" ")

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodSs & "' AND Producto = '" & Prod & "')
                                             INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            Conex.Close()
        End If
    End Sub

    Private Sub TxtBMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtBMaterial.TextChanged
        If TxtBMaterial.Text = "" Then
            M()
        Else
            Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto, Existencia
                                            FROM TB_Productos
                                            WHERE Estado = 'Activo' AND
                                                    (Nombre_Producto  LIKE '%'+@Busqueda+'%' OR
                                                    Clave_Producto  LIKE '%'+@Busqueda+'%' OR
                                                    Codigo_Barras LIKE '%'+@Busqueda+'%') 
                                            ORDER BY Nombre_Producto ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBMaterial.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DGProducto.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub



    'Consultas
    Private Sub Productos()
        Dim Tabla As New DataTable
        Dim Busqueda As String = COCS.Text
        Dim Da As New SqlDataAdapter

        Dim Consulta As New SqlCommand("SELECT OD.id_pro, OD.descripcion, (Convert(Varchar,OD.cantidad) + ' ' + OD.Um), OD.estatus, OD.estado, OD.detalles
                                        FROM TB_Ordenes_Detalle AS OD
                                        WHERE OD.codigo =  '" + Busqueda + "' ", Conex)
        Da.SelectCommand = Consulta
        Da.Fill(Tabla)

        Try
            Conex.Open()

            If (Tabla.Rows.Count > 0) Then
                LID1.Visible = True
                LPr1.Visible = True
                LObserv1.Visible = True
                LCS1.Visible = True
                LCEn1.Visible = True
                LCE1.Visible = True
                LI1.Visible = True
                LBusqueda.Visible = True

                P1.Visible = True
                IDS1.Visible = True
                Producto1.Visible = True
                TxtObser1.Visible = True
                CantidadS1.Visible = True
                CEntra1.Visible = True
                CEnt1.Visible = True
                LUM1.Visible = True
                LAP1.Visible = True
                TxtAP1.Visible = True

                ID1.Text = Tabla.Rows(0)(0).ToString
                Producto1.Text = Tabla.Rows(0)(1).ToString
                TxtObser1.Text = Tabla.Rows(0)(5).ToString
                CantidadS1.Text = Tabla.Rows(0)(2).ToString
                CEntra1.Text = Tabla.Rows(0)(3).ToString
                IDP1.Text = Tabla.Rows(0)(4).ToString
            End If

            If (Tabla.Rows.Count > 1) Then
                P1.Visible = True
                IDS2.Visible = True
                Producto2.Visible = True
                TxtObser2.Visible = True
                CantidadS2.Visible = True
                CEntra2.Visible = True
                CEnt2.Visible = True
                LUM2.Visible = True
                LAP2.Visible = True
                TxtAP2.Visible = True

                ID2.Text = Tabla.Rows(1)(0).ToString
                Producto2.Text = Tabla.Rows(1)(1).ToString
                TxtObser2.Text = Tabla.Rows(1)(5).ToString
                CantidadS2.Text = Tabla.Rows(1)(2).ToString
                CEntra2.Text = Tabla.Rows(1)(3).ToString
                IDP2.Text = Tabla.Rows(1)(4).ToString
            End If

            If (Tabla.Rows.Count > 2) Then
                P2.Visible = True
                IDS3.Visible = True
                Producto3.Visible = True
                TxtObser3.Visible = True
                CantidadS3.Visible = True
                CEntra3.Visible = True
                CEnt3.Visible = True
                LUM3.Visible = True
                LAP3.Visible = True
                TxtAP3.Visible = True

                ID3.Text = Tabla.Rows(2)(0).ToString
                Producto3.Text = Tabla.Rows(2)(1).ToString
                TxtObser3.Text = Tabla.Rows(2)(5).ToString
                CantidadS3.Text = Tabla.Rows(2)(2).ToString
                CEntra3.Text = Tabla.Rows(2)(3).ToString
                IDP3.Text = Tabla.Rows(2)(4).ToString
            End If

            If (Tabla.Rows.Count > 3) Then
                P3.Visible = True

                IDS4.Visible = True
                Producto4.Visible = True
                TxtObser4.Visible = True
                CantidadS4.Visible = True
                CEntra4.Visible = True
                CEnt4.Visible = True
                LUM4.Visible = True
                LAP4.Visible = True
                TxtAP4.Visible = True

                ID4.Text = Tabla.Rows(3)(0).ToString
                Producto4.Text = Tabla.Rows(3)(1).ToString
                TxtObser4.Text = Tabla.Rows(3)(5).ToString
                CantidadS4.Text = Tabla.Rows(3)(2).ToString
                CEntra4.Text = Tabla.Rows(3)(3).ToString
                IDP4.Text = Tabla.Rows(3)(4).ToString
            End If

            If (Tabla.Rows.Count > 4) Then
                LID2.Visible = True
                LPr2.Visible = True
                LObserv2.Visible = True
                LCS2.Visible = True
                LCEn2.Visible = True
                LCE2.Visible = True
                LI2.Visible = True

                IDS5.Visible = True
                Producto5.Visible = True
                TxtObser5.Visible = True
                CantidadS5.Visible = True
                CEntra5.Visible = True
                CEnt5.Visible = True
                LUM5.Visible = True
                LAP5.Visible = True
                TxtAP5.Visible = True

                ID5.Text = Tabla.Rows(4)(0).ToString
                Producto5.Text = Tabla.Rows(4)(1).ToString
                TxtObser5.Text = Tabla.Rows(4)(5).ToString
                CantidadS5.Text = Tabla.Rows(4)(2).ToString
                CEntra5.Text = Tabla.Rows(4)(3).ToString
                IDP5.Text = Tabla.Rows(4)(4).ToString
            End If

            If (Tabla.Rows.Count > 5) Then
                P4.Visible = True
                IDS6.Visible = True
                Producto6.Visible = True
                TxtObser6.Visible = True
                CantidadS6.Visible = True
                CEntra6.Visible = True
                CEnt6.Visible = True
                LUM6.Visible = True
                LAP6.Visible = True
                TxtAP6.Visible = True

                ID6.Text = Tabla.Rows(5)(0).ToString
                Producto6.Text = Tabla.Rows(5)(1).ToString
                TxtObser6.Text = Tabla.Rows(5)(5).ToString
                CantidadS6.Text = Tabla.Rows(5)(2).ToString
                CEntra6.Text = Tabla.Rows(5)(3).ToString
                IDP6.Text = Tabla.Rows(5)(4).ToString
            End If

            If (Tabla.Rows.Count > 6) Then
                P5.Visible = True
                IDS7.Visible = True
                Producto7.Visible = True
                TxtObser7.Visible = True
                CantidadS7.Visible = True
                CEntra7.Visible = True
                CEnt7.Visible = True
                LUM7.Visible = True
                LAP7.Visible = True
                TxtAP7.Visible = True

                ID7.Text = Tabla.Rows(6)(0).ToString
                Producto7.Text = Tabla.Rows(6)(1).ToString
                TxtObser7.Text = Tabla.Rows(6)(5).ToString
                CantidadS7.Text = Tabla.Rows(6)(2).ToString
                CEntra7.Text = Tabla.Rows(6)(3).ToString
                IDP7.Text = Tabla.Rows(6)(4).ToString
            End If

            If (Tabla.Rows.Count > 7) Then
                P6.Visible = True
                IDS8.Visible = True
                Producto8.Visible = True
                TxtObser8.Visible = True
                CantidadS8.Visible = True
                CEntra8.Visible = True
                CEnt8.Visible = True
                LUM8.Visible = True
                LAP8.Visible = True
                TxtAP8.Visible = True

                ID8.Text = Tabla.Rows(7)(0).ToString
                Producto8.Text = Tabla.Rows(7)(1).ToString
                TxtObser8.Text = Tabla.Rows(7)(5).ToString
                CantidadS8.Text = Tabla.Rows(7)(2).ToString
                CEntra8.Text = Tabla.Rows(7)(3).ToString
                IDP8.Text = Tabla.Rows(7)(4).ToString
            End If

            If (Tabla.Rows.Count > 8) Then
                LID3.Visible = True
                LPr3.Visible = True
                LObserv3.Visible = True
                LCS3.Visible = True
                LCEn3.Visible = True
                LCE3.Visible = True
                LI3.Visible = True

                IDS9.Visible = True
                Producto9.Visible = True
                TxtObser9.Visible = True
                CantidadS9.Visible = True
                CEntra9.Visible = True
                CEnt9.Visible = True
                LUM9.Visible = True
                LAP9.Visible = True
                TxtAP9.Visible = True

                ID9.Text = Tabla.Rows(8)(0).ToString
                Producto9.Text = Tabla.Rows(8)(1).ToString
                TxtObser9.Text = Tabla.Rows(8)(5).ToString
                CantidadS9.Text = Tabla.Rows(8)(2).ToString
                CEntra9.Text = Tabla.Rows(8)(3).ToString
                IDP9.Text = Tabla.Rows(8)(4).ToString
            End If

            If (Tabla.Rows.Count > 9) Then
                P7.Visible = True
                IDS10.Visible = True
                Producto10.Visible = True
                TxtObser10.Visible = True
                CantidadS10.Visible = True
                CEntra10.Visible = True
                CEnt10.Visible = True
                LUM10.Visible = True
                LAP10.Visible = True
                TxtAP10.Visible = True

                ID10.Text = Tabla.Rows(9)(0).ToString
                Producto10.Text = Tabla.Rows(9)(1).ToString
                TxtObser10.Text = Tabla.Rows(9)(5).ToString
                CantidadS10.Text = Tabla.Rows(9)(2).ToString
                CEntra10.Text = Tabla.Rows(9)(3).ToString
                IDP10.Text = Tabla.Rows(9)(4).ToString
            End If

            If (Tabla.Rows.Count > 10) Then
                P8.Visible = True
                IDS11.Visible = True
                Producto11.Visible = True
                TxtObser11.Visible = True
                CantidadS11.Visible = True
                CEntra11.Visible = True
                CEnt11.Visible = True
                LUM11.Visible = True
                LAP11.Visible = True
                TxtAP11.Visible = True

                ID11.Text = Tabla.Rows(10)(0).ToString
                Producto11.Text = Tabla.Rows(10)(1).ToString
                TxtObser11.Text = Tabla.Rows(10)(5).ToString
                CantidadS11.Text = Tabla.Rows(10)(2).ToString
                CEntra11.Text = Tabla.Rows(10)(3).ToString
                IDP11.Text = Tabla.Rows(10)(4).ToString
            End If

            If (Tabla.Rows.Count > 11) Then
                P9.Visible = True
                IDS12.Visible = True
                Producto12.Visible = True
                TxtObser12.Visible = True
                CantidadS12.Visible = True
                CEntra12.Visible = True
                CEnt12.Visible = True
                LUM12.Visible = True
                LAP12.Visible = True
                TxtAP12.Visible = True

                ID12.Text = Tabla.Rows(11)(0).ToString
                Producto12.Text = Tabla.Rows(11)(1).ToString
                TxtObser12.Text = Tabla.Rows(11)(5).ToString
                CantidadS12.Text = Tabla.Rows(11)(2).ToString
                CEntra12.Text = Tabla.Rows(11)(3).ToString
                IDP12.Text = Tabla.Rows(11)(4).ToString
            End If

            If (Tabla.Rows.Count > 12) Then
                LID4.Visible = True
                LPr4.Visible = True
                LObserv4.Visible = True
                LCS4.Visible = True
                LCEn4.Visible = True
                LCE4.Visible = True
                LI4.Visible = True

                IDS13.Visible = True
                Producto13.Visible = True
                TxtObser13.Visible = True
                CantidadS13.Visible = True
                CEntra13.Visible = True
                CEnt13.Visible = True
                LUM13.Visible = True
                LAP13.Visible = True
                TxtAP13.Visible = True

                ID13.Text = Tabla.Rows(12)(0).ToString
                Producto13.Text = Tabla.Rows(12)(1).ToString
                TxtObser13.Text = Tabla.Rows(12)(5).ToString
                CantidadS13.Text = Tabla.Rows(12)(2).ToString
                CEntra13.Text = Tabla.Rows(12)(3).ToString
                IDP13.Text = Tabla.Rows(12)(4).ToString
            End If

            If (Tabla.Rows.Count > 13) Then
                P10.Visible = True
                IDS14.Visible = True
                Producto14.Visible = True
                TxtObser14.Visible = True
                CantidadS14.Visible = True
                CEntra14.Visible = True
                CEnt14.Visible = True
                LUM14.Visible = True
                LAP14.Visible = True
                TxtAP14.Visible = True

                ID14.Text = Tabla.Rows(13)(0).ToString
                Producto14.Text = Tabla.Rows(13)(1).ToString
                TxtObser14.Text = Tabla.Rows(13)(5).ToString
                CantidadS14.Text = Tabla.Rows(13)(2).ToString
                CEntra14.Text = Tabla.Rows(13)(3).ToString
                IDP14.Text = Tabla.Rows(13)(4).ToString
            End If

            If (Tabla.Rows.Count > 14) Then
                P11.Visible = True
                IDS15.Visible = True
                Producto15.Visible = True
                TxtObser15.Visible = True
                CantidadS15.Visible = True
                CEntra15.Visible = True
                CEnt15.Visible = True
                LUM15.Visible = True
                LAP15.Visible = True
                TxtAP15.Visible = True

                ID15.Text = Tabla.Rows(14)(0).ToString
                Producto15.Text = Tabla.Rows(14)(1).ToString
                TxtObser15.Text = Tabla.Rows(14)(5).ToString
                CantidadS15.Text = Tabla.Rows(14)(2).ToString
                CEntra15.Text = Tabla.Rows(14)(3).ToString
                IDP15.Text = Tabla.Rows(14)(4).ToString
            End If

            If (Tabla.Rows.Count > 15) Then
                P12.Visible = True
                IDS16.Visible = True
                Producto16.Visible = True
                TxtObser16.Visible = True
                CantidadS16.Visible = True
                CEntra16.Visible = True
                CEnt16.Visible = True
                LUM16.Visible = True
                LAP16.Visible = True
                TxtAP16.Visible = True

                ID16.Text = Tabla.Rows(15)(0).ToString
                Producto16.Text = Tabla.Rows(15)(1).ToString
                TxtObser16.Text = Tabla.Rows(15)(5).ToString
                CantidadS16.Text = Tabla.Rows(15)(2).ToString
                CEntra16.Text = Tabla.Rows(15)(3).ToString
                IDP16.Text = Tabla.Rows(15)(4).ToString
            End If

            If (Tabla.Rows.Count > 16) Then
                LID5.Visible = True
                LPr5.Visible = True
                LObserv5.Visible = True
                LCS5.Visible = True
                LCEn5.Visible = True
                LCE5.Visible = True
                LI5.Visible = True

                IDS17.Visible = True
                Producto17.Visible = True
                TxtObser17.Visible = True
                CantidadS17.Visible = True
                CEntra17.Visible = True
                CEnt17.Visible = True
                LUM17.Visible = True
                LAP17.Visible = True
                TxtAP17.Visible = True

                ID17.Text = Tabla.Rows(16)(0).ToString
                Producto17.Text = Tabla.Rows(16)(1).ToString
                TxtObser17.Text = Tabla.Rows(16)(5).ToString
                CantidadS17.Text = Tabla.Rows(16)(2).ToString
                CEntra17.Text = Tabla.Rows(16)(3).ToString
                IDP17.Text = Tabla.Rows(16)(4).ToString
            End If

            If (Tabla.Rows.Count > 17) Then
                P13.Visible = True
                IDS18.Visible = True
                Producto18.Visible = True
                TxtObser18.Visible = True
                CantidadS18.Visible = True
                CEntra18.Visible = True
                CEnt18.Visible = True
                LUM18.Visible = True
                LAP18.Visible = True
                TxtAP18.Visible = True

                ID18.Text = Tabla.Rows(17)(0).ToString
                Producto18.Text = Tabla.Rows(17)(1).ToString
                TxtObser18.Text = Tabla.Rows(17)(5).ToString
                CantidadS18.Text = Tabla.Rows(17)(2).ToString
                CEntra18.Text = Tabla.Rows(17)(3).ToString
                IDP18.Text = Tabla.Rows(17)(4).ToString
            End If

            If (Tabla.Rows.Count > 18) Then
                P14.Visible = True
                IDS19.Visible = True
                Producto19.Visible = True
                TxtObser19.Visible = True
                CantidadS19.Visible = True
                CEntra19.Visible = True
                CEnt19.Visible = True
                LUM19.Visible = True
                LAP19.Visible = True
                TxtAP19.Visible = True

                ID19.Text = Tabla.Rows(18)(0).ToString
                Producto19.Text = Tabla.Rows(18)(1).ToString
                TxtObser19.Text = Tabla.Rows(18)(5).ToString
                CantidadS19.Text = Tabla.Rows(18)(2).ToString
                CEntra19.Text = Tabla.Rows(18)(3).ToString
                IDP19.Text = Tabla.Rows(18)(4).ToString
            End If

            If (Tabla.Rows.Count > 19) Then
                P15.Visible = True
                IDS20.Visible = True
                Producto20.Visible = True
                TxtObser20.Visible = True
                CantidadS20.Visible = True
                CEntra20.Visible = True
                CEnt20.Visible = True
                LUM20.Visible = True
                LAP20.Visible = True
                TxtAP20.Visible = True

                ID20.Text = Tabla.Rows(19)(0).ToString
                Producto20.Text = Tabla.Rows(19)(1).ToString
                TxtObser20.Text = Tabla.Rows(19)(5).ToString
                CantidadS20.Text = Tabla.Rows(19)(2).ToString
                CEntra20.Text = Tabla.Rows(19)(3).ToString
                IDP20.Text = Tabla.Rows(19)(4).ToString
            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()

        If IDP1.Text <> "" Then
            BP1()
            If LUM1.Text <> "" Then
                CEnt1.ReadOnly = False
                If CEntra1.Text = "" Then
                    BB1.Visible = True
                    BE1.Visible = True
                Else
                    BE1.Visible = False
                    BB1.Visible = False
                End If
            ElseIf LUM1.Text = "" Then
                LA1.Visible = True
                If CEntra1.Text = "" Then
                    BB1.Visible = True
                    BE1.Visible = True
                Else
                    BE1.Visible = False
                    BB1.Visible = False
                End If
            End If
        ElseIf TxtAP1.Text = "" And Producto1.Text <> "" Then
            BB1.Visible = True
        End If

        If IDP2.Text <> "" Then
            BP2()
            If LUM2.Text <> "" Then
                CEnt2.ReadOnly = False
                If CEntra2.Text = "" Then
                    BB2.Visible = True
                    BE2.Visible = True
                Else
                    BE2.Visible = False
                    BB2.Visible = False
                End If
            ElseIf LUM2.Text = "" Then
                LA2.Visible = True
                If CEntra2.Text = "" Then
                    BB2.Visible = True
                    BE2.Visible = True
                Else
                    BE2.Visible = False
                    BB2.Visible = False
                End If
            End If
        ElseIf TxtAP2.Text = "" And Producto2.Text <> "" Then
            BB2.Visible = True
        End If

        If IDP3.Text <> "" Then
            BP3()
            If LUM3.Text <> "" Then
                CEnt3.ReadOnly = False
                If CEntra3.Text = "" Then
                    BB3.Visible = True
                    BE3.Visible = True
                Else
                    BE3.Visible = False
                    BB3.Visible = False
                End If
            ElseIf LUM3.Text = "" Then
                LA3.Visible = True
                If CEntra3.Text = "" Then
                    BB3.Visible = True
                    BE3.Visible = True
                Else
                    BE3.Visible = False
                    BB3.Visible = False
                End If
            End If
        ElseIf TxtAP3.Text = "" And Producto3.Text <> "" Then
            BB3.Visible = True
        End If

        If IDP4.Text <> "" Then
            BP4()
            If LUM4.Text <> "" Then
                CEnt4.ReadOnly = False
                If CEntra4.Text = "" Then
                    BB4.Visible = True
                    BE4.Visible = True
                Else
                    BE4.Visible = False
                    BB4.Visible = False
                End If
            ElseIf LUM4.Text = "" Then
                LA4.Visible = True
                If CEntra4.Text = "" Then
                    BB4.Visible = True
                    BE4.Visible = True
                Else
                    BE4.Visible = False
                    BB4.Visible = False
                End If
            End If
        ElseIf TxtAP4.Text = "" And Producto4.Text <> "" Then
            BB4.Visible = True
        End If

        If IDP5.Text <> "" Then
            BP5()
            If LUM5.Text <> "" Then
                CEnt5.ReadOnly = False
                If CEntra5.Text = "" Then
                    BB5.Visible = True
                    BE5.Visible = True
                Else
                    BE5.Visible = False
                    BB5.Visible = False
                End If
            ElseIf LUM5.Text = "" Then
                LA5.Visible = True
                If CEntra5.Text = "" Then
                    BB5.Visible = True
                    BE5.Visible = True
                Else
                    BE5.Visible = False
                    BB5.Visible = False
                End If
            End If
        ElseIf TxtAP5.Text = "" And Producto5.Text <> "" Then
            BB5.Visible = True
        End If

        If IDP6.Text <> "" Then
            BP6()
            If LUM6.Text <> "" Then
                CEnt6.ReadOnly = False
                If CEntra6.Text = "" Then
                    BB6.Visible = True
                    BE6.Visible = True
                Else
                    BE6.Visible = False
                    BB6.Visible = False
                End If
            ElseIf LUM6.Text = "" Then
                LA6.Visible = True
                If CEntra6.Text = "" Then
                    BB6.Visible = True
                    BE6.Visible = True
                Else
                    BE6.Visible = False
                    BB6.Visible = False
                End If
            End If
        ElseIf TxtAP6.Text = "" And Producto6.Text <> "" Then
            BB6.Visible = True
        End If

        If IDP7.Text <> "" Then
            BP7()
            If LUM7.Text <> "" Then
                CEnt7.ReadOnly = False
                If CEntra7.Text = "" Then
                    BB7.Visible = True
                    BE7.Visible = True
                Else
                    BE7.Visible = False
                    BB7.Visible = False
                End If
            ElseIf LUM7.Text = "" Then
                LA7.Visible = True
                If CEntra7.Text = "" Then
                    BB7.Visible = True
                    BE7.Visible = True
                Else
                    BE7.Visible = False
                    BB7.Visible = False
                End If
            End If
        ElseIf TxtAP7.Text = "" And Producto7.Text <> "" Then
            BB7.Visible = True
        End If

        If IDP8.Text <> "" Then
            BP8()
            If LUM8.Text <> "" Then
                CEnt8.ReadOnly = False
                If CEntra8.Text = "" Then
                    BB8.Visible = True
                    BE8.Visible = True
                Else
                    BE8.Visible = False
                    BB8.Visible = False
                End If
            ElseIf LUM8.Text = "" Then
                LA8.Visible = True
                If CEntra8.Text = "" Then
                    BB8.Visible = True
                    BE8.Visible = True
                Else
                    BE8.Visible = False
                    BB8.Visible = False
                End If
            End If
        ElseIf TxtAP8.Text = "" And Producto8.Text <> "" Then
            BB8.Visible = True
        End If

        If IDP9.Text <> "" Then
            BP9()
            If LUM9.Text <> "" Then
                CEnt9.ReadOnly = False
                If CEntra9.Text = "" Then
                    BB9.Visible = True
                    BE9.Visible = True
                Else
                    BE9.Visible = False
                    BB9.Visible = False
                End If
            ElseIf LUM9.Text = "" Then
                LA9.Visible = True
                If CEntra9.Text = "" Then
                    BB9.Visible = True
                    BE9.Visible = True
                Else
                    BE9.Visible = False
                    BB9.Visible = False
                End If
            End If
        ElseIf TxtAP9.Text = "" And Producto9.Text <> "" Then
            BB9.Visible = True
        End If

        If IDP10.Text <> "" Then
            BP10()
            If LUM10.Text <> "" Then
                CEnt10.ReadOnly = False
                If CEntra10.Text = "" Then
                    BB10.Visible = True
                    BE10.Visible = True
                Else
                    BE10.Visible = False
                    BB10.Visible = False
                End If
            ElseIf LUM10.Text = "" Then
                LA10.Visible = True
                If CEntra10.Text = "" Then
                    BB10.Visible = True
                    BE10.Visible = True
                Else
                    BE10.Visible = False
                    BB10.Visible = False
                End If
            End If
        ElseIf TxtAP10.Text = "" And Producto10.Text <> "" Then
            BB10.Visible = True
        End If

        If IDP11.Text <> "" Then
            BP11()
            If LUM11.Text <> "" Then
                CEnt11.ReadOnly = False
                If CEntra11.Text = "" Then
                    BB11.Visible = True
                    BE11.Visible = True
                Else
                    BE11.Visible = False
                    BB11.Visible = False
                End If
            ElseIf LUM11.Text = "" Then
                LA11.Visible = True
                If CEntra11.Text = "" Then
                    BB11.Visible = True
                    BE11.Visible = True
                Else
                    BE11.Visible = False
                    BB11.Visible = False
                End If
            End If
        ElseIf TxtAP11.Text = "" And Producto11.Text <> "" Then
            BB11.Visible = True
        End If

        If IDP12.Text <> "" Then
            BP12()
            If LUM12.Text <> "" Then
                CEnt12.ReadOnly = False
                If CEntra1.Text = "" Then
                    BB12.Visible = True
                    BE12.Visible = True
                Else
                    BE12.Visible = False
                    BB12.Visible = False
                End If
            ElseIf LUM12.Text = "" Then
                LA12.Visible = True
                If CEntra1.Text = "" Then
                    BB12.Visible = True
                    BE12.Visible = True
                Else
                    BE12.Visible = False
                    BB12.Visible = False
                End If
            End If
        ElseIf TxtAP12.Text = "" And Producto12.Text <> "" Then
            BB12.Visible = True
        End If

        If IDP13.Text <> "" Then
            BP13()
            If LUM13.Text <> "" Then
                CEnt13.ReadOnly = False
                If CEntra13.Text = "" Then
                    BB13.Visible = True
                    BE13.Visible = True
                Else
                    BE13.Visible = False
                    BB13.Visible = False
                End If
            ElseIf LUM13.Text = "" Then
                LA13.Visible = True
                If CEntra13.Text = "" Then
                    BB13.Visible = True
                    BE13.Visible = True
                Else
                    BE13.Visible = False
                    BB13.Visible = False
                End If
            End If
        ElseIf TxtAP13.Text = "" And Producto13.Text <> "" Then
            BB13.Visible = True
        End If

        If IDP14.Text <> "" Then
            BP14()
            If LUM14.Text <> "" Then
                CEnt14.ReadOnly = False
                If CEntra14.Text = "" Then
                    BB14.Visible = True
                    BE14.Visible = True
                Else
                    BE14.Visible = False
                    BB14.Visible = False
                End If
            ElseIf LUM14.Text = "" Then
                LA14.Visible = True
                If CEntra14.Text = "" Then
                    BB14.Visible = True
                    BE14.Visible = True
                Else
                    BE14.Visible = False
                    BB14.Visible = False
                End If
            End If
        ElseIf TxtAP14.Text = "" And Producto14.Text <> "" Then
            BB14.Visible = True
        End If

        If IDP15.Text <> "" Then
            BP15()
            If LUM15.Text <> "" Then
                CEnt15.ReadOnly = False
                If CEntra15.Text = "" Then
                    BB15.Visible = True
                    BE15.Visible = True
                Else
                    BE15.Visible = False
                    BB15.Visible = False
                End If
            ElseIf LUM15.Text = "" Then
                LA15.Visible = True
                If CEntra15.Text = "" Then
                    BB15.Visible = True
                    BE15.Visible = True
                Else
                    BE15.Visible = False
                    BB15.Visible = False
                End If
            End If
        ElseIf TxtAP15.Text = "" And Producto15.Text <> "" Then
            BB15.Visible = True
        End If

        If IDP16.Text <> "" Then
            BP16()
            If LUM16.Text <> "" Then
                CEnt16.ReadOnly = False
                If CEntra16.Text = "" Then
                    BB16.Visible = True
                    BE16.Visible = True
                Else
                    BE16.Visible = False
                    BB16.Visible = False
                End If
            ElseIf LUM16.Text = "" Then
                LA16.Visible = True
                If CEntra16.Text = "" Then
                    BB16.Visible = True
                    BE16.Visible = True
                Else
                    BE16.Visible = False
                    BB16.Visible = False
                End If
            End If
        ElseIf TxtAP16.Text = "" And Producto16.Text <> "" Then
            BB16.Visible = True
        End If

        If IDP17.Text <> "" Then
            BP17()
            If LUM17.Text <> "" Then
                CEnt17.ReadOnly = False
                If CEntra17.Text = "" Then
                    BB17.Visible = True
                    BE17.Visible = True
                Else
                    BE17.Visible = False
                    BB17.Visible = False
                End If
            ElseIf LUM17.Text = "" Then
                LA17.Visible = True
                If CEntra17.Text = "" Then
                    BB17.Visible = True
                    BE17.Visible = True
                Else
                    BE17.Visible = False
                    BB17.Visible = False
                End If
            End If
        ElseIf TxtAP17.Text = "" And Producto17.Text <> "" Then
            BB17.Visible = True
        End If

        If IDP18.Text <> "" Then
            BP18()
            If LUM18.Text <> "" Then
                CEnt18.ReadOnly = False
                If CEntra18.Text = "" Then
                    BB18.Visible = True
                    BE18.Visible = True
                Else
                    BE18.Visible = False
                    BB18.Visible = False
                End If
            ElseIf LUM18.Text = "" Then
                LA18.Visible = True
                If CEntra18.Text = "" Then
                    BB18.Visible = True
                    BE18.Visible = True
                Else
                    BE18.Visible = False
                    BB18.Visible = False
                End If
            End If
        ElseIf TxtAP18.Text = "" And Producto18.Text <> "" Then
            BB18.Visible = True
        End If

        If IDP19.Text <> "" Then
            BP19()
            If LUM19.Text <> "" Then
                CEnt19.ReadOnly = False
                If CEntra19.Text = "" Then
                    BB19.Visible = True
                    BE19.Visible = True
                Else
                    BE19.Visible = False
                    BB19.Visible = False
                End If
            ElseIf LUM19.Text = "" Then
                LA19.Visible = True
                If CEntra19.Text = "" Then
                    BB19.Visible = True
                    BE19.Visible = True
                Else
                    BE19.Visible = False
                    BB19.Visible = False
                End If
            End If
        ElseIf TxtAP19.Text = "" And Producto19.Text <> "" Then
            BB19.Visible = True
        End If

        If IDP20.Text <> "" Then
            BP20()
            If LUM20.Text <> "" Then
                CEnt20.ReadOnly = False
                If CEntra20.Text = "" Then
                    BB20.Visible = True
                    BE20.Visible = True
                Else
                    BE20.Visible = False
                    BB20.Visible = False
                End If
            ElseIf LUM20.Text = "" Then
                LA20.Visible = True
                If CEntra20.Text = "" Then
                    BB20.Visible = True
                    BE20.Visible = True
                Else
                    BE20.Visible = False
                    BB20.Visible = False
                End If
            End If
        ElseIf TxtAP20.Text = "" And Producto20.Text <> "" Then
            BB20.Visible = True
        End If
    End Sub

    '   Relación de Productos
    Private Sub BP1()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP1.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP1.Text = Da.Item("Nombre_Producto").ToString()
            LUM1.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP2()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP2.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP2.Text = Da.Item("Nombre_Producto").ToString()
            LUM2.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP3()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP3.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP3.Text = Da.Item("Nombre_Producto").ToString()
            LUM3.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP4()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP4.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP4.Text = Da.Item("Nombre_Producto").ToString()
            LUM4.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP5()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP5.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP5.Text = Da.Item("Nombre_Producto").ToString()
            LUM5.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP6()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP6.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP6.Text = Da.Item("Nombre_Producto").ToString()
            LUM6.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP7()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP7.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP7.Text = Da.Item("Nombre_Producto").ToString()
            LUM7.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP8()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP8.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP8.Text = Da.Item("Nombre_Producto").ToString()
            LUM8.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP9()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP9.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP9.Text = Da.Item("Nombre_Producto").ToString()
            LUM9.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP10()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP10.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP10.Text = Da.Item("Nombre_Producto").ToString()
            LUM10.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP11()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP11.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP11.Text = Da.Item("Nombre_Producto").ToString()
            LUM11.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP12()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP12.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP12.Text = Da.Item("Nombre_Producto").ToString()
            LUM12.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP13()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP13.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP13.Text = Da.Item("Nombre_Producto").ToString()
            LUM13.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP14()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP14.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP14.Text = Da.Item("Nombre_Producto").ToString()
            LUM14.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP15()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP15.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP15.Text = Da.Item("Nombre_Producto").ToString()
            LUM15.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP16()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP16.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP16.Text = Da.Item("Nombre_Producto").ToString()
            LUM16.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP17()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP17.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP17.Text = Da.Item("Nombre_Producto").ToString()
            LUM17.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP18()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP18.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP18.Text = Da.Item("Nombre_Producto").ToString()
            LUM18.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP19()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                  FROM TB_Productos AS P
                                    INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                  WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP19.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP19.Text = Da.Item("Nombre_Producto").ToString()
            LUM19.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub BP20()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                  FROM TB_Productos AS P
                                    INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                  WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP20.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TxtAP20.Text = Da.Item("Nombre_Producto").ToString()
            LUM20.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub MR()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodSs As String = CodS.Text
        Dim Emple As String = LUsuario.Text
        Dim OrdenCompr As String = OCompra.Text

        Conex.Open()
        Dim CONSULTA As String = "INSERT INTO TB_MovimientoRastreo (Codigo, Tipo, Estado, Responsable, CodiS , Created)
                                                                VALUES ('" & OrdenCompr & "', 'Entrada', 'Entrada', '" & Emple & "', '" & CodSs & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
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

    Private Sub M()
        Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto, Existencia
                                          FROM TB_Productos
                                          WHERE Estado = 'Activo' AND
        									    Existencia > 0
                                          ORDER BY Nombre_Producto ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)
        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DGProducto.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub


    'Blanco
    Private Sub B1()
        LID1.Visible = False
        LPr1.Visible = False
        LObserv1.Visible = False
        LCS1.Visible = False
        LCEn1.Visible = False
        LCE1.Visible = False
        LI1.Visible = False

        IDS1.Visible = False
        ID1.Visible = False
        Producto1.Visible = False
        TxtObser1.Visible = False
        CantidadS1.Visible = False
        CEntra1.Visible = False
        CEnt1.Visible = False
        LUM1.Visible = False
        LAP1.Visible = False
        BB1.Visible = False
        TxtAP1.Visible = False
        IDP1.Visible = False
        LA1.Visible = False
        BE1.Visible = False

        ID1.Text = ""
        Producto1.Text = ""
        TxtObser1.Text = ""
        CantidadS1.Text = ""
        CEntra1.Text = ""
        CEnt1.Text = "0"
        LUM1.Text = ""
        TxtAP1.Text = ""
        IDP1.Text = ""
    End Sub

    Private Sub B2()
        P1.Visible = False
        IDS2.Visible = False
        ID2.Visible = False
        Producto2.Visible = False
        TxtObser2.Visible = False
        CantidadS2.Visible = False
        CEntra2.Visible = False
        CEnt2.Visible = False
        LUM2.Visible = False
        LAP2.Visible = False
        BB2.Visible = False
        TxtAP2.Visible = False
        IDP2.Visible = False
        LA2.Visible = False
        BE2.Visible = False

        ID2.Text = ""
        Producto2.Text = ""
        TxtObser2.Text = ""
        CantidadS2.Text = ""
        CEntra2.Text = ""
        CEnt2.Text = "0"
        LUM2.Text = ""
        TxtAP2.Text = ""
        IDP2.Text = ""
    End Sub

    Private Sub B3()
        P2.Visible = False
        IDS3.Visible = False
        ID3.Visible = False
        Producto3.Visible = False
        TxtObser3.Visible = False
        CantidadS3.Visible = False
        CEntra3.Visible = False
        CEnt3.Visible = False
        LUM3.Visible = False
        LAP3.Visible = False
        BB3.Visible = False
        TxtAP3.Visible = False
        IDP3.Visible = False
        LA3.Visible = False
        BE3.Visible = False

        ID3.Text = ""
        Producto3.Text = ""
        TxtObser3.Text = ""
        CantidadS3.Text = ""
        CEntra3.Text = ""
        CEnt3.Text = "0"
        LUM3.Text = ""
        TxtAP3.Text = ""
        IDP3.Text = ""
    End Sub

    Private Sub B4()
        P3.Visible = False
        IDS4.Visible = False
        ID4.Visible = False
        Producto4.Visible = False
        TxtObser4.Visible = False
        CantidadS4.Visible = False
        CEntra4.Visible = False
        CEnt4.Visible = False
        LUM4.Visible = False
        LAP4.Visible = False
        BB4.Visible = False
        TxtAP4.Visible = False
        IDP4.Visible = False
        LA4.Visible = False
        BE4.Visible = False

        ID4.Text = ""
        Producto4.Text = ""
        TxtObser4.Text = ""
        CantidadS4.Text = ""
        CEntra4.Text = ""
        CEnt4.Text = "0"
        LUM4.Text = ""
        TxtAP4.Text = ""
        IDP4.Text = ""
    End Sub

    Private Sub B5()
        LID2.Visible = False
        LPr2.Visible = False
        LObserv2.Visible = False
        LCS2.Visible = False
        LCEn2.Visible = False
        LCE2.Visible = False
        LI2.Visible = False

        IDS5.Visible = False
        ID5.Visible = False
        Producto5.Visible = False
        TxtObser5.Visible = False
        CantidadS5.Visible = False
        CEntra5.Visible = False
        CEnt5.Visible = False
        LUM5.Visible = False
        LAP5.Visible = False
        BB5.Visible = False
        TxtAP5.Visible = False
        IDP5.Visible = False
        LA5.Visible = False
        BE5.Visible = False

        ID5.Text = ""
        Producto5.Text = ""
        TxtObser5.Text = ""
        CantidadS5.Text = ""
        CEntra5.Text = ""
        CEnt5.Text = "0"
        LUM5.Text = ""
        TxtAP5.Text = ""
        IDP5.Text = ""
    End Sub

    Private Sub B6()
        P4.Visible = False
        IDS6.Visible = False
        ID6.Visible = False
        Producto6.Visible = False
        TxtObser6.Visible = False
        CantidadS6.Visible = False
        CEntra6.Visible = False
        CEnt6.Visible = False
        LUM6.Visible = False
        LAP6.Visible = False
        BB6.Visible = False
        TxtAP6.Visible = False
        IDP6.Visible = False
        LA6.Visible = False
        BE6.Visible = False

        ID6.Text = ""
        Producto6.Text = ""
        TxtObser6.Text = ""
        CantidadS6.Text = ""
        CEntra6.Text = ""
        CEnt6.Text = "0"
        LUM6.Text = ""
        TxtAP6.Text = ""
        IDP6.Text = ""
    End Sub

    Private Sub B7()
        P5.Visible = False
        IDS7.Visible = False
        ID7.Visible = False
        Producto7.Visible = False
        TxtObser7.Visible = False
        CantidadS7.Visible = False
        CEntra7.Visible = False
        CEnt7.Visible = False
        LUM7.Visible = False
        LAP7.Visible = False
        BB7.Visible = False
        TxtAP7.Visible = False
        IDP7.Visible = False
        LA7.Visible = False
        BE7.Visible = False

        ID7.Text = ""
        Producto7.Text = ""
        TxtObser7.Text = ""
        CantidadS7.Text = ""
        CEntra7.Text = ""
        CEnt7.Text = "0"
        LUM7.Text = ""
        TxtAP7.Text = ""
        IDP7.Text = ""
    End Sub

    Private Sub B8()
        P6.Visible = False
        IDS8.Visible = False
        ID8.Visible = False
        Producto8.Visible = False
        TxtObser8.Visible = False
        CantidadS8.Visible = False
        CEntra8.Visible = False
        CEnt8.Visible = False
        LUM8.Visible = False
        LAP8.Visible = False
        BB8.Visible = False
        TxtAP8.Visible = False
        IDP8.Visible = False
        LA8.Visible = False
        BE8.Visible = False

        ID8.Text = ""
        Producto8.Text = ""
        TxtObser8.Text = ""
        CantidadS8.Text = ""
        CEntra8.Text = ""
        CEnt8.Text = "0"
        LUM8.Text = ""
        TxtAP8.Text = ""
        IDP8.Text = ""
    End Sub

    Private Sub B9()
        LID3.Visible = False
        LPr3.Visible = False
        LObserv3.Visible = False
        LCS3.Visible = False
        LCEn3.Visible = False
        LCE3.Visible = False
        LI3.Visible = False

        IDS9.Visible = False
        ID9.Visible = False
        Producto9.Visible = False
        TxtObser9.Visible = False
        CantidadS9.Visible = False
        CEntra9.Visible = False
        CEnt9.Visible = False
        LUM9.Visible = False
        LAP9.Visible = False
        BB9.Visible = False
        TxtAP9.Visible = False
        IDP9.Visible = False
        LA9.Visible = False
        BE9.Visible = False

        ID9.Text = ""
        Producto9.Text = ""
        TxtObser9.Text = ""
        CantidadS9.Text = ""
        CEntra9.Text = ""
        CEnt9.Text = "0"
        LUM9.Text = ""
        TxtAP9.Text = ""
        IDP9.Text = ""
    End Sub

    Private Sub B10()
        P7.Visible = False
        IDS10.Visible = False
        ID10.Visible = False
        Producto10.Visible = False
        TxtObser10.Visible = False
        CantidadS10.Visible = False
        CEntra10.Visible = False
        CEnt10.Visible = False
        LUM10.Visible = False
        LAP10.Visible = False
        BB10.Visible = False
        TxtAP10.Visible = False
        IDP10.Visible = False
        LA10.Visible = False
        BE10.Visible = False

        ID10.Text = ""
        Producto10.Text = ""
        TxtObser10.Text = ""
        CantidadS10.Text = ""
        CEntra10.Text = ""
        CEnt10.Text = "0"
        LUM10.Text = ""
        TxtAP10.Text = ""
        IDP10.Text = ""
    End Sub

    Private Sub B11()
        P8.Visible = False
        IDS11.Visible = False
        ID11.Visible = False
        Producto11.Visible = False
        TxtObser11.Visible = False
        CantidadS11.Visible = False
        CEntra11.Visible = False
        CEnt11.Visible = False
        LUM11.Visible = False
        LAP11.Visible = False
        BB11.Visible = False
        TxtAP11.Visible = False
        IDP11.Visible = False
        LA11.Visible = False
        BE11.Visible = False

        ID11.Text = ""
        Producto11.Text = ""
        TxtObser11.Text = ""
        CantidadS11.Text = ""
        CEntra11.Text = ""
        CEnt11.Text = "0"
        LUM11.Text = ""
        TxtAP11.Text = ""
        IDP11.Text = ""
    End Sub

    Private Sub B12()
        P9.Visible = False
        IDS12.Visible = False
        ID12.Visible = False
        Producto12.Visible = False
        TxtObser12.Visible = False
        CantidadS12.Visible = False
        CEntra12.Visible = False
        CEnt12.Visible = False
        LUM12.Visible = False
        LAP12.Visible = False
        BB12.Visible = False
        TxtAP12.Visible = False
        IDP12.Visible = False
        LA12.Visible = False
        BE12.Visible = False

        ID12.Text = ""
        Producto12.Text = ""
        TxtObser12.Text = ""
        CantidadS12.Text = ""
        CEntra12.Text = ""
        CEnt12.Text = "0"
        LUM12.Text = ""
        TxtAP12.Text = ""
        IDP12.Text = ""
    End Sub

    Private Sub B13()
        LID4.Visible = False
        LPr4.Visible = False
        LObserv4.Visible = False
        LCS4.Visible = False
        LCEn4.Visible = False
        LCE4.Visible = False
        LI4.Visible = False

        IDS13.Visible = False
        ID13.Visible = False
        Producto13.Visible = False
        TxtObser13.Visible = False
        CantidadS13.Visible = False
        CEntra13.Visible = False
        CEnt13.Visible = False
        LUM13.Visible = False
        LAP13.Visible = False
        BB13.Visible = False
        TxtAP13.Visible = False
        IDP13.Visible = False
        LA13.Visible = False
        BE13.Visible = False

        ID13.Text = ""
        Producto13.Text = ""
        TxtObser13.Text = ""
        CantidadS13.Text = ""
        CEntra13.Text = ""
        CEnt13.Text = "0"
        LUM13.Text = ""
        TxtAP13.Text = ""
        IDP13.Text = ""
    End Sub

    Private Sub B14()
        P10.Visible = False
        IDS14.Visible = False
        ID14.Visible = False
        Producto14.Visible = False
        TxtObser14.Visible = False
        CantidadS14.Visible = False
        CEntra14.Visible = False
        CEnt14.Visible = False
        LUM14.Visible = False
        LAP14.Visible = False
        BB14.Visible = False
        TxtAP14.Visible = False
        IDP14.Visible = False
        LA14.Visible = False
        BE14.Visible = False

        ID14.Text = ""
        Producto14.Text = ""
        TxtObser14.Text = ""
        CantidadS14.Text = ""
        CEntra14.Text = ""
        CEnt14.Text = "0"
        LUM14.Text = ""
        TxtAP14.Text = ""
        IDP14.Text = ""
    End Sub

    Private Sub B15()
        P11.Visible = False
        IDS15.Visible = False
        ID15.Visible = False
        Producto15.Visible = False
        TxtObser15.Visible = False
        CantidadS15.Visible = False
        CEntra15.Visible = False
        CEnt15.Visible = False
        LUM15.Visible = False
        LAP15.Visible = False
        BB15.Visible = False
        TxtAP15.Visible = False
        IDP15.Visible = False
        LA15.Visible = False
        BE15.Visible = False

        ID15.Text = ""
        Producto15.Text = ""
        TxtObser15.Text = ""
        CantidadS15.Text = ""
        CEntra15.Text = ""
        CEnt15.Text = "0"
        LUM15.Text = ""
        TxtAP15.Text = ""
        IDP15.Text = ""
    End Sub

    Private Sub B16()
        P12.Visible = False
        IDS16.Visible = False
        ID16.Visible = False
        Producto16.Visible = False
        TxtObser16.Visible = False
        CantidadS16.Visible = False
        CEntra16.Visible = False
        CEnt16.Visible = False
        LUM16.Visible = False
        LAP16.Visible = False
        BB16.Visible = False
        TxtAP16.Visible = False
        IDP16.Visible = False
        LA16.Visible = False
        BE16.Visible = False

        ID16.Text = ""
        Producto16.Text = ""
        TxtObser16.Text = ""
        CantidadS16.Text = ""
        CEntra16.Text = ""
        CEnt16.Text = "0"
        LUM16.Text = ""
        TxtAP16.Text = ""
        IDP16.Text = ""
    End Sub

    Private Sub B17()
        LID5.Visible = False
        LPr5.Visible = False
        LObserv5.Visible = False
        LCS5.Visible = False
        LCEn5.Visible = False
        LCE5.Visible = False
        LI5.Visible = False

        IDS17.Visible = False
        ID17.Visible = False
        Producto17.Visible = False
        TxtObser17.Visible = False
        CantidadS17.Visible = False
        CEntra17.Visible = False
        CEnt17.Visible = False
        LUM17.Visible = False
        LAP17.Visible = False
        BB17.Visible = False
        TxtAP17.Visible = False
        IDP17.Visible = False
        LA17.Visible = False
        BE17.Visible = False

        ID17.Text = ""
        Producto17.Text = ""
        TxtObser17.Text = ""
        CantidadS17.Text = ""
        CEntra17.Text = ""
        CEnt17.Text = "0"
        LUM17.Text = ""
        TxtAP17.Text = ""
        IDP17.Text = ""
    End Sub

    Private Sub B18()
        P13.Visible = False
        IDS18.Visible = False
        ID18.Visible = False
        Producto18.Visible = False
        TxtObser18.Visible = False
        CantidadS18.Visible = False
        CEntra18.Visible = False
        CEnt18.Visible = False
        LUM18.Visible = False
        LAP18.Visible = False
        BB18.Visible = False
        TxtAP18.Visible = False
        IDP18.Visible = False
        LA18.Visible = False
        BE18.Visible = False

        ID18.Text = ""
        Producto18.Text = ""
        TxtObser18.Text = ""
        CantidadS18.Text = ""
        CEntra18.Text = ""
        CEnt18.Text = "0"
        LUM18.Text = ""
        TxtAP18.Text = ""
        IDP18.Text = ""
    End Sub

    Private Sub B19()
        P14.Visible = False
        IDS19.Visible = False
        ID19.Visible = False
        Producto19.Visible = False
        TxtObser19.Visible = False
        CantidadS19.Visible = False
        CEntra19.Visible = False
        CEnt19.Visible = False
        LUM19.Visible = False
        LAP19.Visible = False
        BB19.Visible = False
        TxtAP19.Visible = False
        IDP19.Visible = False
        LA19.Visible = False
        BE19.Visible = False

        ID19.Text = ""
        Producto19.Text = ""
        TxtObser19.Text = ""
        CantidadS19.Text = ""
        CEntra19.Text = ""
        CEnt19.Text = "0"
        LUM19.Text = ""
        TxtAP19.Text = ""
        IDP19.Text = ""
    End Sub

    Private Sub B20()
        P15.Visible = False
        IDS20.Visible = False
        ID20.Visible = False
        Producto20.Visible = False
        TxtObser20.Visible = False
        CantidadS20.Visible = False
        CEntra20.Visible = False
        CEnt20.Visible = False
        LUM20.Visible = False
        LAP20.Visible = False
        BB20.Visible = False
        TxtAP20.Visible = False
        IDP20.Visible = False
        LA20.Visible = False
        BE20.Visible = False

        ID20.Text = ""
        Producto20.Text = ""
        TxtObser20.Text = ""
        CantidadS20.Text = ""
        CEntra20.Text = ""
        CEnt20.Text = "0"
        LUM20.Text = ""
        TxtAP20.Text = ""
        IDP20.Text = ""
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class