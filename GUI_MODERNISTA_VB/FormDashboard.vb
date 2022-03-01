Imports System.Data
Imports System.Data.OleDb
Public Class FormDashboard

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

    End Sub

    Public Sub CargarGrid()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Lis_animales", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Nombre As String
        Dim Especie As String
        Dim Subespecie As String
        Dim Edad As Integer
        Dim Pais_origen As String
        Dim Costumbre_alimentacia As String

        Nombre = Me.TextBox1.Text
        Especie = Me.TextBox2.Text
        Subespecie = Me.TextBox3.Text
        Edad = Me.TextBox4.Text
        Pais_origen = Me.TextBox5.Text
        Costumbre_alimentacia = Me.TextBox6.Text

        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If


        Dim cmd As New OleDbCommand(" INSERT INTO Lis_animales(Nombre, Especie, subespecie, Edad, Pais de origen, Costumbres alimenticias)VALUES(" & Nombre & "," & Especie & "," & Subespecie & "," & Edad & "," & Pais_origen & "," & Costumbre_alimentacia & ")", Conexion)
        cmd.ExecuteNonQuery()

        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If

        MsgBox("INSERTADOS BIEN", vbInformation, "Confirmar")

    End Sub
End Class