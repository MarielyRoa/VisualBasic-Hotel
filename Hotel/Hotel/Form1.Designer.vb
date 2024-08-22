<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(211, 105)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(165, 22)
        Me.txtusuario.TabIndex = 2
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(211, 160)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(165, 22)
        Me.txtcontraseña.TabIndex = 3
        '
        'btnentrar
        '
        Me.btnentrar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.Location = New System.Drawing.Point(84, 242)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(116, 44)
        Me.btnentrar.TabIndex = 4
        Me.btnentrar.Text = "Entrar"
        Me.btnentrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents btnentrar As Button
End Class
