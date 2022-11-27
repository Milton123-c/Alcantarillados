<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_activo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lb_amin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.BTN_NuevasLecturas = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_Administrador = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_Usario = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_Inicio = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BTN_Minimizar = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnResturar = New System.Windows.Forms.PictureBox()
        Me.BTN_Maximizar = New System.Windows.Forms.PictureBox()
        Me.BTN_Restaurar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BTN_Cerrar = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnResturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.Panel6)
        Me.BarraTitulo.Controls.Add(Me.Panel5)
        Me.BarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.BTN_Minimizar)
        Me.BarraTitulo.Controls.Add(Me.BtnMaximizar)
        Me.BarraTitulo.Controls.Add(Me.BtnResturar)
        Me.BarraTitulo.Controls.Add(Me.BTN_Maximizar)
        Me.BarraTitulo.Controls.Add(Me.BTN_Restaurar)
        Me.BarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.BarraTitulo.Controls.Add(Me.BTN_Cerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1288, 33)
        Me.BarraTitulo.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.lb_activo)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(401, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(171, 33)
        Me.Panel6.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stado"
        '
        'lb_activo
        '
        Me.lb_activo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_activo.AutoEllipsis = True
        Me.lb_activo.BackColor = System.Drawing.Color.Cyan
        Me.lb_activo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_activo.Location = New System.Drawing.Point(74, 8)
        Me.lb_activo.Margin = New System.Windows.Forms.Padding(3)
        Me.lb_activo.Name = "lb_activo"
        Me.lb_activo.Size = New System.Drawing.Size(38, 17)
        Me.lb_activo.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.Controls.Add(Me.lb_amin)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(401, 33)
        Me.Panel5.TabIndex = 4
        '
        'lb_amin
        '
        Me.lb_amin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_amin.AutoSize = True
        Me.lb_amin.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lb_amin.ForeColor = System.Drawing.Color.White
        Me.lb_amin.Location = New System.Drawing.Point(157, 7)
        Me.lb_amin.Name = "lb_amin"
        Me.lb_amin.Size = New System.Drawing.Size(235, 21)
        Me.lb_amin.TabIndex = 7
        Me.lb_amin.Text = "Milton David Gago Mercado"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Turquoise
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ADMINISTRADOR:"
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.BTN_NuevasLecturas)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.Panel4)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.BTN_Administrador)
        Me.MenuVertical.Controls.Add(Me.Panel2)
        Me.MenuVertical.Controls.Add(Me.BTN_Usario)
        Me.MenuVertical.Controls.Add(Me.Panel1)
        Me.MenuVertical.Controls.Add(Me.BTN_Inicio)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 33)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(189, 530)
        Me.MenuVertical.TabIndex = 1
        '
        'BTN_NuevasLecturas
        '
        Me.BTN_NuevasLecturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_NuevasLecturas.FlatAppearance.BorderSize = 0
        Me.BTN_NuevasLecturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_NuevasLecturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NuevasLecturas.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BTN_NuevasLecturas.ForeColor = System.Drawing.Color.White
        Me.BTN_NuevasLecturas.Location = New System.Drawing.Point(3, 238)
        Me.BTN_NuevasLecturas.Name = "BTN_NuevasLecturas"
        Me.BTN_NuevasLecturas.Size = New System.Drawing.Size(185, 28)
        Me.BTN_NuevasLecturas.TabIndex = 10
        Me.BTN_NuevasLecturas.Text = "Nuevas Lecturas"
        Me.BTN_NuevasLecturas.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(1, 297)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 28)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(1, 238)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 28)
        Me.Panel3.TabIndex = 6
        '
        'BTN_Administrador
        '
        Me.BTN_Administrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_Administrador.FlatAppearance.BorderSize = 0
        Me.BTN_Administrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_Administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Administrador.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BTN_Administrador.ForeColor = System.Drawing.Color.White
        Me.BTN_Administrador.Location = New System.Drawing.Point(3, 297)
        Me.BTN_Administrador.Name = "BTN_Administrador"
        Me.BTN_Administrador.Size = New System.Drawing.Size(185, 28)
        Me.BTN_Administrador.TabIndex = 5
        Me.BTN_Administrador.Text = "Administrador"
        Me.BTN_Administrador.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(1, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(4, 28)
        Me.Panel2.TabIndex = 4
        '
        'BTN_Usario
        '
        Me.BTN_Usario.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_Usario.FlatAppearance.BorderSize = 0
        Me.BTN_Usario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_Usario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Usario.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BTN_Usario.ForeColor = System.Drawing.Color.White
        Me.BTN_Usario.Location = New System.Drawing.Point(3, 185)
        Me.BTN_Usario.Name = "BTN_Usario"
        Me.BTN_Usario.Size = New System.Drawing.Size(185, 28)
        Me.BTN_Usario.TabIndex = 3
        Me.BTN_Usario.Text = "Usuarios"
        Me.BTN_Usario.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 28)
        Me.Panel1.TabIndex = 2
        '
        'BTN_Inicio
        '
        Me.BTN_Inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_Inicio.FlatAppearance.BorderSize = 0
        Me.BTN_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BTN_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Inicio.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BTN_Inicio.ForeColor = System.Drawing.Color.White
        Me.BTN_Inicio.Location = New System.Drawing.Point(3, 137)
        Me.BTN_Inicio.Name = "BTN_Inicio"
        Me.BTN_Inicio.Size = New System.Drawing.Size(185, 28)
        Me.BTN_Inicio.TabIndex = 1
        Me.BTN_Inicio.Text = "Inicio"
        Me.BTN_Inicio.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(189, 33)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1099, 530)
        Me.PanelContenedor.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Alcantarillados.My.Resources.Resources.Apagado
        Me.PictureBox2.Location = New System.Drawing.Point(10, 458)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox1.Image = Global.Alcantarillados.My.Resources.Resources.Somos_Agua
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Image = Global.Alcantarillados.My.Resources.Resources.Minimizar_cerrar
        Me.BtnMinimizar.Location = New System.Drawing.Point(1203, 6)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(21, 22)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 3
        Me.BtnMinimizar.TabStop = False
        '
        'BTN_Minimizar
        '
        Me.BTN_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Minimizar.Location = New System.Drawing.Point(1336, 6)
        Me.BTN_Minimizar.Name = "BTN_Minimizar"
        Me.BTN_Minimizar.Size = New System.Drawing.Size(21, 22)
        Me.BTN_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_Minimizar.TabIndex = 0
        Me.BTN_Minimizar.TabStop = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Image = Global.Alcantarillados.My.Resources.Resources.Maximizar
        Me.BtnMaximizar.Location = New System.Drawing.Point(1229, 7)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(21, 22)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMaximizar.TabIndex = 1
        Me.BtnMaximizar.TabStop = False
        '
        'BtnResturar
        '
        Me.BtnResturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResturar.Image = Global.Alcantarillados.My.Resources.Resources.Minimizar
        Me.BtnResturar.Location = New System.Drawing.Point(1230, 6)
        Me.BtnResturar.Name = "BtnResturar"
        Me.BtnResturar.Size = New System.Drawing.Size(21, 22)
        Me.BtnResturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnResturar.TabIndex = 2
        Me.BtnResturar.TabStop = False
        '
        'BTN_Maximizar
        '
        Me.BTN_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Maximizar.Location = New System.Drawing.Point(1362, 6)
        Me.BTN_Maximizar.Name = "BTN_Maximizar"
        Me.BTN_Maximizar.Size = New System.Drawing.Size(21, 22)
        Me.BTN_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_Maximizar.TabIndex = 0
        Me.BTN_Maximizar.TabStop = False
        '
        'BTN_Restaurar
        '
        Me.BTN_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Restaurar.Location = New System.Drawing.Point(1362, 6)
        Me.BTN_Restaurar.Name = "BTN_Restaurar"
        Me.BTN_Restaurar.Size = New System.Drawing.Size(21, 22)
        Me.BTN_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_Restaurar.TabIndex = 0
        Me.BTN_Restaurar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Image = Global.Alcantarillados.My.Resources.Resources.Cerrar
        Me.BtnCerrar.Location = New System.Drawing.Point(1256, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(21, 22)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'BTN_Cerrar
        '
        Me.BTN_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Cerrar.Location = New System.Drawing.Point(1389, 6)
        Me.BTN_Cerrar.Name = "BTN_Cerrar"
        Me.BTN_Cerrar.Size = New System.Drawing.Size(21, 22)
        Me.BTN_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTN_Cerrar.TabIndex = 0
        Me.BTN_Cerrar.TabStop = False
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 563)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnResturar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents BTN_Restaurar As PictureBox
    Friend WithEvents BTN_Maximizar As PictureBox
    Friend WithEvents BTN_Cerrar As PictureBox
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BTN_Minimizar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_Inicio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_Administrador As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_Usario As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnResturar As PictureBox
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BTN_NuevasLecturas As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_activo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lb_amin As Label
    Friend WithEvents Label1 As Label
End Class
