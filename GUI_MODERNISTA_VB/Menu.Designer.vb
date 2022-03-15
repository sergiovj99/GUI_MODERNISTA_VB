<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEnfermeria = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnRegistroani = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAcuaticos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAves = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnMamiferos = New System.Windows.Forms.Button()
        Me.tmOCULTAR = New System.Windows.Forms.Timer(Me.components)
        Me.tmMOSTRAR = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.Aquamarine
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1150, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.ForeColor = System.Drawing.Color.White
        Me.btnRestaurar.Image = Global.GUI_MODERNISTA_VB.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1067, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 7
        Me.btnRestaurar.Text = ""
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = Global.GUI_MODERNISTA_VB.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1024, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.Text = ""
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximizar.ForeColor = System.Drawing.Color.White
        Me.btnMaximizar.Image = Global.GUI_MODERNISTA_VB.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1067, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 5
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1110, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.MediumTurquoise
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnEnfermeria)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.PictureBox5)
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.btnPrecio)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.btnVenta)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.btnRegistroani)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.btnAcuaticos)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.btnAves)
        Me.PanelMenu.Controls.Add(Me.Panel10)
        Me.PanelMenu.Controls.Add(Me.btnMamiferos)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 560)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 12
        '
        'btnEnfermeria
        '
        Me.btnEnfermeria.FlatAppearance.BorderSize = 0
        Me.btnEnfermeria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnEnfermeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnfermeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnfermeria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnfermeria.ForeColor = System.Drawing.Color.White
        Me.btnEnfermeria.Image = CType(resources.GetObject("btnEnfermeria.Image"), System.Drawing.Image)
        Me.btnEnfermeria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnfermeria.Location = New System.Drawing.Point(2, 457)
        Me.btnEnfermeria.Name = "btnEnfermeria"
        Me.btnEnfermeria.Size = New System.Drawing.Size(210, 50)
        Me.btnEnfermeria.TabIndex = 14
        Me.btnEnfermeria.Text = "   ENFERMERIA"
        Me.btnEnfermeria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnfermeria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnfermeria.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(180, 5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GUI_MODERNISTA_VB.My.Resources.Resources.pngwing_com__5_
        Me.PictureBox5.Location = New System.Drawing.Point(27, 39)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(193, 82)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 401)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 11
        '
        'btnPrecio
        '
        Me.btnPrecio.FlatAppearance.BorderSize = 0
        Me.btnPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecio.ForeColor = System.Drawing.Color.White
        Me.btnPrecio.Image = CType(resources.GetObject("btnPrecio.Image"), System.Drawing.Image)
        Me.btnPrecio.Location = New System.Drawing.Point(4, 401)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(198, 50)
        Me.btnPrecio.TabIndex = 10
        Me.btnPrecio.Text = "    PRECIOS"
        Me.btnPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 345)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 9
        '
        'btnVenta
        '
        Me.btnVenta.FlatAppearance.BorderSize = 0
        Me.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.Image = CType(resources.GetObject("btnVenta.Image"), System.Drawing.Image)
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Location = New System.Drawing.Point(0, 345)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(220, 50)
        Me.btnVenta.TabIndex = 8
        Me.btnVenta.Text = "  ANIMALES EN VENTA"
        Me.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 289)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 7
        '
        'btnRegistroani
        '
        Me.btnRegistroani.FlatAppearance.BorderSize = 0
        Me.btnRegistroani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnRegistroani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegistroani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroani.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroani.ForeColor = System.Drawing.Color.White
        Me.btnRegistroani.Image = CType(resources.GetObject("btnRegistroani.Image"), System.Drawing.Image)
        Me.btnRegistroani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroani.Location = New System.Drawing.Point(6, 289)
        Me.btnRegistroani.Name = "btnRegistroani"
        Me.btnRegistroani.Size = New System.Drawing.Size(209, 50)
        Me.btnRegistroani.TabIndex = 6
        Me.btnRegistroani.Text = "    REGISTRAR ANIMAL"
        Me.btnRegistroani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistroani.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 5
        '
        'btnAcuaticos
        '
        Me.btnAcuaticos.FlatAppearance.BorderSize = 0
        Me.btnAcuaticos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAcuaticos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAcuaticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcuaticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcuaticos.ForeColor = System.Drawing.Color.White
        Me.btnAcuaticos.Image = CType(resources.GetObject("btnAcuaticos.Image"), System.Drawing.Image)
        Me.btnAcuaticos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcuaticos.Location = New System.Drawing.Point(1, 229)
        Me.btnAcuaticos.Name = "btnAcuaticos"
        Me.btnAcuaticos.Size = New System.Drawing.Size(214, 59)
        Me.btnAcuaticos.TabIndex = 4
        Me.btnAcuaticos.Text = "  ACUATICOS"
        Me.btnAcuaticos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcuaticos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcuaticos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 3
        '
        'btnAves
        '
        Me.btnAves.FlatAppearance.BorderSize = 0
        Me.btnAves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAves.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAves.ForeColor = System.Drawing.Color.White
        Me.btnAves.Image = CType(resources.GetObject("btnAves.Image"), System.Drawing.Image)
        Me.btnAves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAves.Location = New System.Drawing.Point(12, 174)
        Me.btnAves.Name = "btnAves"
        Me.btnAves.Size = New System.Drawing.Size(202, 53)
        Me.btnAves.TabIndex = 2
        Me.btnAves.Text = "  AVES"
        Me.btnAves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAves.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(0, 121)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 50)
        Me.Panel10.TabIndex = 1
        '
        'btnMamiferos
        '
        Me.btnMamiferos.FlatAppearance.BorderSize = 0
        Me.btnMamiferos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnMamiferos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMamiferos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMamiferos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMamiferos.ForeColor = System.Drawing.Color.White
        Me.btnMamiferos.Image = CType(resources.GetObject("btnMamiferos.Image"), System.Drawing.Image)
        Me.btnMamiferos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMamiferos.Location = New System.Drawing.Point(2, 120)
        Me.btnMamiferos.Name = "btnMamiferos"
        Me.btnMamiferos.Size = New System.Drawing.Size(214, 57)
        Me.btnMamiferos.TabIndex = 0
        Me.btnMamiferos.Text = "  MAMÍFEROS TERRESTRES"
        Me.btnMamiferos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMamiferos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMamiferos.UseVisualStyleBackColor = True
        '
        'tmOCULTAR
        '
        Me.tmOCULTAR.Interval = 15
        '
        'tmMOSTRAR
        '
        Me.tmMOSTRAR.Interval = 15
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Control
        Me.PanelContenedor.BackgroundImage = Global.GUI_MODERNISTA_VB.My.Resources.Resources.seres_vivos__1_
        Me.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContenedor.Location = New System.Drawing.Point(218, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(932, 560)
        Me.PanelContenedor.TabIndex = 2
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 600)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBarraTitulo As System.Windows.Forms.Panel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents btnMamiferos As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAcuaticos As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAves As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnPrecio As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnRegistroani As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmOCULTAR As System.Windows.Forms.Timer
    Friend WithEvents tmMOSTRAR As System.Windows.Forms.Timer
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEnfermeria As Button
End Class
