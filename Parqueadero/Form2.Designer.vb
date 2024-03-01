<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_regis
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cedula = New TextBox()
        codad = New TextBox()
        TextBox3 = New TextBox()
        guardar = New Button()
        Pre_segu = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(151, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 65)
        Label1.TabIndex = 0
        Label1.Text = "Registro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(74, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 21)
        Label2.TabIndex = 1
        Label2.Text = "Cedula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(74, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 21)
        Label3.TabIndex = 2
        Label3.Text = "Codigo Dactilar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(74, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 3
        Label4.Text = "Contraseña"
        ' 
        ' cedula
        ' 
        cedula.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cedula.Location = New Point(288, 147)
        cedula.Name = "cedula"
        cedula.Size = New Size(191, 29)
        cedula.TabIndex = 5
        ' 
        ' codad
        ' 
        codad.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        codad.Location = New Point(288, 203)
        codad.Name = "codad"
        codad.Size = New Size(191, 29)
        codad.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(287, 313)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(191, 29)
        TextBox3.TabIndex = 7
        ' 
        ' guardar
        ' 
        guardar.Location = New Point(307, 416)
        guardar.Name = "guardar"
        guardar.Size = New Size(75, 23)
        guardar.TabIndex = 8
        guardar.Text = "Guardar"
        guardar.UseVisualStyleBackColor = True
        ' 
        ' Pre_segu
        ' 
        Pre_segu.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Pre_segu.FormattingEnabled = True
        Pre_segu.Items.AddRange(New Object() {"Color Favorito", "Nombre de la Madre", "Nombre del Padre", "Ciudad Donde Nacio"})
        Pre_segu.Location = New Point(288, 262)
        Pre_segu.Name = "Pre_segu"
        Pre_segu.Size = New Size(190, 29)
        Pre_segu.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(74, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 21)
        Label5.TabIndex = 10
        Label5.Text = "Pregunta de Seguridad"
        ' 
        ' form_regis
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 450)
        Controls.Add(Label5)
        Controls.Add(Pre_segu)
        Controls.Add(guardar)
        Controls.Add(TextBox3)
        Controls.Add(codad)
        Controls.Add(cedula)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "form_regis"
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cedula As TextBox
    Friend WithEvents codad As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents Pre_segu As ComboBox
    Friend WithEvents Label5 As Label
End Class
