Imports System.Runtime.InteropServices
Public Class Menu
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnAves.Click
        AbrirFormEnPanel(New LisAves)
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnMamiferos.Click
        AbrirFormEnPanel(New LisMamimeros)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        btnPrecio.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAcuaticos.Click
        AbrirFormEnPanel(New LisAcuaticos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistroani.Click
        AbrirFormEnPanel(New Rgistraranimal)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        AbrirFormEnPanel(New Venta)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click
        AbrirFormEnPanel(New Precios)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnEnfermeria.Click
        AbrirFormEnPanel(New Enfermeria)
    End Sub
End Class
