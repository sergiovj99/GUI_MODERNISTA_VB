<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.btncomprar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(176, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(513, 27)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Sistema Mundial de Animales sin Casa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.DimGray
        Me.btnCerrar.Location = New System.Drawing.Point(3, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.TabIndex = 57
        Me.btnCerrar.Text = "X"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(101, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 282)
        Me.DataGridView1.TabIndex = 58
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(689, 202)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(88, 69)
        Me.btnmostrar.TabIndex = 59
        Me.btnmostrar.Text = "Mostrar animales"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'btncomprar
        '
        Me.btncomprar.Location = New System.Drawing.Point(689, 289)
        Me.btncomprar.Name = "btncomprar"
        Me.btncomprar.Size = New System.Drawing.Size(88, 60)
        Me.btncomprar.TabIndex = 60
        Me.btncomprar.Text = "Comprar animal"
        Me.btncomprar.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_MODERNISTA_VB.My.Resources.Resources._05a4e0e651735015bca1bc661d7435171
        Me.ClientSize = New System.Drawing.Size(837, 627)
        Me.Controls.Add(Me.btncomprar)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Venta"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnmostrar As Button
    Friend WithEvents btncomprar As Button
End Class
