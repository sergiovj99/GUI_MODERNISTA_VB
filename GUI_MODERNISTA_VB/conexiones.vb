Module conexiones

    Public Conexion As OleDb.OleDbConnection
    Public Sub AbrirConexion()
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Animales.mdb;"
        Conexion.Open()
    End Sub


End Module
