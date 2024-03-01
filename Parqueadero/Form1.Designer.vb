<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_sesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_sesion))
        PictureBox1 = New PictureBox()
        registro = New Button()
        recu = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_usu = New TextBox()
        txt_clave = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(36, 85)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(260, 267)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' registro
        ' 
        registro.Location = New Point(491, 264)
        registro.Name = "registro"
        registro.Size = New Size(85, 50)
        registro.TabIndex = 1
        registro.Text = "Registro"
        registro.UseVisualStyleBackColor = True
        ' 
        ' recu
        ' 
        recu.Location = New Point(592, 264)
        recu.Name = "recu"
        recu.Size = New Size(91, 50)
        recu.TabIndex = 2
        recu.Text = "Recuperar Contraseña"
        recu.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(686, 155)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 49)
        Button3.TabIndex = 3
        Button3.Text = "Iniciar Sesion"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(491, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 65)
        Label1.TabIndex = 4
        Label1.Text = "ParkA+"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(386, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 21)
        Label2.TabIndex = 5
        Label2.Text = "Contraseña"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(413, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 21)
        Label3.TabIndex = 6
        Label3.Text = "Usuario"
        ' 
        ' txt_usu
        ' 
        txt_usu.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_usu.Location = New Point(510, 134)
        txt_usu.Name = "txt_usu"
        txt_usu.Size = New Size(137, 29)
        txt_usu.TabIndex = 7
        ' 
        ' txt_clave
        ' 
        txt_clave.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_clave.Location = New Point(510, 202)
        txt_clave.Name = "txt_clave"
        txt_clave.Size = New Size(137, 29)
        txt_clave.TabIndex = 8
        ' 
        ' form_sesion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(txt_clave)
        Controls.Add(txt_usu)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(recu)
        Controls.Add(registro)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "form_sesion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar Sesion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents registro As Button
    Friend WithEvents recu As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usu As TextBox
    Friend WithEvents txt_clave As TextBox

End Class
