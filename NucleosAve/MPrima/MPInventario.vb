Imports System.Data.SqlClient

Public Class MPInventario
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub MPInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nombres()
        Panel2.Visible = True
        TxtBOC.Text = "-"
        Calibre()
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

    Private Sub BBOC_Click(sender As Object, e As EventArgs) Handles BBOC.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
            TxtBOC.Text = "-"
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub BBOC1_Click(sender As Object, e As EventArgs) Handles BBOC1.Click
        BuscarOC()
    End Sub

    Private Sub DVOC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVOC.CellContentClick
        Dim OC, Prove, UMS, Mat, CodS, Codi, Fal, Det As String
        Dim Exis As Double
        Dim id_orden, ip_pr As Integer
        Dim row As DataGridViewRow = DVOC.CurrentRow

        id_orden = row.Cells(0).Value
        LIDO.Text = id_orden

        OC = row.Cells(1).Value
        TxtOC.Text = OC

        Codi = row.Cells(2).Value
        LCodigo.Text = Codi

        Prove = row.Cells(3).Value
        TxtProveedor.Text = Prove

        Exis = row.Cells(4).Value
        TxtCS.Text = Exis

        UMS = row.Cells(5).Value
        If UMS = "KILOGRAMOS" Or UMS = "KILOGRAMO" Then
            LKGS.Text = "KG"
        ElseIf UMS = "KG" Then
            LKGS.Text = UMS
        ElseIf UMS = "Toneladas" Or UMS = "Tonelada" Then
            LKGS.Text = "TON"
        ElseIf UMS = "TON" Then
            LKGS.Text = UMS
        ElseIf UMS = "MT" Then
            LKGS.Text = UMS
        End If

        CodS = row.Cells(6).Value
        LCS.Text = CodS

        Mat = row.Cells(7).Value
        TxtMaterial.Text = Mat

        Det = row.Cells(8).Value
        TxtDetalles.Text = Det

        ip_pr = row.Cells(9).Value
        ip_pro.Text = ip_pr

        Fal = row.Cells(10).Value
        TxtCR.Text = Fal

        Panel2.Visible = False
        Rol1()
        Rol2()
        Rol3()
        Rol4()
        Rol5()
        Rol6()
        Rol7()
        Rol8()
        Rol9()
        Rol10()
        Rol11()
        Rol12()
        Rol13()
        Rol14()
        Rol15()
        Rol16()
        Rol17()
        Rol18()
        Rol19()
        Rol20()

        TxtPedimento.ReadOnly = False

        TxtTC.ReadOnly = False
        TxtTC.Text = ""
    End Sub

    Private Sub BGMP_Click(sender As Object, e As EventArgs) Handles BGMP.Click
        If TxtOC.Text <> "" Then


            If TxtAncho1.Text = "" And TxtCalibre1.Text = "" And TxtPeso1.Text = "" And TxtNumRollo1.Text = "" And TxtNRolI1.Text = "" And TxtObser1.Text = "" Then
                'Nothing
            ElseIf TxtAncho1.Text = "" Or TxtCalibre1.Text = "" Or TxtPeso1.Text = "" Or TxtNRolI1.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 1", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRolI1.Text
                    If TxtNumRollo1.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo1.Text
                    End If
                    Datos.Calibre_ = TxtCalibre1.Text
                    Datos.Ancho_ = TxtAncho1.Text
                    Datos.Peso_ = TxtPeso1.Text
                    Datos.Espesor_ = TxtEspesor1.Text
                    If TxtObser1.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser1.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If


                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRolI1.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso1.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll1()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If
                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho2.Text = "" And TxtCalibre2.Text = "" And TxtPeso2.Text = "" And TxtNumRollo2.Text = "" And TxtNRoll2.Text = "" And TxtObser2.Text = "" Then
                'Nothing
            ElseIf TxtAncho2.Text = "" Or TxtCalibre2.Text = "" Or TxtPeso2.Text = "" Or TxtNRoll2.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 2", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll2.Text
                    If TxtNumRollo2.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo2.Text
                    End If
                    Datos.Calibre_ = TxtCalibre2.Text
                    Datos.Ancho_ = TxtAncho2.Text
                    Datos.Peso_ = TxtPeso2.Text
                    If TxtObser2.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser2.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor2.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll2.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso2.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll2()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho3.Text = "" And TxtCalibre3.Text = "" And TxtPeso3.Text = "" And TxtNumRollo3.Text = "" And TxtNRoll3.Text = "" And TxtObser3.Text = "" Then
                'Nothing
            ElseIf TxtAncho3.Text = "" Or TxtCalibre3.Text = "" Or TxtPeso3.Text = "" Or TxtNRoll3.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 3", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll3.Text
                    If TxtNumRollo3.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo3.Text
                    End If
                    Datos.Calibre_ = TxtCalibre3.Text
                    Datos.Ancho_ = TxtAncho3.Text
                    Datos.Peso_ = TxtPeso3.Text
                    If TxtObser3.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser3.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor3.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll3.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso3.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll3()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho4.Text = "" And TxtCalibre4.Text = "" And TxtPeso4.Text = "" And TxtNumRollo4.Text = "" And TxtNRoll4.Text = "" And TxtObser4.Text = "" Then
                'Nothing
            ElseIf TxtAncho4.Text = "" Or TxtCalibre4.Text = "" Or TxtPeso4.Text = "" Or TxtNRoll4.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 4", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll4.Text
                    If TxtNumRollo4.Text = "" Then
                        TxtNumRollo4.Text = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo4.Text
                    End If
                    Datos.Calibre_ = TxtCalibre4.Text
                    Datos.Ancho_ = TxtAncho4.Text
                    Datos.Peso_ = TxtPeso4.Text
                    If TxtObser4.Text = "" Then
                        Datos.Descripcion_.Text = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser4.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor4.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                    Datos.TC_ = TxtTC.Text
                    End If

            If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll4.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso4.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = " INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll4()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho5.Text = "" And TxtCalibre5.Text = "" And TxtPeso5.Text = "" And TxtNumRollo5.Text = "" And TxtNRoll5.Text = "" And TxtObser5.Text = "" Then
                'Nothing
            ElseIf TxtAncho5.Text = "" Or TxtCalibre5.Text = "" Or TxtPeso5.Text = "" Or TxtNRoll5.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 5", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll5.Text
                    If TxtNumRollo5.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo5.Text
                    End If
                    Datos.Calibre_ = TxtCalibre5.Text
                    Datos.Ancho_ = TxtAncho5.Text
                    Datos.Peso_ = TxtPeso5.Text
                    If TxtObser5.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser5.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor5.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll5.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso5.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll5()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho6.Text = "" And TxtCalibre6.Text = "" And TxtPeso6.Text = "" And TxtNumRollo6.Text = "" And TxtNRoll6.Text = "" And TxtObser6.Text = "" Then
                'Nothing
            ElseIf TxtAncho6.Text = "" Or TxtCalibre6.Text = "" Or TxtPeso6.Text = "" Or TxtNRoll6.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 6", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll6.Text
                    If TxtNumRollo6.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo6.Text
                    End If
                    Datos.Calibre_ = TxtCalibre6.Text
                    Datos.Ancho_ = TxtAncho6.Text
                    Datos.Peso_ = TxtPeso6.Text
                    If TxtObser6.Text = "" Then
                        TxtObser6.Text = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser6.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor6.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                    Datos.TC_ = TxtTC.Text
                    End If

            If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll6.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso6.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll6()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho7.Text = "" And TxtCalibre7.Text = "" And TxtPeso7.Text = "" And TxtNumRollo7.Text = "" And TxtNRoll7.Text = "" And TxtObser7.Text = "" Then
                'Nothing
            ElseIf TxtAncho7.Text = "" Or TxtCalibre7.Text = "" Or TxtPeso7.Text = "" Or TxtNRoll7.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 7", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll7.Text
                    If TxtNumRollo7.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo7.Text
                    End If
                    Datos.Calibre_ = TxtCalibre7.Text
                    Datos.Ancho_ = TxtAncho7.Text
                    Datos.Peso_ = TxtPeso7.Text
                    If TxtObser7.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser7.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor7.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll7.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso7.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll7()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho8.Text = "" And TxtCalibre8.Text = "" And TxtPeso8.Text = "" And TxtNumRollo8.Text = "" And TxtNRoll8.Text = "" And TxtObser8.Text = "" Then
                'Nothing
            ElseIf TxtAncho8.Text = "" Or TxtCalibre8.Text = "" Or TxtPeso8.Text = "" Or TxtNRoll8.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 8", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll8.Text
                    If TxtNumRollo8.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo8.Text
                    End If
                    Datos.Calibre_ = TxtCalibre8.Text
                    Datos.Ancho_ = TxtAncho8.Text
                    Datos.Peso_ = TxtPeso8.Text
                    If TxtObser8.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser8.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor8.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll8.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso8.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll8()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho9.Text = "" And TxtCalibre9.Text = "" And TxtPeso9.Text = "" And TxtNumRollo9.Text = "" And TxtNRoll9.Text = "" And TxtObser9.Text = "" Then
                'Nothing
            ElseIf TxtAncho9.Text = "" Or TxtCalibre9.Text = "" Or TxtPeso9.Text = "" Or TxtNRoll9.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 9", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll9.Text
                    If TxtNumRollo9.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo9.Text
                    End If
                    Datos.Calibre_ = TxtCalibre9.Text
                    Datos.Ancho_ = TxtAncho9.Text
                    Datos.Peso_ = TxtPeso9.Text
                    If TxtObser9.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser9.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor9.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                    Datos.TC_ = TxtTC.Text
                    End If

            If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll9.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso9.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll9()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho10.Text = "" And TxtCalibre10.Text = "" And TxtPeso10.Text = "" And TxtNumRollo10.Text = "" And TxtNRoll10.Text = "" And TxtObser10.Text = "" Then
                'Nothing
            ElseIf TxtAncho10.Text = "" Or TxtCalibre10.Text = "" Or TxtPeso10.Text = "" Or TxtNRoll10.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 10", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll10.Text
                    If TxtNumRollo10.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo10.Text
                    End If
                    Datos.Calibre_ = TxtCalibre10.Text
                    Datos.Ancho_ = TxtAncho10.Text
                    Datos.Peso_ = TxtPeso10.Text
                    If TxtObser10.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser10.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor10.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                    Datos.TC_ = TxtTC.Text
                    End If

            If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll10.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso10.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll10()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho11.Text = "" And TxtCalibre11.Text = "" And TxtPeso11.Text = "" And TxtNumRollo11.Text = "" And TxtNRoll11.Text = "" And TxtObser11.Text = "" Then
                'Nothing
            ElseIf TxtAncho11.Text = "" Or TxtCalibre11.Text = "" Or TxtPeso11.Text = "" Or TxtNRoll11.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 11", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll11.Text
                    If TxtNumRollo11.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo11.Text
                    End If
                    Datos.Calibre_ = TxtCalibre11.Text
                    Datos.Ancho_ = TxtAncho11.Text
                    Datos.Peso_ = TxtPeso11.Text
                    If TxtObser11.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser11.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor11.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll11.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso11.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll11()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho12.Text = "" And TxtCalibre12.Text = "" And TxtPeso12.Text = "" And TxtNumRollo12.Text = "" And TxtNRoll12.Text = "" And TxtObser12.Text = "" Then
                'Nothing
            ElseIf TxtAncho12.Text = "" Or TxtCalibre12.Text = "" Or TxtPeso12.Text = "" Or TxtNRoll12.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 12", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll12.Text
                    If TxtNumRollo12.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo12.Text
                    End If
                    Datos.Calibre_ = TxtCalibre12.Text
                    Datos.Ancho_ = TxtAncho12.Text
                    Datos.Peso_ = TxtPeso12.Text
                    If TxtObser12.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser12.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor12.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll12.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso12.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll12()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho13.Text = "" And TxtCalibre13.Text = "" And TxtPeso13.Text = "" And TxtNumRollo13.Text = "" And TxtNRoll13.Text = "" And TxtObser13.Text = "" Then
                'Nothing
            ElseIf TxtAncho13.Text = "" Or TxtCalibre13.Text = "" Or TxtPeso13.Text = "" Or TxtNRoll13.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 13", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll13.Text
                    If TxtNumRollo13.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo13.Text
                    End If
                    Datos.Calibre_ = TxtCalibre13.Text
                    Datos.Ancho_ = TxtAncho13.Text
                    Datos.Peso_ = TxtPeso13.Text
                    If TxtObser13.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser13.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor13.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll13.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso13.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll13()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho14.Text = "" And TxtCalibre14.Text = "" And TxtPeso14.Text = "" And TxtNumRollo14.Text = "" And TxtNRoll14.Text = "" And TxtObser14.Text = "" Then
                'Nothing
            ElseIf TxtAncho14.Text = "" Or TxtCalibre14.Text = "" Or TxtPeso14.Text = "" Or TxtNRoll14.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 14", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll14.Text
                    If TxtNumRollo14.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo14.Text
                    End If
                    Datos.Calibre_ = TxtCalibre14.Text
                    Datos.Ancho_ = TxtAncho14.Text
                    Datos.Peso_ = TxtPeso14.Text
                    If TxtObser14.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser14.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor14.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll14.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso14.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll14()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho15.Text = "" And TxtCalibre15.Text = "" And TxtPeso15.Text = "" And TxtNumRollo15.Text = "" And TxtNRoll15.Text = "" And TxtObser15.Text = "" Then
                'Nothing
            ElseIf TxtAncho15.Text = "" Or TxtCalibre15.Text = "" Or TxtPeso15.Text = "" Or TxtNRoll15.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 15", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll15.Text
                    If TxtNumRollo15.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo15.Text
                    End If
                    Datos.Calibre_ = TxtCalibre15.Text
                    Datos.Ancho_ = TxtAncho15.Text
                    Datos.Peso_ = TxtPeso15.Text
                    If TxtObser15.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser15.Text
                        Datos.FechaLlegada = DTFechaLl.Value
                    End If
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor15.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                    Datos.TC_ = TxtTC.Text
                    End If

            If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll15.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso15.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll15()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho16.Text = "" And TxtCalibre16.Text = "" And TxtPeso16.Text = "" And TxtNumRollo16.Text = "" And TxtNRoll16.Text = "" And TxtObser16.Text = "" Then
                'Nothing
            ElseIf TxtAncho16.Text = "" Or TxtCalibre16.Text = "" Or TxtPeso16.Text = "" Or TxtNRoll16.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 16", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll16.Text
                    If TxtNumRollo16.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo16.Text
                    End If
                    Datos.Calibre_ = TxtCalibre16.Text
                    Datos.Ancho_ = TxtAncho16.Text
                    Datos.Peso_ = TxtPeso16.Text
                    If TxtObser16.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser16.Text
                        Datos.FechaLlegada = DTFechaLl.Value
                    End If
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor16.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                    Datos.TC_ = TxtTC.Text
                    End If

            If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll16.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso16.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll16()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho17.Text = "" And TxtCalibre17.Text = "" And TxtPeso17.Text = "" And TxtNumRollo17.Text = "" And TxtNRoll17.Text = "" And TxtObser17.Text = "" Then
                'Nothing
            ElseIf TxtAncho17.Text = "" Or TxtCalibre17.Text = "" Or TxtPeso17.Text = "" Or TxtNRoll17.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 17", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll17.Text
                    If TxtNumRollo17.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo17.Text
                    End If
                    Datos.Calibre_ = TxtCalibre17.Text
                    Datos.Ancho_ = TxtAncho17.Text
                    Datos.Peso_ = TxtPeso17.Text
                    If TxtObser17.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser17.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor17.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll17.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso17.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll17()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho18.Text = "" And TxtCalibre18.Text = "" And TxtPeso18.Text = "" And TxtNumRollo18.Text = "" And TxtNRoll18.Text = "" And TxtObser18.Text = "" Then
                'Nothing
            ElseIf TxtAncho18.Text = "" Or TxtCalibre18.Text = "" Or TxtPeso18.Text = "" Or TxtNRoll18.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 18", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll18.Text
                    If TxtNumRollo18.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo18.Text
                    End If
                    Datos.Calibre_ = TxtCalibre18.Text
                    Datos.Ancho_ = TxtAncho18.Text
                    Datos.Peso_ = TxtPeso18.Text
                    If TxtObser18.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser18.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor18.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll18.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso18.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll18()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho19.Text = "" And TxtCalibre19.Text = "" And TxtPeso19.Text = "" And TxtNumRollo19.Text = "" And TxtNRoll19.Text = "" And TxtObser19.Text = "" Then
                'Nothing
            ElseIf TxtAncho19.Text = "" Or TxtCalibre19.Text = "" Or TxtPeso19.Text = "" Or TxtNRoll19.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 19", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll19.Text
                    If TxtNumRollo19.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo19.Text
                    End If
                    Datos.Calibre_ = TxtCalibre19.Text
                    Datos.Ancho_ = TxtAncho19.Text
                    Datos.Peso_ = TxtPeso19.Text
                    If TxtObser19.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser19.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor19.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll19.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso19.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll19()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If

            If TxtAncho20.Text = "" And TxtCalibre20.Text = "" And TxtPeso20.Text = "" And TxtNumRollo20.Text = "" And TxtNRoll20.Text = "" And TxtObser20.Text = "" Then
                'Nothing
            ElseIf TxtAncho20.Text = "" Or TxtCalibre20.Text = "" Or TxtPeso20.Text = "" Or TxtNRoll20.Text = "" Then
                MessageBox.Show("Ingresar todos los datos en Rollo 20", "Advertencia", MessageBoxButtons.OK)
            Else
                Try
                    Dim Funcion As New RegistroMP
                    Dim Datos As New CRegistroMP

                    Datos.Proveedor_ = TxtProveedor.Text
                    Datos.Num_RIn = TxtNRoll20.Text
                    If TxtNumRollo20.Text = "" Then
                        Datos.Num_REx = "N/A"
                    Else
                        Datos.Num_REx = TxtNumRollo20.Text
                    End If
                    Datos.Calibre_ = TxtCalibre20.Text
                    Datos.Ancho_ = TxtAncho20.Text
                    Datos.Peso_ = TxtPeso20.Text
                    If TxtObser20.Text = "" Then
                        Datos.Descripcion_ = "N/A"
                    Else
                        Datos.Descripcion_ = TxtObser20.Text
                    End If
                    Datos.FechaLlegada = DTFechaLl.Value
                    Datos.FechaRegistro = DTFechaR.Value
                    Datos.OCompra_ = TxtOC.Text
                    Datos.LCS_ = LCS.Text
                    Datos.Trabaj = TxtResponsable.Text
                    Datos.CE_ = TxtCE.Text
                    Datos.IDDO_ = ip_pro.Text
                    Datos.Espesor_ = TxtEspesor20.Text
                    If TxtPedimento.Text = "" Then
                        Datos.Pedimento_ = "N/A"
                        Datos.TC_ = 0.0
                    Else
                        Datos.Pedimento_ = TxtPedimento.Text
                        Datos.TC_ = TxtTC.Text
                    End If

                    If Funcion.R(Datos) Then
                        Dim Prod As String = TxtNRoll20.Text
                        Dim CodSs As String = LCS.Text
                        Dim Can As String = TxtPeso20.Text
                        Dim CanS As String() = Can.Split(" ")

                        Conex.Open()
                        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanS, CanE)
                                                                           VALUES ('" & CodSs & "', '" & Prod & "', '" & CanS(0) & "', 0)"

                        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                        COMANDO.ExecuteNonQuery()

                        Conex.Close()

                        Roll20()

                        Dim ID As Integer = ip_pro.Text
                        Dim cmd As New SqlCommand("SELECT estatus
                                                        FROM TB_Ordenes_Detalle
                                                        WHERE id_pro = '" & ID & "'", Conex)
                        Dim Res As String

                        Conex.Open()
                        Res = cmd.ExecuteScalar
                        Conex.Close()

                        Dim R As Integer = CType(Res.Substring(0), Integer)

                        If LKGS.Text = "TON" Or LKGS.Text = "MT" Then
                            TxtCR.Text = CDec(TxtCS.Text * 1000) - R
                        Else
                            TxtCR.Text = CDec(TxtCS.Text) - R
                        End If

                    End If

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub


    Private Sub BTerminar_Click(sender As Object, e As EventArgs) Handles BTerminar.Click
        If (TxtAncho1.Text = "" And TxtCalibre1.Text = "" And TxtPeso1.Text = "" And TxtNumRollo1.Text = "" And TxtNRolI1.Text = "" And TxtObser1.Text = "") Or
           (TxtAncho2.Text = "" And TxtCalibre2.Text = "" And TxtPeso2.Text = "" And TxtNumRollo2.Text = "" And TxtNRoll2.Text = "" And TxtObser2.Text = "") Or
           (TxtAncho3.Text = "" And TxtCalibre3.Text = "" And TxtPeso3.Text = "" And TxtNumRollo3.Text = "" And TxtNRoll3.Text = "" And TxtObser3.Text = "") Or
           (TxtAncho4.Text = "" And TxtCalibre4.Text = "" And TxtPeso4.Text = "" And TxtNumRollo4.Text = "" And TxtNRoll4.Text = "" And TxtObser4.Text = "") Or
           (TxtAncho5.Text = "" And TxtCalibre5.Text = "" And TxtPeso5.Text = "" And TxtNumRollo5.Text = "" And TxtNRoll5.Text = "" And TxtObser5.Text = "") Or
           (TxtAncho6.Text = "" And TxtCalibre6.Text = "" And TxtPeso6.Text = "" And TxtNumRollo6.Text = "" And TxtNRoll6.Text = "" And TxtObser6.Text = "") Or
           (TxtAncho7.Text = "" And TxtCalibre7.Text = "" And TxtPeso7.Text = "" And TxtNumRollo7.Text = "" And TxtNRoll7.Text = "" And TxtObser7.Text = "") Or
           (TxtAncho8.Text = "" And TxtCalibre8.Text = "" And TxtPeso8.Text = "" And TxtNumRollo8.Text = "" And TxtNRoll8.Text = "" And TxtObser8.Text = "") Or
           (TxtAncho9.Text = "" And TxtCalibre9.Text = "" And TxtPeso9.Text = "" And TxtNumRollo9.Text = "" And TxtNRoll9.Text = "" And TxtObser9.Text = "") Or
           (TxtAncho10.Text = "" And TxtCalibre10.Text = "" And TxtPeso10.Text = "" And TxtNumRollo10.Text = "" And TxtNRoll10.Text = "" And TxtObser10.Text = "") Or
           (TxtAncho11.Text = "" And TxtCalibre11.Text = "" And TxtPeso11.Text = "" And TxtNumRollo11.Text = "" And TxtNRoll11.Text = "" And TxtObser11.Text = "") Or
           (TxtAncho12.Text = "" And TxtCalibre12.Text = "" And TxtPeso12.Text = "" And TxtNumRollo12.Text = "" And TxtNRoll12.Text = "" And TxtObser12.Text = "") Or
           (TxtAncho13.Text = "" And TxtCalibre13.Text = "" And TxtPeso13.Text = "" And TxtNumRollo13.Text = "" And TxtNRoll13.Text = "" And TxtObser13.Text = "") Or
           (TxtAncho14.Text = "" And TxtCalibre14.Text = "" And TxtPeso14.Text = "" And TxtNumRollo14.Text = "" And TxtNRoll14.Text = "" And TxtObser14.Text = "") Or
           (TxtAncho15.Text = "" And TxtCalibre15.Text = "" And TxtPeso15.Text = "" And TxtNumRollo15.Text = "" And TxtNRoll15.Text = "" And TxtObser15.Text = "") Or
           (TxtAncho16.Text = "" And TxtCalibre16.Text = "" And TxtPeso16.Text = "" And TxtNumRollo16.Text = "" And TxtNRoll16.Text = "" And TxtObser16.Text = "") Or
           (TxtAncho17.Text = "" And TxtCalibre17.Text = "" And TxtPeso17.Text = "" And TxtNumRollo17.Text = "" And TxtNRoll17.Text = "" And TxtObser17.Text = "") Or
           (TxtAncho18.Text = "" And TxtCalibre18.Text = "" And TxtPeso18.Text = "" And TxtNumRollo18.Text = "" And TxtNRoll18.Text = "" And TxtObser18.Text = "") Or
           (TxtAncho19.Text = "" And TxtCalibre19.Text = "" And TxtPeso19.Text = "" And TxtNumRollo19.Text = "" And TxtNRoll19.Text = "" And TxtObser19.Text = "") Or
           (TxtAncho20.Text = "" And TxtCalibre20.Text = "" And TxtPeso20.Text = "" And TxtNumRollo20.Text = "" And TxtNRoll20.Text = "" And TxtObser20.Text = "") Then

            If MsgBox("Desea Finalizar la Entrega de Materia Prima", vbYesNo) = vbYes Then

                Dim CodS As String = LIDO.Text

                Conex.Open()
                Dim CONSULTA As String = "UPDATE TB_Ordenes_Compra 
                                        SET estado = 'Finalizado'
                                        WHERE id_orden = '" & CodS & "'"

                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()

                Conex.Close()

                BGMP.Enabled = False
            End If

        Else
            MessageBox.Show("Guardar datos para poder finalizar la orden de compra", "Advertencia", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub BC1_Click(sender As Object, e As EventArgs) Handles BC1.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "1"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "1"
        End If
    End Sub

    Private Sub BC2_Click(sender As Object, e As EventArgs) Handles BC2.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "2"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "2"
        End If
    End Sub

    Private Sub BC3_Click(sender As Object, e As EventArgs) Handles BC3.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "3"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "3"
        End If
    End Sub

    Private Sub BC4_Click(sender As Object, e As EventArgs) Handles BC4.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "4"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "4"
        End If
    End Sub

    Private Sub BC5_Click(sender As Object, e As EventArgs) Handles BC5.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "5"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "5"
        End If
    End Sub

    Private Sub BC6_Click(sender As Object, e As EventArgs) Handles BC6.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "6"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "6"
        End If
    End Sub

    Private Sub BC7_Click(sender As Object, e As EventArgs) Handles BC7.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "7"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "7"
        End If
    End Sub

    Private Sub BC8_Click(sender As Object, e As EventArgs) Handles BC8.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "8"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "8"
        End If
    End Sub

    Private Sub BC9_Click(sender As Object, e As EventArgs) Handles BC9.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "9"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "9"
        End If
    End Sub

    Private Sub BC10_Click(sender As Object, e As EventArgs) Handles BC10.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "10"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "10"
        End If
    End Sub

    Private Sub BC11_Click(sender As Object, e As EventArgs) Handles BC11.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "11"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "11"
        End If
    End Sub

    Private Sub BC12_Click(sender As Object, e As EventArgs) Handles BC12.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "12"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "12"
        End If
    End Sub

    Private Sub BC13_Click(sender As Object, e As EventArgs) Handles BC13.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "13"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "13"
        End If
    End Sub

    Private Sub BC14_Click(sender As Object, e As EventArgs) Handles BC14.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "14"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "14"
        End If
    End Sub

    Private Sub BC15_Click(sender As Object, e As EventArgs) Handles BC15.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "15"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "15"
        End If
    End Sub

    Private Sub BC16_Click(sender As Object, e As EventArgs) Handles BC16.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "16"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "16"
        End If
    End Sub

    Private Sub BC17_Click(sender As Object, e As EventArgs) Handles BC17.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "17"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
        LC.Text = "17"
        End If
    End Sub

    Private Sub BC18_Click(sender As Object, e As EventArgs) Handles BC18.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "18"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "18"
        End If
    End Sub

    Private Sub BC19_Click(sender As Object, e As EventArgs) Handles BC19.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "19"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "19"
        End If
    End Sub

    Private Sub BC20_Click(sender As Object, e As EventArgs) Handles BC20.Click
        If PCalibres.Visible = True And LC.Text <> "" Then
            LC.Text = "20"

        ElseIf PCalibres.Visible = True Then
            PCalibres.Visible = False
            LC.Text = ""
        ElseIf PCalibres.Visible = False Then
            PCalibres.Visible = True
            LC.Text = "20"
        End If
    End Sub

    Private Sub Rollo1_DoubleClick(sender As Object, e As EventArgs) Handles TRollos.Click
        PCalibres.Visible = False
    End Sub


    'Text
    Private Sub TxtBOC_TextChanged(sender As Object, e As EventArgs) Handles TxtBOC.TextChanged
        If TxtBOC.Text = "" Then
        Else
            Dim Consulta As String = "SELECT OC.id_orden, OC.purchase_order, OC.codigo, P.nombre, OD.cantidad, OD.Um,OC.CodiS, OD.descripcion, 
                                             OD.detalles, OD.id_pro, case OD.Um 
		                                                                    When 'MT'
		                                                                        THEN OD.cantidad * 1000 - IsNull(Od.estatus, 0)
		                                                                    When 'TON'
		                                                                        THEN OD.cantidad * 1000 - IsNull(Od.estatus, 0)
		                                                                    WHEN 'KG'
		                                                                        THEN OD.cantidad - IsNull(Od.estatus, 0)
		                                                                    END AS 'Faltante'
                                      FROM TB_Ordenes_Compra as OC
                                          INNER JOIN Tb_Proveedores AS P ON P.id_p = OC.id_pro
                                          INNER JOIN TB_Ordenes_Detalle AS OD ON OD.codigo = OC.codigo
                                          INNER JOIN TB_Productos AS PR ON OD.descripcion = PR.Nombre_Producto
                                      WHERE OC.estado = 'Activo' AND 
                                            PR.Estado = 'MPActivo' AND 
                                            OC.purchase_order LIKE '%'+@Busqueda+'%'
                                      GROUP BY OC.id_orden, OC.purchase_order, OC.codigo, P.nombre, OD.cantidad, OD.Um, OC.CodiS, OD.descripcion, 
                                            od.detalles, OD.id_pro, case OD.Um 
		                                                                When 'MT'
		                                                                    THEN OD.cantidad * 1000 - IsNull(Od.estatus, 0)
		                                                                When 'TON'
		                                                                    THEN OD.cantidad * 1000 - IsNull(Od.estatus, 0)
		                                                                WHEN 'KG'
		                                                                    THEN OD.cantidad - IsNull(Od.estatus, 0)
		                                                                END "

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBOC.Text))

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
        End If
    End Sub


    'Procedimientos
    Private Sub BuscarOC()
        Dim Consulta As New SqlCommand("SP_BOCMPrima", Conex)

        Consulta.Parameters.AddWithValue("Fech1", DTF1.Value)
        Consulta.Parameters.AddWithValue("Fech2", DTF2.Value)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet


        Try
            Conex.Open()
            Da.Fill(Ds)

            DVOC.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub


    'Consultas
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
            TxtResponsable.Text = Da.Item("Nombre").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub Calibre()
        Dim Consulta As String = "SELECT Codigo, Calibre
                                        FROM TB_Calibres"

        Dim cmd As New SqlCommand(Consulta, Conex)

        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DGVCA.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub


    'Validaciones
    Private Sub RInterno(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNRolI1.KeyPress, TxtNRoll2.KeyPress, TxtNRoll3.KeyPress, TxtNRoll4.KeyPress, TxtNRoll5.KeyPress,
                                                                                                            TxtNRoll6.KeyPress, TxtNRoll7.KeyPress, TxtNRoll8.KeyPress, TxtNRoll9.KeyPress, TxtNRoll10.KeyPress,
                                                                                                            TxtNRoll11.KeyPress, TxtNRoll12.KeyPress, TxtNRoll13.KeyPress, TxtNRoll14.KeyPress, TxtNRoll15.KeyPress,
                                                                                                            TxtNRoll16.KeyPress, TxtNRoll17.KeyPress, TxtNRoll18.KeyPress, TxtNRoll19.KeyPress, TxtNRoll20.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub RExterno(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumRollo1.KeyPress, TxtNumRollo2.KeyPress, TxtNumRollo3.KeyPress, TxtNumRollo4.KeyPress, TxtNumRollo5.KeyPress,
                                                                                                            TxtNumRollo6.KeyPress, TxtNumRollo7.KeyPress, TxtNumRollo8.KeyPress, TxtNumRollo9.KeyPress, TxtNumRollo10.KeyPress,
                                                                                                            TxtNumRollo11.KeyPress, TxtNumRollo12.KeyPress, TxtNumRollo13.KeyPress, TxtNumRollo14.KeyPress, TxtNumRollo15.KeyPress,
                                                                                                            TxtNumRollo16.KeyPress, TxtNumRollo17.KeyPress, TxtNumRollo18.KeyPress, TxtNumRollo19.KeyPress, TxtNumRollo20.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Ancho(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAncho1.KeyPress, TxtAncho2.KeyPress, TxtAncho3.KeyPress, TxtAncho4.KeyPress, TxtAncho5.KeyPress,
                                                                                                         TxtAncho6.KeyPress, TxtAncho7.KeyPress, TxtAncho8.KeyPress, TxtAncho9.KeyPress, TxtAncho10.KeyPress,
                                                                                                         TxtAncho11.KeyPress, TxtAncho12.KeyPress, TxtAncho13.KeyPress, TxtAncho14.KeyPress, TxtAncho15.KeyPress,
                                                                                                         TxtAncho16.KeyPress, TxtAncho17.KeyPress, TxtAncho18.KeyPress, TxtAncho19.KeyPress, TxtAncho20.KeyPress
        NumerosyDecimal(TxtAncho1, e)
        NumerosyDecimal(TxtAncho2, e)
        NumerosyDecimal(TxtAncho3, e)
        NumerosyDecimal(TxtAncho4, e)
        NumerosyDecimal(TxtAncho5, e)
        NumerosyDecimal(TxtAncho6, e)
        NumerosyDecimal(TxtAncho7, e)
        NumerosyDecimal(TxtAncho8, e)
        NumerosyDecimal(TxtAncho9, e)
        NumerosyDecimal(TxtAncho10, e)
        NumerosyDecimal(TxtAncho11, e)
        NumerosyDecimal(TxtAncho12, e)
        NumerosyDecimal(TxtAncho13, e)
        NumerosyDecimal(TxtAncho14, e)
        NumerosyDecimal(TxtAncho15, e)
        NumerosyDecimal(TxtAncho16, e)
        NumerosyDecimal(TxtAncho17, e)
        NumerosyDecimal(TxtAncho18, e)
        NumerosyDecimal(TxtAncho19, e)
        NumerosyDecimal(TxtAncho20, e)

    End Sub

    Private Sub Peso(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPeso1.KeyPress, TxtPeso2.KeyPress, TxtPeso3.KeyPress, TxtPeso4.KeyPress, TxtPeso5.KeyPress,
                                                                                                        TxtPeso6.KeyPress, TxtPeso7.KeyPress, TxtPeso8.KeyPress, TxtPeso9.KeyPress, TxtPeso10.KeyPress,
                                                                                                        TxtPeso11.KeyPress, TxtPeso12.KeyPress, TxtPeso13.KeyPress, TxtPeso14.KeyPress, TxtPeso15.KeyPress,
                                                                                                        TxtPeso16.KeyPress, TxtPeso17.KeyPress, TxtPeso18.KeyPress, TxtPeso19.KeyPress, TxtPeso20.KeyPress

        NumerosyDecimal(TxtPeso1, e)
        NumerosyDecimal(TxtPeso2, e)
        NumerosyDecimal(TxtPeso3, e)
        NumerosyDecimal(TxtPeso4, e)
        NumerosyDecimal(TxtPeso5, e)
        NumerosyDecimal(TxtPeso6, e)
        NumerosyDecimal(TxtPeso7, e)
        NumerosyDecimal(TxtPeso8, e)
        NumerosyDecimal(TxtPeso9, e)
        NumerosyDecimal(TxtPeso10, e)
        NumerosyDecimal(TxtPeso11, e)
        NumerosyDecimal(TxtPeso12, e)
        NumerosyDecimal(TxtPeso13, e)
        NumerosyDecimal(TxtPeso14, e)
        NumerosyDecimal(TxtPeso15, e)
        NumerosyDecimal(TxtPeso16, e)
        NumerosyDecimal(TxtPeso17, e)
        NumerosyDecimal(TxtPeso18, e)
        NumerosyDecimal(TxtPeso19, e)
        NumerosyDecimal(TxtPeso20, e)
    End Sub

    Private Sub Espesor(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEspesor1.KeyPress, TxtEspesor2.KeyPress, TxtEspesor3.KeyPress, TxtEspesor4.KeyPress, TxtEspesor5.KeyPress,
                                                                                                        TxtEspesor6.KeyPress, TxtEspesor7.KeyPress, TxtEspesor8.KeyPress, TxtEspesor9.KeyPress, TxtEspesor10.KeyPress,
                                                                                                        TxtEspesor11.KeyPress, TxtEspesor12.KeyPress, TxtEspesor13.KeyPress, TxtEspesor14.KeyPress, TxtEspesor15.KeyPress,
                                                                                                        TxtEspesor16.KeyPress, TxtEspesor17.KeyPress, TxtEspesor18.KeyPress, TxtEspesor19.KeyPress, TxtEspesor20.KeyPress

        NumerosyDecimal(TxtEspesor1, e)
        NumerosyDecimal(TxtEspesor2, e)
        NumerosyDecimal(TxtEspesor3, e)
        NumerosyDecimal(TxtEspesor4, e)
        NumerosyDecimal(TxtEspesor5, e)
        NumerosyDecimal(TxtEspesor6, e)
        NumerosyDecimal(TxtEspesor7, e)
        NumerosyDecimal(TxtEspesor8, e)
        NumerosyDecimal(TxtEspesor9, e)
        NumerosyDecimal(TxtEspesor10, e)
        NumerosyDecimal(TxtEspesor11, e)
        NumerosyDecimal(TxtEspesor12, e)
        NumerosyDecimal(TxtEspesor13, e)
        NumerosyDecimal(TxtEspesor14, e)
        NumerosyDecimal(TxtEspesor15, e)
        NumerosyDecimal(TxtEspesor16, e)
        NumerosyDecimal(TxtEspesor17, e)
        NumerosyDecimal(TxtEspesor18, e)
        NumerosyDecimal(TxtEspesor19, e)
        NumerosyDecimal(TxtEspesor20, e)
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


    'Operaciones
    Private Sub Total(sender As Object, e As EventArgs) Handles TxtPeso1.TextChanged, TxtPeso2.TextChanged, TxtPeso3.TextChanged, TxtPeso4.TextChanged,
                                                                TxtPeso5.TextChanged, TxtPeso6.TextChanged, TxtPeso7.TextChanged, TxtPeso8.TextChanged,
                                                                TxtPeso9.TextChanged, TxtPeso10.TextChanged, TxtPeso11.TextChanged, TxtPeso12.TextChanged,
                                                                TxtPeso13.TextChanged, TxtPeso14.TextChanged, TxtPeso15.TextChanged, TxtPeso16.TextChanged,
                                                                TxtPeso17.TextChanged, TxtPeso18.TextChanged, TxtPeso19.TextChanged, TxtPeso20.TextChanged

        Dim P1 As Decimal = 0
        Dim P2 As Decimal = 0
        Dim P3 As Decimal = 0
        Dim P4 As Decimal = 0
        Dim P5 As Decimal = 0
        Dim P6 As Decimal = 0
        Dim P7 As Decimal = 0
        Dim P8 As Decimal = 0
        Dim P9 As Decimal = 0
        Dim P10 As Decimal = 0
        Dim P11 As Decimal = 0
        Dim P12 As Decimal = 0
        Dim P13 As Decimal = 0
        Dim P14 As Decimal = 0
        Dim P15 As Decimal = 0
        Dim P16 As Decimal = 0
        Dim P17 As Decimal = 0
        Dim P18 As Decimal = 0
        Dim P19 As Decimal = 0
        Dim P20 As Decimal = 0

        If TxtPeso1.Text <> Nothing Then
            P1 = CDec(TxtPeso1.Text)
        End If

        If TxtPeso2.Text <> Nothing Then
            P2 = CDec(TxtPeso2.Text)
        End If

        If TxtPeso3.Text <> Nothing Then
            P3 = CDec(TxtPeso3.Text)
        End If

        If TxtPeso4.Text <> Nothing Then
            P4 = CDec(TxtPeso4.Text)
        End If

        If TxtPeso5.Text <> Nothing Then
            P5 = CDec(TxtPeso5.Text)
        End If

        If TxtPeso6.Text <> Nothing Then
            P6 = CDec(TxtPeso6.Text)
        End If

        If TxtPeso7.Text <> Nothing Then
            P7 = CDec(TxtPeso7.Text)
        End If

        If TxtPeso8.Text <> Nothing Then
            P8 = CDec(TxtPeso8.Text)
        End If

        If TxtPeso9.Text <> Nothing Then
            P9 = CDec(TxtPeso9.Text)
        End If

        If TxtPeso10.Text <> Nothing Then
            P10 = CDec(TxtPeso10.Text)
        End If

        If TxtPeso11.Text <> Nothing Then
            P11 = CDec(TxtPeso11.Text)
        End If

        If TxtPeso12.Text <> Nothing Then
            P12 = CDec(TxtPeso12.Text)
        End If

        If TxtPeso13.Text <> Nothing Then
            P13 = CDec(TxtPeso13.Text)
        End If

        If TxtPeso14.Text <> Nothing Then
            P14 = CDec(TxtPeso14.Text)
        End If

        If TxtPeso15.Text <> Nothing Then
            P15 = CDec(TxtPeso15.Text)
        End If

        If TxtPeso16.Text <> Nothing Then
            P16 = CDec(TxtPeso16.Text)
        End If

        If TxtPeso17.Text <> Nothing Then
            P17 = CDec(TxtPeso17.Text)
        End If

        If TxtPeso18.Text <> Nothing Then
            P18 = CDec(TxtPeso18.Text)
        End If

        If TxtPeso19.Text <> Nothing Then
            P19 = CDec(TxtPeso19.Text)
        End If

        If TxtPeso20.Text <> Nothing Then
            P20 = CDec(TxtPeso20.Text)
        End If

        TxtCE.Text = CDec(P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10 + P11 + P12 + P13 + P14 + P15 + P16 + P17 + P18 + P19 + P20).ToString
    End Sub


    'TXT BLANCO Y WRITE
    Public Sub Rol1()
        TxtAncho1.Text = ""
        TxtAncho1.ReadOnly = False
        TxtCalibre1.Text = ""
        TxtCalibre1.ReadOnly = False
        TxtPeso1.Text = ""
        TxtPeso1.ReadOnly = False
        TxtNumRollo1.Text = ""
        TxtNumRollo1.ReadOnly = False
        TxtNRolI1.Text = ""
        TxtNRolI1.ReadOnly = False
        TxtObser1.Text = ""
        TxtObser1.ReadOnly = False
        TxtEspesor1.Text = ""
        TxtEspesor1.ReadOnly = False
    End Sub

    Public Sub Rol2()
        TxtAncho2.Text = ""
        TxtAncho2.ReadOnly = False
        TxtCalibre2.Text = ""
        TxtCalibre2.ReadOnly = False
        TxtPeso2.Text = ""
        TxtPeso2.ReadOnly = False
        TxtNumRollo2.Text = ""
        TxtNumRollo2.ReadOnly = False
        TxtNRoll2.Text = ""
        TxtNRoll2.ReadOnly = False
        TxtObser2.Text = ""
        TxtObser2.ReadOnly = False
        TxtEspesor2.Text = ""
        TxtEspesor2.ReadOnly = False
    End Sub

    Public Sub Rol3()
        TxtAncho3.Text = ""
        TxtAncho3.ReadOnly = False
        TxtCalibre3.Text = ""
        TxtCalibre3.ReadOnly = False
        TxtPeso3.Text = ""
        TxtPeso3.ReadOnly = False
        TxtNumRollo3.Text = ""
        TxtNumRollo3.ReadOnly = False
        TxtNRoll3.Text = ""
        TxtNRoll3.ReadOnly = False
        TxtObser3.Text = ""
        TxtObser3.ReadOnly = False
        TxtEspesor3.Text = ""
        TxtEspesor3.ReadOnly = False
    End Sub

    Public Sub Rol4()
        TxtAncho4.Text = ""
        TxtAncho4.ReadOnly = False
        TxtCalibre4.Text = ""
        TxtCalibre4.ReadOnly = False
        TxtPeso4.Text = ""
        TxtPeso4.ReadOnly = False
        TxtNumRollo4.Text = ""
        TxtNumRollo4.ReadOnly = False
        TxtNRoll4.Text = ""
        TxtNRoll4.ReadOnly = False
        TxtObser4.Text = ""
        TxtObser4.ReadOnly = False
        TxtEspesor4.Text = ""
        TxtEspesor4.ReadOnly = False
    End Sub

    Public Sub Rol5()
        TxtAncho5.Text = ""
        TxtAncho5.ReadOnly = False
        TxtCalibre5.Text = ""
        TxtCalibre5.ReadOnly = False
        TxtPeso5.Text = ""
        TxtPeso5.ReadOnly = False
        TxtNumRollo5.Text = ""
        TxtNumRollo5.ReadOnly = False
        TxtNRoll5.Text = ""
        TxtNRoll5.ReadOnly = False
        TxtObser5.Text = ""
        TxtObser5.ReadOnly = False
        TxtEspesor5.Text = ""
        TxtEspesor5.ReadOnly = False
    End Sub

    Public Sub Rol6()
        TxtAncho6.Text = ""
        TxtAncho6.ReadOnly = False
        TxtCalibre6.Text = ""
        TxtCalibre6.ReadOnly = False
        TxtPeso6.Text = ""
        TxtPeso6.ReadOnly = False
        TxtNumRollo6.Text = ""
        TxtNumRollo6.ReadOnly = False
        TxtNRoll6.Text = ""
        TxtNRoll6.ReadOnly = False
        TxtObser6.Text = ""
        TxtObser6.ReadOnly = False
        TxtEspesor6.Text = ""
        TxtEspesor6.ReadOnly = False
    End Sub

    Public Sub Rol7()
        TxtAncho7.Text = ""
        TxtAncho7.ReadOnly = False
        TxtCalibre7.Text = ""
        TxtCalibre7.ReadOnly = False
        TxtPeso7.Text = ""
        TxtPeso7.ReadOnly = False
        TxtNumRollo7.Text = ""
        TxtNumRollo7.ReadOnly = False
        TxtNRoll7.Text = ""
        TxtNRoll7.ReadOnly = False
        TxtObser7.Text = ""
        TxtObser7.ReadOnly = False
        TxtEspesor7.Text = ""
        TxtEspesor7.ReadOnly = False
    End Sub

    Public Sub Rol8()
        TxtAncho8.Text = ""
        TxtAncho8.ReadOnly = False
        TxtCalibre8.Text = ""
        TxtCalibre8.ReadOnly = False
        TxtPeso8.Text = ""
        TxtPeso8.ReadOnly = False
        TxtNumRollo8.Text = ""
        TxtNumRollo8.ReadOnly = False
        TxtNRoll8.Text = ""
        TxtNRoll8.ReadOnly = False
        TxtObser8.Text = ""
        TxtObser8.ReadOnly = False
        TxtEspesor8.Text = ""
        TxtEspesor8.ReadOnly = False
    End Sub

    Public Sub Rol9()
        TxtAncho9.Text = ""
        TxtAncho9.ReadOnly = False
        TxtCalibre9.Text = ""
        TxtCalibre9.ReadOnly = False
        TxtPeso9.Text = ""
        TxtPeso9.ReadOnly = False
        TxtNumRollo9.Text = ""
        TxtNumRollo9.ReadOnly = False
        TxtNRoll9.Text = ""
        TxtNRoll9.ReadOnly = False
        TxtObser9.Text = ""
        TxtObser9.ReadOnly = False
        TxtEspesor9.Text = ""
        TxtEspesor9.ReadOnly = False
    End Sub

    Public Sub Rol10()
        TxtAncho10.Text = ""
        TxtAncho10.ReadOnly = False
        TxtCalibre10.Text = ""
        TxtCalibre10.ReadOnly = False
        TxtPeso10.Text = ""
        TxtPeso10.ReadOnly = False
        TxtNumRollo10.Text = ""
        TxtNumRollo10.ReadOnly = False
        TxtNRoll10.Text = ""
        TxtNRoll10.ReadOnly = False
        TxtObser10.Text = ""
        TxtObser10.ReadOnly = False
        TxtEspesor10.Text = ""
        TxtEspesor10.ReadOnly = False
    End Sub

    Public Sub Rol11()
        TxtAncho11.Text = ""
        TxtAncho11.ReadOnly = False
        TxtCalibre11.Text = ""
        TxtCalibre11.ReadOnly = False
        TxtPeso11.Text = ""
        TxtPeso11.ReadOnly = False
        TxtNumRollo11.Text = ""
        TxtNumRollo11.ReadOnly = False
        TxtNRoll11.Text = ""
        TxtNRoll11.ReadOnly = False
        TxtObser11.Text = ""
        TxtObser11.ReadOnly = False
        TxtEspesor11.Text = ""
        TxtEspesor11.ReadOnly = False
    End Sub

    Public Sub Rol12()
        TxtAncho12.Text = ""
        TxtAncho12.ReadOnly = False
        TxtCalibre12.Text = ""
        TxtCalibre12.ReadOnly = False
        TxtPeso12.Text = ""
        TxtPeso12.ReadOnly = False
        TxtNumRollo12.Text = ""
        TxtNumRollo12.ReadOnly = False
        TxtNRoll12.Text = ""
        TxtNRoll12.ReadOnly = False
        TxtObser12.Text = ""
        TxtObser12.ReadOnly = False
        TxtEspesor12.Text = ""
        TxtEspesor12.ReadOnly = False
    End Sub

    Public Sub Rol13()
        TxtAncho13.Text = ""
        TxtAncho13.ReadOnly = False
        TxtCalibre13.Text = ""
        TxtCalibre13.ReadOnly = False
        TxtPeso13.Text = ""
        TxtPeso13.ReadOnly = False
        TxtNumRollo13.Text = ""
        TxtNumRollo13.ReadOnly = False
        TxtNRoll13.Text = ""
        TxtNRoll13.ReadOnly = False
        TxtObser13.Text = ""
        TxtObser13.ReadOnly = False
        TxtEspesor13.Text = ""
        TxtEspesor13.ReadOnly = False
    End Sub

    Public Sub Rol14()
        TxtAncho14.Text = ""
        TxtAncho14.ReadOnly = False
        TxtCalibre14.Text = ""
        TxtCalibre14.ReadOnly = False
        TxtPeso14.Text = ""
        TxtPeso14.ReadOnly = False
        TxtNumRollo14.Text = ""
        TxtNumRollo14.ReadOnly = False
        TxtNRoll14.Text = ""
        TxtNRoll14.ReadOnly = False
        TxtObser14.Text = ""
        TxtObser14.ReadOnly = False
        TxtEspesor14.Text = ""
        TxtEspesor14.ReadOnly = False
    End Sub

    Public Sub Rol15()
        TxtAncho15.Text = ""
        TxtAncho15.ReadOnly = False
        TxtCalibre15.Text = ""
        TxtCalibre15.ReadOnly = False
        TxtPeso15.Text = ""
        TxtPeso15.ReadOnly = False
        TxtNumRollo15.Text = ""
        TxtNumRollo15.ReadOnly = False
        TxtNRoll15.Text = ""
        TxtNRoll15.ReadOnly = False
        TxtObser15.Text = ""
        TxtObser15.ReadOnly = False
        TxtEspesor15.Text = ""
        TxtEspesor15.ReadOnly = False
    End Sub

    Public Sub Rol16()
        TxtAncho16.Text = ""
        TxtAncho16.ReadOnly = False
        TxtCalibre16.Text = ""
        TxtCalibre16.ReadOnly = False
        TxtPeso16.Text = ""
        TxtPeso16.ReadOnly = False
        TxtNumRollo16.Text = ""
        TxtNumRollo16.ReadOnly = False
        TxtNRoll16.Text = ""
        TxtNRoll16.ReadOnly = False
        TxtObser16.Text = ""
        TxtObser16.ReadOnly = False
        TxtEspesor16.Text = ""
        TxtEspesor16.ReadOnly = False
    End Sub

    Public Sub Rol17()
        TxtAncho17.Text = ""
        TxtAncho17.ReadOnly = False
        TxtCalibre17.Text = ""
        TxtCalibre17.ReadOnly = False
        TxtPeso17.Text = ""
        TxtPeso17.ReadOnly = False
        TxtNumRollo17.Text = ""
        TxtNumRollo17.ReadOnly = False
        TxtNRoll17.Text = ""
        TxtNRoll17.ReadOnly = False
        TxtObser17.Text = ""
        TxtObser17.ReadOnly = False
        TxtEspesor17.Text = ""
        TxtEspesor17.ReadOnly = False
    End Sub

    Public Sub Rol18()
        TxtAncho18.Text = ""
        TxtAncho18.ReadOnly = False
        TxtCalibre18.Text = ""
        TxtCalibre18.ReadOnly = False
        TxtPeso18.Text = ""
        TxtPeso18.ReadOnly = False
        TxtNumRollo18.Text = ""
        TxtNumRollo18.ReadOnly = False
        TxtNRoll18.Text = ""
        TxtNRoll18.ReadOnly = False
        TxtObser18.Text = ""
        TxtObser18.ReadOnly = False
        TxtEspesor18.Text = ""
        TxtEspesor18.ReadOnly = False
    End Sub

    Public Sub Rol19()
        TxtAncho19.Text = ""
        TxtAncho19.ReadOnly = False
        TxtCalibre19.Text = ""
        TxtCalibre19.ReadOnly = False
        TxtPeso19.Text = ""
        TxtPeso19.ReadOnly = False
        TxtNumRollo19.Text = ""
        TxtNumRollo19.ReadOnly = False
        TxtNRoll19.Text = ""
        TxtNRoll19.ReadOnly = False
        TxtObser19.Text = ""
        TxtObser19.ReadOnly = False
        TxtEspesor19.Text = ""
        TxtEspesor19.ReadOnly = False
    End Sub

    Public Sub Rol20()
        TxtAncho20.Text = ""
        TxtAncho20.ReadOnly = False
        TxtCalibre20.Text = ""
        TxtCalibre20.ReadOnly = False
        TxtPeso20.Text = ""
        TxtPeso20.ReadOnly = False
        TxtNumRollo20.Text = ""
        TxtNumRollo20.ReadOnly = False
        TxtNRoll20.Text = ""
        TxtNRoll20.ReadOnly = False
        TxtObser20.Text = ""
        TxtObser20.ReadOnly = False
        TxtEspesor20.Text = ""
        TxtEspesor20.ReadOnly = False
    End Sub


    'TXT BLANCO Y READONLY
    Public Sub Roll1()
        TxtAncho1.Text = ""
        TxtAncho1.ReadOnly = True
        TxtCalibre1.Text = ""
        TxtCalibre1.ReadOnly = True
        TxtPeso1.Text = ""
        TxtPeso1.ReadOnly = True
        TxtNumRollo1.Text = ""
        TxtNumRollo1.ReadOnly = True
        TxtNRolI1.Text = ""
        TxtNRolI1.ReadOnly = True
        TxtObser1.Text = ""
        TxtObser1.ReadOnly = True
        TxtEspesor1.Text = ""
        TxtEspesor1.ReadOnly = True
    End Sub

    Public Sub Roll2()
        TxtAncho2.Text = ""
        TxtAncho2.ReadOnly = True
        TxtCalibre2.Text = ""
        TxtCalibre2.ReadOnly = True
        TxtPeso2.Text = ""
        TxtPeso2.ReadOnly = True
        TxtNumRollo2.Text = ""
        TxtNumRollo2.ReadOnly = True
        TxtNRoll2.Text = ""
        TxtNRoll2.ReadOnly = True
        TxtObser2.Text = ""
        TxtObser2.ReadOnly = True
        TxtEspesor2.Text = ""
        TxtEspesor2.ReadOnly = True
    End Sub

    Public Sub Roll3()
        TxtAncho3.Text = ""
        TxtAncho3.ReadOnly = True
        TxtCalibre3.Text = ""
        TxtCalibre3.ReadOnly = True
        TxtPeso3.Text = ""
        TxtPeso3.ReadOnly = True
        TxtNumRollo3.Text = ""
        TxtNumRollo3.ReadOnly = True
        TxtNRoll3.Text = ""
        TxtNRoll3.ReadOnly = True
        TxtObser3.Text = ""
        TxtObser3.ReadOnly = True
        TxtEspesor3.Text = ""
        TxtEspesor3.ReadOnly = True
    End Sub

    Public Sub Roll4()
        TxtAncho4.Text = ""
        TxtAncho4.ReadOnly = True
        TxtCalibre4.Text = ""
        TxtCalibre4.ReadOnly = True
        TxtPeso4.Text = ""
        TxtPeso4.ReadOnly = True
        TxtNumRollo4.Text = ""
        TxtNumRollo4.ReadOnly = True
        TxtNRoll4.Text = ""
        TxtNRoll4.ReadOnly = True
        TxtObser4.Text = ""
        TxtObser4.ReadOnly = True
        TxtEspesor4.Text = ""
        TxtEspesor4.ReadOnly = True
    End Sub

    Public Sub Roll5()
        TxtAncho5.Text = ""
        TxtAncho5.ReadOnly = True
        TxtCalibre5.Text = ""
        TxtCalibre5.ReadOnly = True
        TxtPeso5.Text = ""
        TxtPeso5.ReadOnly = True
        TxtNumRollo5.Text = ""
        TxtNumRollo5.ReadOnly = True
        TxtNRoll5.Text = ""
        TxtNRoll5.ReadOnly = True
        TxtObser5.Text = ""
        TxtObser5.ReadOnly = True
        TxtEspesor5.Text = ""
        TxtEspesor5.ReadOnly = True
    End Sub

    Public Sub Roll6()
        TxtAncho6.Text = ""
        TxtAncho6.ReadOnly = True
        TxtCalibre6.Text = ""
        TxtCalibre6.ReadOnly = True
        TxtPeso6.Text = ""
        TxtPeso6.ReadOnly = True
        TxtNumRollo6.Text = ""
        TxtNumRollo6.ReadOnly = True
        TxtNRoll6.Text = ""
        TxtNRoll6.ReadOnly = True
        TxtObser6.Text = ""
        TxtObser6.ReadOnly = True
        TxtEspesor6.Text = ""
        TxtEspesor6.ReadOnly = True
    End Sub

    Public Sub Roll7()
        TxtAncho7.Text = ""
        TxtAncho7.ReadOnly = True
        TxtCalibre7.Text = ""
        TxtCalibre7.ReadOnly = True
        TxtPeso7.Text = ""
        TxtPeso7.ReadOnly = True
        TxtNumRollo7.Text = ""
        TxtNumRollo7.ReadOnly = True
        TxtNRoll7.Text = ""
        TxtNRoll7.ReadOnly = True
        TxtObser7.Text = ""
        TxtObser7.ReadOnly = True
        TxtEspesor7.Text = ""
        TxtEspesor7.ReadOnly = True
    End Sub

    Public Sub Roll8()
        TxtAncho8.Text = ""
        TxtAncho8.ReadOnly = True
        TxtCalibre8.Text = ""
        TxtCalibre8.ReadOnly = True
        TxtPeso8.Text = ""
        TxtPeso8.ReadOnly = True
        TxtNumRollo8.Text = ""
        TxtNumRollo8.ReadOnly = True
        TxtNRoll8.Text = ""
        TxtNRoll8.ReadOnly = True
        TxtObser8.Text = ""
        TxtObser8.ReadOnly = True
        TxtEspesor8.Text = ""
        TxtEspesor8.ReadOnly = True
    End Sub

    Public Sub Roll9()
        TxtAncho9.Text = ""
        TxtAncho9.ReadOnly = True
        TxtCalibre9.Text = ""
        TxtCalibre9.ReadOnly = True
        TxtPeso9.Text = ""
        TxtPeso9.ReadOnly = True
        TxtNumRollo9.Text = ""
        TxtNumRollo9.ReadOnly = True
        TxtNRoll9.Text = ""
        TxtNRoll9.ReadOnly = True
        TxtObser9.Text = ""
        TxtObser9.ReadOnly = True
        TxtEspesor9.Text = ""
        TxtEspesor9.ReadOnly = True
    End Sub

    Public Sub Roll10()
        TxtAncho10.Text = ""
        TxtAncho10.ReadOnly = True
        TxtCalibre10.Text = ""
        TxtCalibre10.ReadOnly = True
        TxtPeso10.Text = ""
        TxtPeso10.ReadOnly = True
        TxtNumRollo10.Text = ""
        TxtNumRollo10.ReadOnly = True
        TxtNRoll10.Text = ""
        TxtNRoll10.ReadOnly = True
        TxtObser10.Text = ""
        TxtObser10.ReadOnly = True
        TxtEspesor10.Text = ""
        TxtEspesor10.ReadOnly = True
    End Sub

    Public Sub Roll11()
        TxtAncho11.Text = ""
        TxtAncho11.ReadOnly = True
        TxtCalibre11.Text = ""
        TxtCalibre11.ReadOnly = True
        TxtPeso11.Text = ""
        TxtPeso11.ReadOnly = True
        TxtNumRollo11.Text = ""
        TxtNumRollo11.ReadOnly = True
        TxtNRoll11.Text = ""
        TxtNRoll11.ReadOnly = True
        TxtObser11.Text = ""
        TxtObser11.ReadOnly = True
        TxtEspesor11.Text = ""
        TxtEspesor11.ReadOnly = True
    End Sub

    Public Sub Roll12()
        TxtAncho12.Text = ""
        TxtAncho12.ReadOnly = True
        TxtCalibre12.Text = ""
        TxtCalibre12.ReadOnly = True
        TxtPeso12.Text = ""
        TxtPeso12.ReadOnly = True
        TxtNumRollo12.Text = ""
        TxtNumRollo12.ReadOnly = True
        TxtNRoll12.Text = ""
        TxtNRoll12.ReadOnly = True
        TxtObser12.Text = ""
        TxtObser12.ReadOnly = True
        TxtEspesor12.Text = ""
        TxtEspesor12.ReadOnly = True
    End Sub

    Public Sub Roll13()
        TxtAncho13.Text = ""
        TxtAncho13.ReadOnly = True
        TxtCalibre13.Text = ""
        TxtCalibre13.ReadOnly = True
        TxtPeso13.Text = ""
        TxtPeso13.ReadOnly = True
        TxtNumRollo13.Text = ""
        TxtNumRollo13.ReadOnly = True
        TxtNRoll13.Text = ""
        TxtNRoll13.ReadOnly = True
        TxtObser13.Text = ""
        TxtObser13.ReadOnly = True
        TxtEspesor13.Text = ""
        TxtEspesor13.ReadOnly = True
    End Sub

    Public Sub Roll14()
        TxtAncho14.Text = ""
        TxtAncho14.ReadOnly = True
        TxtCalibre14.Text = ""
        TxtCalibre14.ReadOnly = True
        TxtPeso14.Text = ""
        TxtPeso14.ReadOnly = True
        TxtNumRollo14.Text = ""
        TxtNumRollo14.ReadOnly = True
        TxtNRoll14.Text = ""
        TxtNRoll14.ReadOnly = True
        TxtObser14.Text = ""
        TxtObser14.ReadOnly = True
        TxtEspesor14.Text = ""
        TxtEspesor14.ReadOnly = True
    End Sub

    Public Sub Roll15()
        TxtAncho15.Text = ""
        TxtAncho15.ReadOnly = True
        TxtCalibre15.Text = ""
        TxtCalibre15.ReadOnly = True
        TxtPeso15.Text = ""
        TxtPeso15.ReadOnly = True
        TxtNumRollo15.Text = ""
        TxtNumRollo15.ReadOnly = True
        TxtNRoll15.Text = ""
        TxtNRoll15.ReadOnly = True
        TxtObser15.Text = ""
        TxtObser15.ReadOnly = True
        TxtEspesor15.Text = ""
        TxtEspesor15.ReadOnly = True
    End Sub

    Public Sub Roll16()
        TxtAncho16.Text = ""
        TxtAncho16.ReadOnly = True
        TxtCalibre16.Text = ""
        TxtCalibre16.ReadOnly = True
        TxtPeso16.Text = ""
        TxtPeso16.ReadOnly = True
        TxtNumRollo16.Text = ""
        TxtNumRollo16.ReadOnly = True
        TxtNRoll16.Text = ""
        TxtNRoll16.ReadOnly = True
        TxtObser16.Text = ""
        TxtObser16.ReadOnly = True
        TxtEspesor16.Text = ""
        TxtEspesor16.ReadOnly = True
    End Sub

    Public Sub Roll17()
        TxtAncho17.Text = ""
        TxtAncho17.ReadOnly = True
        TxtCalibre17.Text = ""
        TxtCalibre17.ReadOnly = True
        TxtPeso17.Text = ""
        TxtPeso17.ReadOnly = True
        TxtNumRollo17.Text = ""
        TxtNumRollo17.ReadOnly = True
        TxtNRoll17.Text = ""
        TxtNRoll17.ReadOnly = True
        TxtObser17.Text = ""
        TxtObser17.ReadOnly = True
        TxtEspesor17.Text = ""
        TxtEspesor17.ReadOnly = True
    End Sub

    Public Sub Roll18()
        TxtAncho18.Text = ""
        TxtAncho18.ReadOnly = True
        TxtCalibre18.Text = ""
        TxtCalibre18.ReadOnly = True
        TxtPeso18.Text = ""
        TxtPeso18.ReadOnly = True
        TxtNumRollo18.Text = ""
        TxtNumRollo18.ReadOnly = True
        TxtNRoll18.Text = ""
        TxtNRoll18.ReadOnly = True
        TxtObser18.Text = ""
        TxtObser18.ReadOnly = True
        TxtEspesor18.Text = ""
        TxtEspesor18.ReadOnly = True
    End Sub

    Public Sub Roll19()
        TxtAncho19.Text = ""
        TxtAncho19.ReadOnly = True
        TxtCalibre19.Text = ""
        TxtCalibre19.ReadOnly = True
        TxtPeso19.Text = ""
        TxtPeso19.ReadOnly = True
        TxtNumRollo19.Text = ""
        TxtNumRollo19.ReadOnly = True
        TxtNRoll19.Text = ""
        TxtNRoll19.ReadOnly = True
        TxtObser19.Text = ""
        TxtObser19.ReadOnly = True
        TxtEspesor19.Text = ""
        TxtEspesor19.ReadOnly = True
    End Sub

    Public Sub Roll20()
        TxtAncho20.Text = ""
        TxtAncho20.ReadOnly = True
        TxtCalibre20.Text = ""
        TxtCalibre20.ReadOnly = True
        TxtPeso20.Text = ""
        TxtPeso20.ReadOnly = True
        TxtNumRollo20.Text = ""
        TxtNumRollo20.ReadOnly = True
        TxtNRoll20.Text = ""
        TxtNRoll20.ReadOnly = True
        TxtObser20.Text = ""
        TxtObser20.ReadOnly = True
        TxtEspesor20.Text = ""
        TxtEspesor20.ReadOnly = True
    End Sub


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

    Private Sub DGVCA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCA.CellContentClick
        Dim Calibre As String
        Dim Row As DataGridViewRow = DGVCA.Rows(e.RowIndex)

        If LC.Text = "1" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre1.Text = Calibre

        ElseIf LC.Text = "2" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre2.Text = Calibre

        ElseIf LC.Text = "3" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre3.Text = Calibre

        ElseIf LC.Text = "4" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre4.Text = Calibre

        ElseIf LC.Text = "5" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre5.Text = Calibre

        ElseIf LC.Text = "6" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre6.Text = Calibre

        ElseIf LC.Text = "7" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre7.Text = Calibre

        ElseIf LC.Text = "8" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre8.Text = Calibre

        ElseIf LC.Text = "9" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre9.Text = Calibre

        ElseIf LC.Text = "10" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre10.Text = Calibre

        ElseIf LC.Text = "11" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre11.Text = Calibre

        ElseIf LC.Text = "12" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre12.Text = Calibre

        ElseIf LC.Text = "13" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre13.Text = Calibre

        ElseIf LC.Text = "14" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre14.Text = Calibre

        ElseIf LC.Text = "15" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre15.Text = Calibre

        ElseIf LC.Text = "16" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre16.Text = Calibre

        ElseIf LC.Text = "17" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre17.Text = Calibre

        ElseIf LC.Text = "18" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre18.Text = Calibre

        ElseIf LC.Text = "19" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre19.Text = Calibre

        ElseIf LC.Text = "20" Then
            Calibre = Row.Cells(1).Value
            TxtCalibre20.Text = Calibre
        End If
        PCalibres.Visible = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class



'  Select P.Id_Producto, P.Nombre_Producto, P.Clave_Producto, P.Minimo, P.Maximo, P.Existencia, ED.PUUSD, ED.FUSD, 
'			(COALESCE(ED.PUUSD,0) * COALESCE(ED.FUSD,0)) AS TUSD, ED.Tipo_Cambio, 
'						CASE WHEN ED.Tipo_Cambio > 0
'									THEN CASE WHEN TUSD > 0 
'													THEN ED.Tipo_Cambio * TUSD 
'											  ELSE 0
'										 END  
'									ELSE CASE WHEN ED.Precio_Unitario_PZA > 0
'													THEN ED.Precio_Unitario_PZA
'											  ELSE 0
'										 END
'						END AS 'PrecioUnitarioPZA',   
'			ED.PU_Corte_PZA, M.Medida, ED.PU_Total, ED.Precio_Total, 
'			 o.purchase_order
'  FROM TB_Productos AS P
'	LEFT JOIN TB_EDetalleProductos AS ED ON P.Id_Producto = ED.Id_Producto
'	LEFT JOIN TB_Ordenes_Compra AS O ON ED.CodiS = O.CodiS
'	INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
'  WHERE P.Estado = 'Activo' AND
'		P.Existencia > 0
'  ORDER BY Id_Producto asc





'Select 'Importe', PD.id_pedimento, PD.precio_pagado As 'USD', PD.t_cambio AS 'T.C', (PD.precio_pagado * PD.t_cambio) AS 'Moneda Nacional'
'From TB_Pedimentos AS PD


'Select 'Peso', PD.id_pedimento, PD.peso_bruto AS 'USD',' '
'From TB_Pedimentos AS PD

'Select 'Costo - Kilo', PD.id_pedimento, (PD.precio_pagado / PD.peso_bruto) as 'USD', PD.t_cambio AS 'T.C', ((PD.precio_pagado / PD.peso_bruto)*PD.t_cambio)
'From TB_Pedimentos AS PD