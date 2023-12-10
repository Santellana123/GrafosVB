<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnAgregarVertice = New Button()
        btnAgregarArista = New Button()
        btnEliminarVertice = New Button()
        txtOrigen = New TextBox()
        txtVertice = New TextBox()
        txtDestino = New TextBox()
        listGrafo = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnEncontrarCamino = New Button()
        SuspendLayout()
        ' 
        ' btnAgregarVertice
        ' 
        btnAgregarVertice.Location = New Point(50, 46)
        btnAgregarVertice.Name = "btnAgregarVertice"
        btnAgregarVertice.Size = New Size(95, 23)
        btnAgregarVertice.TabIndex = 0
        btnAgregarVertice.Text = "Agregar Vertice"
        btnAgregarVertice.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarArista
        ' 
        btnAgregarArista.Location = New Point(50, 107)
        btnAgregarArista.Name = "btnAgregarArista"
        btnAgregarArista.Size = New Size(95, 26)
        btnAgregarArista.TabIndex = 1
        btnAgregarArista.Text = "Agregar Arista"
        btnAgregarArista.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarVertice
        ' 
        btnEliminarVertice.Location = New Point(575, 64)
        btnEliminarVertice.Name = "btnEliminarVertice"
        btnEliminarVertice.Size = New Size(86, 30)
        btnEliminarVertice.TabIndex = 2
        btnEliminarVertice.Text = "Eliminar"
        btnEliminarVertice.UseVisualStyleBackColor = True
        ' 
        ' txtOrigen
        ' 
        txtOrigen.Location = New Point(164, 110)
        txtOrigen.Name = "txtOrigen"
        txtOrigen.Size = New Size(263, 23)
        txtOrigen.TabIndex = 3
        ' 
        ' txtVertice
        ' 
        txtVertice.Location = New Point(164, 47)
        txtVertice.Name = "txtVertice"
        txtVertice.Size = New Size(263, 23)
        txtVertice.TabIndex = 4
        ' 
        ' txtDestino
        ' 
        txtDestino.Location = New Point(164, 162)
        txtDestino.Name = "txtDestino"
        txtDestino.Size = New Size(263, 23)
        txtDestino.TabIndex = 5
        ' 
        ' listGrafo
        ' 
        listGrafo.FormattingEnabled = True
        listGrafo.ItemHeight = 15
        listGrafo.Location = New Point(127, 214)
        listGrafo.Name = "listGrafo"
        listGrafo.Size = New Size(482, 199)
        listGrafo.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(261, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 7
        Label1.Text = "Vertice Origen"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 8
        Label2.Text = "Label2"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 9
        Label3.Text = "Label3"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(254, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 10
        Label4.Text = "Vertice Destino "' 
        ' btnEncontrarCamino
        ' 
        btnEncontrarCamino.Location = New Point(575, 127)
        btnEncontrarCamino.Name = "btnEncontrarCamino"
        btnEncontrarCamino.Size = New Size(86, 49)
        btnEncontrarCamino.TabIndex = 11
        btnEncontrarCamino.Text = "Encontrar Camino"
        btnEncontrarCamino.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEncontrarCamino)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(listGrafo)
        Controls.Add(txtDestino)
        Controls.Add(txtVertice)
        Controls.Add(txtOrigen)
        Controls.Add(btnEliminarVertice)
        Controls.Add(btnAgregarArista)
        Controls.Add(btnAgregarVertice)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregarVertice As Button
    Friend WithEvents btnAgregarArista As Button
    Friend WithEvents btnEliminarVertice As Button
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtVertice As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents listGrafo As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEncontrarCamino As Button
End Class
