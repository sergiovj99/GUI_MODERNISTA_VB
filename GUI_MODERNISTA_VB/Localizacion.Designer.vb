<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReptiles = New System.Windows.Forms.Button()
        Me.btnMamiferos = New System.Windows.Forms.Button()
        Me.btnRapaces = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(382, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 27)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "LOCALIZACIÓN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReptiles
        '
        Me.btnReptiles.Location = New System.Drawing.Point(217, 133)
        Me.btnReptiles.Name = "btnReptiles"
        Me.btnReptiles.Size = New System.Drawing.Size(108, 53)
        Me.btnReptiles.TabIndex = 63
        Me.btnReptiles.Text = "Reptiles"
        Me.btnReptiles.UseVisualStyleBackColor = True
        '
        'btnMamiferos
        '
        Me.btnMamiferos.Location = New System.Drawing.Point(406, 133)
        Me.btnMamiferos.Name = "btnMamiferos"
        Me.btnMamiferos.Size = New System.Drawing.Size(98, 53)
        Me.btnMamiferos.TabIndex = 64
        Me.btnMamiferos.Text = "Mamiferos"
        Me.btnMamiferos.UseVisualStyleBackColor = True
        '
        'btnRapaces
        '
        Me.btnRapaces.Location = New System.Drawing.Point(585, 133)
        Me.btnRapaces.Name = "btnRapaces"
        Me.btnRapaces.Size = New System.Drawing.Size(100, 53)
        Me.btnRapaces.TabIndex = 65
        Me.btnRapaces.Text = "Rapaces"
        Me.btnRapaces.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(157, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(582, 244)
        Me.DataGridView1.TabIndex = 66
        '
        'Localizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_MODERNISTA_VB.My.Resources.Resources.pngwing1
        Me.ClientSize = New System.Drawing.Size(928, 534)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRapaces)
        Me.Controls.Add(Me.btnMamiferos)
        Me.Controls.Add(Me.btnReptiles)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Localizacion"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnReptiles As Button
    Friend WithEvents btnMamiferos As Button
    Friend WithEvents btnRapaces As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
