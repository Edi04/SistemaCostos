Public Class Index

    'Botones
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub B_Minimizar_Click(sender As Object, e As EventArgs) Handles B_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Compras
    Private Sub BCompras_Click(sender As Object, e As EventArgs) Handles BCompras.Click
        If PMCompras.Visible = True Then
            PMCompras.Visible = False
        ElseIf PMCompras.Visible = False Then
            PMCompras.Visible = True

            PA_R.Visible = False
            PMCostos.Visible = False
            PMTransporte.Visible = False
            PMAlmacen.Visible = False
            PMMass.Visible = False
            PMMPrima.Visible = False
            PMGasolina.Visible = False
        End If
    End Sub

    Private Sub B_Agregar_Orden_Click(sender As Object, e As EventArgs) Handles B_Agregar_Orden.Click
        OrdCompra.Show()
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click
        ReporteOrd.Show()
    End Sub

    Private Sub Btn_listado_Click(sender As Object, e As EventArgs) Handles Btn_listado.Click
        RegistrosOrdCom.Show()
    End Sub

    Private Sub PMPrima_Click(sender As Object, e As EventArgs) Handles PMPrima.Click
        NProductos.Show()
    End Sub


    'Costos
    Private Sub BCost_Click(sender As Object, e As EventArgs) Handles BCost.Click
        If PMCostos.Visible = True Then
            PMCostos.Visible = False
        ElseIf PMCostos.Visible = False Then
            PMCostos.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMTransporte.Visible = False
            PMAlmacen.Visible = False
            PMMPrima.Visible = False
            PMMass.Visible = False
            PMGasolina.Visible = False
        End If
    End Sub

    Private Sub B_Facturas_Click(sender As Object, e As EventArgs) Handles B_Facturas.Click
        factura.Show()
    End Sub

    Private Sub B_pedimentos_Click(sender As Object, e As EventArgs) Handles B_pedimentos.Click
        Pedimentos.Show()
    End Sub


    'Transporte
    Private Sub BTranspor_Click(sender As Object, e As EventArgs) Handles BTranspor.Click
        If PMTransporte.Visible = True Then
            PMTransporte.Visible = False
        ElseIf PMTransporte.Visible = False Then
            PMTransporte.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMCostos.Visible = False
            PMAlmacen.Visible = False
            PMMass.Visible = False
            PMMPrima.Visible = False
            PMGasolina.Visible = False
        End If
    End Sub

    Private Sub btn_trasportes_Click(sender As Object, e As EventArgs) Handles btn_trasportes.Click
        AltaTrasportes.Show()
    End Sub

    Private Sub btn_mantenimientos_Click(sender As Object, e As EventArgs) Handles btn_mantenimientos.Click
        ServiciosMantenimiento.Show()
    End Sub


    'Almacen
    Private Sub BAlmac_Click(sender As Object, e As EventArgs) Handles BAlmac.Click
        If PMAlmacen.Visible = True Then
            PMAlmacen.Visible = False
        ElseIf PMAlmacen.Visible = False Then
            PMAlmacen.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMCostos.Visible = False
            PMTransporte.Visible = False
            PMMass.Visible = False
            PMMPrima.Visible = False
            PMGasolina.Visible = False
        End If
    End Sub

    Private Sub B_Inventario_Click(sender As Object, e As EventArgs) Handles B_Inventario.Click
        Dim Inven As New Inventario()
        Inven.Show()

        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub B_Barras_Click(sender As Object, e As EventArgs) Handles B_Barras.Click
        Dim Eti As New EtiquetasCB()
        Eti.Show()

        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub B_Prestamos_Click(sender As Object, e As EventArgs) Handles B_Prestamos.Click
        Dim P As New Prestamos()
        P.Show()

        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BEntrega_Click(sender As Object, e As EventArgs) Handles BEntrega.Click
        Dim Ent As New Entregas()
        Ent.Show()

        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BContabilizar_Click(sender As Object, e As EventArgs) Handles BContabilizar.Click
        Dim Con As New Contabilizar()
        Con.Show()

        WindowState = FormWindowState.Minimized
    End Sub


    'Mass
    Private Sub BMass_Click(sender As Object, e As EventArgs) Handles BMass.Click
        If PMMass.Visible = True Then
            PMMass.Visible = False
        ElseIf PMMass.Visible = False Then
            PMMass.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMCostos.Visible = False
            PMTransporte.Visible = False
            PMAlmacen.Visible = False
            PMMPrima.Visible = False
            PMGasolina.Visible = False
        End If
    End Sub

    Private Sub BMInventario_Click(sender As Object, e As EventArgs) Handles BMInventario.Click
        Dim MInv As New MInventario()
        MInv.Show()

        WindowState = FormWindowState.Minimized
    End Sub


    'Materia Prima
    Private Sub BMPrima_Click(sender As Object, e As EventArgs) Handles BMPrima.Click
        If PMMPrima.Visible = True Then
            PMMPrima.Visible = False
        ElseIf PMMPrima.Visible = False Then
            PMMPrima.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMCompras.Visible = False
            PMTransporte.Visible = False
            PMAlmacen.Visible = False
            PMMass.Visible = False
            PMGasolina.Visible = False
        End If
    End Sub

    Private Sub BPMPr_Click(sender As Object, e As EventArgs) Handles BPMPr.Click
        MPInventario.Show()
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BMOHR_Click(sender As Object, e As EventArgs) Handles BMOHR.Click
        'MPHistorial.Show()
        WindowState = FormWindowState.Minimized
    End Sub


    'Gasolina
    Private Sub btn_gas_Click_1(sender As Object, e As EventArgs) Handles btn_gas.Click
        If PMGasolina.Visible = True Then
            PMGasolina.Visible = False
        ElseIf PMGasolina.Visible = False Then
            PMGasolina.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMCompras.Visible = False
            PMTransporte.Visible = False
            PMAlmacen.Visible = False
            PMMass.Visible = False
            PMMPrima.Visible = False
        End If
    End Sub

    'recursos_humanos
    Private Sub btn_rh_abre_Click(sender As Object, e As EventArgs) Handles btn_rh_abre.Click

        If PM_recursos_Humanos.Visible = True Then
            PM_recursos_Humanos.Visible = False
        ElseIf PM_recursos_Humanos.Visible = False Then
            PM_recursos_Humanos.Visible = True

            PA_R.Visible = False
            PMCompras.Visible = False
            PMCompras.Visible = False
            PMTransporte.Visible = False
            PMAlmacen.Visible = False
            PMMass.Visible = False
            PMMPrima.Visible = False
            PMGasolina.Visible = False
        End If
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

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub


    Private Sub btn_Programados_Click(sender As Object, e As EventArgs) Handles btn_Programados.Click
        RevicionesProgramadas.Show()
    End Sub

    Private Sub btn_gas_individual_Click(sender As Object, e As EventArgs) Handles btn_gas_individual.Click
        Compra_Conbustible2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Reparticion_gasolina.Show()
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BPedidos_Click(sender As Object, e As EventArgs) Handles BPedidos.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    'Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BA_R.Click
    '    If PA_R.Visible = True Then
    '        PA_R.Visible = False
    '    ElseIf PA_R.Visible = False Then
    '        PA_R.Visible = True

    '        PMAlmacen.Visible = False
    '        PMCompras.Visible = False
    '        PMCostos.Visible = False
    '        PMTransporte.Visible = False
    '        PMMass.Visible = False
    '        PMMPrima.Visible = False
    '        PMGasolina.Visible = False
    '    End If
    'End Sub

    Private Sub LMP_Click(sender As Object, e As EventArgs) Handles LMP.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ' CNM_COMPRAS_OC_PROCESO1.ShowDialog()
    End Sub

    Private Sub btn_entregas_Click(sender As Object, e As EventArgs) Handles btn_entregas.Click
        Entregas_diarias.Show()
    End Sub

    Private Sub btn_fletesyentregas_Click(sender As Object, e As EventArgs) Handles btn_fletesyentregas.Click
        Fletes_y_Entregas.Show()
    End Sub

    Private Sub btn_recursos_humanos_Click(sender As Object, e As EventArgs) Handles btn_recursos_humanos.Click
        Rh.Show()
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        Ventas.Show()
    End Sub

    Private Sub btn_gas_por_mucho_Click(sender As Object, e As EventArgs) Handles btn_gas_por_mucho.Click
        Compra_Conbustible.Show()
    End Sub
End Class